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
            this.PrintRestriction = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GenerateKeyBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PassChangeTimerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Location = new System.Drawing.Point(12, 313);
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
            this.LoginLbl.Location = new System.Drawing.Point(12, 9);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(37, 15);
            this.LoginLbl.TabIndex = 1;
            this.LoginLbl.Text = "Login";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(12, 53);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(57, 15);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Password";
            // 
            // LoginTxtb
            // 
            this.LoginTxtb.Location = new System.Drawing.Point(12, 27);
            this.LoginTxtb.Name = "LoginTxtb";
            this.LoginTxtb.Size = new System.Drawing.Size(200, 23);
            this.LoginTxtb.TabIndex = 4;
            // 
            // PasswordTxtb
            // 
            this.PasswordTxtb.Location = new System.Drawing.Point(12, 71);
            this.PasswordTxtb.Name = "PasswordTxtb";
            this.PasswordTxtb.Size = new System.Drawing.Size(200, 23);
            this.PasswordTxtb.TabIndex = 5;
            // 
            // AdminChcbx
            // 
            this.AdminChcbx.AutoSize = true;
            this.AdminChcbx.Location = new System.Drawing.Point(12, 115);
            this.AdminChcbx.Name = "AdminChcbx";
            this.AdminChcbx.Size = new System.Drawing.Size(62, 19);
            this.AdminChcbx.TabIndex = 6;
            this.AdminChcbx.Text = "Admin";
            this.AdminChcbx.UseVisualStyleBackColor = true;
            // 
            // PassRestChcbx
            // 
            this.PassRestChcbx.AutoSize = true;
            this.PassRestChcbx.Location = new System.Drawing.Point(11, 155);
            this.PassRestChcbx.Name = "PassRestChcbx";
            this.PassRestChcbx.Size = new System.Drawing.Size(137, 19);
            this.PassRestChcbx.TabIndex = 7;
            this.PassRestChcbx.Text = "PasswordRestrictions";
            this.PassRestChcbx.UseVisualStyleBackColor = true;
            // 
            // AccLockedChcbx
            // 
            this.AccLockedChcbx.AutoSize = true;
            this.AccLockedChcbx.Location = new System.Drawing.Point(12, 195);
            this.AccLockedChcbx.Name = "AccLockedChcbx";
            this.AccLockedChcbx.Size = new System.Drawing.Size(64, 19);
            this.AccLockedChcbx.TabIndex = 8;
            this.AccLockedChcbx.Text = "Locked";
            this.AccLockedChcbx.UseVisualStyleBackColor = true;
            // 
            // PassChangeTimerLbl
            // 
            this.PassChangeTimerLbl.AutoSize = true;
            this.PassChangeTimerLbl.Location = new System.Drawing.Point(12, 251);
            this.PassChangeTimerLbl.Name = "PassChangeTimerLbl";
            this.PassChangeTimerLbl.Size = new System.Drawing.Size(138, 15);
            this.PassChangeTimerLbl.TabIndex = 10;
            this.PassChangeTimerLbl.Text = "Day to Password Change";
            // 
            // PassChangeTimerInput
            // 
            this.PassChangeTimerInput.Location = new System.Drawing.Point(13, 269);
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
            this.DeleteUserBtn.Location = new System.Drawing.Point(11, 388);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(200, 50);
            this.DeleteUserBtn.TabIndex = 13;
            this.DeleteUserBtn.Text = "Usun uzytkownika";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrintRestriction
            // 
            this.PrintRestriction.AutoSize = true;
            this.PrintRestriction.Location = new System.Drawing.Point(13, 229);
            this.PrintRestriction.Name = "PrintRestriction";
            this.PrintRestriction.Size = new System.Drawing.Size(92, 19);
            this.PrintRestriction.TabIndex = 14;
            this.PrintRestriction.Text = "Print Locked";
            this.PrintRestriction.UseVisualStyleBackColor = true;
            this.PrintRestriction.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Klucz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Generuj szyfr";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(555, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 23);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Długość klucza";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(326, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 23);
            this.textBox3.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 23);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GenerateKeyBtn
            // 
            this.GenerateKeyBtn.Location = new System.Drawing.Point(634, 27);
            this.GenerateKeyBtn.Name = "GenerateKeyBtn";
            this.GenerateKeyBtn.Size = new System.Drawing.Size(94, 21);
            this.GenerateKeyBtn.TabIndex = 23;
            this.GenerateKeyBtn.Text = "Generuj klucz";
            this.GenerateKeyBtn.UseVisualStyleBackColor = true;
            this.GenerateKeyBtn.Click += new System.EventHandler(this.GenerateKeyBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 21);
            this.button1.TabIndex = 24;
            this.button1.Text = "Szyfruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 21);
            this.button2.TabIndex = 25;
            this.button2.Text = "Deszyfruj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(329, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 23);
            this.textBox4.TabIndex = 26;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenerateKeyBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintRestriction);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private CheckBox PrintRestriction;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox1;
        private Button GenerateKeyBtn;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
    }
}