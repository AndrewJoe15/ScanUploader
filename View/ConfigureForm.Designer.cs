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
            this.panel_url = new System.Windows.Forms.Panel();
            this.textBox_validate_WMS = new System.Windows.Forms.TextBox();
            this.label_validate_WMS = new System.Windows.Forms.Label();
            this.textBox_stockQuery_WMS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_url_subPrefix_MES = new System.Windows.Forms.TextBox();
            this.label_url_subPrefix = new System.Windows.Forms.Label();
            this.textBox_url_prefix = new System.Windows.Forms.TextBox();
            this.label_url_prefix = new System.Windows.Forms.Label();
            this.textBox_url_postfix_submit = new System.Windows.Forms.TextBox();
            this.label_url_submit = new System.Windows.Forms.Label();
            this.textBox_url_postfix_scanContainerIn = new System.Windows.Forms.TextBox();
            this.textBox_url_postfix_scanContainerOut = new System.Windows.Forms.TextBox();
            this.textBox_url_postfix_scanSn = new System.Windows.Forms.TextBox();
            this.textBox_url_postfix_scanContainerUnbind = new System.Windows.Forms.TextBox();
            this.label_url_scanContainerIn = new System.Windows.Forms.Label();
            this.label_url_scanVehicleOut = new System.Windows.Forms.Label();
            this.label_url_scanVehicleUnbind = new System.Windows.Forms.Label();
            this.label_url_scanSn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_port = new System.Windows.Forms.Panel();
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
            this.panel_logFormat = new System.Windows.Forms.Panel();
            this.textBox_logPrefix = new System.Windows.Forms.TextBox();
            this.textBox_logDateFormat = new System.Windows.Forms.TextBox();
            this.textBox_serialFigures = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_logFormat = new System.Windows.Forms.Label();
            this.button_saveConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_httpSite_MES = new System.Windows.Forms.TextBox();
            this.label_httpSite = new System.Windows.Forms.Label();
            this.textBox_httpUserName_MES = new System.Windows.Forms.TextBox();
            this.textBox_httpPassword_MES = new System.Windows.Forms.TextBox();
            this.label_httpUserName = new System.Windows.Forms.Label();
            this.label_httpPassword = new System.Windows.Forms.Label();
            this.tabControl_config = new System.Windows.Forms.TabControl();
            this.tabPage_url = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton_BDS = new System.Windows.Forms.RadioButton();
            this.radioButton_Chemical = new System.Windows.Forms.RadioButton();
            this.radioButton_Kibble = new System.Windows.Forms.RadioButton();
            this.tabPage_socketPort = new System.Windows.Forms.TabPage();
            this.tabPage_httpUser = new System.Windows.Forms.TabPage();
            this.label_url_login_WMS = new System.Windows.Forms.Label();
            this.textBox_url_login_WMS = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_httpUserName_WMS = new System.Windows.Forms.TextBox();
            this.textBox_httpPassword_WMS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_url_login_MES = new System.Windows.Forms.Label();
            this.textBox_url_login_MES = new System.Windows.Forms.TextBox();
            this.tabPage_logFileName = new System.Windows.Forms.TabPage();
            this.button_restoreConfig = new System.Windows.Forms.Button();
            this.panel_url.SuspendLayout();
            this.panel_port.SuspendLayout();
            this.panel_logFormat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl_config.SuspendLayout();
            this.tabPage_url.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage_socketPort.SuspendLayout();
            this.tabPage_httpUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage_logFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_url
            // 
            this.panel_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_url.Controls.Add(this.textBox_validate_WMS);
            this.panel_url.Controls.Add(this.label_validate_WMS);
            this.panel_url.Controls.Add(this.textBox_stockQuery_WMS);
            this.panel_url.Controls.Add(this.label5);
            this.panel_url.Controls.Add(this.textBox_url_subPrefix_MES);
            this.panel_url.Controls.Add(this.label_url_subPrefix);
            this.panel_url.Controls.Add(this.textBox_url_prefix);
            this.panel_url.Controls.Add(this.label_url_prefix);
            this.panel_url.Controls.Add(this.textBox_url_postfix_submit);
            this.panel_url.Controls.Add(this.label_url_submit);
            this.panel_url.Controls.Add(this.textBox_url_postfix_scanContainerIn);
            this.panel_url.Controls.Add(this.textBox_url_postfix_scanContainerOut);
            this.panel_url.Controls.Add(this.textBox_url_postfix_scanSn);
            this.panel_url.Controls.Add(this.textBox_url_postfix_scanContainerUnbind);
            this.panel_url.Controls.Add(this.label_url_scanContainerIn);
            this.panel_url.Controls.Add(this.label_url_scanVehicleOut);
            this.panel_url.Controls.Add(this.label_url_scanVehicleUnbind);
            this.panel_url.Controls.Add(this.label_url_scanSn);
            this.panel_url.Location = new System.Drawing.Point(26, 7);
            this.panel_url.Margin = new System.Windows.Forms.Padding(4);
            this.panel_url.Name = "panel_url";
            this.panel_url.Size = new System.Drawing.Size(683, 464);
            this.panel_url.TabIndex = 19;
            // 
            // textBox_validate_WMS
            // 
            this.textBox_validate_WMS.Location = new System.Drawing.Point(142, 414);
            this.textBox_validate_WMS.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_validate_WMS.Name = "textBox_validate_WMS";
            this.textBox_validate_WMS.Size = new System.Drawing.Size(515, 28);
            this.textBox_validate_WMS.TabIndex = 26;
            this.textBox_validate_WMS.TextChanged += new System.EventHandler(this.textBox_validate_WMS_TextChanged);
            // 
            // label_validate_WMS
            // 
            this.label_validate_WMS.AutoSize = true;
            this.label_validate_WMS.Location = new System.Drawing.Point(37, 421);
            this.label_validate_WMS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_validate_WMS.Name = "label_validate_WMS";
            this.label_validate_WMS.Size = new System.Drawing.Size(62, 18);
            this.label_validate_WMS.TabIndex = 25;
            this.label_validate_WMS.Text = "验证：";
            // 
            // textBox_stockQuery_WMS
            // 
            this.textBox_stockQuery_WMS.Location = new System.Drawing.Point(142, 367);
            this.textBox_stockQuery_WMS.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_stockQuery_WMS.Name = "textBox_stockQuery_WMS";
            this.textBox_stockQuery_WMS.Size = new System.Drawing.Size(515, 28);
            this.textBox_stockQuery_WMS.TabIndex = 24;
            this.textBox_stockQuery_WMS.TextChanged += new System.EventHandler(this.textBox_stockQuery_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "库存查询：";
            // 
            // textBox_url_subPrefix_MES
            // 
            this.textBox_url_subPrefix_MES.Location = new System.Drawing.Point(216, 62);
            this.textBox_url_subPrefix_MES.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_subPrefix_MES.Name = "textBox_url_subPrefix_MES";
            this.textBox_url_subPrefix_MES.Size = new System.Drawing.Size(294, 28);
            this.textBox_url_subPrefix_MES.TabIndex = 22;
            this.textBox_url_subPrefix_MES.TextChanged += new System.EventHandler(this.textBox_url_subPrefix_MES_TextChanged);
            // 
            // label_url_subPrefix
            // 
            this.label_url_subPrefix.AutoSize = true;
            this.label_url_subPrefix.Location = new System.Drawing.Point(111, 69);
            this.label_url_subPrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_subPrefix.Name = "label_url_subPrefix";
            this.label_url_subPrefix.Size = new System.Drawing.Size(107, 18);
            this.label_url_subPrefix.TabIndex = 21;
            this.label_url_subPrefix.Text = "MES子前缀：";
            // 
            // textBox_url_prefix
            // 
            this.textBox_url_prefix.Location = new System.Drawing.Point(142, 14);
            this.textBox_url_prefix.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_prefix.Name = "textBox_url_prefix";
            this.textBox_url_prefix.Size = new System.Drawing.Size(314, 28);
            this.textBox_url_prefix.TabIndex = 20;
            this.textBox_url_prefix.TextChanged += new System.EventHandler(this.textBox_url_prefix_TextChanged);
            // 
            // label_url_prefix
            // 
            this.label_url_prefix.AutoSize = true;
            this.label_url_prefix.Location = new System.Drawing.Point(37, 21);
            this.label_url_prefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_prefix.Name = "label_url_prefix";
            this.label_url_prefix.Size = new System.Drawing.Size(89, 18);
            this.label_url_prefix.TabIndex = 19;
            this.label_url_prefix.Text = "URL前缀：";
            // 
            // textBox_url_postfix_submit
            // 
            this.textBox_url_postfix_submit.Location = new System.Drawing.Point(339, 311);
            this.textBox_url_postfix_submit.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_postfix_submit.Name = "textBox_url_postfix_submit";
            this.textBox_url_postfix_submit.Size = new System.Drawing.Size(318, 28);
            this.textBox_url_postfix_submit.TabIndex = 18;
            this.textBox_url_postfix_submit.TextChanged += new System.EventHandler(this.textBox_url_postfix_submit_TextChanged);
            // 
            // label_url_submit
            // 
            this.label_url_submit.AutoSize = true;
            this.label_url_submit.Location = new System.Drawing.Point(234, 318);
            this.label_url_submit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_submit.Name = "label_url_submit";
            this.label_url_submit.Size = new System.Drawing.Size(62, 18);
            this.label_url_submit.TabIndex = 17;
            this.label_url_submit.Text = "提交：";
            // 
            // textBox_url_postfix_scanContainerIn
            // 
            this.textBox_url_postfix_scanContainerIn.Location = new System.Drawing.Point(339, 210);
            this.textBox_url_postfix_scanContainerIn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_postfix_scanContainerIn.Name = "textBox_url_postfix_scanContainerIn";
            this.textBox_url_postfix_scanContainerIn.Size = new System.Drawing.Size(318, 28);
            this.textBox_url_postfix_scanContainerIn.TabIndex = 3;
            this.textBox_url_postfix_scanContainerIn.TextChanged += new System.EventHandler(this.textBox_url_postfix_scanContainerIn_TextChanged);
            // 
            // textBox_url_postfix_scanContainerOut
            // 
            this.textBox_url_postfix_scanContainerOut.Location = new System.Drawing.Point(339, 110);
            this.textBox_url_postfix_scanContainerOut.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_postfix_scanContainerOut.Name = "textBox_url_postfix_scanContainerOut";
            this.textBox_url_postfix_scanContainerOut.Size = new System.Drawing.Size(318, 28);
            this.textBox_url_postfix_scanContainerOut.TabIndex = 5;
            this.textBox_url_postfix_scanContainerOut.TextChanged += new System.EventHandler(this.textBox_url_postfix_scanContainerOut_TextChanged);
            // 
            // textBox_url_postfix_scanSn
            // 
            this.textBox_url_postfix_scanSn.Location = new System.Drawing.Point(339, 162);
            this.textBox_url_postfix_scanSn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_postfix_scanSn.Name = "textBox_url_postfix_scanSn";
            this.textBox_url_postfix_scanSn.Size = new System.Drawing.Size(318, 28);
            this.textBox_url_postfix_scanSn.TabIndex = 9;
            this.textBox_url_postfix_scanSn.TextChanged += new System.EventHandler(this.textBox_url_postfix_scanSn_TextChanged);
            // 
            // textBox_url_postfix_scanContainerUnbind
            // 
            this.textBox_url_postfix_scanContainerUnbind.Location = new System.Drawing.Point(339, 259);
            this.textBox_url_postfix_scanContainerUnbind.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_postfix_scanContainerUnbind.Name = "textBox_url_postfix_scanContainerUnbind";
            this.textBox_url_postfix_scanContainerUnbind.Size = new System.Drawing.Size(318, 28);
            this.textBox_url_postfix_scanContainerUnbind.TabIndex = 7;
            this.textBox_url_postfix_scanContainerUnbind.TextChanged += new System.EventHandler(this.textBox_url_postfix_scanContainerUnbind_TextChanged);
            // 
            // label_url_scanContainerIn
            // 
            this.label_url_scanContainerIn.AutoSize = true;
            this.label_url_scanContainerIn.Location = new System.Drawing.Point(234, 216);
            this.label_url_scanContainerIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_scanContainerIn.Name = "label_url_scanContainerIn";
            this.label_url_scanContainerIn.Size = new System.Drawing.Size(98, 18);
            this.label_url_scanContainerIn.TabIndex = 2;
            this.label_url_scanContainerIn.Text = "扫入载具：";
            // 
            // label_url_scanVehicleOut
            // 
            this.label_url_scanVehicleOut.AutoSize = true;
            this.label_url_scanVehicleOut.Location = new System.Drawing.Point(234, 117);
            this.label_url_scanVehicleOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_scanVehicleOut.Name = "label_url_scanVehicleOut";
            this.label_url_scanVehicleOut.Size = new System.Drawing.Size(98, 18);
            this.label_url_scanVehicleOut.TabIndex = 4;
            this.label_url_scanVehicleOut.Text = "扫出载具：";
            // 
            // label_url_scanVehicleUnbind
            // 
            this.label_url_scanVehicleUnbind.AutoSize = true;
            this.label_url_scanVehicleUnbind.Location = new System.Drawing.Point(234, 266);
            this.label_url_scanVehicleUnbind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_scanVehicleUnbind.Name = "label_url_scanVehicleUnbind";
            this.label_url_scanVehicleUnbind.Size = new System.Drawing.Size(98, 18);
            this.label_url_scanVehicleUnbind.TabIndex = 6;
            this.label_url_scanVehicleUnbind.Text = "载具解绑：";
            // 
            // label_url_scanSn
            // 
            this.label_url_scanSn.AutoSize = true;
            this.label_url_scanSn.Location = new System.Drawing.Point(234, 169);
            this.label_url_scanSn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_scanSn.Name = "label_url_scanSn";
            this.label_url_scanSn.Size = new System.Drawing.Size(80, 18);
            this.label_url_scanSn.TabIndex = 8;
            this.label_url_scanSn.Text = "SN校验：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1012, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "确 定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel_port
            // 
            this.panel_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_port.Controls.Add(this.label2);
            this.panel_port.Controls.Add(this.textBox_socket_IP);
            this.panel_port.Controls.Add(this.label_socket_IP);
            this.panel_port.Controls.Add(this.checkBox_socket_submit);
            this.panel_port.Controls.Add(this.checkBox_socket_down);
            this.panel_port.Controls.Add(this.checkBox_socket_main);
            this.panel_port.Controls.Add(this.checkBox_socket_up);
            this.panel_port.Controls.Add(this.textBox_port_up);
            this.panel_port.Controls.Add(this.textBox_port_submit);
            this.panel_port.Controls.Add(this.textBox_port_main);
            this.panel_port.Controls.Add(this.textBox_port_down);
            this.panel_port.Controls.Add(this.label_port_up);
            this.panel_port.Controls.Add(this.label_port_submit);
            this.panel_port.Controls.Add(this.label_port_main);
            this.panel_port.Controls.Add(this.label_port_down);
            this.panel_port.Location = new System.Drawing.Point(261, 60);
            this.panel_port.Margin = new System.Windows.Forms.Padding(4);
            this.panel_port.Name = "panel_port";
            this.panel_port.Size = new System.Drawing.Size(368, 286);
            this.panel_port.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "端口：";
            // 
            // textBox_socket_IP
            // 
            this.textBox_socket_IP.Location = new System.Drawing.Point(84, 36);
            this.textBox_socket_IP.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_socket_IP.Name = "textBox_socket_IP";
            this.textBox_socket_IP.Size = new System.Drawing.Size(203, 28);
            this.textBox_socket_IP.TabIndex = 15;
            this.textBox_socket_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_socket_IP.TextChanged += new System.EventHandler(this.textBox_socket_IP_TextChanged);
            // 
            // label_socket_IP
            // 
            this.label_socket_IP.AutoSize = true;
            this.label_socket_IP.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_socket_IP.Location = new System.Drawing.Point(33, 39);
            this.label_socket_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_socket_IP.Name = "label_socket_IP";
            this.label_socket_IP.Size = new System.Drawing.Size(47, 18);
            this.label_socket_IP.TabIndex = 14;
            this.label_socket_IP.Text = "IP：";
            // 
            // checkBox_socket_submit
            // 
            this.checkBox_socket_submit.AutoSize = true;
            this.checkBox_socket_submit.Location = new System.Drawing.Point(310, 240);
            this.checkBox_socket_submit.Name = "checkBox_socket_submit";
            this.checkBox_socket_submit.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_submit.TabIndex = 13;
            this.checkBox_socket_submit.UseVisualStyleBackColor = true;
            this.checkBox_socket_submit.CheckedChanged += new System.EventHandler(this.checkBox_socket_submit_CheckedChanged);
            // 
            // checkBox_socket_down
            // 
            this.checkBox_socket_down.AutoSize = true;
            this.checkBox_socket_down.Location = new System.Drawing.Point(310, 188);
            this.checkBox_socket_down.Name = "checkBox_socket_down";
            this.checkBox_socket_down.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_down.TabIndex = 12;
            this.checkBox_socket_down.UseVisualStyleBackColor = true;
            this.checkBox_socket_down.CheckedChanged += new System.EventHandler(this.checkBox_socket_down_CheckedChanged);
            // 
            // checkBox_socket_main
            // 
            this.checkBox_socket_main.AutoSize = true;
            this.checkBox_socket_main.Location = new System.Drawing.Point(310, 136);
            this.checkBox_socket_main.Name = "checkBox_socket_main";
            this.checkBox_socket_main.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_main.TabIndex = 11;
            this.checkBox_socket_main.UseVisualStyleBackColor = true;
            this.checkBox_socket_main.CheckedChanged += new System.EventHandler(this.checkBox_socket_main_CheckedChanged);
            // 
            // checkBox_socket_up
            // 
            this.checkBox_socket_up.AutoSize = true;
            this.checkBox_socket_up.Location = new System.Drawing.Point(310, 90);
            this.checkBox_socket_up.Name = "checkBox_socket_up";
            this.checkBox_socket_up.Size = new System.Drawing.Size(18, 17);
            this.checkBox_socket_up.TabIndex = 10;
            this.checkBox_socket_up.UseVisualStyleBackColor = true;
            this.checkBox_socket_up.CheckedChanged += new System.EventHandler(this.checkBox_socket_up_CheckedChanged);
            // 
            // textBox_port_up
            // 
            this.textBox_port_up.Location = new System.Drawing.Point(147, 83);
            this.textBox_port_up.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_up.Name = "textBox_port_up";
            this.textBox_port_up.Size = new System.Drawing.Size(140, 28);
            this.textBox_port_up.TabIndex = 1;
            this.textBox_port_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_port_up.TextChanged += new System.EventHandler(this.textBox_port_up_TextChanged);
            // 
            // textBox_port_submit
            // 
            this.textBox_port_submit.Location = new System.Drawing.Point(147, 231);
            this.textBox_port_submit.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_submit.Name = "textBox_port_submit";
            this.textBox_port_submit.Size = new System.Drawing.Size(140, 28);
            this.textBox_port_submit.TabIndex = 3;
            this.textBox_port_submit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_port_submit.TextChanged += new System.EventHandler(this.textBox_port_submit_TextChanged);
            // 
            // textBox_port_main
            // 
            this.textBox_port_main.Location = new System.Drawing.Point(147, 131);
            this.textBox_port_main.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_main.Name = "textBox_port_main";
            this.textBox_port_main.Size = new System.Drawing.Size(140, 28);
            this.textBox_port_main.TabIndex = 5;
            this.textBox_port_main.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_port_main.TextChanged += new System.EventHandler(this.textBox_port_main_TextChanged);
            // 
            // textBox_port_down
            // 
            this.textBox_port_down.Location = new System.Drawing.Point(147, 183);
            this.textBox_port_down.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port_down.Name = "textBox_port_down";
            this.textBox_port_down.Size = new System.Drawing.Size(140, 28);
            this.textBox_port_down.TabIndex = 9;
            this.textBox_port_down.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_port_down.TextChanged += new System.EventHandler(this.textBox_port_down_TextChanged);
            // 
            // label_port_up
            // 
            this.label_port_up.AutoSize = true;
            this.label_port_up.Location = new System.Drawing.Point(90, 91);
            this.label_port_up.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_port_up.Name = "label_port_up";
            this.label_port_up.Size = new System.Drawing.Size(44, 18);
            this.label_port_up.TabIndex = 0;
            this.label_port_up.Text = "上料";
            // 
            // label_port_submit
            // 
            this.label_port_submit.AutoSize = true;
            this.label_port_submit.Location = new System.Drawing.Point(90, 238);
            this.label_port_submit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_port_submit.Name = "label_port_submit";
            this.label_port_submit.Size = new System.Drawing.Size(44, 18);
            this.label_port_submit.TabIndex = 2;
            this.label_port_submit.Text = "提交";
            // 
            // label_port_main
            // 
            this.label_port_main.AutoSize = true;
            this.label_port_main.Location = new System.Drawing.Point(90, 139);
            this.label_port_main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_port_main.Name = "label_port_main";
            this.label_port_main.Size = new System.Drawing.Size(44, 18);
            this.label_port_main.TabIndex = 4;
            this.label_port_main.Text = "主体";
            // 
            // label_port_down
            // 
            this.label_port_down.AutoSize = true;
            this.label_port_down.Location = new System.Drawing.Point(90, 191);
            this.label_port_down.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_port_down.Name = "label_port_down";
            this.label_port_down.Size = new System.Drawing.Size(44, 18);
            this.label_port_down.TabIndex = 8;
            this.label_port_down.Text = "下料";
            // 
            // panel_logFormat
            // 
            this.panel_logFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_logFormat.Controls.Add(this.textBox_logPrefix);
            this.panel_logFormat.Controls.Add(this.textBox_logDateFormat);
            this.panel_logFormat.Controls.Add(this.textBox_serialFigures);
            this.panel_logFormat.Controls.Add(this.label4);
            this.panel_logFormat.Controls.Add(this.label6);
            this.panel_logFormat.Controls.Add(this.label7);
            this.panel_logFormat.Location = new System.Drawing.Point(306, 138);
            this.panel_logFormat.Margin = new System.Windows.Forms.Padding(4);
            this.panel_logFormat.Name = "panel_logFormat";
            this.panel_logFormat.Size = new System.Drawing.Size(334, 187);
            this.panel_logFormat.TabIndex = 21;
            // 
            // textBox_logPrefix
            // 
            this.textBox_logPrefix.Location = new System.Drawing.Point(158, 34);
            this.textBox_logPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_logPrefix.Name = "textBox_logPrefix";
            this.textBox_logPrefix.Size = new System.Drawing.Size(140, 28);
            this.textBox_logPrefix.TabIndex = 1;
            this.textBox_logPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_logPrefix.TextChanged += new System.EventHandler(this.textBox_logPrefix_TextChanged);
            // 
            // textBox_logDateFormat
            // 
            this.textBox_logDateFormat.Location = new System.Drawing.Point(158, 82);
            this.textBox_logDateFormat.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_logDateFormat.Name = "textBox_logDateFormat";
            this.textBox_logDateFormat.Size = new System.Drawing.Size(140, 28);
            this.textBox_logDateFormat.TabIndex = 5;
            this.textBox_logDateFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_logDateFormat.TextChanged += new System.EventHandler(this.textBox_logDateFormat_TextChanged);
            // 
            // textBox_serialFigures
            // 
            this.textBox_serialFigures.Location = new System.Drawing.Point(158, 134);
            this.textBox_serialFigures.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_serialFigures.Name = "textBox_serialFigures";
            this.textBox_serialFigures.Size = new System.Drawing.Size(140, 28);
            this.textBox_serialFigures.TabIndex = 9;
            this.textBox_serialFigures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_serialFigures.TextChanged += new System.EventHandler(this.textBox_serialFigures_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "前缀：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "日期格式：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "流水号位数：";
            // 
            // label_logFormat
            // 
            this.label_logFormat.AutoSize = true;
            this.label_logFormat.Location = new System.Drawing.Point(371, 449);
            this.label_logFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_logFormat.Name = "label_logFormat";
            this.label_logFormat.Size = new System.Drawing.Size(0, 18);
            this.label_logFormat.TabIndex = 16;
            // 
            // button_saveConfig
            // 
            this.button_saveConfig.Location = new System.Drawing.Point(516, 557);
            this.button_saveConfig.Name = "button_saveConfig";
            this.button_saveConfig.Size = new System.Drawing.Size(119, 45);
            this.button_saveConfig.TabIndex = 22;
            this.button_saveConfig.Text = "保 存";
            this.button_saveConfig.UseVisualStyleBackColor = true;
            this.button_saveConfig.Click += new System.EventHandler(this.button_saveConfig_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_httpSite_MES);
            this.panel1.Controls.Add(this.label_httpSite);
            this.panel1.Controls.Add(this.textBox_httpUserName_MES);
            this.panel1.Controls.Add(this.textBox_httpPassword_MES);
            this.panel1.Controls.Add(this.label_httpUserName);
            this.panel1.Controls.Add(this.label_httpPassword);
            this.panel1.Location = new System.Drawing.Point(47, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 181);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "MES";
            // 
            // textBox_httpSite_MES
            // 
            this.textBox_httpSite_MES.Location = new System.Drawing.Point(134, 128);
            this.textBox_httpSite_MES.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_httpSite_MES.Name = "textBox_httpSite_MES";
            this.textBox_httpSite_MES.Size = new System.Drawing.Size(140, 28);
            this.textBox_httpSite_MES.TabIndex = 7;
            this.textBox_httpSite_MES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_httpSite_MES.TextChanged += new System.EventHandler(this.textBox_httpSite_TextChanged);
            // 
            // label_httpSite
            // 
            this.label_httpSite.AutoSize = true;
            this.label_httpSite.Location = new System.Drawing.Point(35, 131);
            this.label_httpSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_httpSite.Name = "label_httpSite";
            this.label_httpSite.Size = new System.Drawing.Size(62, 18);
            this.label_httpSite.TabIndex = 6;
            this.label_httpSite.Text = "站点：";
            // 
            // textBox_httpUserName_MES
            // 
            this.textBox_httpUserName_MES.Location = new System.Drawing.Point(134, 34);
            this.textBox_httpUserName_MES.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_httpUserName_MES.Name = "textBox_httpUserName_MES";
            this.textBox_httpUserName_MES.Size = new System.Drawing.Size(140, 28);
            this.textBox_httpUserName_MES.TabIndex = 1;
            this.textBox_httpUserName_MES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_httpUserName_MES.TextChanged += new System.EventHandler(this.textBox_httpUserName_TextChanged);
            // 
            // textBox_httpPassword_MES
            // 
            this.textBox_httpPassword_MES.Location = new System.Drawing.Point(134, 82);
            this.textBox_httpPassword_MES.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_httpPassword_MES.Name = "textBox_httpPassword_MES";
            this.textBox_httpPassword_MES.Size = new System.Drawing.Size(140, 28);
            this.textBox_httpPassword_MES.TabIndex = 5;
            this.textBox_httpPassword_MES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_httpPassword_MES.TextChanged += new System.EventHandler(this.textBox_httpPassword_TextChanged);
            // 
            // label_httpUserName
            // 
            this.label_httpUserName.AutoSize = true;
            this.label_httpUserName.Location = new System.Drawing.Point(35, 37);
            this.label_httpUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_httpUserName.Name = "label_httpUserName";
            this.label_httpUserName.Size = new System.Drawing.Size(80, 18);
            this.label_httpUserName.TabIndex = 0;
            this.label_httpUserName.Text = "用户名：";
            // 
            // label_httpPassword
            // 
            this.label_httpPassword.AutoSize = true;
            this.label_httpPassword.Location = new System.Drawing.Point(35, 85);
            this.label_httpPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_httpPassword.Name = "label_httpPassword";
            this.label_httpPassword.Size = new System.Drawing.Size(62, 18);
            this.label_httpPassword.TabIndex = 4;
            this.label_httpPassword.Text = "密码：";
            // 
            // tabControl_config
            // 
            this.tabControl_config.Controls.Add(this.tabPage_url);
            this.tabControl_config.Controls.Add(this.tabPage_socketPort);
            this.tabControl_config.Controls.Add(this.tabPage_httpUser);
            this.tabControl_config.Controls.Add(this.tabPage_logFileName);
            this.tabControl_config.Location = new System.Drawing.Point(24, 24);
            this.tabControl_config.Name = "tabControl_config";
            this.tabControl_config.SelectedIndex = 0;
            this.tabControl_config.Size = new System.Drawing.Size(908, 510);
            this.tabControl_config.TabIndex = 26;
            // 
            // tabPage_url
            // 
            this.tabPage_url.Controls.Add(this.panel3);
            this.tabPage_url.Controls.Add(this.panel_url);
            this.tabPage_url.Location = new System.Drawing.Point(4, 28);
            this.tabPage_url.Name = "tabPage_url";
            this.tabPage_url.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_url.Size = new System.Drawing.Size(900, 478);
            this.tabPage_url.TabIndex = 0;
            this.tabPage_url.Text = "URL";
            this.tabPage_url.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton_BDS);
            this.panel3.Controls.Add(this.radioButton_Chemical);
            this.panel3.Controls.Add(this.radioButton_Kibble);
            this.panel3.Location = new System.Drawing.Point(716, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 287);
            this.panel3.TabIndex = 20;
            // 
            // radioButton_BDS
            // 
            this.radioButton_BDS.AutoSize = true;
            this.radioButton_BDS.Location = new System.Drawing.Point(26, 207);
            this.radioButton_BDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_BDS.Name = "radioButton_BDS";
            this.radioButton_BDS.Size = new System.Drawing.Size(110, 22);
            this.radioButton_BDS.TabIndex = 5;
            this.radioButton_BDS.TabStop = true;
            this.radioButton_BDS.Text = "丝印前BDS";
            this.radioButton_BDS.UseVisualStyleBackColor = true;
            this.radioButton_BDS.CheckedChanged += new System.EventHandler(this.radioButton_BDS_CheckedChanged);
            // 
            // radioButton_Chemical
            // 
            this.radioButton_Chemical.AutoSize = true;
            this.radioButton_Chemical.Checked = true;
            this.radioButton_Chemical.Location = new System.Drawing.Point(26, 59);
            this.radioButton_Chemical.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Chemical.Name = "radioButton_Chemical";
            this.radioButton_Chemical.Size = new System.Drawing.Size(65, 22);
            this.radioButton_Chemical.TabIndex = 3;
            this.radioButton_Chemical.TabStop = true;
            this.radioButton_Chemical.Text = "化抛";
            this.radioButton_Chemical.UseVisualStyleBackColor = true;
            this.radioButton_Chemical.CheckedChanged += new System.EventHandler(this.radioButton_Chemical_CheckedChanged);
            // 
            // radioButton_Kibble
            // 
            this.radioButton_Kibble.AutoSize = true;
            this.radioButton_Kibble.Location = new System.Drawing.Point(26, 134);
            this.radioButton_Kibble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Kibble.Name = "radioButton_Kibble";
            this.radioButton_Kibble.Size = new System.Drawing.Size(65, 22);
            this.radioButton_Kibble.TabIndex = 4;
            this.radioButton_Kibble.TabStop = true;
            this.radioButton_Kibble.Text = "粗磨";
            this.radioButton_Kibble.UseVisualStyleBackColor = true;
            this.radioButton_Kibble.CheckedChanged += new System.EventHandler(this.radioButton_Kibble_CheckedChanged);
            // 
            // tabPage_socketPort
            // 
            this.tabPage_socketPort.Controls.Add(this.panel_port);
            this.tabPage_socketPort.Location = new System.Drawing.Point(4, 28);
            this.tabPage_socketPort.Name = "tabPage_socketPort";
            this.tabPage_socketPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_socketPort.Size = new System.Drawing.Size(900, 478);
            this.tabPage_socketPort.TabIndex = 1;
            this.tabPage_socketPort.Text = "Socket端口";
            this.tabPage_socketPort.UseVisualStyleBackColor = true;
            // 
            // tabPage_httpUser
            // 
            this.tabPage_httpUser.Controls.Add(this.label_url_login_WMS);
            this.tabPage_httpUser.Controls.Add(this.textBox_url_login_WMS);
            this.tabPage_httpUser.Controls.Add(this.panel2);
            this.tabPage_httpUser.Controls.Add(this.label_url_login_MES);
            this.tabPage_httpUser.Controls.Add(this.panel1);
            this.tabPage_httpUser.Controls.Add(this.textBox_url_login_MES);
            this.tabPage_httpUser.Location = new System.Drawing.Point(4, 28);
            this.tabPage_httpUser.Name = "tabPage_httpUser";
            this.tabPage_httpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_httpUser.Size = new System.Drawing.Size(900, 478);
            this.tabPage_httpUser.TabIndex = 2;
            this.tabPage_httpUser.Text = "http登录";
            this.tabPage_httpUser.UseVisualStyleBackColor = true;
            // 
            // label_url_login_WMS
            // 
            this.label_url_login_WMS.AutoSize = true;
            this.label_url_login_WMS.Location = new System.Drawing.Point(395, 368);
            this.label_url_login_WMS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_login_WMS.Name = "label_url_login_WMS";
            this.label_url_login_WMS.Size = new System.Drawing.Size(89, 18);
            this.label_url_login_WMS.TabIndex = 27;
            this.label_url_login_WMS.Text = "登录url：";
            // 
            // textBox_url_login_WMS
            // 
            this.textBox_url_login_WMS.Location = new System.Drawing.Point(500, 361);
            this.textBox_url_login_WMS.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_login_WMS.Name = "textBox_url_login_WMS";
            this.textBox_url_login_WMS.Size = new System.Drawing.Size(358, 28);
            this.textBox_url_login_WMS.TabIndex = 28;
            this.textBox_url_login_WMS.TextChanged += new System.EventHandler(this.textBox_url_login_WMS_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_httpUserName_WMS);
            this.panel2.Controls.Add(this.textBox_httpPassword_WMS);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(47, 306);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 130);
            this.panel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "WMS";
            // 
            // textBox_httpUserName_WMS
            // 
            this.textBox_httpUserName_WMS.Location = new System.Drawing.Point(134, 34);
            this.textBox_httpUserName_WMS.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_httpUserName_WMS.Name = "textBox_httpUserName_WMS";
            this.textBox_httpUserName_WMS.Size = new System.Drawing.Size(140, 28);
            this.textBox_httpUserName_WMS.TabIndex = 1;
            this.textBox_httpUserName_WMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_httpUserName_WMS.TextChanged += new System.EventHandler(this.textBox_httpUserName_WMS_TextChanged);
            // 
            // textBox_httpPassword_WMS
            // 
            this.textBox_httpPassword_WMS.Location = new System.Drawing.Point(134, 82);
            this.textBox_httpPassword_WMS.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_httpPassword_WMS.Name = "textBox_httpPassword_WMS";
            this.textBox_httpPassword_WMS.Size = new System.Drawing.Size(140, 28);
            this.textBox_httpPassword_WMS.TabIndex = 5;
            this.textBox_httpPassword_WMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_httpPassword_WMS.TextChanged += new System.EventHandler(this.textBox_httpPassword_WMS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "用户名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "密码：";
            // 
            // label_url_login_MES
            // 
            this.label_url_login_MES.AutoSize = true;
            this.label_url_login_MES.Location = new System.Drawing.Point(395, 167);
            this.label_url_login_MES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_url_login_MES.Name = "label_url_login_MES";
            this.label_url_login_MES.Size = new System.Drawing.Size(89, 18);
            this.label_url_login_MES.TabIndex = 0;
            this.label_url_login_MES.Text = "登录url：";
            // 
            // textBox_url_login_MES
            // 
            this.textBox_url_login_MES.Location = new System.Drawing.Point(500, 160);
            this.textBox_url_login_MES.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url_login_MES.Name = "textBox_url_login_MES";
            this.textBox_url_login_MES.Size = new System.Drawing.Size(358, 28);
            this.textBox_url_login_MES.TabIndex = 1;
            this.textBox_url_login_MES.TextChanged += new System.EventHandler(this.textBox_url_login_MES_TextChanged);
            // 
            // tabPage_logFileName
            // 
            this.tabPage_logFileName.Controls.Add(this.panel_logFormat);
            this.tabPage_logFileName.Location = new System.Drawing.Point(4, 28);
            this.tabPage_logFileName.Name = "tabPage_logFileName";
            this.tabPage_logFileName.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_logFileName.Size = new System.Drawing.Size(900, 478);
            this.tabPage_logFileName.TabIndex = 3;
            this.tabPage_logFileName.Text = "Log文件名格式";
            this.tabPage_logFileName.UseVisualStyleBackColor = true;
            // 
            // button_restoreConfig
            // 
            this.button_restoreConfig.Location = new System.Drawing.Point(332, 557);
            this.button_restoreConfig.Name = "button_restoreConfig";
            this.button_restoreConfig.Size = new System.Drawing.Size(119, 45);
            this.button_restoreConfig.TabIndex = 28;
            this.button_restoreConfig.Text = "还 原";
            this.button_restoreConfig.UseVisualStyleBackColor = true;
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 644);
            this.Controls.Add(this.button_restoreConfig);
            this.Controls.Add(this.tabControl_config);
            this.Controls.Add(this.button_saveConfig);
            this.Controls.Add(this.label_logFormat);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigureForm";
            this.Text = "配置";
            this.panel_url.ResumeLayout(false);
            this.panel_url.PerformLayout();
            this.panel_port.ResumeLayout(false);
            this.panel_port.PerformLayout();
            this.panel_logFormat.ResumeLayout(false);
            this.panel_logFormat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl_config.ResumeLayout(false);
            this.tabPage_url.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage_socketPort.ResumeLayout(false);
            this.tabPage_httpUser.ResumeLayout(false);
            this.tabPage_httpUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage_logFileName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_url_scanContainerIn;
        private System.Windows.Forms.TextBox textBox_url_postfix_scanContainerIn;
        private System.Windows.Forms.Label label_url_scanVehicleOut;
        private System.Windows.Forms.TextBox textBox_url_postfix_scanContainerOut;
        private System.Windows.Forms.TextBox textBox_url_postfix_scanSn;
        private System.Windows.Forms.Label label_url_scanVehicleUnbind;
        private System.Windows.Forms.Label label_url_scanSn;
        private System.Windows.Forms.TextBox textBox_url_postfix_scanContainerUnbind;
        private System.Windows.Forms.TextBox textBox_url_postfix_submit;
        private System.Windows.Forms.Label label_url_submit;
        private System.Windows.Forms.Panel panel_port;
        private System.Windows.Forms.TextBox textBox_port_up;
        private System.Windows.Forms.TextBox textBox_port_submit;
        private System.Windows.Forms.TextBox textBox_port_main;
        private System.Windows.Forms.TextBox textBox_port_down;
        private System.Windows.Forms.Label label_port_up;
        private System.Windows.Forms.Label label_port_submit;
        private System.Windows.Forms.Label label_port_main;
        private System.Windows.Forms.Label label_port_down;
        private System.Windows.Forms.Panel panel_logFormat;
        private System.Windows.Forms.TextBox textBox_logPrefix;
        private System.Windows.Forms.TextBox textBox_logDateFormat;
        private System.Windows.Forms.TextBox textBox_serialFigures;
        private System.Windows.Forms.Label label_logFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_url_prefix;
        private System.Windows.Forms.Label label_url_prefix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_httpUserName_MES;
        private System.Windows.Forms.TextBox textBox_httpPassword_MES;
        private System.Windows.Forms.Label label_httpUserName;
        private System.Windows.Forms.Label label_httpPassword;
        private System.Windows.Forms.TextBox textBox_httpSite_MES;
        private System.Windows.Forms.Label label_httpSite;
        private System.Windows.Forms.TextBox textBox_url_subPrefix_MES;
        private System.Windows.Forms.Label label_url_subPrefix;
        private System.Windows.Forms.TabControl tabControl_config;
        private System.Windows.Forms.TabPage tabPage_url;
        private System.Windows.Forms.TabPage tabPage_socketPort;
        private System.Windows.Forms.TabPage tabPage_httpUser;
        private System.Windows.Forms.TabPage tabPage_logFileName;
        public System.Windows.Forms.Button button_saveConfig;
        private System.Windows.Forms.CheckBox checkBox_socket_up;
        private System.Windows.Forms.CheckBox checkBox_socket_submit;
        private System.Windows.Forms.CheckBox checkBox_socket_down;
        private System.Windows.Forms.CheckBox checkBox_socket_main;
        private System.Windows.Forms.TextBox textBox_socket_IP;
        private System.Windows.Forms.Label label_socket_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_httpUserName_WMS;
        private System.Windows.Forms.TextBox textBox_httpPassword_WMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_url_login_MES;
        private System.Windows.Forms.TextBox textBox_url_login_MES;
        private System.Windows.Forms.Label label_url_login_WMS;
        private System.Windows.Forms.TextBox textBox_url_login_WMS;
        private System.Windows.Forms.TextBox textBox_stockQuery_WMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_validate_WMS;
        private System.Windows.Forms.Label label_validate_WMS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton_BDS;
        private System.Windows.Forms.RadioButton radioButton_Chemical;
        private System.Windows.Forms.RadioButton radioButton_Kibble;
        public System.Windows.Forms.Button button_restoreConfig;
    }
}