using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Model
{
    public static class GlobalValue
    {
        //化抛
        public static string operation_chemicalScan = "A0314";
        //粗磨
        public static string operation_kibbleScan = "A0073";
        //丝印前BDS
        public static string operation_BDS = "03";

        public static List<Glass> GlassList_OK_Left = new List<Glass>();
        public static List<Glass> GlassList_OK_Right = new List<Glass>();
        public static List<Glass> GlassList_NG_Left = new List<Glass>();
        public static List<Glass> GlassList_NG_Right = new List<Glass>();
    }
}
