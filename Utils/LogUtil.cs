using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

using ScanUploader.View;
using ScanUploader.Model;

namespace ScanUploader.Utils
{
    /// <summary>
    /// 日志工具类
    /// </summary>
    public class LogUtil
    {
        /// <summary>
        /// 写入日志到默认日志文件 logFile_line1
        /// </summary>
        /// <param name="logContent"></param>
        public static void WriteLog(string logContent)
        {
            WriteLog(logContent, LogFile.logFile_line1);
        }

        /// <summary>
        /// 写入日志到指定日志文件
        /// </summary>
        /// <param name="logContent"></param>
        /// <param name="logFile"></param>
        public static void WriteLog(string logContent, LogFile logFile)
        {
            if (!File.Exists(logFile.logPath))
                Directory.CreateDirectory(logFile.logPath);
            
            //打开一个文件流，文件尾追加模式
            FileStream fileStream = new FileStream(logFile.logPath + logFile.logFileName, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);

            //前部加上时间戳
            string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + logContent;
            //写入log
            streamWriter.Write(log + "\r\n");

            //界面显示log
            if(MainForm.thisForm != null)
                MainForm.thisForm.ShowLog(log + "\r\n");

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

        /// <summary>
        /// 写入日志到指定日志文件
        /// </summary>
        /// <param name="logContent"></param>
        /// <param name="logFile"></param>
        public static void WriteLog(string logContent, LogFile logFile, bool showLog)
        {
            if (!File.Exists(logFile.logPath))
                Directory.CreateDirectory(logFile.logPath);

            //打开一个文件流，文件尾追加模式
            FileStream fileStream = new FileStream(logFile.logPath + logFile.logFileName, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);

            //前部加上时间戳
            string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + logContent;
            //写入log
            streamWriter.Write(log + "\r\n");

            if (showLog)
            {
                //界面显示log
                if (MainForm.thisForm != null)
                    MainForm.thisForm.ShowLog(log + "\r\n");
            }

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
