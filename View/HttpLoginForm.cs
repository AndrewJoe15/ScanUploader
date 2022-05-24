using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChemicalScan.Model;
using ChemicalScan.Controller;

namespace ChemicalScan.View
{
    public partial class HttpLoginForm : Form
    {
        public HttpLoginForm()
        {
            InitializeComponent();
            textBox_userName.Text = User.httpUserName;
            textBox_password.Text = User.httpUserPassword;
        }

        private void textBox_userName_TextChanged(object sender, EventArgs e)
        {
            User.httpUserName = textBox_userName.Text;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            User.httpUserPassword = textBox_password.Text;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            UserManager.HttpLogin();
            ConnectManager.Instance.StartTimer();
        }
    }
}
