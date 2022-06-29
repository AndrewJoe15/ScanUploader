using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    public class LogFile
    {
        //化抛项目两路log分别记录
        public static LogFile logFile_line1 = null;
        public static LogFile logFile_line2 = null;

        //log文件路径（相对地址）
        public string logPath = Environment.CurrentDirectory + "\\Log\\";

        private static Properties.LogFileName logFileNameSetting = Properties.LogFileName.Default;

        //流水号 初始化为配置文件中的值，流水号从上次软件关闭时的值继续
        public static int nextSerialNumer = 0; //流水号数字

        public string logNumber;

        public string logFileName;

        /// <summary>
        /// 下一个流水号，超出范围从最小编号重新开始
        /// </summary>
        private static void setNextSerialNumber()
        {
            nextSerialNumer++;
            //如果流水号位数大于规定位数 重新置0
            if (nextSerialNumer.ToString().Length > logFileNameSetting.serialFigureCount)
                nextSerialNumer = 0;
        }

        //保存流水号到配置文件中
        public static void SaveSerialNumber()
        {
            logFileNameSetting.nextSerialNumber = nextSerialNumer;
            logFileNameSetting.Save();
        }

        public LogFile()
        {
            //将流水号转为指定位数编号，位数不足以0填充 ({0:D4},3)  ->  0003
            string fmt = "{0:D" + logFileNameSetting.serialFigureCount.ToString() + "}";
            string serialNumString = string.Format(fmt, nextSerialNumer);

            //*********logFileName = prefix + yyyyMMdd + serialNumber +  fileFormat
            //**********             HP        20220601     1234       .txt
            logNumber = logFileNameSetting.prefix + DateTime.Now.ToString(logFileNameSetting.dateFormat) + serialNumString;
            logFileName = logNumber + logFileNameSetting.fileFormat;

            //每新建一个logFile后，更新流水号
            setNextSerialNumber();
        }
    }
}
