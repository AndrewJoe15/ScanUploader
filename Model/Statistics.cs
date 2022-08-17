using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    /// <summary>
    /// 统计信息类
    /// </summary>
    public class Statistics
    {
        public const string NoneData = "-";

        public static bool hasData
        {
            get => yield_total == NoneData ? false : true;
        }

        public static int OK_1 = 0;
        public static int OK_2 = 0;
        public static int OK_total => OK_1 + OK_2;

        public static int NG_1 = 0;
        public static int NG_2 = 0;
        public static int NG_total => NG_1 + NG_2;

        //良率 以字符串的形式输出
        public static string yield1
        {
            get
            {
                if (OK_1 + NG_1 <= 0)
                    return NoneData;
                else
                    return (100.0 * OK_1 / (OK_1 + NG_1)).ToString("F2");//保留2位小数（百分数两位小数）
            }
        }
        public static string yield2
        {
            get
            {
                if (OK_2 + NG_2 <= 0)
                    return NoneData;
                else
                    return (100.0 * OK_2 / (OK_2 + NG_2)).ToString("F2");//保留2位小数（百分数两位小数）
            }
        }
        public static string yield_total
        {
            get
            {
                if (OK_total + NG_total <= 0)
                    return NoneData;
                else
                    return (100.0 * OK_total / (OK_total + NG_total)).ToString("F2");//保留2位小数（百分数两位小数）
            }
        }

        public static void ClearData()
        {
            OK_1 = 0;
            OK_2 = 0;
            NG_1 = 0;
            NG_2 = 0;
        }
    }
}
