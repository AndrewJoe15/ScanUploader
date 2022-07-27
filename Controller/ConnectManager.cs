using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Net.Sockets;
using System.Diagnostics;

using ScanUploader.Model;
using ScanUploader.Utils;

namespace ScanUploader.Controller
{
    internal class ConnectManager : SingleTon<ConnectManager>
    {
        public static int port_up = Properties.Socket.Default.port_up;            //上料端口
        public static int port_main = Properties.Socket.Default.port_main;   //玻璃涂油扫码端口
        public static int port_down = Properties.Socket.Default.port_down;        //下料端口
        public static int port_insert = Properties.Socket.Default.port_insert;    //插架端口
        public static int port_submit = Properties.Socket.Default.port_submit;    //提交端口

        public static string hostIP = Properties.Socket.Default.IP_host;

        public const string stopID = "STOP";

        //private const double httpConnectTimeout = 5 * 1000; //5秒
        private const double httpConnectTimeout = 11 * 60 * 60 * 1000; //11小时
        private const double socketConnectCheckSpan = 1000; //1秒

        private SocketServer socket_L1L2;
        private SocketServer socket_L3L4;
        private SocketServer socket_L5L6;
        private SocketServer socket_OKNG;
        private SocketServer socket_Finish;

        private Timer _timer_http;
        public void StartSocketServer()
        {

            if (Properties.Socket.Default.enable_socket_up)
            {                    
                socket_L1L2 = new SocketServer(hostIP, port_up);
                socket_L1L2.StartListen();
            }

            if (Properties.Socket.Default.enable_socket_main)
            {
                socket_L3L4 = new SocketServer(hostIP, port_main);
                socket_L3L4.StartListen();
            }
            if (Properties.Socket.Default.enable_socket_down)
            {
                socket_L5L6 = new SocketServer(hostIP, port_down);
                socket_L5L6.StartListen();
            }

            if (Properties.Socket.Default.enable_socket_insert)
            {
                socket_OKNG = new SocketServer(hostIP, port_insert);
                socket_OKNG.StartListen();
            }
            
            if (Properties.Socket.Default.enable_socket_submit)
            {
                socket_Finish = new SocketServer(hostIP, port_submit);
                socket_Finish.StartListen();
            }

        }

        /// <summary>
        /// 计时器
        /// 由于MES端设定12小时token过期，所以每隔11小时http登录一次
        /// </summary>
        public void StartTimer_Http()
        {
            _timer_http = new Timer();
            _timer_http.Elapsed += new ElapsedEventHandler(TimeEvent_Http);
            _timer_http.Interval = httpConnectTimeout; // 设置触发的时间间隔 此处设置为11小时
            _timer_http.Enabled = true;
        }

        private void TimeEvent_Http(object source, ElapsedEventArgs e)
        {
            //停止原有计时
            _timer_http?.Stop();

            UIInfoManager.AppendDebugInfo("Token即将过期，重新登录MES...");
            //MES
            if(UserManager.HttpLogin(UserManager.httpUser_MES))            
                //开始重新计时
                _timer_http?.Start();
        }

        /// <summary>
        /// 计时器
        /// 用于周期性触发，更新界面Socket连接状态
        /// </summary>
        public void StartTimer_Socket()
        {
            Timer aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimeEvent_Socket);
            aTimer.Interval = socketConnectCheckSpan;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void TimeEvent_Socket(object source, ElapsedEventArgs e)
        {
            
        }
    }

}
