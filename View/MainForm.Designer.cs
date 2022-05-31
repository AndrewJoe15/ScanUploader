namespace ChemicalScan.View
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
            this.menuStrip_top = new System.Windows.Forms.MenuStrip();
            this.menuStrip_top_Config = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_top_log = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_top_log_openCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_top_log_openFolder = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label_basicInformation = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.comboBox_shift = new System.Windows.Forms.ComboBox();
            this.panel_basicInformation = new System.Windows.Forms.Panel();
            this.textBox_mo = new System.Windows.Forms.TextBox();
            this.label_mo = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_errorInfo = new System.Windows.Forms.TextBox();
            this.panel_log = new System.Windows.Forms.Panel();
            this.label_errorInfo = new System.Windows.Forms.Label();
            this.panel_errorInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_connectStatus = new System.Windows.Forms.Panel();
            this.label_text_connectStatus_PLC = new System.Windows.Forms.Label();
            this.label_connectStatus_PLC = new System.Windows.Forms.Label();
            this.label_text__connectStatus_MES = new System.Windows.Forms.Label();
            this.label_connectStatus_MES = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip_top.SuspendLayout();
            this.panel_basicInformation.SuspendLayout();
            this.panel_log.SuspendLayout();
            this.panel_errorInfo.SuspendLayout();
            this.panel_connectStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_top
            // 
            this.menuStrip_top.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip_top.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_top_Config,
            this.menuStrip_top_log});
            this.menuStrip_top.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_top.Name = "menuStrip_top";
            this.menuStrip_top.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip_top.Size = new System.Drawing.Size(1028, 34);
            this.menuStrip_top.TabIndex = 17;
            this.menuStrip_top.Text = "menuStrip1";
            // 
            // menuStrip_top_Config
            // 
            this.menuStrip_top_Config.Name = "menuStrip_top_Config";
            this.menuStrip_top_Config.Size = new System.Drawing.Size(60, 28);
            this.menuStrip_top_Config.Text = "配置";
            this.menuStrip_top_Config.Click += new System.EventHandler(this.menuStrip_top_Config_Click);
            // 
            // menuStrip_top_log
            // 
            this.menuStrip_top_log.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_top_log_openCurrent,
            this.menuStrip_top_log_openFolder});
            this.menuStrip_top_log.Name = "menuStrip_top_log";
            this.menuStrip_top_log.Size = new System.Drawing.Size(60, 28);
            this.menuStrip_top_log.Text = "日志";
            // 
            // menuStrip_top_log_openCurrent
            // 
            this.menuStrip_top_log_openCurrent.Name = "menuStrip_top_log_openCurrent";
            this.menuStrip_top_log_openCurrent.Size = new System.Drawing.Size(224, 28);
            this.menuStrip_top_log_openCurrent.Text = "打开当前日志";
            this.menuStrip_top_log_openCurrent.Click += new System.EventHandler(this.menuStrip_top_log_openCurrent_Click);
            // 
            // menuStrip_top_log_openFolder
            // 
            this.menuStrip_top_log_openFolder.Name = "menuStrip_top_log_openFolder";
            this.menuStrip_top_log_openFolder.Size = new System.Drawing.Size(224, 28);
            this.menuStrip_top_log_openFolder.Text = "打开日志目录";
            this.menuStrip_top_log_openFolder.Click += new System.EventHandler(this.menuStrip_top_log_openFolder_Click);
            // 
            // textBox_productModel
            // 
            this.textBox_productModel.Location = new System.Drawing.Point(123, 177);
            this.textBox_productModel.Name = "textBox_productModel";
            this.textBox_productModel.Size = new System.Drawing.Size(180, 30);
            this.textBox_productModel.TabIndex = 7;
            this.textBox_productModel.TextChanged += new System.EventHandler(this.textBox_productModel_TextChanged);
            // 
            // label_productModelVersion
            // 
            this.label_productModelVersion.AutoSize = true;
            this.label_productModelVersion.Location = new System.Drawing.Point(23, 229);
            this.label_productModelVersion.Name = "label_productModelVersion";
            this.label_productModelVersion.Size = new System.Drawing.Size(109, 20);
            this.label_productModelVersion.TabIndex = 8;
            this.label_productModelVersion.Text = "型号版本：";
            // 
            // label_productModel
            // 
            this.label_productModel.AutoSize = true;
            this.label_productModel.Location = new System.Drawing.Point(23, 184);
            this.label_productModel.Name = "label_productModel";
            this.label_productModel.Size = new System.Drawing.Size(109, 20);
            this.label_productModel.TabIndex = 6;
            this.label_productModel.Text = "产品型号：";
            // 
            // textBox_productModelVersion
            // 
            this.textBox_productModelVersion.Location = new System.Drawing.Point(123, 222);
            this.textBox_productModelVersion.Name = "textBox_productModelVersion";
            this.textBox_productModelVersion.Size = new System.Drawing.Size(180, 30);
            this.textBox_productModelVersion.TabIndex = 9;
            this.textBox_productModelVersion.TextChanged += new System.EventHandler(this.textBox_productModelVersion_TextChanged);
            // 
            // textBox_resource
            // 
            this.textBox_resource.Location = new System.Drawing.Point(123, 128);
            this.textBox_resource.Name = "textBox_resource";
            this.textBox_resource.Size = new System.Drawing.Size(180, 30);
            this.textBox_resource.TabIndex = 5;
            this.textBox_resource.TextChanged += new System.EventHandler(this.textBox_resource_TextChanged);
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.Location = new System.Drawing.Point(23, 273);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(69, 20);
            this.label_shift.TabIndex = 10;
            this.label_shift.Text = "班次：";
            // 
            // label_resource
            // 
            this.label_resource.AutoSize = true;
            this.label_resource.Location = new System.Drawing.Point(23, 135);
            this.label_resource.Name = "label_resource";
            this.label_resource.Size = new System.Drawing.Size(89, 20);
            this.label_resource.TabIndex = 4;
            this.label_resource.Text = "设备号：";
            // 
            // textBox_operation
            // 
            this.textBox_operation.Location = new System.Drawing.Point(123, 78);
            this.textBox_operation.Name = "textBox_operation";
            this.textBox_operation.Size = new System.Drawing.Size(180, 30);
            this.textBox_operation.TabIndex = 3;
            this.textBox_operation.TextChanged += new System.EventHandler(this.textBox_operation_TextChanged);
            // 
            // label_createBy
            // 
            this.label_createBy.AutoSize = true;
            this.label_createBy.Location = new System.Drawing.Point(23, 322);
            this.label_createBy.Name = "label_createBy";
            this.label_createBy.Size = new System.Drawing.Size(89, 20);
            this.label_createBy.TabIndex = 12;
            this.label_createBy.Text = "操作人：";
            // 
            // label_operation
            // 
            this.label_operation.AutoSize = true;
            this.label_operation.Location = new System.Drawing.Point(23, 86);
            this.label_operation.Name = "label_operation";
            this.label_operation.Size = new System.Drawing.Size(69, 20);
            this.label_operation.TabIndex = 2;
            this.label_operation.Text = "工序：";
            // 
            // textBox_createBy
            // 
            this.textBox_createBy.Location = new System.Drawing.Point(123, 314);
            this.textBox_createBy.Name = "textBox_createBy";
            this.textBox_createBy.Size = new System.Drawing.Size(180, 30);
            this.textBox_createBy.TabIndex = 13;
            this.textBox_createBy.TextChanged += new System.EventHandler(this.textBox_createBy_TextChanged);
            // 
            // textBox_site
            // 
            this.textBox_site.Location = new System.Drawing.Point(123, 29);
            this.textBox_site.Name = "textBox_site";
            this.textBox_site.Size = new System.Drawing.Size(180, 30);
            this.textBox_site.TabIndex = 1;
            this.textBox_site.TextChanged += new System.EventHandler(this.textBox_site_TextChanged);
            // 
            // label_site
            // 
            this.label_site.AutoSize = true;
            this.label_site.Location = new System.Drawing.Point(23, 36);
            this.label_site.Name = "label_site";
            this.label_site.Size = new System.Drawing.Size(109, 20);
            this.label_site.TabIndex = 0;
            this.label_site.Text = "工厂编号：";
            // 
            // label_basicInformation
            // 
            this.label_basicInformation.AutoSize = true;
            this.label_basicInformation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_basicInformation.Location = new System.Drawing.Point(14, 49);
            this.label_basicInformation.Name = "label_basicInformation";
            this.label_basicInformation.Size = new System.Drawing.Size(93, 20);
            this.label_basicInformation.TabIndex = 16;
            this.label_basicInformation.Text = "基本信息";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(134, 406);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(81, 37);
            this.button_start.TabIndex = 17;
            this.button_start.Text = "确 定";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // comboBox_shift
            // 
            this.comboBox_shift.FormattingEnabled = true;
            this.comboBox_shift.Location = new System.Drawing.Point(123, 268);
            this.comboBox_shift.Name = "comboBox_shift";
            this.comboBox_shift.Size = new System.Drawing.Size(180, 28);
            this.comboBox_shift.TabIndex = 19;
            this.comboBox_shift.SelectedIndexChanged += new System.EventHandler(this.comboBox_shift_SelectedIndexChanged);
            // 
            // panel_basicInformation
            // 
            this.panel_basicInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_basicInformation.Controls.Add(this.textBox_mo);
            this.panel_basicInformation.Controls.Add(this.comboBox_shift);
            this.panel_basicInformation.Controls.Add(this.textBox_site);
            this.panel_basicInformation.Controls.Add(this.textBox_createBy);
            this.panel_basicInformation.Controls.Add(this.textBox_operation);
            this.panel_basicInformation.Controls.Add(this.textBox_resource);
            this.panel_basicInformation.Controls.Add(this.textBox_productModelVersion);
            this.panel_basicInformation.Controls.Add(this.textBox_productModel);
            this.panel_basicInformation.Controls.Add(this.label_mo);
            this.panel_basicInformation.Controls.Add(this.button_start);
            this.panel_basicInformation.Controls.Add(this.label_site);
            this.panel_basicInformation.Controls.Add(this.label_operation);
            this.panel_basicInformation.Controls.Add(this.label_createBy);
            this.panel_basicInformation.Controls.Add(this.label_resource);
            this.panel_basicInformation.Controls.Add(this.label_shift);
            this.panel_basicInformation.Controls.Add(this.label_productModel);
            this.panel_basicInformation.Controls.Add(this.label_productModelVersion);
            this.panel_basicInformation.Location = new System.Drawing.Point(10, 59);
            this.panel_basicInformation.Name = "panel_basicInformation";
            this.panel_basicInformation.Size = new System.Drawing.Size(333, 454);
            this.panel_basicInformation.TabIndex = 16;
            // 
            // textBox_mo
            // 
            this.textBox_mo.Location = new System.Drawing.Point(123, 362);
            this.textBox_mo.Name = "textBox_mo";
            this.textBox_mo.Size = new System.Drawing.Size(180, 30);
            this.textBox_mo.TabIndex = 22;
            // 
            // label_mo
            // 
            this.label_mo.AutoSize = true;
            this.label_mo.Location = new System.Drawing.Point(23, 369);
            this.label_mo.Name = "label_mo";
            this.label_mo.Size = new System.Drawing.Size(89, 20);
            this.label_mo.TabIndex = 21;
            this.label_mo.Text = "工单号：";
            // 
            // textBox_log
            // 
            this.textBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_log.Location = new System.Drawing.Point(-2, 16);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(667, 436);
            this.textBox_log.TabIndex = 19;
            // 
            // textBox_errorInfo
            // 
            this.textBox_errorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_errorInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_errorInfo.Location = new System.Drawing.Point(-2, 66);
            this.textBox_errorInfo.Multiline = true;
            this.textBox_errorInfo.Name = "textBox_errorInfo";
            this.textBox_errorInfo.ReadOnly = true;
            this.textBox_errorInfo.Size = new System.Drawing.Size(667, 105);
            this.textBox_errorInfo.TabIndex = 26;
            this.textBox_errorInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_log
            // 
            this.panel_log.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_log.Controls.Add(this.label_errorInfo);
            this.panel_log.Controls.Add(this.panel_errorInfo);
            this.panel_log.Controls.Add(this.textBox_log);
            this.panel_log.Location = new System.Drawing.Point(349, 59);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(667, 649);
            this.panel_log.TabIndex = 27;
            // 
            // label_errorInfo
            // 
            this.label_errorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_errorInfo.AutoSize = true;
            this.label_errorInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_errorInfo.Location = new System.Drawing.Point(7, 462);
            this.label_errorInfo.Name = "label_errorInfo";
            this.label_errorInfo.Size = new System.Drawing.Size(93, 20);
            this.label_errorInfo.TabIndex = 27;
            this.label_errorInfo.Text = "错误信息";
            // 
            // panel_errorInfo
            // 
            this.panel_errorInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_errorInfo.Controls.Add(this.textBox_errorInfo);
            this.panel_errorInfo.Location = new System.Drawing.Point(-2, 474);
            this.panel_errorInfo.Name = "panel_errorInfo";
            this.panel_errorInfo.Size = new System.Drawing.Size(667, 173);
            this.panel_errorInfo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(358, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Log日志";
            // 
            // panel_connectStatus
            // 
            this.panel_connectStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_connectStatus.Controls.Add(this.label_text_connectStatus_PLC);
            this.panel_connectStatus.Controls.Add(this.label_connectStatus_PLC);
            this.panel_connectStatus.Controls.Add(this.label_text__connectStatus_MES);
            this.panel_connectStatus.Controls.Add(this.label_connectStatus_MES);
            this.panel_connectStatus.Location = new System.Drawing.Point(10, 535);
            this.panel_connectStatus.Name = "panel_connectStatus";
            this.panel_connectStatus.Size = new System.Drawing.Size(333, 173);
            this.panel_connectStatus.TabIndex = 29;
            // 
            // label_text_connectStatus_PLC
            // 
            this.label_text_connectStatus_PLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text_connectStatus_PLC.AutoSize = true;
            this.label_text_connectStatus_PLC.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text_connectStatus_PLC.Location = new System.Drawing.Point(146, 108);
            this.label_text_connectStatus_PLC.Name = "label_text_connectStatus_PLC";
            this.label_text_connectStatus_PLC.Size = new System.Drawing.Size(66, 19);
            this.label_text_connectStatus_PLC.TabIndex = 36;
            this.label_text_connectStatus_PLC.Text = "未连接";
            // 
            // label_connectStatus_PLC
            // 
            this.label_connectStatus_PLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_connectStatus_PLC.AutoSize = true;
            this.label_connectStatus_PLC.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_connectStatus_PLC.Location = new System.Drawing.Point(79, 108);
            this.label_connectStatus_PLC.Name = "label_connectStatus_PLC";
            this.label_connectStatus_PLC.Size = new System.Drawing.Size(58, 19);
            this.label_connectStatus_PLC.TabIndex = 35;
            this.label_connectStatus_PLC.Text = "PLC：";
            // 
            // label_text__connectStatus_MES
            // 
            this.label_text__connectStatus_MES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_text__connectStatus_MES.AutoSize = true;
            this.label_text__connectStatus_MES.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text__connectStatus_MES.Location = new System.Drawing.Point(146, 55);
            this.label_text__connectStatus_MES.Name = "label_text__connectStatus_MES";
            this.label_text__connectStatus_MES.Size = new System.Drawing.Size(66, 19);
            this.label_text__connectStatus_MES.TabIndex = 34;
            this.label_text__connectStatus_MES.Text = "未连接";
            // 
            // label_connectStatus_MES
            // 
            this.label_connectStatus_MES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_connectStatus_MES.AutoSize = true;
            this.label_connectStatus_MES.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_connectStatus_MES.Location = new System.Drawing.Point(79, 55);
            this.label_connectStatus_MES.Name = "label_connectStatus_MES";
            this.label_connectStatus_MES.Size = new System.Drawing.Size(58, 19);
            this.label_connectStatus_MES.TabIndex = 33;
            this.label_connectStatus_MES.Text = "MES：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "连接状态";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(315, 720);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "当前时间：";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(425, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "2012-06-26 00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_connectStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_basicInformation);
            this.Controls.Add(this.panel_basicInformation);
            this.Controls.Add(this.menuStrip_top);
            this.Controls.Add(this.panel_log);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip_top;
            this.Name = "MainForm";
            this.Text = "扫码上传上位机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip_top.ResumeLayout(false);
            this.menuStrip_top.PerformLayout();
            this.panel_basicInformation.ResumeLayout(false);
            this.panel_basicInformation.PerformLayout();
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.panel_errorInfo.ResumeLayout(false);
            this.panel_errorInfo.PerformLayout();
            this.panel_connectStatus.ResumeLayout(false);
            this.panel_connectStatus.PerformLayout();
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
        private System.Windows.Forms.Label label_basicInformation;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ComboBox comboBox_shift;
        private System.Windows.Forms.Panel panel_basicInformation;
        public System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_top_log;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_top_Config;
        private System.Windows.Forms.Label label_mo;
        public System.Windows.Forms.TextBox textBox_errorInfo;
        private System.Windows.Forms.Panel panel_log;
        public System.Windows.Forms.TextBox textBox_mo;
        private System.Windows.Forms.Panel panel_errorInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_errorInfo;
        private System.Windows.Forms.Panel panel_connectStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_top_log_openCurrent;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_top_log_openFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_text__connectStatus_MES;
        private System.Windows.Forms.Label label_connectStatus_MES;
        private System.Windows.Forms.Label label_text_connectStatus_PLC;
        private System.Windows.Forms.Label label_connectStatus_PLC;
    }
}

