namespace Admin_App
{
    partial class frmDigital
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
            this.tbxSerialKey = new System.Windows.Forms.TextBox();
            this.lblDlUrl = new System.Windows.Forms.Label();
            this.lblSerialKey = new System.Windows.Forms.Label();
            this.tbxKeyUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxSerialKey
            // 
            this.tbxSerialKey.Location = new System.Drawing.Point(84, 110);
            this.tbxSerialKey.MaxLength = 255;
            this.tbxSerialKey.Name = "tbxSerialKey";
            this.tbxSerialKey.Size = new System.Drawing.Size(112, 20);
            this.tbxSerialKey.TabIndex = 13;
            // 
            // lblDlUrl
            // 
            this.lblDlUrl.AutoSize = true;
            this.lblDlUrl.Location = new System.Drawing.Point(8, 136);
            this.lblDlUrl.Name = "lblDlUrl";
            this.lblDlUrl.Size = new System.Drawing.Size(56, 13);
            this.lblDlUrl.TabIndex = 14;
            this.lblDlUrl.Text = "Key URL: ";
            // 
            // lblSerialKey
            // 
            this.lblSerialKey.AutoSize = true;
            this.lblSerialKey.Location = new System.Drawing.Point(8, 110);
            this.lblSerialKey.Name = "lblSerialKey";
            this.lblSerialKey.Size = new System.Drawing.Size(57, 13);
            this.lblSerialKey.TabIndex = 16;
            this.lblSerialKey.Text = "Serial Key:";
            // 
            // tbxKeyUrl
            // 
            this.tbxKeyUrl.Location = new System.Drawing.Point(84, 136);
            this.tbxKeyUrl.MaxLength = 255;
            this.tbxKeyUrl.Name = "tbxKeyUrl";
            this.tbxKeyUrl.Size = new System.Drawing.Size(112, 20);
            this.tbxKeyUrl.TabIndex = 15;
            // 
            // frmDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(456, 223);
            this.Controls.Add(this.lblSerialKey);
            this.Controls.Add(this.tbxKeyUrl);
            this.Controls.Add(this.lblDlUrl);
            this.Controls.Add(this.tbxSerialKey);
            this.Name = "frmDigital";
            this.Text = "Digital Book ";
            this.Controls.SetChildIndex(this.tbxSerialKey, 0);
            this.Controls.SetChildIndex(this.lblDlUrl, 0);
            this.Controls.SetChildIndex(this.tbxKeyUrl, 0);
            this.Controls.SetChildIndex(this.lblSerialKey, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSerialKey;
        private System.Windows.Forms.Label lblDlUrl;
        private System.Windows.Forms.Label lblSerialKey;
        private System.Windows.Forms.TextBox tbxKeyUrl;
    }
}
