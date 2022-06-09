namespace ChemicalScan.View
{
    partial class InitSettingForm
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
            this.radioButton_Chemical = new System.Windows.Forms.RadioButton();
            this.radioButton_Kibble = new System.Windows.Forms.RadioButton();
            this.radioButton_BDS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_Chemical
            // 
            this.radioButton_Chemical.AutoSize = true;
            this.radioButton_Chemical.Checked = true;
            this.radioButton_Chemical.Location = new System.Drawing.Point(149, 155);
            this.radioButton_Chemical.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Chemical.Name = "radioButton_Chemical";
            this.radioButton_Chemical.Size = new System.Drawing.Size(68, 23);
            this.radioButton_Chemical.TabIndex = 0;
            this.radioButton_Chemical.TabStop = true;
            this.radioButton_Chemical.Text = "化抛";
            this.radioButton_Chemical.UseVisualStyleBackColor = true;
            this.radioButton_Chemical.CheckedChanged += new System.EventHandler(this.radioButton_Chemical_CheckedChanged);
            // 
            // radioButton_Kibble
            // 
            this.radioButton_Kibble.AutoSize = true;
            this.radioButton_Kibble.Location = new System.Drawing.Point(288, 155);
            this.radioButton_Kibble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Kibble.Name = "radioButton_Kibble";
            this.radioButton_Kibble.Size = new System.Drawing.Size(68, 23);
            this.radioButton_Kibble.TabIndex = 1;
            this.radioButton_Kibble.TabStop = true;
            this.radioButton_Kibble.Text = "粗磨";
            this.radioButton_Kibble.UseVisualStyleBackColor = true;
            this.radioButton_Kibble.CheckedChanged += new System.EventHandler(this.radioButton_Kibble_CheckedChanged);
            // 
            // radioButton_BDS
            // 
            this.radioButton_BDS.AutoSize = true;
            this.radioButton_BDS.Location = new System.Drawing.Point(415, 155);
            this.radioButton_BDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_BDS.Name = "radioButton_BDS";
            this.radioButton_BDS.Size = new System.Drawing.Size(117, 23);
            this.radioButton_BDS.TabIndex = 2;
            this.radioButton_BDS.TabStop = true;
            this.radioButton_BDS.Text = "丝印前BDS";
            this.radioButton_BDS.UseVisualStyleBackColor = true;
            this.radioButton_BDS.CheckedChanged += new System.EventHandler(this.radioButton_BDS_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择项目以初始化配置。";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(279, 227);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(95, 39);
            this.button_confirm.TabIndex = 4;
            this.button_confirm.Text = "确 定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // InitSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 315);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_BDS);
            this.Controls.Add(this.radioButton_Kibble);
            this.Controls.Add(this.radioButton_Chemical);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择项目";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitSettingForm_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Chemical;
        private System.Windows.Forms.RadioButton radioButton_Kibble;
        private System.Windows.Forms.RadioButton radioButton_BDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_confirm;
    }
}