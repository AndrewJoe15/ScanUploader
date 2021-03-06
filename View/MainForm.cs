using System;
using System.Collections.Specialized;
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
        private Properties.BasicInfo basicInfSetting = Properties.BasicInfo.Default;

        private static readonly int textBox_text_maxLength = 1024 * 1024;

        public MainForm()
        {
            InitializeComponent();

            BindData();

            Init();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //时钟开始运行
            timer_main.Start();

            LogUtil.WriteLog("上位机启动。");
        }



        private void timer_main_Tick(object sender, EventArgs e)
        {
            //底部时钟
            label_timer_main.Text = TimeUtil.currentTimeString;
        }

        //线程安全调用
        private delegate void _ShowLogInfo();
        //显示日志信息
        public void ShowLogInfo(string text)
        {
            _ShowLogInfo _sl = new _ShowLogInfo(delegate ()
            {
                if (textBox_log.Text.Length > textBox_text_maxLength)
                    textBox_log.Clear();

                textBox_log.AppendText(text);
                textBox_log.AppendText(Environment.NewLine);
                textBox_log.ScrollToCaret();
            });
            Invoke(_sl);
        }

        //线程安全调用
        private delegate void _ShowDebugInfo();
        //显示Debug信息
        public void ShowDebugInfo(string debugInfo)
        {
            _ShowDebugInfo _sdi = new _ShowDebugInfo(delegate ()
            {
                if (textBox_debug.Text.Length > textBox_text_maxLength)
                    textBox_debug.Clear();

                textBox_debug.AppendText(TimeUtil.currentTimeString_log + debugInfo);
                textBox_debug.AppendText(Environment.NewLine);
                textBox_debug.ScrollToCaret();

                //写入日志
                LogUtil.WriteLog(debugInfo, LogFile.debugFile, false);
            });
            Invoke(_sdi);
        }


        private delegate void _UpdateSocketStatus();
        //更新Socket连接状态信息
        public void UpdateSocketStatus(string endPoint, bool connected)
        {
            _UpdateSocketStatus _uss = new _UpdateSocketStatus(delegate ()
            {
                if (endPoint.Contains(ConnectManager.port_up.ToString()))
                {
                    if(connected)
                        label_socketStatus_up.BackColor = Color.Green;
                    else
                        label_socketStatus_up.BackColor = Color.Red;
                }

                if (endPoint.Contains(ConnectManager.port_main.ToString()))
                {
                    if (connected)
                        label_socketStatus_main.BackColor = Color.Green;
                    else
                        label_socketStatus_main.BackColor = Color.Red;
                }

                if (endPoint.Contains(ConnectManager.port_down.ToString()))
                {
                    if (connected)
                        label_socketStatus_down.BackColor = Color.Green;
                    else
                        label_socketStatus_down.BackColor = Color.Red;
                }

                if (endPoint.Contains(ConnectManager.port_insert.ToString()))
                {
                    if (connected)
                        label_socketStatus_insert.BackColor = Color.Green;
                    else
                        label_socketStatus_insert.BackColor = Color.Red;
                }

                if (endPoint.Contains(ConnectManager.port_submit.ToString()))
                {
                    if (connected)
                        label_socketStatus_submit.BackColor = Color.Green;
                    else
                        label_socketStatus_submit.BackColor = Color.Red;
                }
            });
            Invoke(_uss);
        }

        //更新良率统计信息
        private delegate void _UpdateStatistics();
        /// <summary>
        /// 更新良率统计信息
        /// </summary>
        /// <param name="index">1：左通道 2：右通道</param>
        public void UpdateStatistics(int index)
        {
            _UpdateStatistics _us = new _UpdateStatistics(delegate ()
            {
                if(index == 1)
                {
                    label_text_statistics_OK1.Text = Statistics.OK_1.ToString();
                    label_text_statistics_NG1.Text = Statistics.NG_1.ToString();
                    label_text_statistics_yield1.Text = Statistics.yield1;
                }
                if (index == 2)
                {
                    label_text_statistics_OK2.Text = Statistics.OK_2.ToString();
                    label_text_statistics_NG2.Text = Statistics.NG_2.ToString();
                    label_text_statistics_yield2.Text = Statistics.yield2;
                }
                //更新良率总计
                UpdateStatisticsTotal();

            });
            Invoke(_us);
        }
        /// <summary>
        /// 总良率统计
        /// </summary>
        private void UpdateStatisticsTotal()
        {
            label_text_statistics_OK_total.Text = Statistics.OK_total.ToString();
            label_text_statistics_NG_total.Text = Statistics.NG_total.ToString();
            label_text_statistics_yield_total.Text = Statistics.yield_total;
        }

        private static void AddItem(string subItem_1, string subItem_2, ListView listView)
        {
            //一行数据
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = DateTime.Now.ToString("MM-dd HH:mm:ss");//.Add() 从1开始添加，所以第0个以[0]方式访问
            item.SubItems.Add(subItem_1);
            item.SubItems.Add(subItem_2);

            //添加listView项
            listView.Items.Add(item);
            listView.Items[listView.Items.Count - 1].EnsureVisible();//最后一行可见
        }

        //添加Error信息统计数据
        private delegate void _AddErrorInfo();
        public void AddErrorInfo(string errorCode, string msg)
        {
            _AddErrorInfo _aei = new _AddErrorInfo(delegate ()
            {
                AddItem(errorCode, msg, listView_errorInfo);
            });
            Invoke(_aei);
        }

        //添加NG信息统计数据
        private delegate void _AddNGInfo();
        public void AddNGInfo(string snNumber, string msg)
        {
            _AddNGInfo _uni = new _AddNGInfo(delegate ()
            {
                AddItem(snNumber, msg, listView_NG_info);
            });
            Invoke(_uni);
        }

        private void DataBindText(Control control, object dataSource, string dataMember)
        {
            if (dataSource != null)
            {
                control.DataBindings.Add("Text", dataSource, dataMember);
            }
        }

        /// <summary>
        /// 将控件与数据绑定
        /// </summary>
        private void BindData()
        {
            //控件 数据绑定
            DataBindText(comboBox_site, basicInfo, nameof(basicInfo.site));
            DataBindText(comboBox_operation, basicInfo, nameof(basicInfo.operation));
            DataBindText(comboBox_resource, basicInfo, nameof(basicInfo.resource));
            DataBindText(comboBox_productModel, basicInfo, nameof(basicInfo.productModel));
            DataBindText(comboBox_productModelVersion, basicInfo, nameof(basicInfo.productModelVersion));
            DataBindText(comboBox_shift, basicInfo, nameof(basicInfo.shift));
            DataBindText(comboBox_createBy, basicInfo, nameof(basicInfo.createBy));
            DataBindText(comboBox_order, basicInfo, nameof(basicInfo.order));
        }

        /// <summary>
        /// 对控件进行初始化
        /// </summary>
        private void Init()
        {
            thisForm = this;


            //遍历基本信息面板的组合框控件，填充信息
            foreach (Control ctrl in panel_basicInformation.Controls)
            {
                //基本信息的 ComboBox 初始化
                if (ctrl is ComboBox)
                {
                    //遍历基本信息设置中的每一个属性
                    foreach (PropertyInfo p in Properties.BasicInfo.Default.GetType().GetProperties())
                    {
                        if (ctrl.Name.EndsWith(p.Name))
                        {
                            //字符串集合的枚举器
                            StringEnumerator se = ((StringCollection)p.GetValue(Properties.BasicInfo.Default)).GetEnumerator();
                            //下拉列表加载数据
                            while (se.MoveNext())
                            {
                                ((ComboBox)ctrl).Items.Add(se.Current);
                            }
                            //显示最后一个字符串
                            ((ComboBox)ctrl).SelectedIndex = ((ComboBox)ctrl).Items.Count - 1;
                            //给basicInfo的属性赋值 这样界面才会显示，否则又跟着basicInfo的属性为""了
                            PropertyInfo propertyInfo = basicInfo.GetType().GetProperty(p.Name);
                            if(propertyInfo != null)
                                propertyInfo.SetValue(basicInfo, ((ComboBox)ctrl).Text, null);

                            break; 
                        }
                    }
                }
            }

            //保存按钮禁用
            button_save_basicInfo.Enabled = false;

            //初始化日志文件对象
            LogFile.nextSerialNumer = Properties.LogFileName.Default.nextSerialNumber;
            LogFile.logFile = new LogFile();
            //Debug 通讯数据日志
            LogFile.debugFile = new LogFile("Data", "\\Log\\Data\\");
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

        private void menuStrip_top_Config_Click(object sender, EventArgs e)
        {
            LoginForm_Admin form = new LoginForm_Admin();
            form.ShowDialog(this);
        }

        private void button_openLogFile_Click(object sender, EventArgs e)
        {
            if (tabControl_log.SelectedTab == tabPage_logInfo)
                openLogFile(LogFile.logFile);
            else if (tabControl_log.SelectedTab == tabPage_debugInfo)
                openLogFile(LogFile.debugFile);
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

        private void button_openLogDir_Click(object sender, EventArgs e)
        {
            if (LogFile.logFile == null)
                return;
            if (tabControl_log.SelectedTab == tabPage_logInfo)
                System.Diagnostics.Process.Start("explorer.exe", LogFile.logFile.logPath);
            else if (tabControl_log.SelectedTab == tabPage_debugInfo)
                System.Diagnostics.Process.Start("explorer.exe", LogFile.debugFile.logPath);
        }



        private void button_empty_Click(object sender, EventArgs e)
        {
            if (tabControl_error_info.SelectedTab == tabPage_error_info)
            {
                listView_errorInfo.Items.Clear(); //清空error表格所有数据项
            }
            else if (tabControl_error_info.SelectedTab == tabPage_NG_info)
            {
                listView_NG_info.Items.Clear(); //清空NG表格所有数据项
            }
        }

        private void button_export_excel_Click(object sender, EventArgs e)
        {
            if (tabControl_error_info.SelectedTab == tabPage_error_info)
            {
                FileUtil.ExportExcel("Error信息统计", listView_errorInfo);
            }
            else if (tabControl_error_info.SelectedTab == tabPage_NG_info)
            {
                FileUtil.ExportExcel("NG信息统计", listView_NG_info);
            }
        }

        /// <summary>
        /// 组合文本框中文字被更改时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnComboBoxTextUpdate(object sender, EventArgs e)
        {
            button_save_basicInfo.Enabled = true;
        }

        private void Button_save_basicInfo_Click(object sender, EventArgs e)
        {
            //保存BasicInfo到设置文件
            SaveBasicInfoSetting(comboBox_site, basicInfSetting.site);
            SaveBasicInfoSetting(comboBox_operation, basicInfSetting.operation);
            SaveBasicInfoSetting(comboBox_productModel, basicInfSetting.productModel);
            SaveBasicInfoSetting(comboBox_productModelVersion, basicInfSetting.productModelVersion);
            SaveBasicInfoSetting(comboBox_resource, basicInfSetting.resource);
            SaveBasicInfoSetting(comboBox_shift, basicInfSetting.shift);
            SaveBasicInfoSetting(comboBox_createBy, basicInfSetting.createBy);
            SaveBasicInfoSetting(comboBox_order, basicInfSetting.order);
            //保存
            basicInfSetting.Save();

            //保存按钮禁用
            button_save_basicInfo.Enabled = false;
        }


        /// <summary>
        /// 保存一项基本信息到设置文件
        /// </summary>
        /// <param name="sc">设置文件的StringCollection属性</param>
        /// <param name="comboBox">界面中文本框</param>
        private void SaveBasicInfoSetting(ComboBox comboBox, StringCollection sc)
        {
            //表单验证
            if (CheckEmpty(panel_basicInformation))
            {
                ShowUtil.ShowTips("录入信息不能为空！");
                return;
            }
            string text = comboBox.Text.Trim();
            if (!sc.Contains(text))
            {
                sc.Add(text);
                comboBox.Items.Add(text);
            }
        }

        /// <summary>
        /// 判断面板表单信息是否为空
        /// </summary>
        /// <returns></returns>
        private bool CheckEmpty(Panel panel)
        {
            bool done = false;
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox)
                {
                    if (ctrl.Text.Trim() == "")
                    {
                        done = true;
                        break;//找到一个为空即返回
                    }
                }                
            }
            return done;
        }
    }
}
