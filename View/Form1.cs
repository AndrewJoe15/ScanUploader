using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemicalScan
{
    public partial class Form1 : Form
    {
        //MES接口 通信URL
        private string url_login;
        private string url_scanVehicleIn;
        private string url_scanVehicleOut;
        private string url_scanVehicleUnbind;
        private string url_scanSn;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
