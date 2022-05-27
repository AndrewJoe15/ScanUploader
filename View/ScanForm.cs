using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChemicalScan.Controller;

namespace ChemicalScan.View
{
    public partial class ScanForm : Form
    {
        public static ScanForm thisForm;
        public ScanForm()
        {
            InitializeComponent();
            thisForm = this;
        }

        //线程安全调用
        private delegate void _ShowLog();
        public void ShowLog(string text)
        {
            _ShowLog _st = new _ShowLog(delegate ()
            {
                textBox_log.AppendText(text);
                textBox_log.AppendText(Environment.NewLine);
                textBox_log.ScrollToCaret();
            });
            Invoke(_st);
        }
    }
}
