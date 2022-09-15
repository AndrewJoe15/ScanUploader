using System;
using System.Windows.Forms;

using ScanUploader.Model;

namespace ScanUploader.View
{
    public partial class ConfigureForm : Form
    {
        public static ConfigureForm thisForm;
        
        private static Properties.URL url = Properties.URL.Default;
        private static Properties.Settings settings = Properties.Settings.Default;
        private static Properties.Socket socket = Properties.Socket.Default;
        private static Properties.User_Http userHttp = Properties.User_Http.Default;
        private static Properties.LogFileName log = Properties.LogFileName.Default;

        public ConfigureForm()
        {
            InitializeComponent();

            thisForm = this;

            Init();
        }

        private void Init()
        {

            BindData();
        }

        private void BindData_Text(Control control, object dataSource, string dataMember)
        {
            if (dataSource != null)
            {
                control.DataBindings.Add("Text", dataSource, dataMember);
            }
        }

        private void BindData()
        {
            //数据绑定
            //控件 -> 属性设置
            //-- URL
            BindData_Text(textBox_url_scanContainerOut, URL.Instance, nameof(URL.Instance.scanContainerOut));
            BindData_Text(textBox_url_scanSn, URL.Instance, nameof(URL.Instance.scanSn));
            BindData_Text(textBox_url_scanContainerIn, URL.Instance, nameof(URL.Instance.scanContainerIn));
            BindData_Text(textBox_url_submit, URL.Instance, nameof(URL.Instance.scanSubmit));
            BindData_Text(textBox_url_scanContainerUnbind, URL.Instance, nameof(URL.Instance.scanContainerUnbind));

            BindData_Text(textBox_url_login_MES, URL.Instance, nameof(URL.Instance.httpLogin));

            BindData_Text(textBox_getMesMoList, URL.Instance, nameof(URL.Instance.getMesMoList));
            BindData_Text(textBox_getProductModel, URL.Instance, nameof(URL.Instance.getProductModel));

            //-- Log
            textBox_logPrefix.Text = log.prefix;
            textBox_logDateFormat.Text = log.dateFormat;
            textBox_serialFigures.Text = log.serialFigureCount.ToString();

            //socket
            textBox_socket_IP.Text = socket.IP_host;
            textBox_port_up.Text = socket.port_up.ToString();
            textBox_port_main.Text = socket.port_main.ToString();
            textBox_port_down.Text = socket.port_down.ToString();
            textBox_port_insert.Text = socket.port_insert.ToString();            
            textBox_port_submit.Text = socket.port_submit.ToString();            

            textBox_port_up.Enabled = checkBox_socket_up.Checked = socket.enable_socket_up;
            textBox_port_main.Enabled = checkBox_socket_main.Checked = socket.enable_socket_main;
            textBox_port_down.Enabled = checkBox_socket_down.Checked = socket.enable_socket_down;
            textBox_port_insert.Enabled = checkBox_socket_insert.Checked = socket.enable_socket_insert;
            textBox_port_submit.Enabled = checkBox_socket_submit.Checked = socket.enable_socket_submit;

        }

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_saveConfig_Click(object sender, EventArgs e)
        {
            url.Save();

            SaveSocketConfig();
            SaveLogFileNameConfig();
        }


        private void SaveSocketConfig()
        {
            socket.IP_host = textBox_socket_IP.Text;

            socket.port_up = int.Parse(textBox_port_up.Text);
            socket.port_main = int.Parse(textBox_port_main.Text);
            socket.port_down = int.Parse(textBox_port_down.Text);
            socket.port_submit = int.Parse(textBox_port_submit.Text);

            socket.enable_socket_up = checkBox_socket_up.Checked;
            socket.enable_socket_down = checkBox_socket_down.Checked;
            socket.enable_socket_down = checkBox_socket_down.Checked;
            socket.enable_socket_submit = checkBox_socket_submit.Checked;

            socket.Save();
        }

        private void SaveLogFileNameConfig()
        {
            log.prefix = textBox_logPrefix.Text;
            log.dateFormat = textBox_logDateFormat.Text;
            log.serialFigureCount = int.Parse(textBox_serialFigures.Text);

            log.Save();
        }

        private void Button_RestoreConfig_Click(object sender, EventArgs e)
        {         

            if (MessageBox.Show("确定重置所有设置吗？", "退出",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                url.Reset();

                if (MessageBox.Show("配置已重置，请重新打开应用。", "退出",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }

            
        }
    }
}
