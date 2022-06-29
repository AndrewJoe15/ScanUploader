using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ScanUploader.Controller
{
    /// <summary>
    /// 程序优化器
    /// </summary>
    internal class Optimizer
    {
        public static void StartPeriodGarbageCollection()
        {
            Timer aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(ClearMemory);
            aTimer.Interval = 10000; // 时间间隔10s
            aTimer.AutoReset = true;//自动重置
            aTimer.Enabled = true;
        }

        #region 内存回收
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        private static void ClearMemory(object sender, ElapsedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        #endregion
    }
}
