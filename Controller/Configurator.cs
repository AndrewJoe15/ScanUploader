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
        //属性配置对象
        private static Properties.URL url = Properties.URL.Default;
        private static Properties.Settings settings = Properties.Settings.Default;
        private static Properties.Socket socket = Properties.Socket.Default;
        private static Properties.UserData userData = Properties.UserData.Default;
        private static Properties.LogFileName logFileSetting = Properties.LogFileName.Default;


        public static void Init()
        {
#if CHEMICALSCAN
            
#elif KIBBLESCAN
            
#elif BDSSCAN
            
#endif
            url.Save();
            settings.Save();
            socket.Save();

        }

        /// <summary>
        /// 化抛项目参数初始化
        /// </summary>
        public static void InitChemical()
        {
            //化抛的url 后缀
            url.postfix_scanContainerOut = "chemicalScanSourceVehicle";
            url.postfix_scanSn = "chemicalScanSn";
            url.postfix_scanContainerIn = "chemicalScanTargetVehicle";
            url.postfix_submit = "chemicalScanSubmit";
            url.postfix_scanContainerUnbind = "chemicalScanSourceVehicleUnBind";


            //setting
            settings.is_chemicalScan = true;
            settings.is_kibbleScan = false;
            settings.is_BDS = false;

            //socket
            socket.enable_socket_up = true;
            socket.enable_socket_main = true;
            socket.enable_socket_down = true;
            socket.enable_socket_submit = true;

        }

        /// <summary>
        /// 粗磨项目参数初始化
        /// </summary>
        public static void InitKibble()
        {
            //粗磨的url 后缀
            url.postfix_scanContainerOut = "kibbleScanSourceVehicle";
            url.postfix_scanSn = "kibbleScanSn";
            url.postfix_scanContainerIn = "kibbleScanTargetVehicle";
            url.postfix_submit = "kibbleScanSubmit";
            url.postfix_scanContainerUnbind = "";

            settings.is_chemicalScan = false;
            settings.is_kibbleScan = true;
            settings.is_BDS = false;

            //socket
            socket.enable_socket_up = true;
            socket.enable_socket_main = true;
            socket.enable_socket_down = true;
            socket.enable_socket_submit = true;

        }

        /// <summary>
        /// BDS项目参数初始化
        /// </summary>
        public static void InitBDS()
        {
            url.postfix_scanSn = "insertByScaning";
            url.postfix_scanContainerOut = "";
            url.postfix_scanContainerIn = "";
            url.postfix_submit = "";
            url.postfix_scanContainerUnbind = "";

            settings.is_chemicalScan = false;
            settings.is_kibbleScan = false;
            settings.is_BDS = true;

            //socket
            socket.enable_socket_up = false;
            socket.enable_socket_main = true;
            socket.enable_socket_down = false;
            socket.enable_socket_submit = false;
        }


    }
}
