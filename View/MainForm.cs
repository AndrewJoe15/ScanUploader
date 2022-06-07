using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ChemicalScan.Model;
using ChemicalScan.Utils;
using ChemicalScan.Controller;
using System.IO;

namespace ChemicalScan.View
{
    public partial class MainForm : Form
    {

        public static MainForm thisForm;

        //BasicInfo单例
        private BasicInfo basicInfo = BasicInfo.Instance;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer_main.Start();
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            label_timer_main.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //线程安全调用
        private delegate void _ShowLog();
        public void ShowLog(string text)
        {
            _ShowLog _st = new _ShowLog(delegate ()
            {
                if (textBox_log.Text.Length > LogUtil.maxLength)
                    textBox_log.Clear();

                textBox_log.AppendText(text);
                textBox_log.AppendText(Environment.NewLine);
                textBox_log.ScrollToCaret();
            });
            Invoke(_st);
        }

        //线程安全调用
        private delegate void _ShowMsg();
        public void ShowMsg(string text)
        {
            _ShowMsg _sm = new _ShowMsg(delegate ()
            {
                textBox_errorInfo.Text = text;
            });
            Invoke(_sm);
        }

        /// <summary>
        /// 对控件进行初始化
        /// </summary>
        private void Init()
        {
            thisForm = this;

            //遍历基本信息面板的子控件
            foreach (Control ctrl in panel_basicInformation.Controls)
            {
                //基本信息的 TextBox初始化
                if (ctrl is TextBox)
                {
                    foreach (PropertyInfo p in basicInfo.GetType().GetProperties())
                    {
                        if (ctrl.Name.EndsWith(p.Name))
                        {
                            ctrl.Text = p.GetValue(basicInfo).ToString();
                        }
                    }
                }
            }

            //初始化班次下拉列表
            ///显示枚举的Name
            string[] shifts = typeof(SHIFT).GetEnumNames();//获取班次类型数组
            comboBox_shift.Items.AddRange(shifts);

            textBox_mo.Text = "";

        }

        /// <summary>
        /// 关闭程序时执行操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //弹窗再次确认是否退出程序
            if (MessageBox.Show("确定退出程序吗？", "退出",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                //保存日志流水号
                LogUtil.SaveData();
                //彻底退出程序，包括socket进程，这样程序不会后台运行
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// MainForm 显示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void textBox_site_TextChanged(object sender, EventArgs e)
        {
            basicInfo.site = textBox_site.Text;
        }

        private void textBox_operation_TextChanged(object sender, EventArgs e)
        {
            basicInfo.operation = textBox_operation.Text;
        }

        private void textBox_resource_TextChanged(object sender, EventArgs e)
        {
            basicInfo.resource = textBox_resource.Text;
        }

        private void textBox_productModel_TextChanged(object sender, EventArgs e)
        {
            basicInfo.productModel = textBox_productModel.Text;
        }

        private void textBox_productModelVersion_TextChanged(object sender, EventArgs e)
        {
            basicInfo.productModelVersion = textBox_productModelVersion.Text;
        }

        private void comboBox_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            basicInfo.shift = ((SHIFT)comboBox_shift.SelectedIndex).ToString();
        }

        private void textBox_createBy_TextChanged(object sender, EventArgs e)
        {
            basicInfo.createBy = textBox_createBy.Text;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            bool done = true;
            foreach(Control ctrl in panel_basicInformation.Controls)
            {
                if (!(ctrl is Label) && ctrl.Text.Trim() == "")
                {
                    done = false;
                    //反射得到文本控件对应的标签
                    //分割TextBox控件变量名
                    string ctrlNamePostfix = ctrl.Name.Remove(0, ctrl.Name.IndexOf("_"));
                    string name = "label" + ctrlNamePostfix;
                    FieldInfo fieldInfo = (new Label()).GetType().GetField(name);
                    //ShowUtil.ShowTips("请输入" + fieldInfo.GetValue("Text") + "信息。");
                    ShowUtil.ShowTips("请将信息填写完整。");
                    break;//找到一个为空就行了 避免多次弹窗
                }                    
            }
            if (done)
            {
                ShowUtil.ShowTips("信息录入成功！");
            }
        }

        private void menuStrip_top_Config_Click(object sender, EventArgs e)
        {
            AdminLoginForm form = new AdminLoginForm();
            form.ShowDialog(this);
        }

        private void menuStrip_top_log_openCurrent_Click(object sender, EventArgs e)
        {
            if (LogUtil.currentLogFileName == "")
                ShowUtil.ShowTips("当前无日志。");

            string logFile = LogUtil.logPath + LogUtil.currentLogFileName;
            if(!File.Exists(logFile))
                ShowUtil.ShowTips("当前日志无内容。");
            else
            {
                System.Diagnostics.Process.Start("notepad.exe", logFile);
            }
        }

        private void menuStrip_top_log_openFolder_Click(object sender, EventArgs e)
        {
            string logDir = LogUtil.logPath;
            System.Diagnostics.Process.Start("explorer.exe", logDir);
        }
    }
}
