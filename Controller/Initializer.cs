using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChemicalScan.Model;
using ChemicalScan.Utils;

namespace ChemicalScan.Controller
{
    /// <summary>
    /// 初始化器
    /// 用来在程序启动时初始化一些对象和参数
    /// </summary>
    public class Initializer : SingleTon<Initializer>
    {
        public static void Init()
        {
            LogUtil.preStreamNumer = Config.Default.log_preStreamNumer;
        }
    }
}
