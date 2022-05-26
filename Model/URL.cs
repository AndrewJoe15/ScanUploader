#define Debug
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
#if Debug
        private static string basicUrl = "https://45e091c7-424a-4dfe-8308-6d1e996672cc.mock.pstmn.io";
        public static string login = basicUrl + "/login";
        public static string scanContainerOut = basicUrl + "/chemicalScanSourceVehicle";
        public static string scanContainerIn = basicUrl + "/chemicalScanTargetVehicle";
        public static string scanContainerUnbind = basicUrl + "/chemicalScanSourceVehicleUnBind";
        public static string scanSn = basicUrl + "/chemicalScanSn";
        public static string scanSubmit = basicUrl + "/chemicalScanSubmit";
#else

        public static string login =                "http://10.219.196.41/stage-api/auth/login";
        public static string scanContainerOut =     "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSourceVehicle";
        public static string scanContainerIn =      "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanTargetVehicle";
        public static string scanContainerUnbind =  "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSourceVehicleUnBind";
        public static string scanSn =               "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSn";
        public static string scanSubmit =            "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSubmit";
#endif
    }
}
