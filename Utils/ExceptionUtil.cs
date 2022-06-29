using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net.Sockets;

namespace ChemicalScan.Utils
{
    internal class ExceptionUtil : Exception
    {
        public static int errorCode_PortIsUsed = 10048;
        public static int errorCode_ConnectionReset = 10054;

        public static Dictionary<int, string> error2Message = new Dictionary<int, string>()
        {
            { errorCode_PortIsUsed,"端口被占用，Socket服务启动失败。" },
            { errorCode_ConnectionReset,"无法连接远程主机。" }
        };
/*
        private string message;
        private int errorCode;
        private Exception m_exception;
*/


        public static void ExceptionHandler(string msg)
        {
            ShowUtil.ShowError(msg);
            //throw new ExceptionUtil(msg);
        }

        /// <summary>
        /// 异常处理
        /// </summary>
        public static void ExceptionHandler(Exception e)
        {
            //获取错误码
            int errorCode = getErrorCode(e);
            
            //显示对应的错误信息
            if (error2Message.ContainsKey(errorCode))
                ShowUtil.ShowError(error2Message[errorCode]);

            if (errorCode == -1 || !error2Message.ContainsKey(errorCode))
                ShowUtil.ShowError("未知错误。\n" + "错误码：" + errorCode + "\n 错误信息：" + e.Message);
            
        }

        /// <summary>
        /// 获取异常的错误码
        /// </summary>
        /// <param name="e"></param>
        public static int getErrorCode(Exception e)
        {
            Exception ex = e;

            //看看它内部异常
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }            
            return ((Win32Exception)ex).ErrorCode;
        }
    }
}
