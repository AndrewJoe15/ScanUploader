using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScanUploader.Model;
using ScanUploader.Utils;
using ScanUploader.View;

namespace ScanUploader.Controller
{
    /// <summary>
    /// 用户界面信息显示管理
    /// </summary>
    public class UIInfoManager : SingleTon<UIInfoManager>
    {
        public static void AppendDebugInfo(string debugInfo)
        {
            MainForm.thisForm.ShowDebugInfo(TimeUtil.currentTimeString_log + "【通信数据】"+ debugInfo);
        }

        public static void AppendLogInfo(string logInfo)
        {
            MainForm.thisForm.ShowLogInfo(logInfo);
        }
    }
}
