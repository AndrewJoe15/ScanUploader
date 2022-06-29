using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScanUploader.Model;
using ScanUploader.Utils;
using ScanUploader.View;

namespace ScanUploader.Controller
{
    internal class ShowManager : SingleTon<ShowManager>
    {
        

        public void updateMsgFromMES(string msg)
        {
            MainForm.thisForm.ShowMsg(msg);
        }
    }
}
