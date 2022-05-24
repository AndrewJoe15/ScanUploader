using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HttpLoginForm());
            //Application.Run(new MainForm());

            //ConnectManager.Instance.StartSocketServer();
        }
    }
}
