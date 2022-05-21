using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalScan.Objs
{
    internal class BasicInfo
    {
        //post请求的Authorization，格式Bearer token
        //例如: Bearer 10a4b28d‐476d‐4166‐b65d‐651be75df9f8
        public static string authorization { get; set; }

        //工厂代码
        public static string site { get; set; }
        //工序
        public static string operation { get; set; }
        //资源编码/设备号 
        public static string resource { get; set; }
        //产品型号
        public static string productModel { get; set; }
        //型号版本 
        public static string productModelVersion { get; set; }
        //班次
        public static string shift { get; set; }
        //操作人
        public static string createBy { get; set; }
        //操作时间
        public static string createTime { get; set; }
    }
}
