using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChemicalScan.View;
using ChemicalScan.Controller;

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
            ConnectManager.Instance.StartSocketServer();
            UserManager.HttpLogin();
            ConnectManager.Instance.StartTimer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HttpLoginForm());
            Application.Run(new MainForm());
            Application.Run(new ScanForm());
        }
    }
}
