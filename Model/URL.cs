using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ScanUploader.Model
{
    /// <summary>
    /// URL 静态类
    /// 用来存放一些URL
    /// </summary>
    public class URL : SingleTon<URL>, INotifyPropertyChanged
    {
#if DEBUG
        public static string prefix = "http://a29bdf48-e376-4c0c-96bb-cb8e7f12897f.mock.pstmn.io/";
        //-载具扫出
        public string scanContainerOut
        {
            get { return prefix + "scanContainerOut"; }
            set
            {
                _scanContainerOut = url.scanContainerOut = value;
                SendChangedInfo(nameof(scanContainerOut));
            }
        }

        //-单片玻璃
        public string scanSn
        {
            get => prefix + "scanSn";
            set
            {
                _scanSn = url.scanSn = value;
                SendChangedInfo(nameof(scanSn));
            }
        }
        //-载具扫入
        public string scanContainerIn
        {
            get => prefix + "scanContainerIn";
            set
            {
                _scanContainerIn = url.scanContainerIn = value;
                SendChangedInfo(nameof(scanContainerIn));
            }
        }
        //-载具解绑
        public string scanContainerUnbind
        {
            get => prefix + "scanContainerUnbind";
            set
            {
                _scanContainerUnbind = url.scanContainerUnbind = value;
                SendChangedInfo(nameof(scanContainerUnbind));
            }
        }
        //-提交
        public string scanSubmit
        {
            get => prefix + "scanSubmit";
            set
            {
                _scanSubmit = url.submit = value;
                SendChangedInfo(nameof(scanSubmit));
            }
        }

        //登录http的url
        public string httpLogin
        {
            get => prefix + "login";
            set
            {
                _httpLogin = url.httpLogin = value;
                SendChangedInfo(nameof(httpLogin));
            }
        }

        //-工单号获取
        public string getMesMoList
        {
            get => prefix + "getMesMoListByProductModelAndOperation";
            set
            {
                _getMesMoList = url.getMesMoList = value;
                SendChangedInfo(nameof(getMesMoList));
            }
        }

        //-产品型号获取
        public string getProductModel
        {
            get => prefix + "getProductModelBySite";
            set
            {
                _getProductModel = url.getProductModel = value;
                SendChangedInfo(nameof(getProductModel));
            }
        }
#else

        //扫码上传url
        //-载具扫出
        public string scanContainerOut {
            get { return _scanContainerOut; }
            set
            {
                _scanContainerOut = url.scanContainerOut = value;
                SendChangedInfo(nameof(scanContainerOut));
            }
        }
         
        //-单片玻璃
        public string scanSn 
        {
            get => _scanSn;
            set
            {
                _scanSn = url.scanSn = value;
                SendChangedInfo(nameof(scanSn));
            }
        }
        //-载具扫入
        public string scanContainerIn
        {
            get => _scanContainerIn;
            set
            {
                _scanContainerIn = url.scanContainerIn = value;
                SendChangedInfo(nameof(scanContainerIn));
            }
        }
        //-载具解绑
        public string scanContainerUnbind
        {
            get => _scanContainerUnbind;
            set
            {
                _scanContainerUnbind = url.scanContainerUnbind = value;
                SendChangedInfo(nameof(scanContainerUnbind));
            }
        }
        //-提交
        public string scanSubmit
        {
            get => _scanSubmit;
            set
            {
                _scanSubmit = url.submit = value;
                SendChangedInfo(nameof(scanSubmit));
            }
        }

        //登录http的url
        public string httpLogin
        {
            get => _httpLogin;
            set
            {
                _httpLogin = url.httpLogin = value;
                SendChangedInfo(nameof(httpLogin));
            }
        }

        //-工单号获取
        public string getMesMoList
        {
            get => _getMesMoList;
            set
            {
                _getMesMoList = url.getMesMoList = value;
                SendChangedInfo(nameof(getMesMoList));
            }
        }

        public string getProductModel
        {
            get => _getProductModel;
            set
            {
                _getProductModel = url.getProductModel = value;
                SendChangedInfo(nameof(getProductModel));
            }
        }
#endif
        public event PropertyChangedEventHandler PropertyChanged;

        //获取url配置对象
        private static readonly Properties.URL url = Properties.URL.Default;

        private string _scanContainerOut = url.scanContainerOut;
        private string _scanSn = url.scanSn;
        private string _scanContainerIn = url.scanContainerIn;
        private string _scanSubmit = url.submit;
        private string _scanContainerUnbind = url.scanContainerUnbind;

        private string _httpLogin = url.httpLogin;

        private string _getMesMoList = url.getMesMoList;
        private string _getProductModel = url.getProductModel;

        private void SendChangedInfo(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
