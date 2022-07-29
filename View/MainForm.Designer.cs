namespace ScanUploader.View
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip_top = new System.Windows.Forms.MenuStrip();
            this.menuStrip_top_config = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_top_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_productModel = new System.Windows.Forms.ComboBox();
            this.label_productModelVersion = new System.Windows.Forms.Label();
            this.label_productModel = new System.Windows.Forms.Label();
            this.comboBox_productModelVersion = new System.Windows.Forms.ComboBox();
            this.comboBox_resource = new System.Windows.Forms.ComboBox();
            this.label_shift = new System.Windows.Forms.Label();
            this.label_resource = new System.Windows.Forms.Label();
            this.comboBox_operation = new System.Windows.Forms.ComboBox();
            this.label_createBy = new System.Windows.Forms.Label();
            this.label_operation = new System.Windows.Forms.Label();
            this.comboBox_createBy = new System.Windows.Forms.ComboBox();
            this.comboBox_site = new System.Windows.Forms.ComboBox();
            this.label_site = new System.Windows.Forms.Label();
            this.comboBox_shift = new System.Windows.Forms.ComboBox();
            this.panel_basicInformation = new System.Windows.Forms.Panel();
            this.button_save_basicInfo = new System.Windows.Forms.Button();
            this.comboBox_order = new System.Windows.Forms.ComboBox();
            this.label_mo = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.panel_log = new System.Windows.Forms.Panel();
            this.button_openLogDir = new System.Windows.Forms.Button();
            this.tabControl_log = new System.Windows.Forms.TabControl();
            this.tabPage_logInfo = new System.Windows.Forms.TabPage();
            this.tabPage_debugInfo = new System.Windows.Forms.TabPage();
            this.textBox_debug = new System.Windows.Forms.TextBox();
            this.button_openLogFile = new System.Windows.Forms.Button();
            this.panel_connectStatus = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_text_statistics_yield_total = new System.Windows.Forms.Label();
            this.label_text_statistics_NG_total = new System.Windows.Forms.Label();
            this.label_text_statistics_OK_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_text_statistics_yield2 = new System.Windows.Forms.Label();
            this.label_text_statistics_NG2 = new System.Windows.Forms.Label();
            this.label_text_statistics_OK2 = new System.Windows.Forms.Label();
            this.label_text_statistics_yield1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_text_statistics_NG1 = new System.Windows.Forms.Label();
            this.label_connectStatus_PLC = new System.Windows.Forms.Label();
            this.label_text_statistics_OK1 = new System.Windows.Forms.Label();
            this.label_connectStatus_MES = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.label_timer_main = new System.Windows.Forms.Label();
            this.panel_NG_info = new System.Windows.Forms.Panel();
            this.button_empty = new System.Windows.Forms.Button();
            this.button_export_excel = new System.Windows.Forms.Button();
            this.tabControl_error_info = new System.Windows.Forms.TabControl();
            this.tabPage_NG_info = new System.Windows.Forms.TabPage();
            this.listView_NG = new System.Windows.Forms.ListView();
            this.columnHeader_time_NG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_snNumber_NG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_targetVehicle_NG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_sourceVehicle_NG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_error_info = new System.Windows.Forms.TabPage();
            this.listView_errorInfo = new System.Windows.Forms.ListView();
            this.columnHeader_errorTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_errorCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_errorMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_socket = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_socket = new System.Windows.Forms.TabPage();
            this.label_socketPort_submit = new System.Windows.Forms.Label();
            this.label_socket_port = new System.Windows.Forms.Label();
            this.label_socketStatus_submit = new System.Windows.Forms.Label();
            this.label_socketPort_main = new System.Windows.Forms.Label();
            this.label_socketStatus_main = new System.Windows.Forms.Label();
            this.label_socketPort_insert = new System.Windows.Forms.Label();
            this.label_socketStatus_down = new System.Windows.Forms.Label();
            this.label_socket_status = new System.Windows.Forms.Label();
            this.label_socketPort_up = new System.Windows.Forms.Label();
            this.label_socketStatus_insert = new System.Windows.Forms.Label();
            this.label_socketPort_down = new System.Windows.Forms.Label();
            this.label_socketStatus_up = new System.Windows.Forms.Label();
            this.tabPage_http = new System.Windows.Forms.TabPage();
            this.textBox_http_site = new System.Windows.Forms.TextBox();
            this.label_http_site = new System.Windows.Forms.Label();
            this.textBox_http_password = new System.Windows.Forms.TextBox();
            this.textBox_http_username = new System.Windows.Forms.TextBox();
            this.label_http_username = new System.Windows.Forms.Label();
            this.label_http_password = new System.Windows.Forms.Label();
            this.button_http_login = new System.Windows.Forms.Button();
            this.label_http_status = new System.Windows.Forms.Label();
            this.label_http_status_color = new System.Windows.Forms.Label();
            this.tabPage_OK_info = new System.Windows.Forms.TabPage();
            this.listView_OK = new System.Windows.Forms.ListView();
            this.columnHeader_time_OK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_snNumber_OK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_targetVehicle_OK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_sourceVehicle_OK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_NG_info_BDS = new System.Windows.Forms.TabPage();
            this.listView_NG_BDS = new System.Windows.Forms.ListView();
            this.columnHeader_time_BDS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_snNumber_BDS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_NG_info_BDS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.basicInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip_top.SuspendLayout();
            this.panel_basicInformation.SuspendLayout();
            this.panel_log.SuspendLayout();
            this.tabControl_log.SuspendLayout();
            this.tabPage_logInfo.SuspendLayout();
            this.tabPage_debugInfo.SuspendLayout();
            this.panel_connectStatus.SuspendLayout();
            this.panel_NG_info.SuspendLayout();
            this.tabControl_error_info.SuspendLayout();
            this.tabPage_NG_info.SuspendLayout();
            this.tabPage_error_info.SuspendLayout();
            this.panel_socket.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_socket.SuspendLayout();
            this.tabPage_http.SuspendLayout();
            this.tabPage_OK_info.SuspendLayout();
            this.tabPage_NG_info_BDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basicInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_top
            // 
            this.menuStrip_top.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip_top.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_top_config,
            this.menuStrip_top_restart});
            this.menuStrip_top.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_top.Name = "menuStrip_top";
            this.menuStrip_top.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip_top.Size = new System.Drawing.Size(1008, 30);
            this.menuStrip_top.TabIndex = 17;
            this.menuStrip_top.Text = "menuStrip1";
            // 
            // menuStrip_top_config
            // 
            this.menuStrip_top_config.Name = "menuStrip_top_config";
            this.menuStrip_top_config.Size = new System.Drawing.Size(53, 24);
            this.menuStrip_top_config.Text = "配置";
            this.menuStrip_top_config.Click += new System.EventHandler(this.menuStrip_top_Config_Click);
            // 
            // menuStrip_top_restart
            // 
            this.menuStrip_top_restart.Name = "menuStrip_top_restart";
            this.menuStrip_top_restart.Size = new System.Drawing.Size(53, 24);
            this.menuStrip_top_restart.Text = "重启";
            // 
            // comboBox_productModel
            // 
            this.comboBox_productModel.Location = new System.Drawing.Point(94, 101);
            this.comboBox_productModel.Name = "comboBox_productModel";
            this.comboBox_productModel.Size = new System.Drawing.Size(101, 23);
            this.comboBox_productModel.TabIndex = 7;
            this.comboBox_productModel.TextChanged += new System.EventHandler(this.OnComboBoxTextUpdate);
            // 
            // label_productModelVersion
            // 
            this.label_productModelVersion.AutoSize = true;
            this.label_productModelVersion.Location = new System.Drawing.Point(15, 137);
            this.label_productModelVersion.Name = "label_productModelVersion";
            this.label_productModelVersion.Size = new System.Drawing.Size(82, 15);
            this.label_productModelVersion.TabIndex = 8;
            this.label_productModelVersion.Text = "型号版本：";
            // 
            // label_productModel
            // 
            this.label_productModel.AutoSize = true;
            this.label_productModel.Location = new System.Drawing.Point(15, 107);
            this.label_productModel.Name = "label_productModel";
            this.label_productModel.Size = new System.Drawing.Size(82, 15);
            this.label_productModel.TabIndex = 6;
            this.label_productModel.Text = "产品型号：";
            // 
            // comboBox_productModelVersion
            // 
            this.comboBox_productModelVersion.Location = new System.Drawing.Point(94, 131);
            this.comboBox_productModelVersion.Name = "comboBox_productModelVersion";
            this.comboBox_productModelVersion.Size = new System.Drawing.Size(101, 23);
            this.comboBox_productModelVersion.TabIndex = 9;
            this.comboBox_productModelVersion.TextChanged += new System.EventHandler(this.OnComboBoxTextUpdate);
            // 
            // comboBox_resource
            // 
            this.comboBox_resource.Location = new System.Drawing.Point(94, 71);
            this.comboBox_resource.Name = "comboBox_resource";
            this.comboBox_resource.Size = new System.Drawing.Size(101, 23);
            this.comboBox_resource.TabIndex = 5;
            this.comboBox_resource.TextChanged += new System.EventHandler(this.OnComboBoxTextUpdate);
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.Location = new System.Drawing.Point(15, 165);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(52, 15);
            this.label_shift.TabIndex = 10;
            this.label_shift.Text = "班次：";
            // 
            // label_resource
            // 
            this.label_resource.AutoSize = true;
            this.label_resource.Location = new System.Drawing.Point(15, 77);
            this.label_resource.Name = "label_resource";
            this.label_resource.Size = new System.Drawing.Size(67, 15);
            this.label_resource.TabIndex = 4;
            this.label_resource.Text = "设备号：";
            // 
            // comboBox_operation
            // 
            this.comboBox_operation.Location = new System.Drawing.Point(94, 41);
            this.comboBox_operation.Name = "comboBox_operation";
            this.comboBox_operation.Size = new System.Drawing.Size(101, 23);
            this.comboBox_operation.TabIndex = 3;
            this.comboBox_operation.TextChanged += new System.EventHandler(this.OnComboBoxTextUpdate);
            // 
            // label_createBy
            // 
            this.label_createBy.AutoSize = true;
            this.label_createBy.Location = new System.Drawing.Point(15, 196);
            this.label_createBy.Name = "label_createBy";
            this.label_createBy.Size = new System.Drawing.Size(67, 15);
            this.label_createBy.TabIndex = 12;
            this.label_createBy.Text = "操作人：";
            // 
            // label_operation
            // 
            this.label_operation.AutoSize = true;
            this.label_operation.Location = new System.Drawing.Point(15, 48);
            this.label_operation.Name = "label_operation";
            this.label_operation.Size = new System.Drawing.Size(52, 15);
            this.label_operation.TabIndex = 2;
            this.label_operation.Text = "工序：";
            // 
            // comboBox_createBy
            // 
            this.comboBox_createBy.Location = new System.Drawing.Point(94, 189);
            this.comboBox_createBy.Name = "comboBox_createBy";
            this.comboBox_createBy.Size = new System.Drawing.Size(101, 23);
            this.comboBox_createBy.TabIndex = 13;
            this.comboBox_createBy.TextChanged += new System.EventHandler(this.OnComboBoxTextUpdate);
            // 
            // comboBox_site
            // 
            this.comboBox_site.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.basicInfoBindingSource, "site", true));
            this.comboBox_site.Location = new System.Drawing.Point(94, 11);
            this.comboBox_site.Name = "comboBox_site";
            this.comboBox_site.Size = new System.Drawing.Size(101, 23);
            this.comboBox_site.TabIndex = 1;
            this.comboBox_site.TextChanged += new System.EventHandler(this.OnComboBoxTextUpdate);
            // 
            // label_site
            // 
            this.label_site.AutoSize = true;
            this.label_site.Location = new System.Drawing.Point(15, 17);
            this.label_site.Name = "label_site";
            this.label_site.Size = new System.Drawing.Size(82, 15);
            this.label_site.TabIndex = 0;
            this.label_site.Text = "工厂编号：";
            // 
            // comboBox_shift
            // 
            this.comboBox_shift.FormattingEnabled = true;
            this.comboBox_shift.Location = new System.Drawing.Point(94, 161);
            this.comboBox_shift.Name = "comboBox_shift";
            this.comboBox_shift.Size = new System.Drawing.Size(101, 23);
            this.comboBox_shift.TabIndex = 19;
            this.comboBox_shift.TextChanged += new System.EventHandler(this.OnComboBoxTextUpdate);
            // 
            // panel_basicInformation
            // 
            this.panel_basicInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_basicInformation.Controls.Add(this.button_save_basicInfo);
            this.panel_basicInformation.Controls.Add(this.label_site);
            this.panel_basicInformation.Controls.Add(this.comboBox_shift);
            this.panel_basicInformation.Controls.Add(this.comboBox_productModel);
            this.panel_basicInformation.Controls.Add(this.comboBox_order);
            this.panel_basicInformation.Controls.Add(this.label_productModel);
            this.panel_basicInformation.Controls.Add(this.label_mo);
            this.panel_basicInformation.Controls.Add(this.comboBox_resource);
            this.panel_basicInformation.Controls.Add(this.comboBox_productModelVersion);
            this.panel_basicInformation.Controls.Add(this.label_createBy);
            this.panel_basicInformation.Controls.Add(this.comboBox_site);
            this.panel_basicInformation.Controls.Add(this.comboBox_createBy);
            this.panel_basicInformation.Controls.Add(this.label_shift);
            this.panel_basicInformation.Controls.Add(this.comboBox_operation);
            this.panel_basicInformation.Controls.Add(this.label_productModelVersion);
            this.panel_basicInformation.Controls.Add(this.label_operation);
            this.panel_basicInformation.Controls.Add(this.label_resource);
            this.panel_basicInformation.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_basicInformation.Location = new System.Drawing.Point(9, 31);
            this.panel_basicInformation.Name = "panel_basicInformation";
            this.panel_basicInformation.Size = new System.Drawing.Size(209, 292);
            this.panel_basicInformation.TabIndex = 16;
            // 
            // button_save_basicInfo
            // 
            this.button_save_basicInfo.Enabled = false;
            this.button_save_basicInfo.Location = new System.Drawing.Point(73, 253);
            this.button_save_basicInfo.Name = "button_save_basicInfo";
            this.button_save_basicInfo.Size = new System.Drawing.Size(56, 32);
            this.button_save_basicInfo.TabIndex = 36;
            this.button_save_basicInfo.Text = "保存";
            this.button_save_basicInfo.UseVisualStyleBackColor = true;
            this.button_save_basicInfo.Click += new System.EventHandler(this.Button_save_basicInfo_Click);
            // 
            // comboBox_order
            // 
            this.comboBox_order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_order.Location = new System.Drawing.Point(94, 223);
            this.comboBox_order.Name = "comboBox_order";
            this.comboBox_order.Size = new System.Drawing.Size(101, 23);
            this.comboBox_order.TabIndex = 22;
            this.comboBox_order.DropDown += new System.EventHandler(this.Combobox_Oder_DropDown);
            this.comboBox_order.SelectedIndexChanged += new System.EventHandler(this.comboBox_order_SelectedIndexChanged);
            this.comboBox_order.TextChanged += new System.EventHandler(this.OnComboBoxTextUpdate);
            // 
            // label_mo
            // 
            this.label_mo.AutoSize = true;
            this.label_mo.Location = new System.Drawing.Point(17, 229);
            this.label_mo.Name = "label_mo";
            this.label_mo.Size = new System.Drawing.Size(67, 15);
            this.label_mo.TabIndex = 21;
            this.label_mo.Text = "工单号：";
            // 
            // textBox_log
            // 
            this.textBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_log.Location = new System.Drawing.Point(0, 3);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(675, 308);
            this.textBox_log.TabIndex = 19;
            // 
            // panel_log
            // 
            this.panel_log.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_log.Controls.Add(this.button_openLogDir);
            this.panel_log.Controls.Add(this.tabControl_log);
            this.panel_log.Controls.Add(this.button_openLogFile);
            this.panel_log.Location = new System.Drawing.Point(224, 31);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(772, 338);
            this.panel_log.TabIndex = 27;
            // 
            // button_openLogDir
            // 
            this.button_openLogDir.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_openLogDir.Location = new System.Drawing.Point(694, 196);
            this.button_openLogDir.Name = "button_openLogDir";
            this.button_openLogDir.Size = new System.Drawing.Size(59, 32);
            this.button_openLogDir.TabIndex = 35;
            this.button_openLogDir.Text = "目录";
            this.button_openLogDir.UseVisualStyleBackColor = true;
            this.button_openLogDir.Click += new System.EventHandler(this.button_openLogDir_Click);
            // 
            // tabControl_log
            // 
            this.tabControl_log.Controls.Add(this.tabPage_logInfo);
            this.tabControl_log.Controls.Add(this.tabPage_debugInfo);
            this.tabControl_log.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl_log.Location = new System.Drawing.Point(-2, -2);
            this.tabControl_log.Name = "tabControl_log";
            this.tabControl_log.SelectedIndex = 0;
            this.tabControl_log.Size = new System.Drawing.Size(686, 338);
            this.tabControl_log.TabIndex = 20;
            // 
            // tabPage_logInfo
            // 
            this.tabPage_logInfo.Controls.Add(this.textBox_log);
            this.tabPage_logInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPage_logInfo.Name = "tabPage_logInfo";
            this.tabPage_logInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_logInfo.Size = new System.Drawing.Size(678, 309);
            this.tabPage_logInfo.TabIndex = 0;
            this.tabPage_logInfo.Text = "日志";
            this.tabPage_logInfo.UseVisualStyleBackColor = true;
            // 
            // tabPage_debugInfo
            // 
            this.tabPage_debugInfo.Controls.Add(this.textBox_debug);
            this.tabPage_debugInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPage_debugInfo.Name = "tabPage_debugInfo";
            this.tabPage_debugInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_debugInfo.Size = new System.Drawing.Size(678, 309);
            this.tabPage_debugInfo.TabIndex = 1;
            this.tabPage_debugInfo.Text = "通信数据";
            this.tabPage_debugInfo.UseVisualStyleBackColor = true;
            // 
            // textBox_debug
            // 
            this.textBox_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_debug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_debug.Location = new System.Drawing.Point(1, 3);
            this.textBox_debug.Multiline = true;
            this.textBox_debug.Name = "textBox_debug";
            this.textBox_debug.ReadOnly = true;
            this.textBox_debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_debug.Size = new System.Drawing.Size(674, 306);
            this.textBox_debug.TabIndex = 33;
            // 
            // button_openLogFile
            // 
            this.button_openLogFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_openLogFile.Location = new System.Drawing.Point(694, 107);
            this.button_openLogFile.Name = "button_openLogFile";
            this.button_openLogFile.Size = new System.Drawing.Size(59, 32);
            this.button_openLogFile.TabIndex = 34;
            this.button_openLogFile.Text = "打开";
            this.button_openLogFile.UseVisualStyleBackColor = true;
            this.button_openLogFile.Click += new System.EventHandler(this.button_openLogFile_Click);
            // 
            // panel_connectStatus
            // 
            this.panel_connectStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_connectStatus.Controls.Add(this.label16);
            this.panel_connectStatus.Controls.Add(this.label17);
            this.panel_connectStatus.Controls.Add(this.label18);
            this.panel_connectStatus.Controls.Add(this.label15);
            this.panel_connectStatus.Controls.Add(this.label11);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_yield_total);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_NG_total);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_OK_total);
            this.panel_connectStatus.Controls.Add(this.label10);
            this.panel_connectStatus.Controls.Add(this.label9);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_yield2);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_NG2);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_OK2);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_yield1);
            this.panel_connectStatus.Controls.Add(this.label4);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_NG1);
            this.panel_connectStatus.Controls.Add(this.label_connectStatus_PLC);
            this.panel_connectStatus.Controls.Add(this.label_text_statistics_OK1);
            this.panel_connectStatus.Controls.Add(this.label_connectStatus_MES);
            this.panel_connectStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_connectStatus.Location = new System.Drawing.Point(9, 545);
            this.panel_connectStatus.Name = "panel_connectStatus";
            this.panel_connectStatus.Size = new System.Drawing.Size(209, 114);
            this.panel_connectStatus.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(15, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 51;
            this.label16.Text = "合计";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(7, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 50;
            this.label17.Text = "右通道";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(7, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 49;
            this.label18.Text = "左通道";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(13, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 48;
            this.label15.Text = "位置";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(187, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 15);
            this.label11.TabIndex = 47;
            this.label11.Text = "%";
            // 
            // label_text_statistics_yield_total
            // 
            this.label_text_statistics_yield_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_yield_total.AutoSize = true;
            this.label_text_statistics_yield_total.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_yield_total.Location = new System.Drawing.Point(145, 86);
            this.label_text_statistics_yield_total.Name = "label_text_statistics_yield_total";
            this.label_text_statistics_yield_total.Size = new System.Drawing.Size(47, 15);
            this.label_text_statistics_yield_total.TabIndex = 46;
            this.label_text_statistics_yield_total.Text = "00.00";
            this.label_text_statistics_yield_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_text_statistics_NG_total
            // 
            this.label_text_statistics_NG_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_NG_total.AutoSize = true;
            this.label_text_statistics_NG_total.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_NG_total.Location = new System.Drawing.Point(103, 86);
            this.label_text_statistics_NG_total.Name = "label_text_statistics_NG_total";
            this.label_text_statistics_NG_total.Size = new System.Drawing.Size(23, 15);
            this.label_text_statistics_NG_total.TabIndex = 45;
            this.label_text_statistics_NG_total.Text = "00";
            this.label_text_statistics_NG_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_text_statistics_OK_total
            // 
            this.label_text_statistics_OK_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_OK_total.AutoSize = true;
            this.label_text_statistics_OK_total.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_OK_total.Location = new System.Drawing.Point(65, 86);
            this.label_text_statistics_OK_total.Name = "label_text_statistics_OK_total";
            this.label_text_statistics_OK_total.Size = new System.Drawing.Size(23, 15);
            this.label_text_statistics_OK_total.TabIndex = 44;
            this.label_text_statistics_OK_total.Text = "00";
            this.label_text_statistics_OK_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(187, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(187, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "%";
            // 
            // label_text_statistics_yield2
            // 
            this.label_text_statistics_yield2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_yield2.AutoSize = true;
            this.label_text_statistics_yield2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_yield2.Location = new System.Drawing.Point(145, 63);
            this.label_text_statistics_yield2.Name = "label_text_statistics_yield2";
            this.label_text_statistics_yield2.Size = new System.Drawing.Size(47, 15);
            this.label_text_statistics_yield2.TabIndex = 41;
            this.label_text_statistics_yield2.Text = "00.00";
            this.label_text_statistics_yield2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_text_statistics_NG2
            // 
            this.label_text_statistics_NG2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_NG2.AutoSize = true;
            this.label_text_statistics_NG2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_NG2.Location = new System.Drawing.Point(103, 63);
            this.label_text_statistics_NG2.Name = "label_text_statistics_NG2";
            this.label_text_statistics_NG2.Size = new System.Drawing.Size(23, 15);
            this.label_text_statistics_NG2.TabIndex = 40;
            this.label_text_statistics_NG2.Text = "00";
            this.label_text_statistics_NG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_text_statistics_OK2
            // 
            this.label_text_statistics_OK2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_OK2.AutoSize = true;
            this.label_text_statistics_OK2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_OK2.Location = new System.Drawing.Point(65, 63);
            this.label_text_statistics_OK2.Name = "label_text_statistics_OK2";
            this.label_text_statistics_OK2.Size = new System.Drawing.Size(23, 15);
            this.label_text_statistics_OK2.TabIndex = 39;
            this.label_text_statistics_OK2.Text = "00";
            this.label_text_statistics_OK2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_text_statistics_yield1
            // 
            this.label_text_statistics_yield1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_yield1.AutoSize = true;
            this.label_text_statistics_yield1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_yield1.Location = new System.Drawing.Point(145, 37);
            this.label_text_statistics_yield1.Name = "label_text_statistics_yield1";
            this.label_text_statistics_yield1.Size = new System.Drawing.Size(47, 15);
            this.label_text_statistics_yield1.TabIndex = 38;
            this.label_text_statistics_yield1.Text = "00.00";
            this.label_text_statistics_yield1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(152, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "良率";
            // 
            // label_text_statistics_NG1
            // 
            this.label_text_statistics_NG1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_NG1.AutoSize = true;
            this.label_text_statistics_NG1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_NG1.Location = new System.Drawing.Point(103, 37);
            this.label_text_statistics_NG1.Name = "label_text_statistics_NG1";
            this.label_text_statistics_NG1.Size = new System.Drawing.Size(23, 15);
            this.label_text_statistics_NG1.TabIndex = 36;
            this.label_text_statistics_NG1.Text = "00";
            this.label_text_statistics_NG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_connectStatus_PLC
            // 
            this.label_connectStatus_PLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_connectStatus_PLC.AutoSize = true;
            this.label_connectStatus_PLC.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_connectStatus_PLC.Location = new System.Drawing.Point(102, 13);
            this.label_connectStatus_PLC.Name = "label_connectStatus_PLC";
            this.label_connectStatus_PLC.Size = new System.Drawing.Size(25, 15);
            this.label_connectStatus_PLC.TabIndex = 35;
            this.label_connectStatus_PLC.Text = "NG";
            // 
            // label_text_statistics_OK1
            // 
            this.label_text_statistics_OK1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_OK1.AutoSize = true;
            this.label_text_statistics_OK1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_OK1.Location = new System.Drawing.Point(65, 37);
            this.label_text_statistics_OK1.Name = "label_text_statistics_OK1";
            this.label_text_statistics_OK1.Size = new System.Drawing.Size(23, 15);
            this.label_text_statistics_OK1.TabIndex = 34;
            this.label_text_statistics_OK1.Text = "00";
            this.label_text_statistics_OK1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_connectStatus_MES
            // 
            this.label_connectStatus_MES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_connectStatus_MES.AutoSize = true;
            this.label_connectStatus_MES.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_connectStatus_MES.Location = new System.Drawing.Point(64, 13);
            this.label_connectStatus_MES.Name = "label_connectStatus_MES";
            this.label_connectStatus_MES.Size = new System.Drawing.Size(25, 15);
            this.label_connectStatus_MES.TabIndex = 33;
            this.label_connectStatus_MES.Text = "OK";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(397, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "当前时间：";
            // 
            // timer_main
            // 
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // label_timer_main
            // 
            this.label_timer_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_timer_main.AutoSize = true;
            this.label_timer_main.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_timer_main.Location = new System.Drawing.Point(474, 671);
            this.label_timer_main.Name = "label_timer_main";
            this.label_timer_main.Size = new System.Drawing.Size(159, 15);
            this.label_timer_main.TabIndex = 32;
            this.label_timer_main.Text = "2012-06-26 00:00:00";
            // 
            // panel_NG_info
            // 
            this.panel_NG_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_NG_info.Controls.Add(this.button_empty);
            this.panel_NG_info.Controls.Add(this.button_export_excel);
            this.panel_NG_info.Controls.Add(this.tabControl_error_info);
            this.panel_NG_info.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_NG_info.Location = new System.Drawing.Point(224, 375);
            this.panel_NG_info.Name = "panel_NG_info";
            this.panel_NG_info.Size = new System.Drawing.Size(772, 284);
            this.panel_NG_info.TabIndex = 29;
            // 
            // button_empty
            // 
            this.button_empty.Location = new System.Drawing.Point(694, 166);
            this.button_empty.Name = "button_empty";
            this.button_empty.Size = new System.Drawing.Size(59, 32);
            this.button_empty.TabIndex = 2;
            this.button_empty.Text = "清空";
            this.button_empty.UseVisualStyleBackColor = true;
            this.button_empty.Click += new System.EventHandler(this.button_empty_Click);
            // 
            // button_export_excel
            // 
            this.button_export_excel.Location = new System.Drawing.Point(694, 98);
            this.button_export_excel.Name = "button_export_excel";
            this.button_export_excel.Size = new System.Drawing.Size(59, 32);
            this.button_export_excel.TabIndex = 1;
            this.button_export_excel.Text = "导出";
            this.button_export_excel.UseVisualStyleBackColor = true;
            this.button_export_excel.Click += new System.EventHandler(this.button_export_excel_Click);
            // 
            // tabControl_error_info
            // 
            this.tabControl_error_info.Controls.Add(this.tabPage_OK_info);
            this.tabControl_error_info.Controls.Add(this.tabPage_NG_info);
            this.tabControl_error_info.Controls.Add(this.tabPage_NG_info_BDS);
            this.tabControl_error_info.Controls.Add(this.tabPage_error_info);
            this.tabControl_error_info.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl_error_info.Location = new System.Drawing.Point(3, -2);
            this.tabControl_error_info.Name = "tabControl_error_info";
            this.tabControl_error_info.SelectedIndex = 0;
            this.tabControl_error_info.Size = new System.Drawing.Size(681, 284);
            this.tabControl_error_info.TabIndex = 33;
            // 
            // tabPage_NG_info
            // 
            this.tabPage_NG_info.Controls.Add(this.listView_NG);
            this.tabPage_NG_info.Location = new System.Drawing.Point(4, 25);
            this.tabPage_NG_info.Name = "tabPage_NG_info";
            this.tabPage_NG_info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NG_info.Size = new System.Drawing.Size(673, 255);
            this.tabPage_NG_info.TabIndex = 1;
            this.tabPage_NG_info.Text = "NG列表";
            this.tabPage_NG_info.UseVisualStyleBackColor = true;
            // 
            // listView_NG
            // 
            this.listView_NG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_time_NG,
            this.columnHeader_snNumber_NG,
            this.columnHeader_targetVehicle_NG,
            this.columnHeader_sourceVehicle_NG});
            this.listView_NG.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_NG.GridLines = true;
            this.listView_NG.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_NG.HideSelection = false;
            this.listView_NG.Location = new System.Drawing.Point(0, 0);
            this.listView_NG.Name = "listView_NG";
            this.listView_NG.Size = new System.Drawing.Size(673, 251);
            this.listView_NG.TabIndex = 0;
            this.listView_NG.UseCompatibleStateImageBehavior = false;
            this.listView_NG.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_time_NG
            // 
            this.columnHeader_time_NG.Text = "时间";
            this.columnHeader_time_NG.Width = 82;
            // 
            // columnHeader_snNumber_NG
            // 
            this.columnHeader_snNumber_NG.Text = "玻璃码";
            this.columnHeader_snNumber_NG.Width = 186;
            // 
            // columnHeader_targetVehicle_NG
            // 
            this.columnHeader_targetVehicle_NG.Text = "清洗架码";
            this.columnHeader_targetVehicle_NG.Width = 174;
            // 
            // columnHeader_sourceVehicle_NG
            // 
            this.columnHeader_sourceVehicle_NG.Text = "化抛架码";
            this.columnHeader_sourceVehicle_NG.Width = 224;
            // 
            // tabPage_error_info
            // 
            this.tabPage_error_info.Controls.Add(this.listView_errorInfo);
            this.tabPage_error_info.Location = new System.Drawing.Point(4, 25);
            this.tabPage_error_info.Name = "tabPage_error_info";
            this.tabPage_error_info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_error_info.Size = new System.Drawing.Size(673, 255);
            this.tabPage_error_info.TabIndex = 0;
            this.tabPage_error_info.Text = "错误信息";
            this.tabPage_error_info.UseVisualStyleBackColor = true;
            // 
            // listView_errorInfo
            // 
            this.listView_errorInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_errorTime,
            this.columnHeader_errorCode,
            this.columnHeader_errorMsg});
            this.listView_errorInfo.GridLines = true;
            this.listView_errorInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_errorInfo.HideSelection = false;
            this.listView_errorInfo.Location = new System.Drawing.Point(0, 0);
            this.listView_errorInfo.Name = "listView_errorInfo";
            this.listView_errorInfo.Size = new System.Drawing.Size(673, 257);
            this.listView_errorInfo.TabIndex = 33;
            this.listView_errorInfo.UseCompatibleStateImageBehavior = false;
            this.listView_errorInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_errorTime
            // 
            this.columnHeader_errorTime.Text = "时间";
            this.columnHeader_errorTime.Width = 98;
            // 
            // columnHeader_errorCode
            // 
            this.columnHeader_errorCode.Text = "错误码";
            this.columnHeader_errorCode.Width = 100;
            // 
            // columnHeader_errorMsg
            // 
            this.columnHeader_errorMsg.Text = "错误信息";
            this.columnHeader_errorMsg.Width = 384;
            // 
            // panel_socket
            // 
            this.panel_socket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_socket.Controls.Add(this.tabControl1);
            this.panel_socket.Location = new System.Drawing.Point(9, 329);
            this.panel_socket.Name = "panel_socket";
            this.panel_socket.Size = new System.Drawing.Size(209, 210);
            this.panel_socket.TabIndex = 33;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_socket);
            this.tabControl1.Controls.Add(this.tabPage_http);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(203, 205);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_socket
            // 
            this.tabPage_socket.Controls.Add(this.label_socketPort_submit);
            this.tabPage_socket.Controls.Add(this.label_socket_port);
            this.tabPage_socket.Controls.Add(this.label_socketStatus_submit);
            this.tabPage_socket.Controls.Add(this.label_socketPort_main);
            this.tabPage_socket.Controls.Add(this.label_socketStatus_main);
            this.tabPage_socket.Controls.Add(this.label_socketPort_insert);
            this.tabPage_socket.Controls.Add(this.label_socketStatus_down);
            this.tabPage_socket.Controls.Add(this.label_socket_status);
            this.tabPage_socket.Controls.Add(this.label_socketPort_up);
            this.tabPage_socket.Controls.Add(this.label_socketStatus_insert);
            this.tabPage_socket.Controls.Add(this.label_socketPort_down);
            this.tabPage_socket.Controls.Add(this.label_socketStatus_up);
            this.tabPage_socket.Location = new System.Drawing.Point(4, 27);
            this.tabPage_socket.Name = "tabPage_socket";
            this.tabPage_socket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_socket.Size = new System.Drawing.Size(195, 174);
            this.tabPage_socket.TabIndex = 0;
            this.tabPage_socket.Text = "设备通信";
            this.tabPage_socket.UseVisualStyleBackColor = true;
            // 
            // label_socketPort_submit
            // 
            this.label_socketPort_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketPort_submit.AutoSize = true;
            this.label_socketPort_submit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketPort_submit.Location = new System.Drawing.Point(16, 149);
            this.label_socketPort_submit.Name = "label_socketPort_submit";
            this.label_socketPort_submit.Size = new System.Drawing.Size(37, 15);
            this.label_socketPort_submit.TabIndex = 63;
            this.label_socketPort_submit.Text = "提交";
            // 
            // label_socket_port
            // 
            this.label_socket_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socket_port.AutoSize = true;
            this.label_socket_port.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socket_port.Location = new System.Drawing.Point(24, 2);
            this.label_socket_port.Name = "label_socket_port";
            this.label_socket_port.Size = new System.Drawing.Size(39, 15);
            this.label_socket_port.TabIndex = 53;
            this.label_socket_port.Text = "端口";
            // 
            // label_socketStatus_submit
            // 
            this.label_socketStatus_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketStatus_submit.AutoSize = true;
            this.label_socketStatus_submit.BackColor = System.Drawing.Color.Red;
            this.label_socketStatus_submit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketStatus_submit.Location = new System.Drawing.Point(132, 149);
            this.label_socketStatus_submit.Name = "label_socketStatus_submit";
            this.label_socketStatus_submit.Size = new System.Drawing.Size(31, 15);
            this.label_socketStatus_submit.TabIndex = 62;
            this.label_socketStatus_submit.Text = "   ";
            // 
            // label_socketPort_main
            // 
            this.label_socketPort_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketPort_main.AutoSize = true;
            this.label_socketPort_main.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketPort_main.Location = new System.Drawing.Point(16, 60);
            this.label_socketPort_main.Name = "label_socketPort_main";
            this.label_socketPort_main.Size = new System.Drawing.Size(67, 15);
            this.label_socketPort_main.TabIndex = 57;
            this.label_socketPort_main.Text = "玻璃扫码";
            // 
            // label_socketStatus_main
            // 
            this.label_socketStatus_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketStatus_main.AutoSize = true;
            this.label_socketStatus_main.BackColor = System.Drawing.Color.Red;
            this.label_socketStatus_main.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketStatus_main.Location = new System.Drawing.Point(132, 60);
            this.label_socketStatus_main.Name = "label_socketStatus_main";
            this.label_socketStatus_main.Size = new System.Drawing.Size(31, 15);
            this.label_socketStatus_main.TabIndex = 56;
            this.label_socketStatus_main.Text = "   ";
            // 
            // label_socketPort_insert
            // 
            this.label_socketPort_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketPort_insert.AutoSize = true;
            this.label_socketPort_insert.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketPort_insert.Location = new System.Drawing.Point(16, 119);
            this.label_socketPort_insert.Name = "label_socketPort_insert";
            this.label_socketPort_insert.Size = new System.Drawing.Size(67, 15);
            this.label_socketPort_insert.TabIndex = 61;
            this.label_socketPort_insert.Text = "玻璃插架";
            // 
            // label_socketStatus_down
            // 
            this.label_socketStatus_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketStatus_down.AutoSize = true;
            this.label_socketStatus_down.BackColor = System.Drawing.Color.Red;
            this.label_socketStatus_down.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketStatus_down.Location = new System.Drawing.Point(132, 88);
            this.label_socketStatus_down.Name = "label_socketStatus_down";
            this.label_socketStatus_down.Size = new System.Drawing.Size(31, 15);
            this.label_socketStatus_down.TabIndex = 58;
            this.label_socketStatus_down.Text = "   ";
            // 
            // label_socket_status
            // 
            this.label_socket_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socket_status.AutoSize = true;
            this.label_socket_status.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socket_status.Location = new System.Drawing.Point(126, 2);
            this.label_socket_status.Name = "label_socket_status";
            this.label_socket_status.Size = new System.Drawing.Size(39, 15);
            this.label_socket_status.TabIndex = 52;
            this.label_socket_status.Text = "状态";
            // 
            // label_socketPort_up
            // 
            this.label_socketPort_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketPort_up.AutoSize = true;
            this.label_socketPort_up.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketPort_up.Location = new System.Drawing.Point(16, 28);
            this.label_socketPort_up.Name = "label_socketPort_up";
            this.label_socketPort_up.Size = new System.Drawing.Size(82, 15);
            this.label_socketPort_up.TabIndex = 55;
            this.label_socketPort_up.Text = "化抛架扫码";
            // 
            // label_socketStatus_insert
            // 
            this.label_socketStatus_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketStatus_insert.AutoSize = true;
            this.label_socketStatus_insert.BackColor = System.Drawing.Color.Red;
            this.label_socketStatus_insert.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketStatus_insert.Location = new System.Drawing.Point(132, 119);
            this.label_socketStatus_insert.Name = "label_socketStatus_insert";
            this.label_socketStatus_insert.Size = new System.Drawing.Size(31, 15);
            this.label_socketStatus_insert.TabIndex = 60;
            this.label_socketStatus_insert.Text = "   ";
            // 
            // label_socketPort_down
            // 
            this.label_socketPort_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketPort_down.AutoSize = true;
            this.label_socketPort_down.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketPort_down.Location = new System.Drawing.Point(16, 88);
            this.label_socketPort_down.Name = "label_socketPort_down";
            this.label_socketPort_down.Size = new System.Drawing.Size(82, 15);
            this.label_socketPort_down.TabIndex = 59;
            this.label_socketPort_down.Text = "清洗架扫码";
            // 
            // label_socketStatus_up
            // 
            this.label_socketStatus_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_socketStatus_up.AutoSize = true;
            this.label_socketStatus_up.BackColor = System.Drawing.Color.Red;
            this.label_socketStatus_up.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socketStatus_up.Location = new System.Drawing.Point(132, 28);
            this.label_socketStatus_up.Name = "label_socketStatus_up";
            this.label_socketStatus_up.Size = new System.Drawing.Size(31, 15);
            this.label_socketStatus_up.TabIndex = 54;
            this.label_socketStatus_up.Text = "   ";
            // 
            // tabPage_http
            // 
            this.tabPage_http.Controls.Add(this.textBox_http_site);
            this.tabPage_http.Controls.Add(this.label_http_site);
            this.tabPage_http.Controls.Add(this.textBox_http_password);
            this.tabPage_http.Controls.Add(this.textBox_http_username);
            this.tabPage_http.Controls.Add(this.label_http_username);
            this.tabPage_http.Controls.Add(this.label_http_password);
            this.tabPage_http.Controls.Add(this.button_http_login);
            this.tabPage_http.Controls.Add(this.label_http_status);
            this.tabPage_http.Controls.Add(this.label_http_status_color);
            this.tabPage_http.Location = new System.Drawing.Point(4, 27);
            this.tabPage_http.Name = "tabPage_http";
            this.tabPage_http.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_http.Size = new System.Drawing.Size(195, 174);
            this.tabPage_http.TabIndex = 1;
            this.tabPage_http.Text = "MES通信";
            this.tabPage_http.UseVisualStyleBackColor = true;
            // 
            // textBox_http_site
            // 
            this.textBox_http_site.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_http_site.Location = new System.Drawing.Point(76, 81);
            this.textBox_http_site.Name = "textBox_http_site";
            this.textBox_http_site.Size = new System.Drawing.Size(100, 25);
            this.textBox_http_site.TabIndex = 66;
            // 
            // label_http_site
            // 
            this.label_http_site.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_http_site.AutoSize = true;
            this.label_http_site.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_http_site.Location = new System.Drawing.Point(23, 84);
            this.label_http_site.Name = "label_http_site";
            this.label_http_site.Size = new System.Drawing.Size(39, 15);
            this.label_http_site.TabIndex = 65;
            this.label_http_site.Text = "站点";
            // 
            // textBox_http_password
            // 
            this.textBox_http_password.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_http_password.Location = new System.Drawing.Point(77, 45);
            this.textBox_http_password.Name = "textBox_http_password";
            this.textBox_http_password.Size = new System.Drawing.Size(100, 25);
            this.textBox_http_password.TabIndex = 64;
            // 
            // textBox_http_username
            // 
            this.textBox_http_username.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_http_username.Location = new System.Drawing.Point(77, 9);
            this.textBox_http_username.Name = "textBox_http_username";
            this.textBox_http_username.Size = new System.Drawing.Size(100, 25);
            this.textBox_http_username.TabIndex = 63;
            // 
            // label_http_username
            // 
            this.label_http_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_http_username.AutoSize = true;
            this.label_http_username.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_http_username.Location = new System.Drawing.Point(24, 13);
            this.label_http_username.Name = "label_http_username";
            this.label_http_username.Size = new System.Drawing.Size(39, 15);
            this.label_http_username.TabIndex = 62;
            this.label_http_username.Text = "账号";
            // 
            // label_http_password
            // 
            this.label_http_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_http_password.AutoSize = true;
            this.label_http_password.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_http_password.Location = new System.Drawing.Point(24, 48);
            this.label_http_password.Name = "label_http_password";
            this.label_http_password.Size = new System.Drawing.Size(39, 15);
            this.label_http_password.TabIndex = 61;
            this.label_http_password.Text = "密码";
            // 
            // button_http_login
            // 
            this.button_http_login.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_http_login.Location = new System.Drawing.Point(63, 139);
            this.button_http_login.Name = "button_http_login";
            this.button_http_login.Size = new System.Drawing.Size(56, 28);
            this.button_http_login.TabIndex = 60;
            this.button_http_login.Text = "登录";
            this.button_http_login.UseVisualStyleBackColor = true;
            this.button_http_login.Click += new System.EventHandler(this.button_http_login_Click);
            // 
            // label_http_status
            // 
            this.label_http_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_http_status.AutoSize = true;
            this.label_http_status.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_http_status.Location = new System.Drawing.Point(24, 116);
            this.label_http_status.Name = "label_http_status";
            this.label_http_status.Size = new System.Drawing.Size(39, 15);
            this.label_http_status.TabIndex = 56;
            this.label_http_status.Text = "状态";
            // 
            // label_http_status_color
            // 
            this.label_http_status_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_http_status_color.AutoSize = true;
            this.label_http_status_color.BackColor = System.Drawing.Color.Red;
            this.label_http_status_color.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_http_status_color.Location = new System.Drawing.Point(110, 116);
            this.label_http_status_color.Name = "label_http_status_color";
            this.label_http_status_color.Size = new System.Drawing.Size(31, 15);
            this.label_http_status_color.TabIndex = 58;
            this.label_http_status_color.Text = "   ";
            // 
            // tabPage_OK_info
            // 
            this.tabPage_OK_info.Controls.Add(this.listView_OK);
            this.tabPage_OK_info.Location = new System.Drawing.Point(4, 25);
            this.tabPage_OK_info.Name = "tabPage_OK_info";
            this.tabPage_OK_info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OK_info.Size = new System.Drawing.Size(673, 255);
            this.tabPage_OK_info.TabIndex = 2;
            this.tabPage_OK_info.Text = "OK列表";
            this.tabPage_OK_info.UseVisualStyleBackColor = true;
            // 
            // listView_OK
            // 
            this.listView_OK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_time_OK,
            this.columnHeader_snNumber_OK,
            this.columnHeader_targetVehicle_OK,
            this.columnHeader_sourceVehicle_OK});
            this.listView_OK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_OK.GridLines = true;
            this.listView_OK.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_OK.HideSelection = false;
            this.listView_OK.Location = new System.Drawing.Point(0, 2);
            this.listView_OK.Name = "listView_OK";
            this.listView_OK.Size = new System.Drawing.Size(671, 251);
            this.listView_OK.TabIndex = 1;
            this.listView_OK.UseCompatibleStateImageBehavior = false;
            this.listView_OK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_time_OK
            // 
            this.columnHeader_time_OK.Text = "时间";
            this.columnHeader_time_OK.Width = 120;
            // 
            // columnHeader_snNumber_OK
            // 
            this.columnHeader_snNumber_OK.Text = "玻璃码";
            this.columnHeader_snNumber_OK.Width = 165;
            // 
            // columnHeader_targetVehicle_OK
            // 
            this.columnHeader_targetVehicle_OK.Text = "清洗架码";
            this.columnHeader_targetVehicle_OK.Width = 179;
            // 
            // columnHeader_sourceVehicle_OK
            // 
            this.columnHeader_sourceVehicle_OK.Text = "化抛架码";
            this.columnHeader_sourceVehicle_OK.Width = 197;
            // 
            // tabPage_NG_info_BDS
            // 
            this.tabPage_NG_info_BDS.Controls.Add(this.listView_NG_BDS);
            this.tabPage_NG_info_BDS.Location = new System.Drawing.Point(4, 25);
            this.tabPage_NG_info_BDS.Name = "tabPage_NG_info_BDS";
            this.tabPage_NG_info_BDS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NG_info_BDS.Size = new System.Drawing.Size(673, 255);
            this.tabPage_NG_info_BDS.TabIndex = 3;
            this.tabPage_NG_info_BDS.Text = "NG列表";
            this.tabPage_NG_info_BDS.UseVisualStyleBackColor = true;
            // 
            // listView_NG_BDS
            // 
            this.listView_NG_BDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_time_BDS,
            this.columnHeader_snNumber_BDS,
            this.columnHeader_NG_info_BDS});
            this.listView_NG_BDS.GridLines = true;
            this.listView_NG_BDS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_NG_BDS.HideSelection = false;
            this.listView_NG_BDS.Location = new System.Drawing.Point(0, -1);
            this.listView_NG_BDS.Name = "listView_NG_BDS";
            this.listView_NG_BDS.Size = new System.Drawing.Size(673, 257);
            this.listView_NG_BDS.TabIndex = 34;
            this.listView_NG_BDS.UseCompatibleStateImageBehavior = false;
            this.listView_NG_BDS.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_time_BDS
            // 
            this.columnHeader_time_BDS.Text = "时间";
            this.columnHeader_time_BDS.Width = 98;
            // 
            // columnHeader_snNumber_BDS
            // 
            this.columnHeader_snNumber_BDS.Text = "玻璃码";
            this.columnHeader_snNumber_BDS.Width = 180;
            // 
            // columnHeader_NG_info_BDS
            // 
            this.columnHeader_NG_info_BDS.Text = "NG信息";
            this.columnHeader_NG_info_BDS.Width = 384;
            // 
            // basicInfoBindingSource
            // 
            this.basicInfoBindingSource.DataSource = typeof(ScanUploader.Model.BasicInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 689);
            this.Controls.Add(this.panel_socket);
            this.Controls.Add(this.panel_NG_info);
            this.Controls.Add(this.label_timer_main);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_connectStatus);
            this.Controls.Add(this.panel_basicInformation);
            this.Controls.Add(this.menuStrip_top);
            this.Controls.Add(this.panel_log);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip_top;
            this.Name = "MainForm";
            this.Text = "扫码上传上位机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip_top.ResumeLayout(false);
            this.menuStrip_top.PerformLayout();
            this.panel_basicInformation.ResumeLayout(false);
            this.panel_basicInformation.PerformLayout();
            this.panel_log.ResumeLayout(false);
            this.tabControl_log.ResumeLayout(false);
            this.tabPage_logInfo.ResumeLayout(false);
            this.tabPage_logInfo.PerformLayout();
            this.tabPage_debugInfo.ResumeLayout(false);
            this.tabPage_debugInfo.PerformLayout();
            this.panel_connectStatus.ResumeLayout(false);
            this.panel_connectStatus.PerformLayout();
            this.panel_NG_info.ResumeLayout(false);
            this.tabControl_error_info.ResumeLayout(false);
            this.tabPage_NG_info.ResumeLayout(false);
            this.tabPage_error_info.ResumeLayout(false);
            this.panel_socket.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_socket.ResumeLayout(false);
            this.tabPage_socket.PerformLayout();
            this.tabPage_http.ResumeLayout(false);
            this.tabPage_http.PerformLayout();
            this.tabPage_OK_info.ResumeLayout(false);
            this.tabPage_NG_info_BDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basicInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_top;
        private System.Windows.Forms.ComboBox comboBox_productModel;
        private System.Windows.Forms.Label label_productModelVersion;
        private System.Windows.Forms.Label label_productModel;
        private System.Windows.Forms.ComboBox comboBox_productModelVersion;
        private System.Windows.Forms.ComboBox comboBox_resource;
        private System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.Label label_resource;
        private System.Windows.Forms.ComboBox comboBox_operation;
        private System.Windows.Forms.Label label_createBy;
        private System.Windows.Forms.Label label_operation;
        private System.Windows.Forms.ComboBox comboBox_createBy;
        private System.Windows.Forms.ComboBox comboBox_site;
        private System.Windows.Forms.Label label_site;
        private System.Windows.Forms.ComboBox comboBox_shift;
        private System.Windows.Forms.Panel panel_basicInformation;
        public System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_top_config;
        private System.Windows.Forms.Label label_mo;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Panel panel_connectStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_text_statistics_OK1;
        private System.Windows.Forms.Label label_connectStatus_MES;
        private System.Windows.Forms.Label label_text_statistics_NG1;
        private System.Windows.Forms.Label label_connectStatus_PLC;
        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.Label label_timer_main;
        private System.Windows.Forms.Label label_text_statistics_yield2;
        private System.Windows.Forms.Label label_text_statistics_NG2;
        private System.Windows.Forms.Label label_text_statistics_OK2;
        private System.Windows.Forms.Label label_text_statistics_yield1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_NG_info;
        private System.Windows.Forms.Button button_empty;
        private System.Windows.Forms.Button button_export_excel;
        private System.Windows.Forms.TabControl tabControl_log;
        private System.Windows.Forms.TabPage tabPage_logInfo;
        private System.Windows.Forms.TabPage tabPage_debugInfo;
        public System.Windows.Forms.TextBox textBox_debug;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_text_statistics_yield_total;
        private System.Windows.Forms.Label label_text_statistics_NG_total;
        private System.Windows.Forms.Label label_text_statistics_OK_total;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_top_restart;
        private System.Windows.Forms.TabControl tabControl_error_info;
        private System.Windows.Forms.TabPage tabPage_error_info;
        private System.Windows.Forms.ListView listView_errorInfo;
        private System.Windows.Forms.ColumnHeader columnHeader_errorTime;
        private System.Windows.Forms.ColumnHeader columnHeader_errorCode;
        private System.Windows.Forms.ColumnHeader columnHeader_errorMsg;
        private System.Windows.Forms.TabPage tabPage_NG_info;
        private System.Windows.Forms.ListView listView_NG;
        private System.Windows.Forms.ColumnHeader columnHeader_time_NG;
        private System.Windows.Forms.ColumnHeader columnHeader_snNumber_NG;
        private System.Windows.Forms.Button button_openLogDir;
        private System.Windows.Forms.Button button_openLogFile;
        private System.Windows.Forms.BindingSource basicInfoBindingSource;
        private System.Windows.Forms.Button button_save_basicInfo;
        private System.Windows.Forms.Panel panel_socket;
        private System.Windows.Forms.Label label_socket_port;
        private System.Windows.Forms.Label label_socket_status;
        private System.Windows.Forms.Label label_socketPort_up;
        private System.Windows.Forms.Label label_socketStatus_up;
        private System.Windows.Forms.Label label_socketPort_submit;
        private System.Windows.Forms.Label label_socketStatus_submit;
        private System.Windows.Forms.Label label_socketPort_insert;
        private System.Windows.Forms.Label label_socketStatus_insert;
        private System.Windows.Forms.Label label_socketPort_down;
        private System.Windows.Forms.Label label_socketStatus_down;
        private System.Windows.Forms.Label label_socketPort_main;
        private System.Windows.Forms.Label label_socketStatus_main;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_socket;
        private System.Windows.Forms.TabPage tabPage_http;
        private System.Windows.Forms.Label label_http_status;
        private System.Windows.Forms.Label label_http_status_color;
        private System.Windows.Forms.Button button_http_login;
        private System.Windows.Forms.TextBox textBox_http_password;
        private System.Windows.Forms.TextBox textBox_http_username;
        private System.Windows.Forms.Label label_http_username;
        private System.Windows.Forms.Label label_http_password;
        private System.Windows.Forms.TextBox textBox_http_site;
        private System.Windows.Forms.Label label_http_site;
        private System.Windows.Forms.ComboBox comboBox_order;
        private System.Windows.Forms.ColumnHeader columnHeader_targetVehicle_NG;
        private System.Windows.Forms.ColumnHeader columnHeader_sourceVehicle_NG;
        private System.Windows.Forms.TabPage tabPage_OK_info;
        private System.Windows.Forms.ListView listView_OK;
        private System.Windows.Forms.ColumnHeader columnHeader_time_OK;
        private System.Windows.Forms.ColumnHeader columnHeader_snNumber_OK;
        private System.Windows.Forms.ColumnHeader columnHeader_targetVehicle_OK;
        private System.Windows.Forms.ColumnHeader columnHeader_sourceVehicle_OK;
        private System.Windows.Forms.TabPage tabPage_NG_info_BDS;
        private System.Windows.Forms.ListView listView_NG_BDS;
        private System.Windows.Forms.ColumnHeader columnHeader_time_BDS;
        private System.Windows.Forms.ColumnHeader columnHeader_snNumber_BDS;
        private System.Windows.Forms.ColumnHeader columnHeader_NG_info_BDS;
    }
}

