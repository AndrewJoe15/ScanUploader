using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Objs
{
    internal class ReturnData
    {
        public static int code_success = 200;
        public static int code_error = 500;

        public int code { get; set; }
        public string msg { get; set; }
        public string data { get; set; }
    }
}
