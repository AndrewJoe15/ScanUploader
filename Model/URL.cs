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
    public static class URL
    {
        //登录http的url
        public static string httpLogin = "";

        //扫码上传url
        //-载具扫出
        public static string scanContainerOut       = "";
        //-单片玻璃
        public static string scanSn                 = "";
        //-载具扫入
        public static string scanContainerIn        = "";
        //-载具解绑
        public static string scanContainerUnbind    = "";
        //-提交
        public static string scanSubmit             = "";

        //URL 分段字符串
        //-前缀 http://10.219.95.85/prod-api/
        public static string prefix                    = Properties.URL.Default.prefix;
        //-登录后缀
        public static string postfix_httpLogin         = Properties.URL.Default.postfix_httpLogin;
        //-MES端口 
        public static string subPrefix_MES             = Properties.URL.Default.subPrefix_MES;
     
        public static string postfix_scanContainerOut  = Properties.URL.Default.postfix_scanContainerOut;
        public static string postfix_scanSn            = Properties.URL.Default.postfix_scanSn;
        public static string postfix_scanContainerIn   = Properties.URL.Default.postfix_scanContainerIn;
        public static string postfix_scanContainerUnbind = Properties.URL.Default.postfix_scanContainerUnbind;
        public static string postfix_submit            = Properties.URL.Default.postfix_submit;

        public static void UpdateURL()
        {
            httpLogin = postfix_httpLogin;

            scanContainerOut = prefix + subPrefix_MES + postfix_scanContainerOut;
            scanSn = prefix + subPrefix_MES + postfix_scanSn;
            scanContainerIn = prefix + subPrefix_MES + postfix_scanContainerIn;
            scanContainerUnbind = prefix + subPrefix_MES + postfix_scanContainerUnbind;
            scanSubmit = prefix + subPrefix_MES + postfix_submit;
        }
    }
}
