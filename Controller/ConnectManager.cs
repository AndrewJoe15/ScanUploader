using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Net.Sockets;
using System.Diagnostics;

using ChemicalScan.Model;
using ChemicalScan.Utils;

namespace ChemicalScan.Controller
{
    internal class ConnectManager : SingleTon<ConnectManager>
    {
        public const int port_L1L2 = 1100;
        public const int port_L3L4 = 1200;
        public const int port_L5L6 = 1300;
        public const int port_L7L8 = 1400;

        public const string finishID = "STOP";

        private const double connectTimeout = 11 * 60 * 60 * 1000; //11小时

        private const string hostIP = "0.0.0.0";


        public void StartSocketServer()
        {

            SocketServer socket_L1L2 = new SocketServer(hostIP, port_L1L2);
            socket_L1L2.StartListen();

            SocketServer socket_L3L4 = new SocketServer(hostIP, port_L3L4);
            socket_L3L4.StartListen();

            SocketServer socket_L5L6 = new SocketServer(hostIP, port_L5L6);
            socket_L5L6.StartListen();

            SocketServer socket_L7L8 = new SocketServer(hostIP, port_L7L8);
            socket_L7L8.StartListen();
        }

        /// <summary>
        /// 计时器
        /// 由于MES端设定12小时token过期，所以每隔11小时http登录一次
        /// </summary>
        public void StartTimer()
        {
            Debug.WriteLine("计时器开0始运行...");
            Timer aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimeEvent);           
            aTimer.Interval = connectTimeout; // 设置触发的时间间隔 此处设置为11小时
            aTimer.AutoReset = true;//自动重置，每11小时执行一次TimeEvent()
            aTimer.Enabled = true;
        }

        private void TimeEvent(object source, ElapsedEventArgs e)
        {
            Debug.WriteLine("Token过期，重新登录MES端...");
            UserManager.HttpLogin();
        }
    }

}
