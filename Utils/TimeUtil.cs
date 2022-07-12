using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Utils
{
    public class TimeUtil
    {
        public static string currentTimeString { get => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); set { } }
        public static string currentTimeString_log { get => "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "] "; set { } }

        static TimeUtil()
        {
            currentTimeString = "";
            currentTimeString_log = "";
        }
    }
}
