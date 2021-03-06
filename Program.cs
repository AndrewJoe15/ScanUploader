using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using ScanUploader.View;
using ScanUploader.Controller;
using ScanUploader.Utils;
using ScanUploader.Model;

namespace ScanUploader
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form mainForm = new MainForm();

            //应用程序初始化
            Init();

            //打开主窗体
            Application.Run(mainForm);

        }

        private static void Init()
        {
#if !DEBUG
            //http用户登录以更新Token
            UserManager.HttpLogin();
            //粗磨项目还要登陆 WMS 获取token
            /*if(Properties.Settings.Default.is_kibbleScan)
                UserManager.HttpLogin_WMS();*/
            //启动连接计时器，每11小时重新登录一次
            ConnectManager.Instance.StartTimer_Http();
#endif

            //启动Socket服务器
            ConnectManager.Instance.StartSocketServer();

            //启动定时垃圾回收 以解决内存占用越来越大的问题
            Optimizer.StartPeriodGarbageCollection();

            //初始化配置
            Configurator.Init();
        }
    }
}
