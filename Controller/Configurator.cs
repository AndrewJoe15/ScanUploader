using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChemicalScan.Model;
using ChemicalScan.Utils;
using ChemicalScan.View;

namespace ChemicalScan.Controller
{
    /// <summary>
    /// 初始化器
    /// 用来在程序启动时初始化一些对象和参数
    /// </summary>
    public class Configurator : SingleTon<Configurator>
    {
        /// <summary>
        /// 化抛项目参数初始化
        /// </summary>
        public static void InitChemical()
        {
        }

        /// <summary>
        /// 粗磨项目参数初始化
        /// </summary>
        public static void InitKibble()
        {
            
        }

        /// <summary>
        /// BDS项目参数初始化
        /// </summary>
        public static void InitBDS()
        {

        }


    }
}
