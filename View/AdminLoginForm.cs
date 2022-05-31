using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChemicalScan.Utils;

namespace ChemicalScan.View
{
    public partial class AdminLoginForm : Form
    {
        private string userName = "RP";
        private string password = "120626";

        public AdminLoginForm()
        {
            InitializeComponent();
            textBox_userName.Text = userName;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_userName.Text == userName && textBox_password.Text == password)
            {
                this.Close();
                new ConfigureForm().Show();
            }
            else
            {
                ShowUtil.ShowTips("用户名或密码错误。");
            }
        }
    }
}
