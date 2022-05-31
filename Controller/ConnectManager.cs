﻿using System;
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
        public const int port_up = 1100;            //上料端口
        public const int port_glassScan = 1200;     //玻璃涂油扫码端口
        public const int port_down = 1300;          //下料端口
        public const int port_submit = 1400;        //提交端口

        public const string stopID = "STOP";

        private const double connectTimeout = 11 * 60 * 60 * 1000; //11小时

        private const string hostIP = "0.0.0.0";


        public void StartSocketServer()
        {

            SocketServer socket_L3L4 = new SocketServer(hostIP, port_glassScan);
            socket_L3L4.StartListen();
#if !BDSSCAN
            SocketServer socket_L1L2 = new SocketServer(hostIP, port_up);
            socket_L1L2.StartListen();


            SocketServer socket_L5L6 = new SocketServer(hostIP, port_down);
            socket_L5L6.StartListen();

            SocketServer socket_L7L8 = new SocketServer(hostIP, port_submit);
            socket_L7L8.StartListen();
#endif
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
