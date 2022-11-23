namespace Cyberbezpieczenstwo
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogInBtn = new System.Windows.Forms.Button();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.LoginTxtbx = new System.Windows.Forms.TextBox();
            this.KomunikatLbl = new System.Windows.Forms.Label();
            this.btnCaptcha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(250, 397);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(671, 60);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "Login";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(250, 137);
            this.LoginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(56, 25);
            this.LoginLbl.TabIndex = 0;
            this.LoginLbl.Text = "Login";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(250, 258);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(87, 25);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.Location = new System.Drawing.Point(250, 288);
            this.passwordTxtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.PasswordChar = '*';
            this.passwordTxtbx.Size = new System.Drawing.Size(670, 31);
            this.passwordTxtbx.TabIndex = 4;
            // 
            // LoginTxtbx
            // 
            this.LoginTxtbx.Location = new System.Drawing.Point(250, 167);
            this.LoginTxtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginTxtbx.Name = "LoginTxtbx";
            this.LoginTxtbx.Size = new System.Drawing.Size(670, 31);
            this.LoginTxtbx.TabIndex = 5;
            this.LoginTxtbx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // KomunikatLbl
            // 
            this.KomunikatLbl.AutoSize = true;
            this.KomunikatLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KomunikatLbl.ForeColor = System.Drawing.Color.Red;
            this.KomunikatLbl.Location = new System.Drawing.Point(192, 20);
            this.KomunikatLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KomunikatLbl.Name = "KomunikatLbl";
            this.KomunikatLbl.Size = new System.Drawing.Size(0, 48);
            this.KomunikatLbl.TabIndex = 6;
            this.KomunikatLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCaptcha
            // 
            this.btnCaptcha.Location = new System.Drawing.Point(250, 486);
            this.btnCaptcha.Name = "btnCaptcha";
            this.btnCaptcha.Size = new System.Drawing.Size(219, 79);
            this.btnCaptcha.TabIndex = 7;
            this.btnCaptcha.Text = "captchaTesting";
            this.btnCaptcha.UseVisualStyleBackColor = true;
            this.btnCaptcha.Click += new System.EventHandler(this.btnCaptcha_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnCaptcha);
            this.Controls.Add(this.KomunikatLbl);
            this.Controls.Add(this.LoginTxtbx);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.LogInBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button LogInBtn;
        private Label LoginLbl;
        private Label PasswordLbl;
        private TextBox passwordTxtbx;
        private TextBox LoginTxtbx;
        private Label KomunikatLbl;
        private Button btnCaptcha;
    }
}