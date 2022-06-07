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
        public InitSettingForm()
        {
            InitializeComponent();
        }

        private void button_certain_Click(object sender, EventArgs e)
        {
            if (radioButton_Chemical.Checked)
                Configurator.InitChemical();

            if(radioButton_Kibble.Checked)
                Configurator.InitKibble();

            if(radioButton_BDS.Checked)
                Configurator.InitBDS();
        }

    }
}
