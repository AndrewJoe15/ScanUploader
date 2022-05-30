using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChemicalScan.Model;
using ChemicalScan.Utils;
using ChemicalScan.View;

namespace ChemicalScan.Controller
{
    internal class ShowManager : SingleTon<ShowManager>
    {
        

        public void updateMsgFromMES(string msg)
        {
            MainForm.thisForm.ShowMsg(msg);
        }
    }
}
