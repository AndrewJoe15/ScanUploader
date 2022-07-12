using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Diagnostics;
using ScanUploader.Controller;
using ScanUploader.View;
using ScanUploader.Model;

namespace ScanUploader.Utils
{
    /// <summary>
    /// Socket 工具类
    /// 实现Socket服务器端配置
    /// </summary>
    public class SocketServer
    {
        private string _ip = string.Empty;
        private int _port = 0;
        private Socket _socket = null;
        private int backlog = 7;//socket最大连接数
        //private byte[] buffer = new byte[1024 * 1024 * 2];
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ip">监听的IP</param>
        /// <param name="port">监听的端口</param>
        public SocketServer(string ip, int port)
        {
            this._ip = ip;
            this._port = port;
        }
        public SocketServer(int port)
        {
            this._ip = "0.0.0.0";//缺省
            this._port = port;
        }


        /// <summary>
        /// 启动监听
        /// </summary>
        public void StartListen()
        {
            IPAddress address = null;
            IPEndPoint endPoint = null;
            try
            {
                //实例化Socket对象
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //根据IP地址创建IP对象
                address = IPAddress.Parse(_ip);
                //根据IP对象和端口创建网络端口
                endPoint = new IPEndPoint(address, _port);
                
                //端口可复用
                //_socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 2);
                //socket对象绑定端口
                _socket.Bind(endPoint);
                //将 Socket 置于侦听状态
                _socket.Listen(backlog);


                //开始监听
                Thread thread = new Thread(ListenClientConnect);
                thread.Start();
            }
            catch (Exception e)
            {
                ExceptionUtil.ExceptionHandler(e);
            }
        }
        /// <summary>
        /// 监听客户端连接
        /// </summary>
        private void ListenClientConnect()
        {
            try
            {
                while (true)
                {
                    //Socket创建的新连接
                    Socket tmp = _socket.Accept();//持续等待接受客户端消息
                    //开启新线程接受客户端消息
                    Thread thread = new Thread(ReceiveMessage);
                    thread.Start(tmp);
                }
            }
            catch (Exception e)
            {
                string msg = e.InnerException.Message;
                ShowUtil.ShowWarning("Socke连接失败。");
                ExceptionUtil.ExceptionHandler(msg);
            }
        }

        /// <summary>
        /// 接收客户端消息
        /// </summary>
        /// <param name="socket">socket</param>
        private void ReceiveMessage(object socket)
        {
            Socket clientSocket = (Socket)socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 3];
                    //获取从客户端发来的数据
                    int length = clientSocket.Receive(buffer);
                    if(length > 0)
                    {
                        string str = Encoding.Default.GetString(buffer, 0, length);

                        //去掉前后空格
                        str = str.Trim();

                        UIInfoManager.AppendDebugInfo("上位机收到Machine端的消息: " + str);

                        if (str == ConnectManager.stopID)
                        {
                            string rep = clientSocket.RemoteEndPoint.ToString();
                            UIInfoManager.AppendDebugInfo("与客户端" + rep + "的Socket连接关闭.");

                            //断开连接
                            clientSocket.Shutdown(SocketShutdown.Both);
                            clientSocket.Close();
                            break;
                        }
                        
                        //解析消息传给MES，并将回传数据转发给Machine
                        IPEndPoint endPort = (IPEndPoint)clientSocket.LocalEndPoint;
                        ReturnData dataToMachine = Communicator.GetDataFromMES(str,endPort.Port);

                        if (dataToMachine == null)
                        {
                            dataToMachine = new ReturnData();
                            dataToMachine.code = ReturnData.code_error;
                            dataToMachine.msg = "与MES通信失败，返回数据为空。";
                        }
                        if (dataToMachine.data == null)
                            dataToMachine.data = dataToMachine.code;
                        //扫入化抛架时，data存的是绑定单片数量的值
                        //其他情况data存的code值，将code发给machine
                        clientSocket.Send(Encoding.UTF8.GetBytes(dataToMachine.code));

                        UIInfoManager.AppendDebugInfo("发给Machine端的消息: " + dataToMachine.code);

                        //如果返回状态码不是成功码，将出错信息展示给操作员
                        if (dataToMachine.code != ReturnData.code_success)
                        {
                            MainForm.thisForm.AddErrorInfo(dataToMachine.code, dataToMachine.msg);
                            continue;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    UIInfoManager.AppendDebugInfo(ex.Message);
                    //ExceptionUtil.ExceptionHandler(ex.Message);
                    //break;
                }
            }
        }
    }

}