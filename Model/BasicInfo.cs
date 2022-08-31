using System.Runtime.Serialization;

using ScanUploader.Utils;

namespace ScanUploader.Model
{
    /// <summary>
    /// 基本信息类
    /// 放置一些交互界面录入的常量
    /// 由于该类需要序列化生成Json数据，所以谨慎改动，原则上不允许增删变量
    /// </summary>
    [DataContract]
    public class BasicInfo : DataBase
    {
        //工厂代码
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
# if BDSSCAN
        [DataMember(Name ="submitTime")]
#else
        [DataMember]
#endif 
        public string createTime { get => TimeUtil.currentTimeString; }

        //工单号
#if CHEMICALSCAN || CUMOSCAN
        [DataMember(Name = "mo")] //序列化后的字段名
#else
        [DataMember]
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
}
