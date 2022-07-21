using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    public class ReturnData
    {
        public static string code_default = "-1";
        public static string code_wrongData_PLC = "-2";
        public static string code_wrongData_MES = "-3";

        public static string code_success = "200";
        public static string  code_error = "500";

        public string code { get; set; } = code_default;
        public string msg { get; set; } = "";
        public string data { get; set; } = "";
    }
}
