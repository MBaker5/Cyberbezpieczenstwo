namespace Cyberbezpieczenstwo
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            this.AccoutsGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passwordRestrictionsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lockedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewUserPassTxtb = new System.Windows.Forms.TextBox();
            this.NewUserLoginTxtb = new System.Windows.Forms.TextBox();
            this.AddNewUserBtn = new System.Windows.Forms.Button();
            this.NewUserPassLbl = new System.Windows.Forms.Label();
            this.NewUserLoginLbl = new System.Windows.Forms.Label();
            this.EditUserBtn = new System.Windows.Forms.Button();
            this.EditUserIDTxtb = new System.Windows.Forms.TextBox();
            this.UserToEditLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenOneTimePassChckBX = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AccoutsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccoutsGV
            // 
            this.AccoutsGV.AllowUserToAddRows = false;
            this.AccoutsGV.AllowUserToDeleteRows = false;
            this.AccoutsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccoutsGV.AutoGenerateColumns = false;
            this.AccoutsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccoutsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn,
            this.passwordRestrictionsDataGridViewCheckBoxColumn,
            this.lockedDataGridViewCheckBoxColumn,
            this.passChangeDataGridViewTextBoxColumn});
            this.AccoutsGV.DataSource = this.accountBindingSource;
            this.AccoutsGV.Location = new System.Drawing.Point(12, 31);
            this.AccoutsGV.Name = "AccoutsGV";
            this.AccoutsGV.ReadOnly = true;
            this.AccoutsGV.RowTemplate.Height = 25;
            this.AccoutsGV.Size = new System.Drawing.Size(776, 223);
            this.AccoutsGV.TabIndex = 0;
            this.AccoutsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            this.adminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // passwordRestrictionsDataGridViewCheckBoxColumn
            // 
            this.passwordRestrictionsDataGridViewCheckBoxColumn.DataPropertyName = "PasswordRestrictions";
            this.passwordRestrictionsDataGridViewCheckBoxColumn.HeaderText = "PasswordRestrictions";
            this.passwordRestrictionsDataGridViewCheckBoxColumn.Name = "passwordRestrictionsDataGridViewCheckBoxColumn";
            this.passwordRestrictionsDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // lockedDataGridViewCheckBoxColumn
            // 
            this.lockedDataGridViewCheckBoxColumn.DataPropertyName = "Locked";
            this.lockedDataGridViewCheckBoxColumn.HeaderText = "Locked";
            this.lockedDataGridViewCheckBoxColumn.Name = "lockedDataGridViewCheckBoxColumn";
            this.lockedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // passChangeDataGridViewTextBoxColumn
            // 
            this.passChangeDataGridViewTextBoxColumn.DataPropertyName = "PassChange";
            this.passChangeDataGridViewTextBoxColumn.HeaderText = "PassChange";
            this.passChangeDataGridViewTextBoxColumn.Name = "passChangeDataGridViewTextBoxColumn";
            this.passChangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.passChangeDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(Cyberbezpieczenstwo.Models.Account);
            // 
            // NewUserPassTxtb
            // 
            this.NewUserPassTxtb.Location = new System.Drawing.Point(12, 321);
            this.NewUserPassTxtb.Name = "NewUserPassTxtb";
            this.NewUserPassTxtb.Size = new System.Drawing.Size(150, 23);
            this.NewUserPassTxtb.TabIndex = 2;
            // 
            // NewUserLoginTxtb
            // 
            this.NewUserLoginTxtb.Location = new System.Drawing.Point(12, 275);
            this.NewUserLoginTxtb.Name = "NewUserLoginTxtb";
            this.NewUserLoginTxtb.Size = new System.Drawing.Size(150, 23);
            this.NewUserLoginTxtb.TabIndex = 3;
            // 
            // AddNewUserBtn
            // 
            this.AddNewUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewUserBtn.Location = new System.Drawing.Point(12, 383);
            this.AddNewUserBtn.Name = "AddNewUserBtn";
            this.AddNewUserBtn.Size = new System.Drawing.Size(150, 55);
            this.AddNewUserBtn.TabIndex = 4;
            this.AddNewUserBtn.Text = "Dodaj nowego uzytkownika";
            this.AddNewUserBtn.UseVisualStyleBackColor = true;
            this.AddNewUserBtn.Click += new System.EventHandler(this.AddNewUserBtn_Click);
            // 
            // NewUserPassLbl
            // 
            this.NewUserPassLbl.AutoSize = true;
            this.NewUserPassLbl.Location = new System.Drawing.Point(12, 301);
            this.NewUserPassLbl.Name = "NewUserPassLbl";
            this.NewUserPassLbl.Size = new System.Drawing.Size(57, 15);
            this.NewUserPassLbl.TabIndex = 5;
            this.NewUserPassLbl.Text = "password";
            // 
            // NewUserLoginLbl
            // 
            this.NewUserLoginLbl.AutoSize = true;
            this.NewUserLoginLbl.Location = new System.Drawing.Point(12, 257);
            this.NewUserLoginLbl.Name = "NewUserLoginLbl";
            this.NewUserLoginLbl.Size = new System.Drawing.Size(34, 15);
            this.NewUserLoginLbl.TabIndex = 6;
            this.NewUserLoginLbl.Text = "login";
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.Location = new System.Drawing.Point(638, 383);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(150, 55);
            this.EditUserBtn.TabIndex = 7;
            this.EditUserBtn.Text = "Edytuj uzytkownika";
            this.EditUserBtn.UseVisualStyleBackColor = true;
            this.EditUserBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditUserIDTxtb
            // 
            this.EditUserIDTxtb.Location = new System.Drawing.Point(638, 339);
            this.EditUserIDTxtb.Name = "EditUserIDTxtb";
            this.EditUserIDTxtb.Size = new System.Drawing.Size(150, 23);
            this.EditUserIDTxtb.TabIndex = 8;
            // 
            // UserToEditLbl
            // 
            this.UserToEditLbl.AutoSize = true;
            this.UserToEditLbl.Location = new System.Drawing.Point(638, 321);
            this.UserToEditLbl.Name = "UserToEditLbl";
            this.UserToEditLbl.Size = new System.Drawing.Size(18, 15);
            this.UserToEditLbl.TabIndex = 9;
            this.UserToEditLbl.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(194, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 10;
            // 
            // GenOneTimePassChckBX
            // 
            this.GenOneTimePassChckBX.AutoSize = true;
            this.GenOneTimePassChckBX.Location = new System.Drawing.Point(12, 358);
            this.GenOneTimePassChckBX.Name = "GenOneTimePassChckBX";
            this.GenOneTimePassChckBX.Size = new System.Drawing.Size(209, 19);
            this.GenOneTimePassChckBX.TabIndex = 11;
            this.GenOneTimePassChckBX.Text = "Generowanie jednorazowego hasła";
            this.GenOneTimePassChckBX.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenOneTimePassChckBX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserToEditLbl);
            this.Controls.Add(this.EditUserIDTxtb);
            this.Controls.Add(this.EditUserBtn);
            this.Controls.Add(this.NewUserLoginLbl);
            this.Controls.Add(this.NewUserPassLbl);
            this.Controls.Add(this.AddNewUserBtn);
            this.Controls.Add(this.NewUserLoginTxtb);
            this.Controls.Add(this.NewUserPassTxtb);
            this.Controls.Add(this.AccoutsGV);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.AccoutsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView AccoutsGV;
        private BindingSource accountBindingSource;
        private TextBox NewUserPassTxtb;
        private TextBox NewUserLoginTxtb;
        private Button AddNewUserBtn;
        private Label NewUserPassLbl;
        private Label NewUserLoginLbl;
        private Button EditUserBtn;
        private TextBox EditUserIDTxtb;
        private Label UserToEditLbl;
        private Label label4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn passwordRestrictionsDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn lockedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn printLockedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn passChangeDataGridViewTextBoxColumn;
        private CheckBox GenOneTimePassChckBX;
    }
}