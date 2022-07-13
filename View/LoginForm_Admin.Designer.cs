namespace ScanUploader.View
{
    partial class LoginForm_Admin
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
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(50, 43);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(53, 12);
            this.label_userName.TabIndex = 0;
            this.label_userName.Text = "用户名：";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(115, 40);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(107, 21);
            this.textBox_userName.TabIndex = 1;
            this.textBox_userName.Text = "RP";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(115, 85);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(107, 21);
            this.textBox_password.TabIndex = 3;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(50, 89);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(41, 12);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "密码：";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(104, 125);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(73, 31);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "登 录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LoginForm_Admin
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 181);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_userName);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "LoginForm_Admin";
            this.Text = "管理员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
    }
}