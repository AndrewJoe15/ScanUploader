using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    public static class GlobalValue
    {
#if CHEMICALSCAN
        //化抛
        public static List<Glass> GlassList_OK_Left = new List<Glass>();
        public static List<Glass> GlassList_OK_Right = new List<Glass>();
        public static List<Glass> GlassList_NG_Left = new List<Glass>();
        public static List<Glass> GlassList_NG_Right = new List<Glass>();
#endif
#if KIBBLESCAN
        //粗磨
        public static List<Glass> GlassList_OK = new List<Glass>();
        public static List<Glass> GlassList_NG = new List<Glass>();
#endif

    }
}
