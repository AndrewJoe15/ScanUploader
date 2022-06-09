using System;
using System.Windows.Forms;

namespace ChemicalScan.View
{
    public partial class ConfigureForm : Form
    {
        enum TAB_CONFIG
        {
            URL = 0,
            Socket,
            HTTP,
            Log
        }
        public static ConfigureForm thisForm;
        
        private static Properties.URL url = Properties.URL.Default;
        private static Properties.Settings settings = Properties.Settings.Default;
        private static Properties.Socket socket = Properties.Socket.Default;
        private static Properties.UserData userData = Properties.UserData.Default;
        private static Properties.LogFile log = Properties.LogFile.Default;

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

            InitUser();

            InitLogFile();

            SaveButtonToggle(false);
        }
        public void SaveButtonToggle(bool status)
        {
            button_saveConfig.Enabled = status;
        }
        private void InitURL()
        {
            textBox_url_prefix.Text = url.prefix;
            textBox_url_subPrefix_MES.Text = url.subPrefix_MES;

            textBox_url_postfix_scanContainerOut.Text = url.httpLogin_MES;
            textBox_url_postfix_scanSn.Text = url.postfix_scanSn;
            textBox_url_postfix_scanContainerIn.Text = url.postfix_scanContainerIn;
            textBox_url_postfix_scanContainerUnbind.Text = url.postfix_scanContainerUnbind;
            textBox_url_postfix_submit.Text = url.postfix_submit;
            
            if (settings.is_kibbleScan)
            {
                textBox_url_postfix_scanContainerUnbind.Enabled = false;
                textBox_stockQuery_WMS.Text = Properties.URL.Default.stockQuery_WMS;
                textBox_validate_WMS.Text = Properties.URL.Default.validate_WMS;
            }
            else
            {
                textBox_stockQuery_WMS.Enabled = false;
                textBox_validate_WMS.Enabled = false;
            }

            if (settings.is_BDS)
            {
                textBox_url_postfix_scanContainerOut.Enabled = false;
                textBox_url_postfix_scanContainerIn.Enabled = false;
                textBox_url_postfix_scanContainerUnbind.Enabled = false;
                textBox_url_postfix_submit.Enabled = false;
            }
        }

        private void InitSocket()
        {
            textBox_socket_IP.Text = socket.IP_host;
            textBox_port_up.Text = socket.port_up.ToString();
            textBox_port_main.Text = socket.port_main.ToString();
            textBox_port_down.Text = socket.port_down.ToString();
            textBox_port_submit.Text = socket.port_submit.ToString();            

            textBox_port_up.Enabled = checkBox_socket_up.Checked = socket.socket_up;
            textBox_port_main.Enabled = checkBox_socket_main.Checked = socket.socket_main;
            textBox_port_down.Enabled = checkBox_socket_down.Checked = socket.socket_down;
            textBox_port_submit.Enabled = checkBox_socket_submit.Checked = socket.socket_submit;

        }

        private void InitUser()
        {
            textBox_httpUserName_MES.Text = userData.userName_http_MES;
            textBox_httpPassword_MES.Text = userData.password_http_MES;
            textBox_httpSite_MES.Text = userData.site_http_MES;

            textBox_url_login_MES.Text = url.httpLogin_MES;

            textBox_httpUserName_MES.Text = userData.userName_http_MES;
            textBox_httpPassword_MES.Text = userData.password_http_MES;
            textBox_httpSite_MES.Text = userData.site_http_MES;

            textBox_url_login_WMS.Text = url.httpLogin_WMS;

        }

        private void InitLogFile()
        {
            textBox_logPrefix.Text = log.prefix;
            textBox_logDateFormat.Text = log.dateFormat;
            textBox_serialFigures.Text = log.serialFigures.ToString();
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
                SaveURL();
            if (index == (int)TAB_CONFIG.Socket)
                SaveSocketConfig();
            if (index == (int)TAB_CONFIG.HTTP)
                SaveUserData();
            if (index == (int)TAB_CONFIG.Log)
                SaveLogFileNameConfig();

            SaveButtonToggle(false);
        }

        /// <summary>
        /// 保存URL到配置文件
        /// </summary>
        private void SaveURL()
        {
            url.prefix = textBox_url_prefix.Text;
            url.subPrefix_MES = textBox_url_subPrefix_MES.Text;

            url.postfix_scanContainerOut = textBox_url_postfix_scanContainerOut.Text;
            url.postfix_scanSn = textBox_url_postfix_scanSn.Text;
            url.postfix_scanContainerIn = textBox_url_postfix_scanContainerIn.Text;
            url.postfix_scanContainerUnbind = textBox_url_postfix_scanContainerUnbind.Text;
            url.postfix_submit = textBox_url_postfix_submit.Text;

            url.stockQuery_WMS = textBox_stockQuery_WMS.Text;
            url.validate_WMS = textBox_validate_WMS.Text;

            url.Save();
        }

        private void SaveSocketConfig()
        {
            socket.IP_host = textBox_socket_IP.Text;

            socket.port_up = int.Parse(textBox_port_up.Text);
            socket.port_main = int.Parse(textBox_port_main.Text);
            socket.port_down = int.Parse(textBox_port_down.Text);
            socket.port_submit = int.Parse(textBox_port_submit.Text);

            socket.socket_up = checkBox_socket_up.Checked;
            socket.socket_down = checkBox_socket_down.Checked;
            socket.socket_down = checkBox_socket_down.Checked;
            socket.socket_submit = checkBox_socket_submit.Checked;

            socket.Save();
        }

        private void SaveUserData()
        {
            userData.userName_http_MES = textBox_httpUserName_MES.Text;
            userData.password_http_MES = textBox_httpPassword_MES.Text;
            userData.site_http_MES = textBox_httpSite_MES.Text;

            url.httpLogin_MES = textBox_url_login_MES.Text;

            userData.userName_http_WMS = textBox_httpUserName_WMS.Text;
            userData.password_http_WMS = textBox_httpPassword_WMS.Text;

            url.httpLogin_WMS = textBox_url_login_WMS.Text;

            userData.Save();
        }

        private void SaveLogFileNameConfig()
        {
            log.prefix = textBox_logPrefix.Text;
            log.dateFormat = textBox_logDateFormat.Text;
            log.serialFigures = int.Parse(textBox_serialFigures.Text);

            log.Save();
        }

        #region URL Config
        private void textBox_url_prefix_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_url_subPrefix_MES_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_scanContainerOut_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_scanSn_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_scanContainerIn_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_scanContainerUnbind_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_url_postfix_submit_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }
        private void textBox_stockQuery_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }
        private void textBox_validate_WMS_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);

        }
        #endregion

        #region Socket Config
        private void textBox_socket_IP_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);

        }
        private void textBox_port_up_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }        

        private void textBox_port_main_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_port_down_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_port_submit_TextChanged(object sender, EventArgs e)
        {
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

        #region Http
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


        private void textBox_httpUserName_WMS_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);

        }

        private void textBox_httpPassword_WMS_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);

        }

        private void textBox_url_login_MES_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }

        private void textBox_url_login_WMS_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);
        }
        #endregion

        #region LogFileNameFormat
        private void textBox_logPrefix_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);

        }

        private void textBox_logDateFormat_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);

        }

        private void textBox_serialFigures_TextChanged(object sender, EventArgs e)
        {
            SaveButtonToggle(true);

        }


        #endregion


    }
}
