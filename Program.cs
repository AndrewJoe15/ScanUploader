using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChemicalScan.View;
using ChemicalScan.Controller;
using ChemicalScan.Utils;

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

            //http用户登录以更新Token
            //UserManager.HttpLogin();
            //启动连接计时器，每11小时重新登录一次
            //ConnectManager.Instance.StartTimer();
            //启动Socket服务器
            ConnectManager.Instance.StartSocketServer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HttpLoginForm());
            Application.Run(new MainForm());
            //Application.Run(new ConfigureForm());


#if CHEMICALSCAN
#elif KIBBLESCAN
#elif BDSSCAN
#endif
        }
    }
}
