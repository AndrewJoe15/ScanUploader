using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    /// <summary>
    /// URL 静态类
    /// 用来存放一些URL
    /// </summary>
    public class URL : SingleTon<URL>
    {
        //获取url配置 静态对象
        static readonly Properties.URL url = Properties.URL.Default;

        //登录http的url
        public static string httpLogin = url.httpLogin_MES; //postfix_httpLogin 暂时用完整的url

        //扫码上传url
        //-载具扫出
        public static string scanContainerOut = url.prefix + url.subPrefix_MES + url.postfix_scanContainerOut; 
        //-单片玻璃
        public static string scanSn = url.prefix + url.subPrefix_MES + url.postfix_scanSn; 
        //-载具扫入
        public static string scanContainerIn = url.prefix + url.subPrefix_MES + url.postfix_scanContainerIn; 
        //-载具解绑
        public static string scanContainerUnbind = url.prefix + url.subPrefix_MES + url.postfix_scanContainerUnbind;
        //-提交
        public static string scanSubmit = url.prefix + url.subPrefix_MES + url.postfix_submit; 

    }
}
