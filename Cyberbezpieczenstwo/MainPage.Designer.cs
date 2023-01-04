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
            this.LogInBtn.Location = new System.Drawing.Point(175, 238);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(470, 36);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "Login";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(175, 82);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(37, 15);
            this.LoginLbl.TabIndex = 0;
            this.LoginLbl.Text = "Login";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(175, 155);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(57, 15);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.Location = new System.Drawing.Point(175, 173);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.PasswordChar = '*';
            this.passwordTxtbx.Size = new System.Drawing.Size(470, 23);
            this.passwordTxtbx.TabIndex = 4;
            // 
            // LoginTxtbx
            // 
            this.LoginTxtbx.Location = new System.Drawing.Point(175, 100);
            this.LoginTxtbx.Name = "LoginTxtbx";
            this.LoginTxtbx.Size = new System.Drawing.Size(470, 23);
            this.LoginTxtbx.TabIndex = 5;
            this.LoginTxtbx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // KomunikatLbl
            // 
            this.KomunikatLbl.AutoSize = true;
            this.KomunikatLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KomunikatLbl.ForeColor = System.Drawing.Color.Red;
            this.KomunikatLbl.Location = new System.Drawing.Point(134, 12);
            this.KomunikatLbl.Name = "KomunikatLbl";
            this.KomunikatLbl.Size = new System.Drawing.Size(0, 32);
            this.KomunikatLbl.TabIndex = 6;
            this.KomunikatLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCaptcha
            // 
            this.btnCaptcha.Location = new System.Drawing.Point(175, 292);
            this.btnCaptcha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaptcha.Name = "btnCaptcha";
            this.btnCaptcha.Size = new System.Drawing.Size(153, 47);
            this.btnCaptcha.TabIndex = 7;
            this.btnCaptcha.Text = "captchaTesting";
            this.btnCaptcha.UseVisualStyleBackColor = true;
            this.btnCaptcha.Visible = false;
            this.btnCaptcha.Click += new System.EventHandler(this.btnCaptcha_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaptcha);
            this.Controls.Add(this.KomunikatLbl);
            this.Controls.Add(this.LoginTxtbx);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.LogInBtn);
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