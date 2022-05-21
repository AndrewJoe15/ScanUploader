using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Objs
{
    /// <summary>
    /// URL 静态类
    /// 用来存放一些URL
    /// </summary>
    internal static class URL
    {
        public static string login =                "http://10.219.196.41/stage-api/auth/login";
        public static string scanContainerOut =     "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSourceContainer";
        public static string scanContainerIn =      "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanTargetContainer ";
        public static string scanContainerUnbind =  "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSourceVehicleUnBind";
        public static string scanSn =               "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSn";
        public static string scanSbmit =            "http://10.219.196.41/stage-api/mes/machine/api/machineToMes/chemicalScanSubmit";
    }
}
