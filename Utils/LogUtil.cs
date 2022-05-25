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
        private static FileStream fileStream;
        private static StreamWriter streamWriter;

        /// <summary>
        /// 开始打Log（在建立连接时开始）
        /// 与写入log的代码分离开是为了避免频繁创建文件流对象浪费时间
        /// </summary>
        public static void StartLog()
        {
            if (!File.Exists(logPath))
                Directory.CreateDirectory(logPath);

            fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            //打开一个文件流，文件尾追加模式
            //if (fileStream == null)
            //{
            fileStream = new FileStream(logPath + fileName, FileMode.Append);
            streamWriter = new StreamWriter(fileStream, Encoding.Default);
            //}
        }

        /// <summary>
        /// 停止打Log（在断开连接时停止）
        /// </summary>
        public static void StopLog()
        {
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
                    ConnectException.ExceptionHandler(e);
                }
            }
        }
        /*
        public static void WriteLog(string logContent)
        {
            //if (!File.Exists(logPath))
            //    Directory.CreateDirectory(logPath);

            //fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            //打开一个文件流，文件尾追加模式
            //if (fileStream == null)
            //{
            //fileStream = new FileStream(logPath + fileName, FileMode.Append);
            //streamWriter = new StreamWriter(fileStream, Encoding.Default);
            //}

            //前部加上时间戳
            string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + logContent;
            //写入log
            //streamWriter.Write(log + "\n");

            //界面显示log
            ScanForm.thisForm.ShowLog(log + "\n");
            //StopLog();
        }
        public static void WriteLog(string logContent)
        {
            //前部加上时间戳
            string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + logContent;
            //写入log
            streamWriter.Write(log + "\n");

            //界面显示log
            ScanForm.thisForm.ShowLog(log + "\n");
        }*/

        public static void WriteLog(string logContent)
        {
            if (!File.Exists(logPath))
                Directory.CreateDirectory(logPath);

            fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            //打开一个文件流，文件尾追加模式
            fileStream = new FileStream(logPath + fileName, FileMode.Append);
            streamWriter = new StreamWriter(fileStream, Encoding.Default);

            //前部加上时间戳
            string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + logContent;
            //写入log
            streamWriter.Write(log + "\n");

            //界面显示log
            ScanForm.thisForm.ShowLog(log + "\n");
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
                    ConnectException.ExceptionHandler(e);
                }
            }
        }

    }
}
