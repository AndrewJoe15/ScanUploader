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
using ChemicalScan.Utils;

namespace ChemicalScan.View
{
    public partial class ConfigureForm : Form
    {
        public static ConfigureForm thisForm;
     
        enum TAB_CONFIG
        {
            URL = 0,
            Socket,
            HTTP,
            Log
        }
        
        public ConfigureForm()
        {
            InitializeComponent();
            thisForm = this;

            Init();
        }


        private void Init()
        {
            InitURL();

            InitSocket();

            SaveButtonToggle(false);
        }
        public void SaveButtonToggle(bool status)
        {
            button_saveConfig.Enabled = status;
        }
        private void InitURL()
        {
            textBox_url_prefix.Text = URL.prefix;
            textBox_url_postfix_login.Text = URL.postfix_httpLogin;
            textBox_url_subPrefix_MES.Text = URL.subPrefix_MES;
#if CHEMICALSCAN
            textBox_url_postfix_scanContainerOut.Text = URL.postfix_httpLogin;
            textBox_url_postfix_scanSn.Text = URL.postfix_scanSn;
            textBox_url_postfix_scanContainerIn.Text = URL.postfix_scanContainerIn;
            textBox_url_postfix_scanContainerUnbind.Text = URL.postfix_scanContainerUnbind;
            textBox_url_postfix_submit.Text = URL.postfix_submit;
#elif KIBBLESCAN
            textBox_url_postfix_scanContainerOut.Text = URL.postfix_httpLogin;
            textBox_url_postfix_scanSn.Text = URL.postfix_scanSn;
            textBox_url_postfix_scanContainerIn.Text = URL.postfix_scanContainerIn;
            textBox_url_postfix_scanContainerUnbind.Enabled = false;
            textBox_url_postfix_submit.Text = URL.postfix_submit;
#elif BDSSCAN
            textBox_url_postfix_scanContainerOut.Enabled = false;
            textBox_url_postfix_scanSn.Text = URL.postfix_scanSn;
            textBox_url_postfix_scanContainerIn.Enabled = false;
            textBox_url_postfix_scanContainerUnbind.Enabled = false;
            textBox_url_postfix_submit.Enabled = false;
#endif
        }

        private void InitSocket()
        {
            textBox_socket_IP.Text = ConnectManager.hostIP;
            textBox_port_up.Text = ConnectManager.port_up.ToString();
            textBox_port_main.Text = ConnectManager.port_main.ToString();
            textBox_port_down.Text = ConnectManager.port_down.ToString();
            textBox_port_submit.Text = ConnectManager.port_submit.ToString();
#if CHEMICALSCAN

#elif KIBBLESCAN

#elif BDSSCAN
        textBox_port_up.Enabled = checkBox_socket_up.Checked = false;
        textBox_port_down.Enabled = checkBox_socket_down.Checked = false;
        textBox_port_submit.Enabled = checkBox_socket_submit.Checked = false;
#endif
        }


        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_saveConfig_Click(object sender, EventArgs e)
        {
            //当前选中的选项卡的索引
            int index = tabControl_config.SelectedIndex;

            //保存url配置
            if (index == (int)TAB_CONFIG.URL)                
                Configurator.SaveURL();
            if (index == (int)TAB_CONFIG.Socket)
                ConnectManager.SaveSocketConfig();
            
            SaveButtonToggle(false);
        }

        #region URL Config
        private void textBox_url_prefix_TextChanged(object sender, EventArgs e)
        {
            URL.prefix = textBox_url_prefix.Text;
            SaveButtonToggle(true);
        }

        private void textBox_url_login_TextChanged(object sender, EventArgs e)
        {

            URL.postfix_httpLogin = textBox_url_postfix_login.Text;
            SaveButtonToggle(true);
        }

        private void textBox_url_subPrefix_MES_TextChanged(object sender, EventArgs e)
        {
            URL.subPrefix_MES = textBox_url_subPrefix_MES.Text;
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_scanContainerOut_TextChanged(object sender, EventArgs e)
        {
            URL.postfix_scanContainerOut = textBox_url_postfix_scanContainerOut.Text;
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_scanSn_TextChanged(object sender, EventArgs e)
        {
            URL.postfix_scanSn = textBox_url_postfix_scanSn.Text;
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_scanContainerIn_TextChanged(object sender, EventArgs e)
        {
            URL.postfix_scanContainerIn = textBox_url_postfix_scanContainerIn.Text;
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_scanContainerUnbind_TextChanged(object sender, EventArgs e)
        {
            URL.postfix_scanContainerUnbind = textBox_url_postfix_scanContainerUnbind.Text;
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_submit_TextChanged(object sender, EventArgs e)
        {
            URL.postfix_submit = textBox_url_postfix_submit.Text;
            SaveButtonToggle(true);
        }
        #endregion

        #region Socket Config
        private void textBox_socket_IP_TextChanged(object sender, EventArgs e)
        {
            ConnectManager.hostIP = textBox_socket_IP.Text;
            SaveButtonToggle(true);

        }
        private void textBox_port_up_TextChanged(object sender, EventArgs e)
        {
            ConnectManager.port_up =  int.Parse(textBox_port_up.Text);
            SaveButtonToggle(true);
        }        

        private void textBox_port_main_TextChanged(object sender, EventArgs e)
        {
            ConnectManager.port_main = int.Parse(textBox_port_main.Text);
            SaveButtonToggle(true);
        }

        private void textBox_port_down_TextChanged(object sender, EventArgs e)
        {
            ConnectManager.port_down = int.Parse(textBox_port_down.Text);
            SaveButtonToggle(true);
        }

        private void textBox_port_submit_TextChanged(object sender, EventArgs e)
        {
            ConnectManager.port_submit = int.Parse(textBox_port_submit.Text);
            SaveButtonToggle(true);
        }

        private void checkBox_socket_up_CheckedChanged(object sender, EventArgs e)
        {
            textBox_port_up.Enabled = checkBox_socket_up.Checked;
            SaveButtonToggle(true);
        }

        private void checkBox_socket_main_CheckedChanged(object sender, EventArgs e)
        {
            textBox_port_main.Enabled = checkBox_socket_main.Checked;
            SaveButtonToggle(true);

        }

        private void checkBox_socket_down_CheckedChanged(object sender, EventArgs e)
        {
            textBox_port_down.Enabled = checkBox_socket_down.Checked;
            SaveButtonToggle(true);

        }

        private void checkBox_socket_submit_CheckedChanged(object sender, EventArgs e)
        {
            textBox_port_submit.Enabled = checkBox_socket_submit.Checked;
            SaveButtonToggle(true);

        }
        #endregion

        private void textBox_httpUserName_TextChanged(object sender, EventArgs e)
        {
            
            SaveButtonToggle(true);
        }

        private void textBox_httpPassword_TextChanged(object sender, EventArgs e)
        {

            SaveButtonToggle(true);
        }

        private void textBox_httpSite_TextChanged(object sender, EventArgs e)
        {

            SaveButtonToggle(true);
        }


    }
}
