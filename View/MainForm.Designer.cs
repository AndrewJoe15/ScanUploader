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
            this.menuStrip_ = new System.Windows.Forms.MenuStrip();
            this.权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.技术支持ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开发人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_.SuspendLayout();
            this.panel_basicInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_
            // 
            this.menuStrip_.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限ToolStripMenuItem,
            this.日志ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip_.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_.Name = "menuStrip_";
            this.menuStrip_.Size = new System.Drawing.Size(888, 28);
            this.menuStrip_.TabIndex = 17;
            this.menuStrip_.Text = "menuStrip1";
            // 
            // 权限ToolStripMenuItem
            // 
            this.权限ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作员ToolStripMenuItem,
            this.技术支持ToolStripMenuItem,
            this.开发人员ToolStripMenuItem});
            this.权限ToolStripMenuItem.Name = "权限ToolStripMenuItem";
            this.权限ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.权限ToolStripMenuItem.Text = "权限";
            // 
            // 操作员ToolStripMenuItem
            // 
            this.操作员ToolStripMenuItem.Name = "操作员ToolStripMenuItem";
            this.操作员ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.操作员ToolStripMenuItem.Text = "操作人员";
            // 
            // 技术支持ToolStripMenuItem
            // 
            this.技术支持ToolStripMenuItem.Name = "技术支持ToolStripMenuItem";
            this.技术支持ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.技术支持ToolStripMenuItem.Text = "技术支持";
            // 
            // 开发人员ToolStripMenuItem
            // 
            this.开发人员ToolStripMenuItem.Name = "开发人员ToolStripMenuItem";
            this.开发人员ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.开发人员ToolStripMenuItem.Text = "开发人员";
            // 
            // textBox_productModel
            // 
            this.textBox_productModel.Location = new System.Drawing.Point(119, 152);
            this.textBox_productModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_productModel.Name = "textBox_productModel";
            this.textBox_productModel.Size = new System.Drawing.Size(152, 25);
            this.textBox_productModel.TabIndex = 7;
            this.textBox_productModel.TextChanged += new System.EventHandler(this.textBox_productModel_TextChanged);
            // 
            // label_productModelVersion
            // 
            this.label_productModelVersion.AutoSize = true;
            this.label_productModelVersion.Location = new System.Drawing.Point(31, 202);
            this.label_productModelVersion.Name = "label_productModelVersion";
            this.label_productModelVersion.Size = new System.Drawing.Size(82, 15);
            this.label_productModelVersion.TabIndex = 8;
            this.label_productModelVersion.Text = "型号版本：";
            // 
            // label_productModel
            // 
            this.label_productModel.AutoSize = true;
            this.label_productModel.Location = new System.Drawing.Point(31, 162);
            this.label_productModel.Name = "label_productModel";
            this.label_productModel.Size = new System.Drawing.Size(82, 15);
            this.label_productModel.TabIndex = 6;
            this.label_productModel.Text = "产品型号：";
            // 
            // textBox_productModelVersion
            // 
            this.textBox_productModelVersion.Location = new System.Drawing.Point(119, 192);
            this.textBox_productModelVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_productModelVersion.Name = "textBox_productModelVersion";
            this.textBox_productModelVersion.Size = new System.Drawing.Size(152, 25);
            this.textBox_productModelVersion.TabIndex = 9;
            this.textBox_productModelVersion.TextChanged += new System.EventHandler(this.textBox_productModelVersion_TextChanged);
            // 
            // textBox_resource
            // 
            this.textBox_resource.Location = new System.Drawing.Point(119, 112);
            this.textBox_resource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_resource.Name = "textBox_resource";
            this.textBox_resource.Size = new System.Drawing.Size(152, 25);
            this.textBox_resource.TabIndex = 5;
            this.textBox_resource.TextChanged += new System.EventHandler(this.textBox_resource_TextChanged);
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.Location = new System.Drawing.Point(31, 242);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(52, 15);
            this.label_shift.TabIndex = 10;
            this.label_shift.Text = "班次：";
            // 
            // label_resource
            // 
            this.label_resource.AutoSize = true;
            this.label_resource.Location = new System.Drawing.Point(31, 122);
            this.label_resource.Name = "label_resource";
            this.label_resource.Size = new System.Drawing.Size(67, 15);
            this.label_resource.TabIndex = 4;
            this.label_resource.Text = "设备号：";
            // 
            // textBox_operation
            // 
            this.textBox_operation.Location = new System.Drawing.Point(119, 72);
            this.textBox_operation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_operation.Name = "textBox_operation";
            this.textBox_operation.Size = new System.Drawing.Size(152, 25);
            this.textBox_operation.TabIndex = 3;
            this.textBox_operation.TextChanged += new System.EventHandler(this.textBox_operation_TextChanged);
            // 
            // label_createBy
            // 
            this.label_createBy.AutoSize = true;
            this.label_createBy.Location = new System.Drawing.Point(31, 282);
            this.label_createBy.Name = "label_createBy";
            this.label_createBy.Size = new System.Drawing.Size(67, 15);
            this.label_createBy.TabIndex = 12;
            this.label_createBy.Text = "操作人：";
            // 
            // label_operation
            // 
            this.label_operation.AutoSize = true;
            this.label_operation.Location = new System.Drawing.Point(31, 82);
            this.label_operation.Name = "label_operation";
            this.label_operation.Size = new System.Drawing.Size(52, 15);
            this.label_operation.TabIndex = 2;
            this.label_operation.Text = "工序：";
            // 
            // textBox_createBy
            // 
            this.textBox_createBy.Location = new System.Drawing.Point(119, 272);
            this.textBox_createBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_createBy.Name = "textBox_createBy";
            this.textBox_createBy.Size = new System.Drawing.Size(152, 25);
            this.textBox_createBy.TabIndex = 13;
            this.textBox_createBy.TextChanged += new System.EventHandler(this.textBox_createBy_TextChanged);
            // 
            // textBox_site
            // 
            this.textBox_site.Location = new System.Drawing.Point(119, 32);
            this.textBox_site.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_site.Name = "textBox_site";
            this.textBox_site.Size = new System.Drawing.Size(152, 25);
            this.textBox_site.TabIndex = 1;
            this.textBox_site.TextChanged += new System.EventHandler(this.textBox_site_TextChanged);
            // 
            // label_site
            // 
            this.label_site.AutoSize = true;
            this.label_site.Location = new System.Drawing.Point(31, 42);
            this.label_site.Name = "label_site";
            this.label_site.Size = new System.Drawing.Size(82, 15);
            this.label_site.TabIndex = 0;
            this.label_site.Text = "工厂编号：";
            // 
            // label_basicInformation
            // 
            this.label_basicInformation.AutoSize = true;
            this.label_basicInformation.Location = new System.Drawing.Point(-1, 0);
            this.label_basicInformation.Name = "label_basicInformation";
            this.label_basicInformation.Size = new System.Drawing.Size(67, 15);
            this.label_basicInformation.TabIndex = 16;
            this.label_basicInformation.Text = "基本信息";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(109, 328);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 26);
            this.button_start.TabIndex = 17;
            this.button_start.Text = "确 定";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // comboBox_shift
            // 
            this.comboBox_shift.FormattingEnabled = true;
            this.comboBox_shift.Location = new System.Drawing.Point(119, 235);
            this.comboBox_shift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_shift.Name = "comboBox_shift";
            this.comboBox_shift.Size = new System.Drawing.Size(152, 23);
            this.comboBox_shift.TabIndex = 19;
            this.comboBox_shift.SelectedIndexChanged += new System.EventHandler(this.comboBox_shift_SelectedIndexChanged);
            // 
            // panel_basicInformation
            // 
            this.panel_basicInformation.Controls.Add(this.comboBox_shift);
            this.panel_basicInformation.Controls.Add(this.button_start);
            this.panel_basicInformation.Controls.Add(this.label_basicInformation);
            this.panel_basicInformation.Controls.Add(this.label_site);
            this.panel_basicInformation.Controls.Add(this.textBox_site);
            this.panel_basicInformation.Controls.Add(this.textBox_createBy);
            this.panel_basicInformation.Controls.Add(this.label_operation);
            this.panel_basicInformation.Controls.Add(this.label_createBy);
            this.panel_basicInformation.Controls.Add(this.textBox_operation);
            this.panel_basicInformation.Controls.Add(this.label_resource);
            this.panel_basicInformation.Controls.Add(this.label_shift);
            this.panel_basicInformation.Controls.Add(this.textBox_resource);
            this.panel_basicInformation.Controls.Add(this.textBox_productModelVersion);
            this.panel_basicInformation.Controls.Add(this.label_productModel);
            this.panel_basicInformation.Controls.Add(this.label_productModelVersion);
            this.panel_basicInformation.Controls.Add(this.textBox_productModel);
            this.panel_basicInformation.Location = new System.Drawing.Point(49, 79);
            this.panel_basicInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_basicInformation.Name = "panel_basicInformation";
            this.panel_basicInformation.Size = new System.Drawing.Size(300, 378);
            this.panel_basicInformation.TabIndex = 16;
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(415, 44);
            this.textBox_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.Size = new System.Drawing.Size(433, 454);
            this.textBox_log.TabIndex = 19;
            // 
            // 日志ToolStripMenuItem
            // 
            this.日志ToolStripMenuItem.Name = "日志ToolStripMenuItem";
            this.日志ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.日志ToolStripMenuItem.Text = "日志";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 520);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.panel_basicInformation);
            this.Controls.Add(this.menuStrip_);
            this.MainMenuStrip = this.menuStrip_;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip_.ResumeLayout(false);
            this.menuStrip_.PerformLayout();
            this.panel_basicInformation.ResumeLayout(false);
            this.panel_basicInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_;
        private System.Windows.Forms.ToolStripMenuItem 权限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 技术支持ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开发人员ToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem 日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
    }
}

