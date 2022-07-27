using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net.Sockets;

namespace ScanUploader.Utils
{
    internal class ExceptionUtil : Exception
    {
        public static int errorCode_PortIsUsed = 10048;
        public static int errorCode_ConnectionReset = 10054;

        public static Dictionary<int, string> error2Message = new Dictionary<int, string>()
        {
            { errorCode_PortIsUsed,"端口被占用，Socket服务启动失败。" },
            { errorCode_ConnectionReset,"无法连接到MES。" }
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
            
            if(!ProcessError(errorCode))
                ShowUtil.ShowError("未知错误。\n" + "错误码：" + errorCode + "\n 错误信息：" + e.Message);
            
        }

        public static bool ProcessError(int errorCode)
        {
            //显示对应的错误信息
            if (error2Message.ContainsKey(errorCode))
            {
                ShowUtil.ShowError(error2Message[errorCode]);
                return true;
            }
            else
                return false;
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
