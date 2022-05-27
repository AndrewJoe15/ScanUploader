using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

using ChemicalScan.View;
using ChemicalScan.Model;

namespace ChemicalScan.Utils
{
    /// <summary>
    /// 日志工具类
    /// </summary>
    internal class LogUtil : SingleTon<LogUtil>
    {
        public static string logPath = "./Log/";

        public static string logNumber;

        public static string streamNumer = "00000026"; //流水号

        public static int maxLength = 5000; //显示的log 最大长度

        private static string fileName = "";

        private static string prefix = "HP";//日志前两个字母，化抛

        public static string getLogNumber()
        {
            if(logNumber == "")
                logNumber = prefix + DateTime.Now.ToString("yyyyMMdd") + streamNumer;
            return logNumber;
        }

        public static void WriteLog(string logContent)
        {
            if (!File.Exists(logPath))
                Directory.CreateDirectory(logPath);
            logNumber = prefix + DateTime.Now.ToString("yyyyMMdd") + streamNumer;
            fileName = logNumber + ".txt";
            //打开一个文件流，文件尾追加模式
            FileStream fileStream = new FileStream(logPath + fileName, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);

            //前部加上时间戳
            string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + logContent;
            //写入log
            streamWriter.Write(log + "\n");

            //界面显示log
            if(MainForm.thisForm != null)
                MainForm.thisForm.ShowLog(log + "\n");

            if (fileStream != null)
            {
                try
                {
                    streamWriter.Close();
                    fileStream.Close();
                }
                catch (Exception e)
                {
                    Debug.WriteLine("文件流关闭失败，" + e.Message);
                    ExceptionUtil.ExceptionHandler(e);
                }
            }
        }

    }
}
