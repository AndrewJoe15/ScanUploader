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
    public class LogUtil : SingleTon<LogUtil>
    {
        //log文件路径（相对地址）
        public static string logPath = Environment.CurrentDirectory + "\\Log\\";

        //*********logFileName = prefix + yyyyMMdd + serialNumber +  fileFormat
        //**********             HP        20220601     12345678       .txt
        //                      ***********  logNumber  ***********
        //前缀
        public static string prefix = Properties.LogFile.Default.prefix;
        //日志文件名中的日期格式
        public static string dateFormat = Properties.LogFile.Default.dateFormat;
        //log流水号位数
        public static int serialFigures = Properties.LogFile.Default.serialFigures;
        
        public static string serialNumString     //将流水号数字转为指定位数字符串
        {
            get
            {
                //将流水号转为指定位数编号，位数不足以0填充 ({0:D4},3)  ->  0003
                string fmt = "{0:D" + serialFigures.ToString() + "}";
                return string.Format(fmt, currentSerialNumer);
            }
        }
        
        public static string logNumber
        {
            get
            {
                return prefix + DateTime.Now.ToString(dateFormat) + serialNumString;
            }
        }

        public static string currentLogFileName = ""; 

        public static int maxLength = 10000; //显示的log 最大长度

        public static string logFileFormat = ".txt";


        //流水号 通过配置文件初始化
        private static int currentSerialNumer = Properties.LogSN.Default.log_currSerialNumber; //当前流水号数字
        private static int nextSerialNumer = Properties.LogSN.Default.log_nextSerialNumber; //下一个流水号数字   双数字控制流水号在规定位数内增长 归零

        public static void setNextSerialNumber()
        {
            if ((currentSerialNumer + 1).ToString().Length > serialFigures)
                nextSerialNumer = 0;
            else
                nextSerialNumer = currentSerialNumer + 1;
        }

        public static void WriteLog(string logContent)
        {
            if (!File.Exists(logPath))
                Directory.CreateDirectory(logPath);

            //不等说明提交的时候nextSerialNumer循环+1了
            if (currentSerialNumer != nextSerialNumer)
                currentSerialNumer = nextSerialNumer;
            
            currentLogFileName = logNumber + ".txt";
            //打开一个文件流，文件尾追加模式
            FileStream fileStream = new FileStream(logPath + currentLogFileName, FileMode.Append);
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

        public static void SaveData()
        {            
            //保存日志流水号
            Properties.LogSN.Default.log_currSerialNumber = currentSerialNumer;
            Properties.LogSN.Default.log_nextSerialNumber = nextSerialNumer;

            Properties.LogSN.Default.Save();
        }

    }
}
