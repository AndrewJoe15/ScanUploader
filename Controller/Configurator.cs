using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScanUploader.Model;
using ScanUploader.Utils;
using ScanUploader.View;

namespace ScanUploader.Controller
{
    /// <summary>
    /// 初始化器
    /// 用来在程序启动时初始化一些对象和参数
    /// </summary>
    public class Configurator : SingleTon<Configurator>
    {
        //属性配置对象
        private static Properties.URL url = Properties.URL.Default;
        private static Properties.Settings settings = Properties.Settings.Default;
        private static Properties.Socket socket = Properties.Socket.Default;
        private static Properties.User_Http user_http = Properties.User_Http.Default;
        private static Properties.LogFileName logFileSetting = Properties.LogFileName.Default;




    }
}
