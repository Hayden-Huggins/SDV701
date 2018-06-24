namespace Admin_App
{
    partial class frmPhysical
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
            this.lblCoverType = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.cbxCoverType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCoverType
            // 
            this.lblCoverType.AutoSize = true;
            this.lblCoverType.Location = new System.Drawing.Point(8, 136);
            this.lblCoverType.Name = "lblCoverType";
            this.lblCoverType.Size = new System.Drawing.Size(68, 13);
            this.lblCoverType.TabIndex = 13;
            this.lblCoverType.Text = "Cover Type: ";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(84, 110);
            this.tbxQuantity.MaxLength = 4;
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbxQuantity.TabIndex = 16;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(9, 113);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(52, 13);
            this.lblQty.TabIndex = 15;
            this.lblQty.Text = "Quantity: ";
            // 
            // cbxCoverType
            // 
            this.cbxCoverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoverType.FormattingEnabled = true;
            this.cbxCoverType.Items.AddRange(new object[] {
            "S",
            "H"});
            this.cbxCoverType.Location = new System.Drawing.Point(82, 136);
            this.cbxCoverType.Name = "cbxCoverType";
            this.cbxCoverType.Size = new System.Drawing.Size(121, 21);
            this.cbxCoverType.TabIndex = 17;
            // 
            // frmPhysical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(456, 223);
            this.Controls.Add(this.cbxCoverType);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblCoverType);
            this.Name = "frmPhysical";
            this.Text = "Physical Book";
            this.Controls.SetChildIndex(this.lblCoverType, 0);
            this.Controls.SetChildIndex(this.lblQty, 0);
            this.Controls.SetChildIndex(this.tbxQuantity, 0);
            this.Controls.SetChildIndex(this.cbxCoverType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoverType;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ComboBox cbxCoverType;
    }
}
