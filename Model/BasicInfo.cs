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
    /// 由于该类需要序列化生成Json数据，所以谨慎改动，原则上不允许增删变量
    /// </summary>
    public class BasicInfo : DataBase
    {
        //工厂代码
        public string site
        {
            get { return _site; }
            set
            {
                _site = value;
                SendChangedInfo(nameof(site));
            }
        }
        //工序
        public string operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                SendChangedInfo(nameof(operation));
            }
        }
        //资源编码/设备号 
        public string resource
        {
            get { return _resource; }
            set
            {
                _resource = value;
                SendChangedInfo(nameof(resource));
            }
        }
        //产品型号
        public string productModel
        {
            get { return _productModel; }
            set
            {
                _productModel = value;
                SendChangedInfo(nameof(productModel));
            }
        }
        //型号版本 
        public string productModelVersion
        {
            get { return _productModelVersion; }
            set
            {
                _productModelVersion = value;
                SendChangedInfo(nameof(productModelVersion));
            }
        }
        //班次
        public string shift
        {
            get { return _shift; }
            set
            {
                _shift = value;
                SendChangedInfo(nameof(shift));
            }
        }
        //操作人
        public string createBy
        {
            get { return _createBy; }
            set
            {
                _createBy = value;
                SendChangedInfo(nameof(createBy));
            }
        }
        //操作时间
        public string createTime { get => TimeUtil.currentTimeString; }

#if !BDSSCAN
        //工单号
#endif
        public string order
        {
            get { return _order; }
            set
            {
                _order = value;
                SendChangedInfo(nameof(order));
            }
        }

        private string _site = "";
        private string _operation = "";
        private string _resource = "";
        private string _productModel = "";
        private string _productModelVersion = "";
        private string _shift = "";
        private string _createBy = "";
        private string _order = "";
    }

    public enum SHIFT
    {
        晚班,
        白班
    }
}
