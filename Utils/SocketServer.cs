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
                _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 2);
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

            //Socket连接状态
            MainForm.thisForm.UpdateSocketStatus(clientSocket.LocalEndPoint.ToString(), clientSocket.Connected);

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

                        UIInfoManager.AppendDebugInfo("机器->上位机: " + str);

                        if (str == ConnectManager.stopID)
                        {
                            string rep = clientSocket.RemoteEndPoint.ToString();
                            UIInfoManager.AppendDebugInfo("与机器端口 " + rep + " 的连接关闭.");

                            //断开连接
                            clientSocket.Shutdown(SocketShutdown.Both);
                            clientSocket.Close();
                            break;
                        }
                        
                        //解析消息传给MES，并将回传数据转发给Machine
                        IPEndPoint endPort = (IPEndPoint)clientSocket.LocalEndPoint;
                        ReturnData dataToMachine = Communicator.GetDataFromMES(str,endPort.Port);

                        if (dataToMachine.code == ReturnData.code_default)
                        {
                            //未找到符合命令的操作，PLC发来的命令没法识别
                            dataToMachine.msg = "命令有误，端口" + endPort.Port + "下不存在命令：" + str;
                        }
                        else if(dataToMachine.code == ReturnData.code_wrongData_PLC)
                        {
                            //PLC数据有误
                        }
                        else if(dataToMachine.code == ReturnData.code_wrongData_MES)
                        {
                            //MES数据有误
                        }
                        else
                        {
                            clientSocket.Send(Encoding.UTF8.GetBytes(dataToMachine.code));
                            UIInfoManager.AppendDebugInfo("上位机->机器: " + dataToMachine.code + "," + dataToMachine.msg);
                        }

                        //如果返回状态码不是成功码，将出错信息展示给操作员
                        if (dataToMachine.code != ReturnData.code_success)
                        {
                            UIInfoManager.AppendDebugInfo(dataToMachine.code + "，" + dataToMachine.msg);
                            MainForm.thisForm.AddErrorInfo(dataToMachine.code, dataToMachine.msg);
                            continue;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    UIInfoManager.AppendDebugInfo(ex.Message);
                    //ExceptionUtil.ExceptionHandler(ex.Message);
                    break;
                }
            }
        }
    }

}