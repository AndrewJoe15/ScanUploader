#define TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    /// <summary>
    /// URL 静态类
    /// 用来存放一些URL
    /// </summary>
    internal static class URL
    {
        //测试环境url
#if TEST
        public static string login =                "http://10.219.196.41/stage-api/auth/login";
#if CHEMICALSCAN
        public static string scanContainerOut =     "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSourceVehicle";
        public static string scanContainerIn =      "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanTargetVehicle";
        public static string scanContainerUnbind =  "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSourceVehicleUnBind";
        public static string scanSn =               "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSn";
        public static string scanSubmit =            "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSubmit";
#endif
#if KIBBLESCAN
        public static string scanContainerOut       = "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/kibbleScanSourceVehicle";//暂时不需要扫出载具扫码
        public static string scanContainerUnbind    = "";
        public static string scanContainerIn        = "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/kibbleScanTargetVehicle";
        public static string scanSn                 = "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/kibbleScanSn";
        public static string scanSubmit             = "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/kibbleScanSubmit";
#endif
#if BDSSCAN
        public static string scanSn = "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/insertByScaning";
#endif

#else
#endif

    }
}
