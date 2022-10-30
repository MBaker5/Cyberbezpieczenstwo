namespace Cyberbezpieczenstwo
{
    partial class UserPanel
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
            this.ChangepassBtn = new System.Windows.Forms.Button();
            this.newpassTxtbx = new System.Windows.Forms.TextBox();
            this.oldpassTxtbx = new System.Windows.Forms.TextBox();
            this.oldpassLbl = new System.Windows.Forms.Label();
            this.newpassLbl = new System.Windows.Forms.Label();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.DoSthBtn = new System.Windows.Forms.Button();
            this.newpassrepeatTxtbx = new System.Windows.Forms.TextBox();
            this.newpassrepatLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangepassBtn
            // 
            this.ChangepassBtn.Location = new System.Drawing.Point(242, 264);
            this.ChangepassBtn.Name = "ChangepassBtn";
            this.ChangepassBtn.Size = new System.Drawing.Size(300, 50);
            this.ChangepassBtn.TabIndex = 1;
            this.ChangepassBtn.Text = "Zmien hasło";
            this.ChangepassBtn.UseVisualStyleBackColor = true;
            this.ChangepassBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // newpassTxtbx
            // 
            this.newpassTxtbx.Location = new System.Drawing.Point(242, 164);
            this.newpassTxtbx.Name = "newpassTxtbx";
            this.newpassTxtbx.PasswordChar = '*';
            this.newpassTxtbx.Size = new System.Drawing.Size(300, 23);
            this.newpassTxtbx.TabIndex = 2;
            this.newpassTxtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // oldpassTxtbx
            // 
            this.oldpassTxtbx.Location = new System.Drawing.Point(242, 120);
            this.oldpassTxtbx.Name = "oldpassTxtbx";
            this.oldpassTxtbx.PasswordChar = '*';
            this.oldpassTxtbx.Size = new System.Drawing.Size(300, 23);
            this.oldpassTxtbx.TabIndex = 3;
            // 
            // oldpassLbl
            // 
            this.oldpassLbl.AutoSize = true;
            this.oldpassLbl.Location = new System.Drawing.Point(242, 102);
            this.oldpassLbl.Name = "oldpassLbl";
            this.oldpassLbl.Size = new System.Drawing.Size(64, 15);
            this.oldpassLbl.TabIndex = 4;
            this.oldpassLbl.Text = "Stare haslo";
            // 
            // newpassLbl
            // 
            this.newpassLbl.AutoSize = true;
            this.newpassLbl.Location = new System.Drawing.Point(242, 146);
            this.newpassLbl.Name = "newpassLbl";
            this.newpassLbl.Size = new System.Drawing.Size(69, 15);
            this.newpassLbl.TabIndex = 5;
            this.newpassLbl.Text = "Nowe hasło";
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLbl.Location = new System.Drawing.Point(242, 51);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(0, 37);
            this.WelcomeLbl.TabIndex = 6;
            // 
            // DoSthBtn
            // 
            this.DoSthBtn.Location = new System.Drawing.Point(242, 329);
            this.DoSthBtn.Name = "DoSthBtn";
            this.DoSthBtn.Size = new System.Drawing.Size(300, 50);
            this.DoSthBtn.TabIndex = 7;
            this.DoSthBtn.Text = "Zrob cos";
            this.DoSthBtn.UseVisualStyleBackColor = true;
            this.DoSthBtn.Click += new System.EventHandler(this.DoSthBtn_Click);
            // 
            // newpassrepeatTxtbx
            // 
            this.newpassrepeatTxtbx.Location = new System.Drawing.Point(242, 208);
            this.newpassrepeatTxtbx.Name = "newpassrepeatTxtbx";
            this.newpassrepeatTxtbx.PasswordChar = '*';
            this.newpassrepeatTxtbx.Size = new System.Drawing.Size(300, 23);
            this.newpassrepeatTxtbx.TabIndex = 8;
            // 
            // newpassrepatLbl
            // 
            this.newpassrepatLbl.AutoSize = true;
            this.newpassrepatLbl.Location = new System.Drawing.Point(242, 190);
            this.newpassrepatLbl.Name = "newpassrepatLbl";
            this.newpassrepatLbl.Size = new System.Drawing.Size(113, 15);
            this.newpassrepatLbl.TabIndex = 9;
            this.newpassrepatLbl.Text = "Powtorz nowe hasło";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newpassrepatLbl);
            this.Controls.Add(this.newpassrepeatTxtbx);
            this.Controls.Add(this.DoSthBtn);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.newpassLbl);
            this.Controls.Add(this.oldpassLbl);
            this.Controls.Add(this.oldpassTxtbx);
            this.Controls.Add(this.newpassTxtbx);
            this.Controls.Add(this.ChangepassBtn);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChangepassBtn;
        private TextBox newpassTxtbx;
        private TextBox oldpassTxtbx;
        private Label oldpassLbl;
        private Label newpassLbl;
        private Label WelcomeLbl;
        private Button DoSthBtn;
        private TextBox newpassrepeatTxtbx;
        private Label newpassrepatLbl;
    }
}