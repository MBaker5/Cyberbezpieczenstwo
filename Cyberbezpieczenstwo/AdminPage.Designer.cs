namespace Cyberbezpieczenstwo
{
    partial class AdminPage
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
            this.MngUserBtn = new System.Windows.Forms.Button();
            this.ChangepassBtn = new System.Windows.Forms.Button();
            this.DoStuffBtn = new System.Windows.Forms.Button();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MngUserBtn
            // 
            this.MngUserBtn.Location = new System.Drawing.Point(262, 120);
            this.MngUserBtn.Name = "MngUserBtn";
            this.MngUserBtn.Size = new System.Drawing.Size(300, 50);
            this.MngUserBtn.TabIndex = 0;
            this.MngUserBtn.Text = "Manage Users";
            this.MngUserBtn.UseVisualStyleBackColor = true;
            this.MngUserBtn.Click += new System.EventHandler(this.MngUserBtn_Click);
            // 
            // ChangepassBtn
            // 
            this.ChangepassBtn.Location = new System.Drawing.Point(262, 232);
            this.ChangepassBtn.Name = "ChangepassBtn";
            this.ChangepassBtn.Size = new System.Drawing.Size(300, 50);
            this.ChangepassBtn.TabIndex = 1;
            this.ChangepassBtn.Text = "Change Password";
            this.ChangepassBtn.UseVisualStyleBackColor = true;
            this.ChangepassBtn.Click += new System.EventHandler(this.ChangepassBtn_Click);
            // 
            // DoStuffBtn
            // 
            this.DoStuffBtn.Location = new System.Drawing.Point(262, 344);
            this.DoStuffBtn.Name = "DoStuffBtn";
            this.DoStuffBtn.Size = new System.Drawing.Size(300, 50);
            this.DoStuffBtn.TabIndex = 2;
            this.DoStuffBtn.Text = "Do Stuff";
            this.DoStuffBtn.UseVisualStyleBackColor = true;
            this.DoStuffBtn.Visible = false;
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLbl.Location = new System.Drawing.Point(262, 49);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(0, 25);
            this.WelcomeLbl.TabIndex = 3;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.DoStuffBtn);
            this.Controls.Add(this.ChangepassBtn);
            this.Controls.Add(this.MngUserBtn);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MngUserBtn;
        private Button ChangepassBtn;
        private Button DoStuffBtn;
        private Label WelcomeLbl;
    }
}