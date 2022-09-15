namespace ScanUploader.View
{
    partial class ConfigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label_logFormat = new System.Windows.Forms.Label();
            this.button_saveConfig = new System.Windows.Forms.Button();
            this.tabControl_config = new System.Windows.Forms.TabControl();
            this.tabPage_url_scan = new System.Windows.Forms.TabPage();
            this.textBox_url_submit = new System.Windows.Forms.TextBox();
            this.label_url_submit = new System.Windows.Forms.Label();
            this.textBox_url_scanContainerIn = new System.Windows.Forms.TextBox();
            this.textBox_url_scanContainerOut = new System.Windows.Forms.TextBox();
            this.textBox_url_scanSn = new System.Windows.Forms.TextBox();
            this.textBox_url_scanContainerUnbind = new System.Windows.Forms.TextBox();
            this.label_url_scanContainerIn = new System.Windows.Forms.Label();
            this.label_url_scanVehicleOut = new System.Windows.Forms.Label();
            this.label_url_scanVehicleUnbind = new System.Windows.Forms.Label();
            this.label_url_scanSn = new System.Windows.Forms.Label();
            this.tabPage_url_info = new System.Windows.Forms.TabPage();
            this.textBox_getProductModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_getMesMoList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_url_login_MES = new System.Windows.Forms.Label();
            this.textBox_url_login_MES = new System.Windows.Forms.TextBox();
            this.tabPage_logFileName = new System.Windows.Forms.TabPage();
            this.textBox_logPrefix = new System.Windows.Forms.TextBox();
            this.textBox_logDateFormat = new System.Windows.Forms.TextBox();
            this.textBox_serialFigures = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_socketPort = new System.Windows.Forms.TabPage();
            this.checkBox_socket_insert = new System.Windows.Forms.CheckBox();
            this.textBox_port_insert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_socket_IP = new System.Windows.Forms.TextBox();
            this.label_socket_IP = new System.Windows.Forms.Label();
            this.checkBox_socket_submit = new System.Windows.Forms.CheckBox();
            this.checkBox_socket_down = new System.Windows.Forms.CheckBox();
            this.checkBox_socket_main = new System.Windows.Forms.CheckBox();
            this.checkBox_socket_up = new System.Windows.Forms.CheckBox();
            this.textBox_port_up = new System.Windows.Forms.TextBox();
            this.textBox_port_submit = new System.Windows.Forms.TextBox();
            this.textBox_port_main = new System.Windows.Forms.TextBox();
            this.textBox_port_down = new System.Windows.Forms.TextBox();
            this.label_port_up = new System.Windows.Forms.Label();
            this.label_port_submit = new System.Windows.Forms.Label();
            this.label_port_main = new System.Windows.Forms.Label();
            this.label_port_down = new System.Windows.Forms.Label();
            this.button_restoreConfig = new System.Windows.Forms.Button();
            this.tabControl_config.SuspendLayout();
            this.tabPage_url_scan.SuspendLayout();
            this.tabPage_url_info.SuspendLayout();
            this.tabPage_logFileName.SuspendLayout();
            this.tabPage_socketPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1156, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "确 定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_logFormat
            // 
            this.label_logFormat.AutoSize = true;
            this.label_logFormat.Location = new System.Drawing.Point(424, 481);
            this.label_logFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_logFormat.Name = "label_logFormat";
            this.label_logFormat.Size = new System.Drawing.Size(0, 15);
            this.label_logFormat.TabIndex = 16;
            // 
            // button_saveConfig
            // 
            this.button_saveConfig.Location = new System.Drawing.Point(411, 377);
            this.button_saveConfig.Margin = new System.Windows.Forms.Padding(4);
            this.button_saveConfig.Name = "button_saveConfig";
            this.button_saveConfig.Size = new System.Drawing.Size(99, 41);
            this.button_saveConfig.TabIndex = 22;
            this.button_saveConfig.Text = "保 存";
            this.button_saveConfig.UseVisualStyleBackColor = true;
            this.button_saveConfig.Click += new System.EventHandler(this.button_saveConfig_Click);
            // 
            // tabControl_config
            // 
            this.tabControl_config.Controls.Add(this.tabPage_url_scan);
            this.tabControl_config.Controls.Add(this.tabPage_url_info);
            this.tabControl_config.Controls.Add(this.tabPage_logFileName);
            this.tabControl_config.Controls.Add(this.tabPage_socketPort);
            this.tabControl_config.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_config.Location = new System.Drawing.Point(0, 0);
            this.tabControl_config.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_config.Name = "tabControl_config";
            this.tabControl_config.SelectedIndex = 0;
            this.tabControl_config.Size = new System.Drawing.Size(678, 359);
            this.tabControl_config.TabIndex = 26;
            // 
            // tabPage_url_scan
            // 
            this.tabPage_url_scan.Controls.Add(this.textBox_url_submit);
            this.tabPage_url_scan.Controls.Add(this.label_url_submit);
            this.tabPage_url_scan.Controls.Add(this.textBox_url_scanContainerIn);
            this.tabPage_url_scan.Controls.Add(this.textBox_url_scanContainerOut);
            this.tabPage_url_scan.Controls.Add(this.textBox_url_scanSn);
            this.tabPage_url_scan.Controls.Add(this.textBox_url_scanContainerUnbind);
            this.tabPage_url_scan.Controls.Add(this.label_url_scanContainerIn);
            this.tabPage_url_scan.Controls.Add(this.label_url_scanVehicleOut);
            this.tabPage_url_scan.Controls.Add(this.label_url_scanVehicleUnbind);
            this.tabPage_url_scan.Controls.Add(this.label_url_scanSn);
            this.tabPage_url_scan.Location = new System.Drawing.Point(4, 25);
            this.tabPage_url_scan.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_url_scan.Name = "tabPage_url_scan";
            this.tabPage_url_scan.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_url_scan.Size = new System.Drawing.Size(670, 330);
            this.tabPage_url_scan.TabIndex = 0;
            this.tabPage_url_scan.Text = "扫码URL";
            this.tabPage_url_scan.UseVisualStyleBackColor = true;
            // 
            // textBox_url_submit
            // 
            this.textBox_url_submit.Location = new System.Drawing.Point(145, 193);
            this.textBox_url_submit.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_submit.Name = "textBox_url_submit";
            this.textBox_url_submit.Size = new System.Drawing.Size(492, 25);
            this.textBox_url_submit.TabIndex = 32;
            // 
            // label_url_submit
            // 
            this.label_url_submit.AutoSize = true;
            this.label_url_submit.Location = new System.Drawing.Point(25, 200);
            this.label_url_submit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_submit.Name = "label_url_submit";
            this.label_url_submit.Size = new System.Drawing.Size(52, 15);
            this.label_url_submit.TabIndex = 31;
            this.label_url_submit.Text = "提交：";
            // 
            // textBox_url_scanContainerIn
            // 
            this.textBox_url_scanContainerIn.Location = new System.Drawing.Point(145, 148);
            this.textBox_url_scanContainerIn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_scanContainerIn.Name = "textBox_url_scanContainerIn";
            this.textBox_url_scanContainerIn.Size = new System.Drawing.Size(492, 25);
            this.textBox_url_scanContainerIn.TabIndex = 24;
            // 
            // textBox_url_scanContainerOut
            // 
            this.textBox_url_scanContainerOut.Location = new System.Drawing.Point(145, 57);
            this.textBox_url_scanContainerOut.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_scanContainerOut.Name = "textBox_url_scanContainerOut";
            this.textBox_url_scanContainerOut.Size = new System.Drawing.Size(492, 25);
            this.textBox_url_scanContainerOut.TabIndex = 26;
            // 
            // textBox_url_scanSn
            // 
            this.textBox_url_scanSn.Location = new System.Drawing.Point(145, 103);
            this.textBox_url_scanSn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_scanSn.Name = "textBox_url_scanSn";
            this.textBox_url_scanSn.Size = new System.Drawing.Size(492, 25);
            this.textBox_url_scanSn.TabIndex = 30;
            // 
            // textBox_url_scanContainerUnbind
            // 
            this.textBox_url_scanContainerUnbind.Location = new System.Drawing.Point(145, 246);
            this.textBox_url_scanContainerUnbind.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_scanContainerUnbind.Name = "textBox_url_scanContainerUnbind";
            this.textBox_url_scanContainerUnbind.Size = new System.Drawing.Size(492, 25);
            this.textBox_url_scanContainerUnbind.TabIndex = 28;
            // 
            // label_url_scanContainerIn
            // 
            this.label_url_scanContainerIn.AutoSize = true;
            this.label_url_scanContainerIn.Location = new System.Drawing.Point(25, 154);
            this.label_url_scanContainerIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_scanContainerIn.Name = "label_url_scanContainerIn";
            this.label_url_scanContainerIn.Size = new System.Drawing.Size(112, 15);
            this.label_url_scanContainerIn.TabIndex = 23;
            this.label_url_scanContainerIn.Text = "下料载具扫码：";
            // 
            // label_url_scanVehicleOut
            // 
            this.label_url_scanVehicleOut.AutoSize = true;
            this.label_url_scanVehicleOut.Location = new System.Drawing.Point(25, 64);
            this.label_url_scanVehicleOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_scanVehicleOut.Name = "label_url_scanVehicleOut";
            this.label_url_scanVehicleOut.Size = new System.Drawing.Size(112, 15);
            this.label_url_scanVehicleOut.TabIndex = 25;
            this.label_url_scanVehicleOut.Text = "上料载具扫码：";
            // 
            // label_url_scanVehicleUnbind
            // 
            this.label_url_scanVehicleUnbind.AutoSize = true;
            this.label_url_scanVehicleUnbind.Location = new System.Drawing.Point(25, 253);
            this.label_url_scanVehicleUnbind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_scanVehicleUnbind.Name = "label_url_scanVehicleUnbind";
            this.label_url_scanVehicleUnbind.Size = new System.Drawing.Size(112, 15);
            this.label_url_scanVehicleUnbind.TabIndex = 27;
            this.label_url_scanVehicleUnbind.Text = "上料载具解绑：";
            // 
            // label_url_scanSn
            // 
            this.label_url_scanSn.AutoSize = true;
            this.label_url_scanSn.Location = new System.Drawing.Point(25, 110);
            this.label_url_scanSn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_scanSn.Name = "label_url_scanSn";
            this.label_url_scanSn.Size = new System.Drawing.Size(98, 15);
            this.label_url_scanSn.TabIndex = 29;
            this.label_url_scanSn.Text = "SN扫码校验：";
            // 
            // tabPage_url_info
            // 
            this.tabPage_url_info.Controls.Add(this.textBox_getProductModel);
            this.tabPage_url_info.Controls.Add(this.label5);
            this.tabPage_url_info.Controls.Add(this.textBox_getMesMoList);
            this.tabPage_url_info.Controls.Add(this.label3);
            this.tabPage_url_info.Controls.Add(this.label_url_login_MES);
            this.tabPage_url_info.Controls.Add(this.textBox_url_login_MES);
            this.tabPage_url_info.Location = new System.Drawing.Point(4, 25);
            this.tabPage_url_info.Name = "tabPage_url_info";
            this.tabPage_url_info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_url_info.Size = new System.Drawing.Size(670, 330);
            this.tabPage_url_info.TabIndex = 4;
            this.tabPage_url_info.Text = "信息URL";
            this.tabPage_url_info.UseVisualStyleBackColor = true;
            // 
            // textBox_getProductModel
            // 
            this.textBox_getProductModel.Location = new System.Drawing.Point(185, 110);
            this.textBox_getProductModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_getProductModel.Name = "textBox_getProductModel";
            this.textBox_getProductModel.Size = new System.Drawing.Size(420, 25);
            this.textBox_getProductModel.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "获取产品型号：";
            // 
            // textBox_getMesMoList
            // 
            this.textBox_getMesMoList.Location = new System.Drawing.Point(185, 143);
            this.textBox_getMesMoList.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_getMesMoList.Name = "textBox_getMesMoList";
            this.textBox_getMesMoList.Size = new System.Drawing.Size(420, 25);
            this.textBox_getMesMoList.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "自动获取工单：";
            // 
            // label_url_login_MES
            // 
            this.label_url_login_MES.AutoSize = true;
            this.label_url_login_MES.Location = new System.Drawing.Point(65, 71);
            this.label_url_login_MES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_login_MES.Name = "label_url_login_MES";
            this.label_url_login_MES.Size = new System.Drawing.Size(76, 15);
            this.label_url_login_MES.TabIndex = 43;
            this.label_url_login_MES.Text = "MES登录：";
            // 
            // textBox_url_login_MES
            // 
            this.textBox_url_login_MES.Location = new System.Drawing.Point(185, 61);
            this.textBox_url_login_MES.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_login_MES.Name = "textBox_url_login_MES";
            this.textBox_url_login_MES.Size = new System.Drawing.Size(420, 25);
            this.textBox_url_login_MES.TabIndex = 44;
            // 
            // tabPage_logFileName
            // 
            this.tabPage_logFileName.Controls.Add(this.textBox_logPrefix);
            this.tabPage_logFileName.Controls.Add(this.textBox_logDateFormat);
            this.tabPage_logFileName.Controls.Add(this.textBox_serialFigures);
            this.tabPage_logFileName.Controls.Add(this.label4);
            this.tabPage_logFileName.Controls.Add(this.label6);
            this.tabPage_logFileName.Controls.Add(this.label7);
            this.tabPage_logFileName.Location = new System.Drawing.Point(4, 25);
            this.tabPage_logFileName.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_logFileName.Name = "tabPage_logFileName";
            this.tabPage_logFileName.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_logFileName.Size = new System.Drawing.Size(670, 330);
            this.tabPage_logFileName.TabIndex = 3;
            this.tabPage_logFileName.Text = "Log文件名格式";
            this.tabPage_logFileName.UseVisualStyleBackColor = true;
            // 
            // textBox_logPrefix
            // 
            this.textBox_logPrefix.Location = new System.Drawing.Point(325, 96);
            this.textBox_logPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_logPrefix.Name = "textBox_logPrefix";
            this.textBox_logPrefix.Size = new System.Drawing.Size(160, 25);
            this.textBox_logPrefix.TabIndex = 11;
            this.textBox_logPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_logDateFormat
            // 
            this.textBox_logDateFormat.Location = new System.Drawing.Point(325, 148);
            this.textBox_logDateFormat.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_logDateFormat.Name = "textBox_logDateFormat";
            this.textBox_logDateFormat.Size = new System.Drawing.Size(160, 25);
            this.textBox_logDateFormat.TabIndex = 13;
            this.textBox_logDateFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_serialFigures
            // 
            this.textBox_serialFigures.Location = new System.Drawing.Point(325, 204);
            this.textBox_serialFigures.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_serialFigures.Name = "textBox_serialFigures";
            this.textBox_serialFigures.Size = new System.Drawing.Size(160, 25);
            this.textBox_serialFigures.TabIndex = 15;
            this.textBox_serialFigures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "前缀：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "日期格式：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "流水号位数：";
            // 
            // tabPage_socketPort
            // 
            this.tabPage_socketPort.Controls.Add(this.checkBox_socket_insert);
            this.tabPage_socketPort.Controls.Add(this.textBox_port_insert);
            this.tabPage_socketPort.Controls.Add(this.label1);
            this.tabPage_socketPort.Controls.Add(this.label2);
            this.tabPage_socketPort.Controls.Add(this.textBox_socket_IP);
            this.tabPage_socketPort.Controls.Add(this.label_socket_IP);
            this.tabPage_socketPort.Controls.Add(this.checkBox_socket_submit);
            this.tabPage_socketPort.Controls.Add(this.checkBox_socket_down);
            this.tabPage_socketPort.Controls.Add(this.checkBox_socket_main);
            this.tabPage_socketPort.Controls.Add(this.checkBox_socket_up);
            this.tabPage_socketPort.Controls.Add(this.textBox_port_up);
            this.tabPage_socketPort.Controls.Add(this.textBox_port_submit);
            this.tabPage_socketPort.Controls.Add(this.textBox_port_main);
            this.tabPage_socketPort.Controls.Add(this.textBox_port_down);
            this.tabPage_socketPort.Controls.Add(this.label_port_up);
            this.tabPage_socketPort.Controls.Add(this.label_port_submit);
            this.tabPage_socketPort.Controls.Add(this.label_port_main);
            this.tabPage_socketPort.Controls.Add(this.label_port_down);
            this.tabPage_socketPort.Location = new System.Drawing.Point(4, 25);
            this.tabPage_socketPort.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_socketPort.Name = "tabPage_socketPort";
            this.tabPage_socketPort.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_socketPort.Size = new System.Drawing.Size(670, 330);
            this.tabPage_socketPort.TabIndex = 1;
            this.tabPage_socketPort.Text = "Socket端口";
            this.tabPage_socketPort.UseVisualStyleBackColor = true;
            // 
            // checkBox_socket_insert
            // 
            this.checkBox_socket_insert.AutoSize = true;
            this.checkBox_socket_insert.Location = new System.Drawing.Point(486, 235);
            this.checkBox_socket_insert.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_socket_insert.Name = "checkBox_socket_insert";
            this.checkBox_socket_insert.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_insert.TabIndex = 34;
            this.checkBox_socket_insert.UseVisualStyleBackColor = true;
            // 
            // textBox_port_insert
            // 
            this.textBox_port_insert.Location = new System.Drawing.Point(299, 225);
            this.textBox_port_insert.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_insert.Name = "textBox_port_insert";
            this.textBox_port_insert.Size = new System.Drawing.Size(160, 25);
            this.textBox_port_insert.TabIndex = 33;
            this.textBox_port_insert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "插架";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(173, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "端口：";
            // 
            // textBox_socket_IP
            // 
            this.textBox_socket_IP.Location = new System.Drawing.Point(227, 35);
            this.textBox_socket_IP.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_socket_IP.Name = "textBox_socket_IP";
            this.textBox_socket_IP.Size = new System.Drawing.Size(232, 25);
            this.textBox_socket_IP.TabIndex = 30;
            this.textBox_socket_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_socket_IP
            // 
            this.label_socket_IP.AutoSize = true;
            this.label_socket_IP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socket_IP.Location = new System.Drawing.Point(173, 37);
            this.label_socket_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_socket_IP.Name = "label_socket_IP";
            this.label_socket_IP.Size = new System.Drawing.Size(41, 15);
            this.label_socket_IP.TabIndex = 29;
            this.label_socket_IP.Text = "IP：";
            // 
            // checkBox_socket_submit
            // 
            this.checkBox_socket_submit.AutoSize = true;
            this.checkBox_socket_submit.Location = new System.Drawing.Point(486, 281);
            this.checkBox_socket_submit.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_socket_submit.Name = "checkBox_socket_submit";
            this.checkBox_socket_submit.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_submit.TabIndex = 28;
            this.checkBox_socket_submit.UseVisualStyleBackColor = true;
            // 
            // checkBox_socket_down
            // 
            this.checkBox_socket_down.AutoSize = true;
            this.checkBox_socket_down.Location = new System.Drawing.Point(486, 183);
            this.checkBox_socket_down.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_socket_down.Name = "checkBox_socket_down";
            this.checkBox_socket_down.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_down.TabIndex = 27;
            this.checkBox_socket_down.UseVisualStyleBackColor = true;
            // 
            // checkBox_socket_main
            // 
            this.checkBox_socket_main.AutoSize = true;
            this.checkBox_socket_main.Location = new System.Drawing.Point(486, 139);
            this.checkBox_socket_main.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_socket_main.Name = "checkBox_socket_main";
            this.checkBox_socket_main.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_main.TabIndex = 26;
            this.checkBox_socket_main.UseVisualStyleBackColor = true;
            // 
            // checkBox_socket_up
            // 
            this.checkBox_socket_up.AutoSize = true;
            this.checkBox_socket_up.Location = new System.Drawing.Point(486, 92);
            this.checkBox_socket_up.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_socket_up.Name = "checkBox_socket_up";
            this.checkBox_socket_up.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_up.TabIndex = 25;
            this.checkBox_socket_up.UseVisualStyleBackColor = true;
            // 
            // textBox_port_up
            // 
            this.textBox_port_up.Location = new System.Drawing.Point(299, 85);
            this.textBox_port_up.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_up.Name = "textBox_port_up";
            this.textBox_port_up.Size = new System.Drawing.Size(160, 25);
            this.textBox_port_up.TabIndex = 18;
            this.textBox_port_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_port_submit
            // 
            this.textBox_port_submit.Location = new System.Drawing.Point(299, 271);
            this.textBox_port_submit.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_submit.Name = "textBox_port_submit";
            this.textBox_port_submit.Size = new System.Drawing.Size(160, 25);
            this.textBox_port_submit.TabIndex = 20;
            this.textBox_port_submit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_port_main
            // 
            this.textBox_port_main.Location = new System.Drawing.Point(299, 133);
            this.textBox_port_main.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_main.Name = "textBox_port_main";
            this.textBox_port_main.Size = new System.Drawing.Size(160, 25);
            this.textBox_port_main.TabIndex = 22;
            this.textBox_port_main.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_port_down
            // 
            this.textBox_port_down.Location = new System.Drawing.Point(299, 178);
            this.textBox_port_down.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_down.Name = "textBox_port_down";
            this.textBox_port_down.Size = new System.Drawing.Size(160, 25);
            this.textBox_port_down.TabIndex = 24;
            this.textBox_port_down.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_port_up
            // 
            this.label_port_up.AutoSize = true;
            this.label_port_up.Location = new System.Drawing.Point(234, 94);
            this.label_port_up.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_port_up.Name = "label_port_up";
            this.label_port_up.Size = new System.Drawing.Size(37, 15);
            this.label_port_up.TabIndex = 17;
            this.label_port_up.Text = "上料";
            // 
            // label_port_submit
            // 
            this.label_port_submit.AutoSize = true;
            this.label_port_submit.Location = new System.Drawing.Point(234, 278);
            this.label_port_submit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_port_submit.Name = "label_port_submit";
            this.label_port_submit.Size = new System.Drawing.Size(37, 15);
            this.label_port_submit.TabIndex = 19;
            this.label_port_submit.Text = "提交";
            // 
            // label_port_main
            // 
            this.label_port_main.AutoSize = true;
            this.label_port_main.Location = new System.Drawing.Point(234, 142);
            this.label_port_main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_port_main.Name = "label_port_main";
            this.label_port_main.Size = new System.Drawing.Size(37, 15);
            this.label_port_main.TabIndex = 21;
            this.label_port_main.Text = "主体";
            // 
            // label_port_down
            // 
            this.label_port_down.AutoSize = true;
            this.label_port_down.Location = new System.Drawing.Point(234, 187);
            this.label_port_down.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_port_down.Name = "label_port_down";
            this.label_port_down.Size = new System.Drawing.Size(37, 15);
            this.label_port_down.TabIndex = 23;
            this.label_port_down.Text = "下料";
            // 
            // button_restoreConfig
            // 
            this.button_restoreConfig.Location = new System.Drawing.Point(158, 377);
            this.button_restoreConfig.Margin = new System.Windows.Forms.Padding(4);
            this.button_restoreConfig.Name = "button_restoreConfig";
            this.button_restoreConfig.Size = new System.Drawing.Size(99, 41);
            this.button_restoreConfig.TabIndex = 28;
            this.button_restoreConfig.Text = "还 原";
            this.button_restoreConfig.UseVisualStyleBackColor = true;
            this.button_restoreConfig.Click += new System.EventHandler(this.Button_RestoreConfig_Click);
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 437);
            this.Controls.Add(this.button_restoreConfig);
            this.Controls.Add(this.tabControl_config);
            this.Controls.Add(this.button_saveConfig);
            this.Controls.Add(this.label_logFormat);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置";
            this.tabControl_config.ResumeLayout(false);
            this.tabPage_url_scan.ResumeLayout(false);
            this.tabPage_url_scan.PerformLayout();
            this.tabPage_url_info.ResumeLayout(false);
            this.tabPage_url_info.PerformLayout();
            this.tabPage_logFileName.ResumeLayout(false);
            this.tabPage_logFileName.PerformLayout();
            this.tabPage_socketPort.ResumeLayout(false);
            this.tabPage_socketPort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_logFormat;
        private System.Windows.Forms.TabControl tabControl_config;
        private System.Windows.Forms.TabPage tabPage_url_scan;
        private System.Windows.Forms.TabPage tabPage_socketPort;
        private System.Windows.Forms.TabPage tabPage_logFileName;
        public System.Windows.Forms.Button button_saveConfig;
        public System.Windows.Forms.Button button_restoreConfig;
        private System.Windows.Forms.TextBox textBox_url_submit;
        private System.Windows.Forms.Label label_url_submit;
        private System.Windows.Forms.TextBox textBox_url_scanContainerIn;
        private System.Windows.Forms.TextBox textBox_url_scanContainerOut;
        private System.Windows.Forms.TextBox textBox_url_scanSn;
        private System.Windows.Forms.TextBox textBox_url_scanContainerUnbind;
        private System.Windows.Forms.Label label_url_scanContainerIn;
        private System.Windows.Forms.Label label_url_scanVehicleOut;
        private System.Windows.Forms.Label label_url_scanVehicleUnbind;
        private System.Windows.Forms.Label label_url_scanSn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_socket_IP;
        private System.Windows.Forms.Label label_socket_IP;
        private System.Windows.Forms.CheckBox checkBox_socket_submit;
        private System.Windows.Forms.CheckBox checkBox_socket_down;
        private System.Windows.Forms.CheckBox checkBox_socket_main;
        private System.Windows.Forms.CheckBox checkBox_socket_up;
        private System.Windows.Forms.TextBox textBox_port_up;
        private System.Windows.Forms.TextBox textBox_port_submit;
        private System.Windows.Forms.TextBox textBox_port_main;
        private System.Windows.Forms.TextBox textBox_port_down;
        private System.Windows.Forms.Label label_port_up;
        private System.Windows.Forms.Label label_port_submit;
        private System.Windows.Forms.Label label_port_main;
        private System.Windows.Forms.Label label_port_down;
        private System.Windows.Forms.CheckBox checkBox_socket_insert;
        private System.Windows.Forms.TextBox textBox_port_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_logPrefix;
        private System.Windows.Forms.TextBox textBox_logDateFormat;
        private System.Windows.Forms.TextBox textBox_serialFigures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage_url_info;
        private System.Windows.Forms.TextBox textBox_getProductModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_getMesMoList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_url_login_MES;
        private System.Windows.Forms.TextBox textBox_url_login_MES;
    }
}