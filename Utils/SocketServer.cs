using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Diagnostics;
using ChemicalScan.Controller;
using ChemicalScan.Model;

namespace ChemicalScan.Utils
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

                Debug.WriteLine("{0}开始监听消息...", _socket.LocalEndPoint.ToString());

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

                        if (str.Trim() == "")
                        {
                            Thread.Sleep(100);
                        }
                        if (str == ConnectManager.finishID)
                        {
                            string rep = clientSocket.RemoteEndPoint.ToString();
                            Debug.WriteLine("与客户端{0}的Socket连接关闭.", rep);
                            //写入日志                            
                            LogUtil.WriteLog(str + "与客户端" + rep + "的Socket连接关闭.");

                            //断开连接
                            clientSocket.Shutdown(SocketShutdown.Both);
                            clientSocket.Close();
                            break;
                        }
                        Debug.WriteLine("接收客户端 {0} 的消息: {1}。", clientSocket.RemoteEndPoint.ToString(), str);
                        LogUtil.WriteLog("上位机收到Machine端的消息: " + str);
                        
                        //解析消息传给MES，并将回传数据转发给Machine
                        IPEndPoint endPort = (IPEndPoint)clientSocket.LocalEndPoint;
                        ReturnData dataToMachine = Communicator.GetDataFromMES(str,endPort.Port);

                        if (dataToMachine != null && dataToMachine.code != null)
                        {
                            //将code发给machine
                            clientSocket.Send(Encoding.UTF8.GetBytes(dataToMachine.code));

                            LogUtil.WriteLog("发给Machine端的消息: " + dataToMachine.code);

                            //如果返回状态码为错误码，将出错信息展示给操作员
                            if(dataToMachine.code == ReturnData.code_error)
                            {
                                //ShowUtil.ShowWarning(dataToMachine.msg);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    ExceptionUtil.ExceptionHandler(ex.Message);
                    break;
                }
            }
        }
    }

    /// <summary>
    /// 客户端Socket 调试用
    /// </summary>
    public class SocketClient
    {
        private string _ip = string.Empty;
        private int _port = 0;
        private Socket _socket = null;
        private byte[] buffer = new byte[1024 * 2];

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ip">连接服务器的IP</param>
        /// <param name="port">连接服务器的端口</param>
        public SocketClient(string ip, int port)
        {
            this._ip = ip;
            this._port = port;
        }
        public SocketClient(int port)
        {
            this._ip = "127.0.0.1";
            this._port = port;
        }

        /// <summary>
        /// 开启服务,连接服务端
        /// </summary>
        public void StartClient()
        {
            try
            {
                //1.0 实例化套接字(IP4寻址地址,流式传输,TCP协议)
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //2.0 创建IP对象
                IPAddress address = IPAddress.Parse(_ip);
                //3.0 创建网络端口包括ip和端口
                IPEndPoint endPoint = new IPEndPoint(address, _port);
                //4.0 建立连接
                _socket.Connect(endPoint);
                Debug.WriteLine("连接服务器成功");
                //5.0 接收数据
                int length = _socket.Receive(buffer);
                Debug.WriteLine("接收服务器{0},消息:{1}", _socket.RemoteEndPoint.ToString(), Encoding.Default.GetString(buffer, 0, length));
                //6.0 向服务器发送消息
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(2000);
                    string sendMessage = string.Format("客户端发送的消息,当前时间{0}", DateTime.Now.ToString());
                    //_socket.Send(Encoding.UTF8.GetBytes(sendMessage));
                    Debug.WriteLine("向服务器发送的消息:{0}", sendMessage);
                }
            }
            catch (Exception ex)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
                Debug.WriteLine(ex.Message);
            }
            Debug.WriteLine("发送消息结束");
            Console.ReadKey();
        }

    }
}