namespace Cyberbezpieczenstwo
{
    partial class EditUser
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
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LoginTxtb = new System.Windows.Forms.TextBox();
            this.PasswordTxtb = new System.Windows.Forms.TextBox();
            this.AdminChcbx = new System.Windows.Forms.CheckBox();
            this.PassRestChcbx = new System.Windows.Forms.CheckBox();
            this.AccLockedChcbx = new System.Windows.Forms.CheckBox();
            this.PassChangeTimerLbl = new System.Windows.Forms.Label();
            this.PassChangeTimerInput = new System.Windows.Forms.NumericUpDown();
            this.Komunikat = new System.Windows.Forms.Label();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.OneTimePassBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PassChangeTimerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Location = new System.Drawing.Point(307, 335);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(200, 50);
            this.SaveChangesBtn.TabIndex = 0;
            this.SaveChangesBtn.Text = "Zapisz Zmiany";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(308, 9);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(37, 15);
            this.LoginLbl.TabIndex = 1;
            this.LoginLbl.Text = "Login";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(308, 53);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(57, 15);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Password";
            // 
            // LoginTxtb
            // 
            this.LoginTxtb.Location = new System.Drawing.Point(308, 27);
            this.LoginTxtb.Name = "LoginTxtb";
            this.LoginTxtb.Size = new System.Drawing.Size(200, 23);
            this.LoginTxtb.TabIndex = 4;
            // 
            // PasswordTxtb
            // 
            this.PasswordTxtb.Location = new System.Drawing.Point(308, 71);
            this.PasswordTxtb.Name = "PasswordTxtb";
            this.PasswordTxtb.Size = new System.Drawing.Size(200, 23);
            this.PasswordTxtb.TabIndex = 5;
            // 
            // AdminChcbx
            // 
            this.AdminChcbx.AutoSize = true;
            this.AdminChcbx.Location = new System.Drawing.Point(308, 115);
            this.AdminChcbx.Name = "AdminChcbx";
            this.AdminChcbx.Size = new System.Drawing.Size(62, 19);
            this.AdminChcbx.TabIndex = 6;
            this.AdminChcbx.Text = "Admin";
            this.AdminChcbx.UseVisualStyleBackColor = true;
            // 
            // PassRestChcbx
            // 
            this.PassRestChcbx.AutoSize = true;
            this.PassRestChcbx.Location = new System.Drawing.Point(307, 155);
            this.PassRestChcbx.Name = "PassRestChcbx";
            this.PassRestChcbx.Size = new System.Drawing.Size(137, 19);
            this.PassRestChcbx.TabIndex = 7;
            this.PassRestChcbx.Text = "PasswordRestrictions";
            this.PassRestChcbx.UseVisualStyleBackColor = true;
            // 
            // AccLockedChcbx
            // 
            this.AccLockedChcbx.AutoSize = true;
            this.AccLockedChcbx.Location = new System.Drawing.Point(308, 195);
            this.AccLockedChcbx.Name = "AccLockedChcbx";
            this.AccLockedChcbx.Size = new System.Drawing.Size(64, 19);
            this.AccLockedChcbx.TabIndex = 8;
            this.AccLockedChcbx.Text = "Locked";
            this.AccLockedChcbx.UseVisualStyleBackColor = true;
            // 
            // PassChangeTimerLbl
            // 
            this.PassChangeTimerLbl.AutoSize = true;
            this.PassChangeTimerLbl.Location = new System.Drawing.Point(307, 232);
            this.PassChangeTimerLbl.Name = "PassChangeTimerLbl";
            this.PassChangeTimerLbl.Size = new System.Drawing.Size(138, 15);
            this.PassChangeTimerLbl.TabIndex = 10;
            this.PassChangeTimerLbl.Text = "Day to Password Change";
            // 
            // PassChangeTimerInput
            // 
            this.PassChangeTimerInput.Location = new System.Drawing.Point(308, 250);
            this.PassChangeTimerInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PassChangeTimerInput.Name = "PassChangeTimerInput";
            this.PassChangeTimerInput.Size = new System.Drawing.Size(136, 23);
            this.PassChangeTimerInput.TabIndex = 11;
            // 
            // Komunikat
            // 
            this.Komunikat.AutoSize = true;
            this.Komunikat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Komunikat.ForeColor = System.Drawing.Color.Red;
            this.Komunikat.Location = new System.Drawing.Point(254, 313);
            this.Komunikat.Name = "Komunikat";
            this.Komunikat.Size = new System.Drawing.Size(0, 25);
            this.Komunikat.TabIndex = 12;
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Location = new System.Drawing.Point(307, 388);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(200, 50);
            this.DeleteUserBtn.TabIndex = 13;
            this.DeleteUserBtn.Text = "Usun uzytkownika";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // OneTimePassBtn
            // 
            this.OneTimePassBtn.Location = new System.Drawing.Point(307, 279);
            this.OneTimePassBtn.Name = "OneTimePassBtn";
            this.OneTimePassBtn.Size = new System.Drawing.Size(200, 50);
            this.OneTimePassBtn.TabIndex = 14;
            this.OneTimePassBtn.Text = "Nadaj Hasło Jednorazowe";
            this.OneTimePassBtn.UseVisualStyleBackColor = true;
            this.OneTimePassBtn.Click += new System.EventHandler(this.OneTimePassBtn_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OneTimePassBtn);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.Komunikat);
            this.Controls.Add(this.PassChangeTimerInput);
            this.Controls.Add(this.PassChangeTimerLbl);
            this.Controls.Add(this.AccLockedChcbx);
            this.Controls.Add(this.PassRestChcbx);
            this.Controls.Add(this.AdminChcbx);
            this.Controls.Add(this.PasswordTxtb);
            this.Controls.Add(this.LoginTxtb);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.SaveChangesBtn);
            this.Name = "EditUser";
            this.Text = "EditUser";
            ((System.ComponentModel.ISupportInitialize)(this.PassChangeTimerInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveChangesBtn;
        private Label LoginLbl;
        private Label PasswordLbl;
        private TextBox LoginTxtb;
        private TextBox PasswordTxtb;
        private CheckBox AdminChcbx;
        private CheckBox PassRestChcbx;
        private CheckBox AccLockedChcbx;
        private Label PassChangeTimerLbl;
        private NumericUpDown PassChangeTimerInput;
        private Label Komunikat;
        private Button DeleteUserBtn;
        private Button OneTimePassBtn;
    }
}