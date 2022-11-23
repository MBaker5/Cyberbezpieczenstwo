namespace Cyberbezpieczenstwo
{
    partial class CaptchaForm
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
            this.CaptchapicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchapicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptchapicBox
            // 
            this.CaptchapicBox.Location = new System.Drawing.Point(233, 64);
            this.CaptchapicBox.Name = "CaptchapicBox";
            this.CaptchapicBox.Size = new System.Drawing.Size(300, 100);
            this.CaptchapicBox.TabIndex = 0;
            this.CaptchapicBox.TabStop = false;
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CaptchapicBox);
            this.Name = "CaptchaForm";
            this.Text = "CaptchaForm";
            ((System.ComponentModel.ISupportInitialize)(this.CaptchapicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox CaptchapicBox;
    }
}