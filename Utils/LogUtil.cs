using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

using ChemicalScan.View;
using ChemicalScan.Controller;

namespace ChemicalScan.Utils
{
    /// <summary>
    /// 日志工具类
    /// </summary>
    internal class LogUtil
    {
        public static string logPath = "./Log/";

        private static string fileName = "";


        public static void WriteLog(string logContent)
        {
            if (!File.Exists(logPath))
                Directory.CreateDirectory(logPath);

            fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
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
