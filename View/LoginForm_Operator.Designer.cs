
namespace ScanUploader.View
{
    partial class LoginForm_Operator
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
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(181, 204);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(106, 48);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "登 录";
            this.button_login.UseVisualStyleBackColor = true;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(163, 130);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(223, 28);
            this.textBox_password.TabIndex = 8;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(63, 133);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(66, 19);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "密码：";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(163, 65);
            this.textBox_userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(223, 28);
            this.textBox_userName.TabIndex = 6;
            this.textBox_userName.Text = "ly611937";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(63, 68);
            this.label_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(66, 19);
            this.label_userName.TabIndex = 5;
            this.label_userName.Text = "工号：";
            // 
            // LoginForm_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 287);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_userName);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm_Operator";
            this.Text = "LoginForm_Operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label_userName;
    }
}