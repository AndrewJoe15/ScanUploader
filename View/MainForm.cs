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
using Newtonsoft.Json.Linq;

namespace ScanUploader.View
{
    public partial class MainForm : Form
    {

        public static MainForm thisForm;

        public ConfigureForm configureForm = new ConfigureForm();

        private HttpUser httpUser;

        //BasicInfo单例
        private BasicInfo basicInfo = BasicInfo.Instance;
        private Properties.BasicInfo basicInfSetting = Properties.BasicInfo.Default;

        private static readonly int textBox_text_maxLength = 1024 * 1024;
        private static readonly int listView_maxLines = 1024;

        //列表文件目录
        private static readonly string _OK_list_file_path = Environment.CurrentDirectory + "\\表\\扫码OK\\";
        private static readonly string _NG_list_file_path = Environment.CurrentDirectory + "\\表\\扫码NG\\";
        private static readonly string _OK_list_file_path_threeCode = Environment.CurrentDirectory + "\\表\\OK插架\\";
        private static readonly string _NG_list_file_path_threeCode = Environment.CurrentDirectory + "\\表\\NG插架\\";
        private static readonly string _OK_list_file_name = "OK_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
        private static readonly string _NG_list_file_name = "NG_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";

        private static readonly string _error_list_file_path = Environment.CurrentDirectory + "\\表\\Error\\";
        private static readonly string _error_list_file_name = "Error_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";

        private static readonly string _statistics_file_path = Environment.CurrentDirectory + "\\表\\良率\\";
        private static readonly string _statistics_file_name = "良率统计_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";

        private ListView _listView_statistics = new ListView();

        public MainForm()
        {
            InitializeComponent();

            Init();

            BindData();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogUtil.WriteLog("上位机启动。");

#if !DEBUGx
            //http用户登录以更新Token
            if (UserManager.HttpLogin(httpUser))
                //启动连接计时器，每11小时重新登录一次
                ConnectManager.Instance.StartTimer_Http();
#endif

            //启动Socket服务器
            ConnectManager.Instance.StartSocketServer();

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

        /// <summary>
        /// 更新Http的登录状态
        /// </summary>
        private delegate void _UpdateHttpStatus();
        public void UpdateHttpStatus(bool LoggedIn)
        {
            _UpdateHttpStatus _uhs = new _UpdateHttpStatus(delegate ()
            {
                if (LoggedIn)
                    label_http_status_color.BackColor = Color.Green;
                else
                    label_http_status_color.BackColor = Color.Red;
            });
            Invoke(_uhs);
        }

        private delegate void _UpdateSocketStatus();
        //更新Socket连接状态信息
        public void UpdateSocketStatus(string endPoint, bool connected)
        {
            _UpdateSocketStatus _uss = new _UpdateSocketStatus(delegate ()
            {
                if (endPoint.Contains(ConnectManager.port_up.ToString()))
                {
                    if (connected)
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
                ///通道1
                if (index == 1)
                {
                    label_text_statistics_OK1.Text = Statistics.OK_1.ToString();
                    label_text_statistics_NG1.Text = Statistics.NG_1.ToString();
                    label_text_statistics_yield1.Text = Statistics.yield1;
                }
                //通道2
                if (index == 2)
                {
                    label_text_statistics_OK2.Text = Statistics.OK_2.ToString();
                    label_text_statistics_NG2.Text = Statistics.NG_2.ToString();
                    label_text_statistics_yield2.Text = Statistics.yield2;
                }
                //更新良率总计
                UpdateStatisticsTotal();

                //激活\失活按钮
                button_stastiticsData_clear.Enabled = Statistics.hasData;
                button_stastiticsData_save.Enabled = Statistics.hasData;
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

        private static void AddItem(string subItem_1, string subItem_2, string subItem_3, ListView listView)
        {
            //一行数据
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = DateTime.Now.ToString("MM-dd HH:mm:ss");//.Add() 从1开始添加，所以第0个以[0]方式访问
            item.SubItems.Add(subItem_1);
            item.SubItems.Add(subItem_2);
            item.SubItems.Add(subItem_3);

            //添加listView项
            listView.Items.Add(item);
            listView.Items[listView.Items.Count - 1].EnsureVisible();//最后一行可见
        }

        private static void AddItem_Glass(Glass glass, ListView listView)
        {
            //列表超出范围则清空 只留最后一个
            if (listView.Items.Count >= listView_maxLines)
            {
                ListViewItem tmp_last = listView.Items[listView.Items.Count - 1];
                listView.Items.Clear();
                listView.Items.Add(tmp_last);
            }

            //一行数据
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = DateTime.Now.ToString("MM-dd HH:mm:ss");//.Add() 从1开始添加，所以第0个以[0]方式访问
            item.SubItems.Add(glass.snNumber);
            item.SubItems.Add(glass.targetVehicle);
            item.SubItems.Add(glass.sourceVehicle);

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
                MaterialListManager.Instance.AppendItemToFile(listView_errorInfo, _error_list_file_path, _error_list_file_name);
            });
            Invoke(_aei);
        }

        //添加NG信息统计数据
        private delegate void _AddNGInfo();
        public void AddGlassScanInfo(string snNumber, string code, string msg, bool isOK)
        {
            _AddNGInfo _uni = new _AddNGInfo(delegate ()
            {
                if (isOK)
                {
                    AddItem(snNumber, code, msg, listView_OK_info);
                    MaterialListManager.Instance.AppendItemToFile(listView_OK_info, _OK_list_file_path, _OK_list_file_name);
                }
                else
                {
                    AddItem(snNumber, code, msg, listView_NG_info);
                    MaterialListManager.Instance.AppendItemToFile(listView_NG_info, _NG_list_file_path, _NG_list_file_name);
                }
            });
            Invoke(_uni);
        }
        public void AddGlassInfo(Glass glass, bool isOK)
        {
            _AddNGInfo _uni = new _AddNGInfo(delegate ()
            {
                if (isOK)
                {
                    //界面ListView添加一项
                    AddItem_Glass(glass, listView_OK_threeCodes);
                    //文件写入一项
                    MaterialListManager.Instance.AppendItemToFile(listView_OK_threeCodes, _OK_list_file_path_threeCode, _OK_list_file_name);
                }
                else
                {
                    AddItem_Glass(glass, listView_NG_threeCodes);
                    MaterialListManager.Instance.AppendItemToFile(listView_NG_threeCodes, _NG_list_file_path_threeCode, _NG_list_file_name);
                }
            });
            Invoke(_uni);
        }

        private void BindData_Text(Control control, object dataSource, string dataMember)
        {
            if (dataSource != null)
            {
                control.DataBindings.Add("Text", dataSource, dataMember);
            }
        }

        private void DataBind_Item(ComboBox combo, object dataSource, string dataMember)
        {
            if (dataSource != null)
            {
                combo.DataBindings.Add("SelectedItem", dataSource, dataMember);
            }
        }

        /// <summary>
        /// 将控件与数据绑定
        /// </summary>
        private void BindData()
        {
            //基本信息 数据绑定
            BindData_Text(comboBox_site, basicInfo, nameof(basicInfo.site));
            BindData_Text(comboBox_operation, basicInfo, nameof(basicInfo.operation));
            BindData_Text(comboBox_resource, basicInfo, nameof(basicInfo.resource));
            BindData_Text(comboBox_productModel, basicInfo, nameof(basicInfo.productModel));
            BindData_Text(comboBox_productModelVersion, basicInfo, nameof(basicInfo.productModelVersion));
            BindData_Text(comboBox_shift, basicInfo, nameof(basicInfo.shift));
            BindData_Text(comboBox_createBy, basicInfo, nameof(basicInfo.createBy));
            DataBind_Item(comboBox_order, basicInfo, nameof(basicInfo.order));

            //http user
            BindData_Text(textBox_http_username, httpUser, nameof(httpUser.username));
            BindData_Text(textBox_http_password, httpUser, nameof(httpUser.password));
            BindData_Text(textBox_http_site, httpUser, nameof(httpUser.site));
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

                            //向下拉列表加载数据
                            while (se.MoveNext())
                            {
                                ((ComboBox)ctrl).Items.Add(se.Current);
                            }

                            //设置文本框显示的项
                            //目前是将新的项添加到末尾，所以设置显示最后一项字符串
                            ((ComboBox)ctrl).SelectedIndex = ((ComboBox)ctrl).Items.Count - 1;

                            //给basicInfo的属性赋值 这样界面才会显示，否则又跟着basicInfo的属性为""了
                            PropertyInfo propertyInfo = basicInfo.GetType().GetProperty(p.Name);
                            if (propertyInfo != null)
                                propertyInfo.SetValue(basicInfo, ((ComboBox)ctrl).Text, null);

                            break;
                        }
                    }
                }
            }

            //设置工单号为上次保存的项，超过范围则显示最后一项
            //comboBox_order.SelectedIndex = Math.Min(Properties.SelectedIndex.Default.order, comboBox_order.Items.Count - 1);

            //保存按钮禁用
            button_save_basicInfo.Enabled = false;

            //Log 新建日志文件
            LogFile.nextSerialNumer = Properties.LogFileName.Default.nextSerialNumber;
            LogFile.logFile = new LogFile();
            //Debug 新建通讯数据日志文件
            LogFile.debugFile = new LogFile("Data", "\\Log\\Data\\");

            //良率统计 listview
            ColumnHeader[] columnHeader = new ColumnHeader[] {
                new ColumnHeader(),
                new ColumnHeader(), new ColumnHeader(), new ColumnHeader(),
                new ColumnHeader(), new ColumnHeader(), new ColumnHeader(),
                new ColumnHeader(), new ColumnHeader(), new ColumnHeader() };
            columnHeader[0].Text = "时间";
            columnHeader[1].Text = "左通道OK"; columnHeader[2].Text = "左通道NG"; columnHeader[3].Text = "左通道良率";
            columnHeader[4].Text = "右通道OK"; columnHeader[5].Text = "右通道NG"; columnHeader[6].Text = "右通道良率";
            columnHeader[7].Text = "OK总计"; columnHeader[8].Text = "NG总计"; columnHeader[9].Text = "良率总计";
            _listView_statistics.Columns.AddRange(columnHeader);

            //非化抛项目
            //选项卡隐藏
#if BDSSCAN
            tabPage_NG_threeCode.Parent = null;
            tabPage_OK_threeCode.Parent = null;

            //Socket端口状态隐藏
            label_socketPort_up.Visible = false;
            label_socketPort_down.Visible = false;
            label_socketPort_insert.Visible = false;
            label_socketPort_submit.Visible = false;

            label_socketStatus_up.Visible = false;
            label_socketStatus_down.Visible = false;
            label_socketStatus_insert.Visible = false;
            label_socketStatus_submit.Visible = false;
#endif

            httpUser = UserManager.httpUser_MES;
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
                openFile(LogFile.logFile.filePath + LogFile.logFile.fileName);
            else if (tabControl_log.SelectedTab == tabPage_debugInfo)
                openFile(LogFile.debugFile.filePath + LogFile.debugFile.fileName);
        }

        private void openFile(string file)
        {
            if (file != null)
            {
                if (!File.Exists(file))
                    ShowUtil.ShowTips("当前文件无内容。");
                else
                {
                    try
                    {
                        System.Diagnostics.Process.Start(file);
                    }
                    catch (Exception ex)
                    {
                        ShowUtil.ShowTips("打开文件失败。" + ex?.Message);
                    }
                }
            }
        }

        private void button_openLogDir_Click(object sender, EventArgs e)
        {
            if (tabControl_log.SelectedTab == tabPage_logInfo)
                System.Diagnostics.Process.Start("explorer.exe", LogFile.logFile.filePath);
            else if (tabControl_log.SelectedTab == tabPage_debugInfo)
                System.Diagnostics.Process.Start("explorer.exe", LogFile.debugFile.filePath);
        }



        private void button_empty_Click(object sender, EventArgs e)
        {
            if (tabControl_list.SelectedTab == tabPage_error_info)
            {
                listView_errorInfo.Items.Clear(); //清空error表格所有数据项
            }
            else if (tabControl_list.SelectedTab == tabPage_NG_threeCode)
            {
                listView_NG_threeCodes.Items.Clear(); //清空NG表格所有数据项
            }
        }

        private void button_export_excel_Click(object sender, EventArgs e)
        {
            if (tabControl_list.SelectedTab == tabPage_error_info)
            {
                FileUtil.ExportExcel("Error信息统计", listView_errorInfo);
            }
            else if (tabControl_list.SelectedTab == tabPage_NG_threeCode)
            {
                FileUtil.ExportExcel("NG三码信息统计", listView_NG_threeCodes);
            }
            else if (tabControl_list.SelectedTab == tabPage_OK_threeCode)
            {
                FileUtil.ExportExcel("OK三码信息统计", listView_OK_threeCodes);
            }
            else if (tabControl_list.SelectedTab == tabPage_OK_info)
            {
                FileUtil.ExportExcel("OK信息统计", listView_OK_info);
            }
            else if (tabControl_list.SelectedTab == tabPage_NG_info)
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

            if (sc.Count == 0)
                sc.Add(text);
            else if (!sc.Contains(text))
                sc[0] = text;

            if (!comboBox.Items.Contains(text))
                comboBox.Items.Add(text);
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

        private void button_http_login_Click(object sender, EventArgs e)
        {
            //登录MES
            if (UserManager.HttpLogin(httpUser))
            {
                //登录成功 保存用户名密码
                Properties.User_Http user_http = Properties.User_Http.Default;
                user_http.username_MES_hp = textBox_http_username.Text;
                user_http.password_MES_hp = textBox_http_password.Text;
                user_http.site_MES = textBox_http_site.Text;

                user_http.Save();
            }

        }

        private void ComboBox_Order_DropDown(object sender, EventArgs e)
        {
            GetMesMoList();
        }

        private void GetMesMoList()
        {
            //将鼠标指针设置为等待状态
            Cursor = Cursors.WaitCursor;

            //构建请求数据
            JObject postData = new JObject();
            postData.Add("site", basicInfo.site);
            postData.Add("operation", basicInfo.operation);
            postData.Add("productModel", basicInfo.productModel);
            postData.Add("moDate", DateTime.Now.ToString("yyyy-MM-dd"));

            //发送Http请求获取数据
            JObject result = HttpUtil.PostResponse(URL.Instance.getMesMoList, postData.ToString());

            //获取工单列表成功
            if (result?["code"]?.ToString() == ReturnData.code_success)
            {
                //获取JSon数据中的mo列表
                var jMos = result?["data"]?["moList"]?.Values("mo");

                //与当前列表比较
                if (!CompareComboBoxItems(jMos, comboBox_order.Items))
                {
                    //工单列表存入下拉列表中
                    comboBox_order.Items.Clear();
                    foreach (var item in jMos)
                    {
                        comboBox_order.Items.Add(item.ToString());
                    }
                    comboBox_order.SelectedIndex = 0;
                }

            }
            else
            {
                //获取工单失败
                ShowUtil.ShowError("获取工单失败，" + result?["msg"]);
            }

            Cursor = Cursors.Default;

        }

        /// <summary>
        /// 比较当前下拉列表和MES端获取的列表
        /// </summary>
        /// <param name="jMos">MES端获取的列表</param>
        /// <param name="items">当前下拉列表</param>
        /// <returns>true：相同 false：不同</returns>
        private bool CompareComboBoxItems(IJEnumerable<JToken> jList, ComboBox.ObjectCollection items)
        {
            if (items.Count != jList.Count())
            {
                return false;
            }
            foreach (var item in jList)
            {
                if (!items.Contains(item.ToString()))
                    return false;
            }

            return true;
        }

        private void ComboBox_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_save_basicInfo.Enabled = true;
        }

        private void button_openCsvFile_Click(object sender, EventArgs e)
        {
            if (tabControl_list.SelectedTab == tabPage_OK_threeCode)
                openFile(_OK_list_file_path_threeCode + _OK_list_file_name);
            else if (tabControl_list.SelectedTab == tabPage_NG_threeCode)
                openFile(_NG_list_file_path_threeCode + _NG_list_file_name);
            else if (tabControl_list.SelectedTab == tabPage_OK_info)
                openFile(_OK_list_file_path + _OK_list_file_name);
            else if (tabControl_list.SelectedTab == tabPage_NG_info)
                openFile(_NG_list_file_path + _NG_list_file_name);
            else if (tabControl_list.SelectedTab == tabPage_error_info)
                openFile(_error_list_file_path + _error_list_file_name);
        }

        private void button_openCsvDir_Click(object sender, EventArgs e)
        {
            if (tabControl_list.SelectedTab == tabPage_OK_threeCode)
                System.Diagnostics.Process.Start("explorer.exe", _OK_list_file_path_threeCode);
            else if (tabControl_list.SelectedTab == tabPage_NG_threeCode)
                System.Diagnostics.Process.Start("explorer.exe", _NG_list_file_path_threeCode);
            else if (tabControl_list.SelectedTab == tabPage_OK_info)
                System.Diagnostics.Process.Start("explorer.exe", _OK_list_file_path);
            else if (tabControl_list.SelectedTab == tabPage_NG_info)
                System.Diagnostics.Process.Start("explorer.exe", _NG_list_file_path);
            else if (tabControl_list.SelectedTab == tabPage_error_info)
                System.Diagnostics.Process.Start("explorer.exe", _error_list_file_path);
        }

        private void button_stastiticsData_clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清空良率统计数据吗？", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Statistics.ClearData();
                UpdateStatistics(1);
                UpdateStatistics(2);
            }
        }

        private void button_stastiticsData_save_Click(object sender, EventArgs e)
        {
            //添加一条记录
            ListViewItem item = new ListViewItem(new[] {
                TimeUtil.currentTimeString,
                Statistics.OK_1.ToString(), Statistics.NG_1.ToString(), Statistics.yield1,
                Statistics.OK_2.ToString(), Statistics.NG_2.ToString(), Statistics.yield2,
                Statistics.OK_total.ToString(), Statistics.NG_total.ToString(), Statistics.yield_total});
            _listView_statistics.Items.Add(item);

            //写入文件
            FileUtil.AppendLastItemToExcel(_listView_statistics, _statistics_file_path, _statistics_file_name);

            openFile(_statistics_file_path + _statistics_file_name);
        }

        private void ToolStripMenuItem_Config_Click(object sender, EventArgs e)
        {
            LoginForm_Admin loginForm = new LoginForm_Admin();
            loginForm.ShowDialog();
        }
    }
}