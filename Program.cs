using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using ChemicalScan.View;
using ChemicalScan.Controller;
using ChemicalScan.Utils;
using ChemicalScan.Model;

namespace ChemicalScan
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogUtil.WriteLog("上位机软件启动。");

            URL.UpdateURL();

            //http用户登录以更新Token
            UserManager.HttpLogin();
            //启动连接计时器，每11小时重新登录一次
            ConnectManager.Instance.StartTimer();

            //启动Socket服务器
            ConnectManager.Instance.StartSocketServer();

            //启动定时垃圾回收 以解决内存占用越来越大的问题
            Optimizer.StartPeriodGarbageCollection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new InitSettingForm());
            Application.Run(new MainForm());
            //Application.Run(new ConfigureForm());


#if CHEMICALSCAN
#elif KIBBLESCAN
#elif BDSSCAN
#endif
        }

    }
}
