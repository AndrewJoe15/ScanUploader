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


            //应用程序初始化
            Init();

            //打开主窗体
            Form mainForm = new MainForm();
            Application.Run(mainForm);

        }

        private static void Init()
        {
            //启动定时垃圾回收 以解决内存占用越来越大的问题
            Optimizer.StartPeriodGarbageCollection();

            //初始化配置
            Configurator.Instance.Init();
        }
    }
}
