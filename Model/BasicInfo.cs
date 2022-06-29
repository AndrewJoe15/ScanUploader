using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using ScanUploader.Utils;

namespace ScanUploader.Model
{
    /// <summary>
    /// 基本信息类
    /// 放置一些交互界面录入的常量
    /// 由于该类需要序列化生成Json数据，所以不允许添加额外变量
    /// </summary>
    public class BasicInfo : SingleTon<BasicInfo>
    {
#if CHEMICALSCAN
        //工厂代码
        public string site { get; set; } = "2018";
        //工序
        public string operation { get; set; } = "A0314";
        //资源编码/设备号 
        public string resource { get; set; } = "51005748";
        //产品型号
        public string productModel { get; set; } = "L3038LA";
        //型号版本 
        public string productModelVersion { get; set; } = "1.0";
        //班次
        public string shift { get; set; } = "白班";
        //操作人
        public string createBy { get; set; } = "sy100228";
        //操作时间
        public string createTime { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
#endif

#if KIBBLESCAN
        //工厂代码
        public string site { get; set; } = "2018";
        //工序
        public string operation { get; set; } = "A0312";
        //资源编码/设备号 
        public string resource { get; set; } = "62046875";
        //产品型号
        public string productModel { get; set; } = "L3038LA";
        //型号版本 
        public string productModelVersion { get; set; } = "1.0";
        //班次
        public string shift { get; set; } = "白班";
        //操作人
        public string createBy { get; set; } = "sy100228";
        //操作时间
        public string createTime { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
#endif


#if BDSSCAN
        //工厂代码
        public string site { get; set; } = "2018";
        //工序
        public string operation { get; set; } = "03";
        //资源编码/设备号 
        public string resource { get; set; } = "1";
        //产品型号
        public string productModel { get; set; } = "S3018B02";
        //型号版本 
        public string productModelVersion { get; set; } = "1.0";
        //班次
        public string shift { get; set; } = "白班";
        //操作人
        public string createBy { get; set; } = "sy100228";
        //操作时间
        public string submitTime { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public string order = "000600003375";
#endif
    }

    public enum SHIFT
    {
        白班,
        晚班
    }
}
