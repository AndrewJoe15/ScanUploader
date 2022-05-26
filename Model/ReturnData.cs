using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    public class ReturnData
    {
        public static string code_success = "200";
        public static string  code_error = "500";

        public string code { get; set; }
        public string msg { get; set; }
        public string data { get; set; }
    }
}
