using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    /// <summary>
    /// 统计信息类
    /// </summary>
    public class Statistics
    {
        public static int OK1 = 0;
        public static int OK2 = 0;

        public static int NG1 = 0;
        public static int NG2 = 0;

        //良率 以字符串的形式输出
        public static string yield1
        {
            get
            {
                if (OK1 + NG1 <= 0)
                    return "-";
                else
                    return ((float)OK1 / (OK1 + NG1)).ToString("F2");//保留两位小数
            }
        }
        public static string yield2
        {
            get
            {
                if (OK2 + NG2 <= 0)
                    return "-";
                else
                    return ((float)OK2 / (OK2 + NG2)).ToString("F2");//保留两位小数
            }
        }
    }
}
