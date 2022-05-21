using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

using ChemicalScan.Objs;
using ChemicalScan.Utils;

namespace ChemicalScan.BLL
{
    internal class ConnectManager
    {
        private const double ConnectTimeout = 11 * 60 * 60 * 1000; //11小时

        /// <summary>
        /// 计时器
        /// 由于MES端设定12小时token过期，所以每隔11小时http登录一次
        /// </summary>
        public static void StartTimer()
        {
            Console.WriteLine("计时器开始运行...");
            Timer aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimeEvent);           
            aTimer.Interval = ConnectTimeout; // 设置触发的时间间隔 此处设置为11小时
            aTimer.AutoReset = true;        //自动重置，每11小时执行一次TimeEvent()
            aTimer.Enabled = true;
        }

        private static void TimeEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("超时，重新登录MES端...");
            UserManager.HttpLogin();
        }
    }

}
