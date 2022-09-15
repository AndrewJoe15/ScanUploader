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
        private Properties.URL url = Properties.URL.Default;
        private Properties.Settings settings = Properties.Settings.Default;
        private Properties.Socket socket = Properties.Socket.Default;
        private Properties.User_Http user_http = Properties.User_Http.Default;
        private Properties.LogFileName logFileSetting = Properties.LogFileName.Default;


        public void Init()
        {
            switch (settings.workSite)
            {
                case 'H':
                    InitHP();
                    break;
                case 'B':
                    InitBDS();
                    break;
                case 'C':
                    InitCM();
                    break;
                default:
                    break;
            }
        }

        private void InitHP()
        {

        }
        private void InitBDS()
        {
            url.scanSn = "http://10.219.95.85/prod-api/mes/machine/api/machineToMes/insertByScaning";
        }
        private void InitCM()
        {
            url.scanSn = "http://10.219.95.85/prod-api/mes/machine/api/machineToMes/kibbleScanSn";
            url.scanContainerIn = "http://10.219.95.85/prod-api/mes/machine/api/machineToMes/kibbleScanTargetVehicle";
            url.submit = "http://10.219.95.85/prod-api/mes/machine/api/machineToMes/cuMoScanSubmit";

            user_http.username_MES = "test";

            logFileSetting.prefix = "CM";
        }

    }
}
