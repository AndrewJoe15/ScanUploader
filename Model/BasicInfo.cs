using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using ChemicalScan.Utils;

namespace ChemicalScan.Model
{
    /// <summary>
    /// 基本信息类
    /// 放置一些交互界面录入的常量
    /// 由于该类需要序列化生成Json数据，所以不允许添加额外变量
    /// </summary>
    public class BasicInfo : SingleTon<BasicInfo>
    {
        //工厂代码
        public string site { get; set; } = "2018";
        //工序
        public string operation { get; set; } = GlobalValue.operation_chemicalScan;
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
        public string createTime { get; set; } = "2022‐05‐10 21:24:15";
    }

    public enum SHIFT
    {
        白班,
        晚班
        /*
        [Description("白班")]
        Day,
        [Description("晚班")]
        Night
        */
    }
}
