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
            this.textBox_productModel = new System.Windows.Forms.TextBox();
            this.label_productModelVersion = new System.Windows.Forms.Label();
            this.label_productModel = new System.Windows.Forms.Label();
            this.textBox_productModelVersion = new System.Windows.Forms.TextBox();
            this.textBox_resource = new System.Windows.Forms.TextBox();
            this.label_shift = new System.Windows.Forms.Label();
            this.label_resource = new System.Windows.Forms.Label();
            this.textBox_operation = new System.Windows.Forms.TextBox();
            this.label_createBy = new System.Windows.Forms.Label();
            this.label_operation = new System.Windows.Forms.Label();
            this.textBox_createBy = new System.Windows.Forms.TextBox();
            this.textBox_site = new System.Windows.Forms.TextBox();
            this.label_site = new System.Windows.Forms.Label();
            this.comboBox_shift = new System.Windows.Forms.ComboBox();
            this.panel_basicInformation = new System.Windows.Forms.Panel();
            this.textBox_mo = new System.Windows.Forms.TextBox();
            this.label_mo = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.panel_log = new System.Windows.Forms.Panel();
            this.tabControl_log = new System.Windows.Forms.TabControl();
            this.tabPage_logInfo = new System.Windows.Forms.TabPage();
            this.button_openLogDir = new System.Windows.Forms.Button();
            this.button_openLogFile = new System.Windows.Forms.Button();
            this.tabPage_debugInfo = new System.Windows.Forms.TabPage();
            this.textBox_debug = new System.Windows.Forms.TextBox();
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
            this.listView_NG_info = new System.Windows.Forms.ListView();
            this.columnHeader_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_SN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_NG_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_error_info = new System.Windows.Forms.TabPage();
            this.listView_errorInfo = new System.Windows.Forms.ListView();
            this.columnHeader_errorTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_errorCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_errorMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.menuStrip_top.Size = new System.Drawing.Size(1008, 27);
            this.menuStrip_top.TabIndex = 17;
            this.menuStrip_top.Text = "menuStrip1";
            // 
            // menuStrip_top_config
            // 
            this.menuStrip_top_config.Name = "menuStrip_top_config";
            this.menuStrip_top_config.Size = new System.Drawing.Size(44, 21);
            this.menuStrip_top_config.Text = "配置";
            this.menuStrip_top_config.Click += new System.EventHandler(this.menuStrip_top_Config_Click);
            // 
            // menuStrip_top_restart
            // 
            this.menuStrip_top_restart.Name = "menuStrip_top_restart";
            this.menuStrip_top_restart.Size = new System.Drawing.Size(44, 21);
            this.menuStrip_top_restart.Text = "重启";
            // 
            // textBox_productModel
            // 
            this.textBox_productModel.Location = new System.Drawing.Point(94, 101);
            this.textBox_productModel.Name = "textBox_productModel";
            this.textBox_productModel.Size = new System.Drawing.Size(90, 21);
            this.textBox_productModel.TabIndex = 7;
            this.textBox_productModel.TextChanged += new System.EventHandler(this.textBox_productModel_TextChanged);
            // 
            // label_productModelVersion
            // 
            this.label_productModelVersion.AutoSize = true;
            this.label_productModelVersion.Location = new System.Drawing.Point(15, 137);
            this.label_productModelVersion.Name = "label_productModelVersion";
            this.label_productModelVersion.Size = new System.Drawing.Size(65, 12);
            this.label_productModelVersion.TabIndex = 8;
            this.label_productModelVersion.Text = "型号版本：";
            // 
            // label_productModel
            // 
            this.label_productModel.AutoSize = true;
            this.label_productModel.Location = new System.Drawing.Point(15, 107);
            this.label_productModel.Name = "label_productModel";
            this.label_productModel.Size = new System.Drawing.Size(65, 12);
            this.label_productModel.TabIndex = 6;
            this.label_productModel.Text = "产品型号：";
            // 
            // textBox_productModelVersion
            // 
            this.textBox_productModelVersion.Location = new System.Drawing.Point(94, 131);
            this.textBox_productModelVersion.Name = "textBox_productModelVersion";
            this.textBox_productModelVersion.Size = new System.Drawing.Size(90, 21);
            this.textBox_productModelVersion.TabIndex = 9;
            this.textBox_productModelVersion.TextChanged += new System.EventHandler(this.textBox_productModelVersion_TextChanged);
            // 
            // textBox_resource
            // 
            this.textBox_resource.Location = new System.Drawing.Point(94, 71);
            this.textBox_resource.Name = "textBox_resource";
            this.textBox_resource.Size = new System.Drawing.Size(90, 21);
            this.textBox_resource.TabIndex = 5;
            this.textBox_resource.TextChanged += new System.EventHandler(this.textBox_resource_TextChanged);
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.Location = new System.Drawing.Point(15, 165);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(41, 12);
            this.label_shift.TabIndex = 10;
            this.label_shift.Text = "班次：";
            // 
            // label_resource
            // 
            this.label_resource.AutoSize = true;
            this.label_resource.Location = new System.Drawing.Point(15, 77);
            this.label_resource.Name = "label_resource";
            this.label_resource.Size = new System.Drawing.Size(53, 12);
            this.label_resource.TabIndex = 4;
            this.label_resource.Text = "设备号：";
            // 
            // textBox_operation
            // 
            this.textBox_operation.Location = new System.Drawing.Point(94, 41);
            this.textBox_operation.Name = "textBox_operation";
            this.textBox_operation.Size = new System.Drawing.Size(90, 21);
            this.textBox_operation.TabIndex = 3;
            this.textBox_operation.TextChanged += new System.EventHandler(this.textBox_operation_TextChanged);
            // 
            // label_createBy
            // 
            this.label_createBy.AutoSize = true;
            this.label_createBy.Location = new System.Drawing.Point(15, 196);
            this.label_createBy.Name = "label_createBy";
            this.label_createBy.Size = new System.Drawing.Size(53, 12);
            this.label_createBy.TabIndex = 12;
            this.label_createBy.Text = "操作人：";
            // 
            // label_operation
            // 
            this.label_operation.AutoSize = true;
            this.label_operation.Location = new System.Drawing.Point(15, 48);
            this.label_operation.Name = "label_operation";
            this.label_operation.Size = new System.Drawing.Size(41, 12);
            this.label_operation.TabIndex = 2;
            this.label_operation.Text = "工序：";
            // 
            // textBox_createBy
            // 
            this.textBox_createBy.Location = new System.Drawing.Point(94, 189);
            this.textBox_createBy.Name = "textBox_createBy";
            this.textBox_createBy.Size = new System.Drawing.Size(90, 21);
            this.textBox_createBy.TabIndex = 13;
            this.textBox_createBy.TextChanged += new System.EventHandler(this.textBox_createBy_TextChanged);
            // 
            // textBox_site
            // 
            this.textBox_site.Location = new System.Drawing.Point(94, 11);
            this.textBox_site.Name = "textBox_site";
            this.textBox_site.Size = new System.Drawing.Size(90, 21);
            this.textBox_site.TabIndex = 1;
            this.textBox_site.TextChanged += new System.EventHandler(this.textBox_site_TextChanged);
            // 
            // label_site
            // 
            this.label_site.AutoSize = true;
            this.label_site.Location = new System.Drawing.Point(15, 17);
            this.label_site.Name = "label_site";
            this.label_site.Size = new System.Drawing.Size(65, 12);
            this.label_site.TabIndex = 0;
            this.label_site.Text = "工厂编号：";
            // 
            // comboBox_shift
            // 
            this.comboBox_shift.FormattingEnabled = true;
            this.comboBox_shift.Location = new System.Drawing.Point(94, 161);
            this.comboBox_shift.Name = "comboBox_shift";
            this.comboBox_shift.Size = new System.Drawing.Size(90, 20);
            this.comboBox_shift.TabIndex = 19;
            this.comboBox_shift.SelectedIndexChanged += new System.EventHandler(this.comboBox_shift_SelectedIndexChanged);
            // 
            // panel_basicInformation
            // 
            this.panel_basicInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_basicInformation.Controls.Add(this.label_site);
            this.panel_basicInformation.Controls.Add(this.comboBox_shift);
            this.panel_basicInformation.Controls.Add(this.textBox_productModel);
            this.panel_basicInformation.Controls.Add(this.textBox_mo);
            this.panel_basicInformation.Controls.Add(this.label_productModel);
            this.panel_basicInformation.Controls.Add(this.label_mo);
            this.panel_basicInformation.Controls.Add(this.textBox_resource);
            this.panel_basicInformation.Controls.Add(this.textBox_productModelVersion);
            this.panel_basicInformation.Controls.Add(this.label_createBy);
            this.panel_basicInformation.Controls.Add(this.textBox_site);
            this.panel_basicInformation.Controls.Add(this.textBox_createBy);
            this.panel_basicInformation.Controls.Add(this.label_shift);
            this.panel_basicInformation.Controls.Add(this.textBox_operation);
            this.panel_basicInformation.Controls.Add(this.label_productModelVersion);
            this.panel_basicInformation.Controls.Add(this.label_operation);
            this.panel_basicInformation.Controls.Add(this.label_resource);
            this.panel_basicInformation.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_basicInformation.Location = new System.Drawing.Point(9, 31);
            this.panel_basicInformation.Name = "panel_basicInformation";
            this.panel_basicInformation.Size = new System.Drawing.Size(209, 267);
            this.panel_basicInformation.TabIndex = 16;
            // 
            // textBox_mo
            // 
            this.textBox_mo.Location = new System.Drawing.Point(94, 223);
            this.textBox_mo.Name = "textBox_mo";
            this.textBox_mo.Size = new System.Drawing.Size(90, 21);
            this.textBox_mo.TabIndex = 22;
            this.textBox_mo.Text = "000603873750";
            this.textBox_mo.TextChanged += new System.EventHandler(this.textBox_mo_TextChanged);
            // 
            // label_mo
            // 
            this.label_mo.AutoSize = true;
            this.label_mo.Location = new System.Drawing.Point(17, 229);
            this.label_mo.Name = "label_mo";
            this.label_mo.Size = new System.Drawing.Size(53, 12);
            this.label_mo.TabIndex = 21;
            this.label_mo.Text = "工单号：";
            // 
            // textBox_log
            // 
            this.textBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_log.Location = new System.Drawing.Point(3, 3);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(662, 308);
            this.textBox_log.TabIndex = 19;
            // 
            // panel_log
            // 
            this.panel_log.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_log.Controls.Add(this.tabControl_log);
            this.panel_log.Location = new System.Drawing.Point(224, 31);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(772, 338);
            this.panel_log.TabIndex = 27;
            // 
            // tabControl_log
            // 
            this.tabControl_log.Controls.Add(this.tabPage_logInfo);
            this.tabControl_log.Controls.Add(this.tabPage_debugInfo);
            this.tabControl_log.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl_log.Location = new System.Drawing.Point(-2, -2);
            this.tabControl_log.Name = "tabControl_log";
            this.tabControl_log.SelectedIndex = 0;
            this.tabControl_log.Size = new System.Drawing.Size(767, 338);
            this.tabControl_log.TabIndex = 20;
            // 
            // tabPage_logInfo
            // 
            this.tabPage_logInfo.Controls.Add(this.button_openLogDir);
            this.tabPage_logInfo.Controls.Add(this.textBox_log);
            this.tabPage_logInfo.Controls.Add(this.button_openLogFile);
            this.tabPage_logInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_logInfo.Name = "tabPage_logInfo";
            this.tabPage_logInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_logInfo.Size = new System.Drawing.Size(759, 312);
            this.tabPage_logInfo.TabIndex = 0;
            this.tabPage_logInfo.Text = "日志";
            this.tabPage_logInfo.UseVisualStyleBackColor = true;
            // 
            // button_openLogDir
            // 
            this.button_openLogDir.Location = new System.Drawing.Point(675, 165);
            this.button_openLogDir.Name = "button_openLogDir";
            this.button_openLogDir.Size = new System.Drawing.Size(69, 32);
            this.button_openLogDir.TabIndex = 35;
            this.button_openLogDir.Text = "打开目录";
            this.button_openLogDir.UseVisualStyleBackColor = true;
            this.button_openLogDir.Click += new System.EventHandler(this.button_openLogDir_Click);
            // 
            // button_openLogFile
            // 
            this.button_openLogFile.Location = new System.Drawing.Point(675, 97);
            this.button_openLogFile.Name = "button_openLogFile";
            this.button_openLogFile.Size = new System.Drawing.Size(69, 32);
            this.button_openLogFile.TabIndex = 34;
            this.button_openLogFile.Text = "打开日志";
            this.button_openLogFile.UseVisualStyleBackColor = true;
            this.button_openLogFile.Click += new System.EventHandler(this.button_openLogFile_Click);
            // 
            // tabPage_debugInfo
            // 
            this.tabPage_debugInfo.Controls.Add(this.textBox_debug);
            this.tabPage_debugInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_debugInfo.Name = "tabPage_debugInfo";
            this.tabPage_debugInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_debugInfo.Size = new System.Drawing.Size(759, 312);
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
            this.textBox_debug.Size = new System.Drawing.Size(755, 306);
            this.textBox_debug.TabIndex = 33;
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
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 51;
            this.label16.Text = "合计";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(11, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 50;
            this.label17.Text = "右通道";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(11, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
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
            this.label15.Size = new System.Drawing.Size(31, 12);
            this.label15.TabIndex = 48;
            this.label15.Text = "位置";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(184, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 47;
            this.label11.Text = "%";
            // 
            // label_text_statistics_yield_total
            // 
            this.label_text_statistics_yield_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_yield_total.AutoSize = true;
            this.label_text_statistics_yield_total.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_yield_total.Location = new System.Drawing.Point(147, 86);
            this.label_text_statistics_yield_total.Name = "label_text_statistics_yield_total";
            this.label_text_statistics_yield_total.Size = new System.Drawing.Size(35, 12);
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
            this.label_text_statistics_NG_total.Size = new System.Drawing.Size(17, 12);
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
            this.label_text_statistics_OK_total.Size = new System.Drawing.Size(17, 12);
            this.label_text_statistics_OK_total.TabIndex = 44;
            this.label_text_statistics_OK_total.Text = "00";
            this.label_text_statistics_OK_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(184, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 43;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(184, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 42;
            this.label9.Text = "%";
            // 
            // label_text_statistics_yield2
            // 
            this.label_text_statistics_yield2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_yield2.AutoSize = true;
            this.label_text_statistics_yield2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_yield2.Location = new System.Drawing.Point(147, 63);
            this.label_text_statistics_yield2.Name = "label_text_statistics_yield2";
            this.label_text_statistics_yield2.Size = new System.Drawing.Size(35, 12);
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
            this.label_text_statistics_NG2.Size = new System.Drawing.Size(17, 12);
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
            this.label_text_statistics_OK2.Size = new System.Drawing.Size(17, 12);
            this.label_text_statistics_OK2.TabIndex = 39;
            this.label_text_statistics_OK2.Text = "00";
            this.label_text_statistics_OK2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_text_statistics_yield1
            // 
            this.label_text_statistics_yield1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_statistics_yield1.AutoSize = true;
            this.label_text_statistics_yield1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_statistics_yield1.Location = new System.Drawing.Point(147, 37);
            this.label_text_statistics_yield1.Name = "label_text_statistics_yield1";
            this.label_text_statistics_yield1.Size = new System.Drawing.Size(35, 12);
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
            this.label4.Size = new System.Drawing.Size(31, 12);
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
            this.label_text_statistics_NG1.Size = new System.Drawing.Size(17, 12);
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
            this.label_connectStatus_PLC.Size = new System.Drawing.Size(19, 12);
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
            this.label_text_statistics_OK1.Size = new System.Drawing.Size(17, 12);
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
            this.label_connectStatus_MES.Size = new System.Drawing.Size(19, 12);
            this.label_connectStatus_MES.TabIndex = 33;
            this.label_connectStatus_MES.Text = "OK";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(800, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
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
            this.label_timer_main.Location = new System.Drawing.Point(877, 671);
            this.label_timer_main.Name = "label_timer_main";
            this.label_timer_main.Size = new System.Drawing.Size(119, 12);
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
            this.tabControl_error_info.Controls.Add(this.tabPage_NG_info);
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
            this.tabPage_NG_info.Controls.Add(this.listView_NG_info);
            this.tabPage_NG_info.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NG_info.Name = "tabPage_NG_info";
            this.tabPage_NG_info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NG_info.Size = new System.Drawing.Size(673, 258);
            this.tabPage_NG_info.TabIndex = 1;
            this.tabPage_NG_info.Text = "单片NG";
            this.tabPage_NG_info.UseVisualStyleBackColor = true;
            // 
            // listView_NG_info
            // 
            this.listView_NG_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Time,
            this.columnHeader_SN,
            this.columnHeader_NG_Info});
            this.listView_NG_info.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_NG_info.GridLines = true;
            this.listView_NG_info.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_NG_info.HideSelection = false;
            this.listView_NG_info.Location = new System.Drawing.Point(0, 0);
            this.listView_NG_info.Name = "listView_NG_info";
            this.listView_NG_info.Size = new System.Drawing.Size(673, 251);
            this.listView_NG_info.TabIndex = 0;
            this.listView_NG_info.UseCompatibleStateImageBehavior = false;
            this.listView_NG_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Time
            // 
            this.columnHeader_Time.Text = "时间";
            this.columnHeader_Time.Width = 98;
            // 
            // columnHeader_SN
            // 
            this.columnHeader_SN.Text = "玻璃码";
            this.columnHeader_SN.Width = 186;
            // 
            // columnHeader_NG_Info
            // 
            this.columnHeader_NG_Info.Text = "NG原因";
            this.columnHeader_NG_Info.Width = 384;
            // 
            // tabPage_error_info
            // 
            this.tabPage_error_info.Controls.Add(this.listView_errorInfo);
            this.tabPage_error_info.Location = new System.Drawing.Point(4, 22);
            this.tabPage_error_info.Name = "tabPage_error_info";
            this.tabPage_error_info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_error_info.Size = new System.Drawing.Size(673, 258);
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
            this.columnHeader_errorCode.Width = 186;
            // 
            // columnHeader_errorMsg
            // 
            this.columnHeader_errorMsg.Text = "错误信息";
            this.columnHeader_errorMsg.Width = 384;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 689);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_top;
        private System.Windows.Forms.TextBox textBox_productModel;
        private System.Windows.Forms.Label label_productModelVersion;
        private System.Windows.Forms.Label label_productModel;
        private System.Windows.Forms.TextBox textBox_productModelVersion;
        private System.Windows.Forms.TextBox textBox_resource;
        private System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.Label label_resource;
        private System.Windows.Forms.TextBox textBox_operation;
        private System.Windows.Forms.Label label_createBy;
        private System.Windows.Forms.Label label_operation;
        private System.Windows.Forms.TextBox textBox_createBy;
        private System.Windows.Forms.TextBox textBox_site;
        private System.Windows.Forms.Label label_site;
        private System.Windows.Forms.ComboBox comboBox_shift;
        private System.Windows.Forms.Panel panel_basicInformation;
        public System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_top_config;
        private System.Windows.Forms.Label label_mo;
        private System.Windows.Forms.Panel panel_log;
        public System.Windows.Forms.TextBox textBox_mo;
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
        private System.Windows.Forms.ListView listView_NG_info;
        private System.Windows.Forms.ColumnHeader columnHeader_Time;
        private System.Windows.Forms.ColumnHeader columnHeader_SN;
        private System.Windows.Forms.ColumnHeader columnHeader_NG_Info;
        private System.Windows.Forms.Button button_openLogDir;
        private System.Windows.Forms.Button button_openLogFile;
    }
}

