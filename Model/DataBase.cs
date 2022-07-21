using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace ScanUploader.Model
{
    /// <summary>
    /// 所有数据类的基类
    /// </summary>
    public class DataBase : SingleTon<BasicInfo>, INotifyPropertyChanged
    {
        //属性更改事件
        public event PropertyChangedEventHandler PropertyChanged;

        internal void SendChangedInfo(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
