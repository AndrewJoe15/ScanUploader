using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ScanUploader.Model;
using ScanUploader.Utils;
using ScanUploader.Controller;
using System.IO;

namespace ScanUploader.View
{
    public partial class MainForm : Form
    {

        public static MainForm thisForm;

        //BasicInfo单例
        private BasicInfo basicInfo = BasicInfo.Instance;

        private static int textBox_log_maxLength = 10000;

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
        //显示日志信息
        public void ShowLog(string text)
        {
            _ShowLog _sl = new _ShowLog(delegate ()
            {
                if (textBox_log.Text.Length > textBox_log_maxLength)
                    textBox_log.Clear();

                textBox_log.AppendText(text);
                textBox_log.AppendText(Environment.NewLine);
                textBox_log.ScrollToCaret();
            });
            Invoke(_sl);
        }

        //线程安全调用
        private delegate void _ShowMsg();
        //显示错误信息
        public void ShowMsg(string text)
        {
            _ShowMsg _sm = new _ShowMsg(delegate ()
            {
                textBox_errorInfo.Text = text;
            });
            Invoke(_sm);
        }

        //更新良率统计信息
        private delegate void _UpdateStatistics();
        public void UpdateStatistics(int index)
        {
            _UpdateStatistics _us = new _UpdateStatistics(delegate ()
            {
                if(index == 1)
                {
                    label_text_statistics_OK1.Text = Statistics.OK1.ToString();
                    label_text_statistics_NG1.Text = Statistics.NG1.ToString();
                    label_text_statistics_yield1.Text = Statistics.yield1;
                }
                if(index == 2)
                {
                    label_text_statistics_OK2.Text = Statistics.OK2.ToString();
                    label_text_statistics_NG2.Text = Statistics.NG2.ToString();
                    label_text_statistics_yield2.Text = Statistics.yield2;
                }

            });
            Invoke(_us);
        }


        //更新NG信息统计表
        private delegate void _UpdateNGInfo();
        public void AddNGInfo(string snNumber, string msg)
        {
            _UpdateNGInfo _uni = new _UpdateNGInfo(delegate ()
            {
                //一行数据
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//.Add() 从1开始添加，所以第0个以[0]方式访问
                item.SubItems.Add(snNumber);
                item.SubItems.Add(msg);

                //添加listView项
                listView_NG_info.Items.Add(item);
                listView_NG_info.Items[listView_NG_info.Items.Count - 1].EnsureVisible();//最后一行可见
            });
            Invoke(_uni);
        }


        /// <summary>
        /// 对控件进行初始化
        /// </summary>
        private void Init()
        {
            thisForm = this;

            //遍历基本信息面板的子控件，填充信息
            foreach (Control ctrl in tabPage_basicInfo.Controls)
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
            comboBox_shift.SelectedIndex = 0;

            //WMS 校验信息
            textBox_orgnizationId.Text = textBox_site.Text;
            textBox_upperMaterialCode.Text = BasicInfo_WMS.Instance.upperMaterialCode;
            textBox_standardTextCode.Text = BasicInfo_WMS.Instance.standardTextCode;

            //初始化日志文件对象
            LogFile.nextSerialNumer = Properties.LogFileName.Default.nextSerialNumber;
            LogFile.logFile_line1 = new LogFile();
            //- 化抛项目有两路日志文件
            if (Properties.Settings.Default.is_chemicalScan)
                LogFile.logFile_line2 = new LogFile();
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
                LogFile.SaveSerialNumber();

                //彻底退出程序，包括socket进程
                //这样关闭软件后不会有进程后台运行
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
            //最大化窗口
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
            openLogFile(LogFile.logFile_line1);
            openLogFile(LogFile.logFile_line2);
        }

        private void openLogFile(LogFile logFile)
        {
            if (logFile != null)
            {
                string fullPath = logFile.logPath + logFile.logFileName;
                if (!File.Exists(fullPath))
                    ShowUtil.ShowTips("当前日志无内容。");
                else
                    System.Diagnostics.Process.Start("notepad.exe", fullPath);
            }
        }


        private void menuStrip_top_log_openFolder_Click(object sender, EventArgs e)
        {
            if(LogFile.logFile_line1 != null)
                System.Diagnostics.Process.Start("explorer.exe", LogFile.logFile_line1.logPath);
        }

        private void textBox_standardTextCode_TextChanged(object sender, EventArgs e)
        {
            BasicInfo_WMS.Instance.standardTextCode = textBox_standardTextCode.Text;
        }

        private void textBox_upperMaterialCode_TextChanged(object sender, EventArgs e)
        {
            BasicInfo_WMS.Instance.upperMaterialCode = textBox_upperMaterialCode.Text;
        }

        private void textBox_mo_TextChanged(object sender, EventArgs e)
        {
            BasicInfo_WMS.Instance.workOrder = textBox_mo.Text;
        }

        private void textBox_wareHouseCode_TextChanged(object sender, EventArgs e)
        {
            Query_WMS.Instance.wareHouseCode = textBox_wareHouseCode.Text;
        }

        private void textBox_orgnizationId_TextChanged(object sender, EventArgs e)
        {
            Query_WMS.Instance.orgnizationId = textBox_orgnizationId.Text;
        }

        private void textBox_cargoNumber_TextChanged(object sender, EventArgs e)
        {
            BasicInfo_WMS.Instance.cargoNumber = Query_WMS.Instance.cargoNumber = textBox_cargoNumber.Text;
        }

        private void button_empty_Click(object sender, EventArgs e)
        {
            listView_NG_info.Items.Clear(); //清空所有数据项
        }

        private void button_export_excel_Click(object sender, EventArgs e)
        {
            FileUtil.ExportExcel("NG信息统计", listView_NG_info);
        }
    }
}
