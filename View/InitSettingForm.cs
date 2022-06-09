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
    public partial class InitSettingForm : Form
    {
        Properties.Settings settings = Properties.Settings.Default;
        public InitSettingForm()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            radioButton_Chemical.Checked = settings.is_chemicalScan;
            radioButton_Kibble.Checked = settings.is_kibbleScan;
            radioButton_BDS.Checked = settings.is_BDS;
        }

        private void InitSettingForm_Closing(object sender, FormClosingEventArgs e)
        {
            settings.Save();

/*            if (radioButton_Chemical.Checked)
                Configurator.InitChemical();

            if (radioButton_Kibble.Checked)
                Configurator.InitKibble();

            if (radioButton_BDS.Checked)
                Configurator.InitBDS();*/
        }

        private void radioButton_Chemical_CheckedChanged(object sender, EventArgs e)
        {
            settings.is_chemicalScan = radioButton_Chemical.Checked;
        }

        private void radioButton_Kibble_CheckedChanged(object sender, EventArgs e)
        {
            settings.is_kibbleScan = radioButton_Kibble.Checked;
        }

        private void radioButton_BDS_CheckedChanged(object sender, EventArgs e)
        {
            settings.is_BDS = radioButton_BDS.Checked;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            settings.Save();
            Close();
        }
    }
}
