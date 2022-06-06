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
    public class Configurator : SingleTon<Configurator>
    {
        /// <summary>
        /// 加载初始化参数
        /// 在程序启动时执行
        /// </summary>
        public static void Initialize()
        {
            //log 流水号
            LogUtil.currentSerialNumer = Config.Default.log_currSerialNumber;
            LogUtil.nextSerialNumer = Config.Default.log_nextSerialNumber;
        }

        public static void SaveData()
        {
            Config.Default.log_currSerialNumber = LogUtil.currentSerialNumer;
            Config.Default.log_nextSerialNumber = LogUtil.nextSerialNumer;
            

            Config.Default.Save();
        }
    }
}
