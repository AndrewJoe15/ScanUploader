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

        /// <summary>
        /// 将当前URL值保存到配置文件中
        /// </summary>
        public static void SaveURL()
        {
            Properties.URL.Default.prefix = URL.prefix;
            Properties.URL.Default.postfix_httpLogin = URL.postfix_httpLogin;
            Properties.URL.Default.subPrefix_MES = URL.subPrefix_MES;
            Properties.URL.Default.postfix_scanContainerIn = URL.postfix_scanContainerIn;
            Properties.URL.Default.postfix_scanSn = URL.postfix_scanSn;
            Properties.URL.Default.postfix_scanContainerOut = URL.postfix_scanContainerOut;
            Properties.URL.Default.postfix_scanContainerUnbind = URL.postfix_scanContainerUnbind;
            Properties.URL.Default.postfix_submit = URL.postfix_submit;

            Properties.URL.Default.Save();
        }


    }
}
