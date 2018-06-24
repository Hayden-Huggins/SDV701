namespace Admin_App
{
    partial class frmBook
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.cbxGenreName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(369, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(369, 160);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(8, 35);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN:";
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(84, 32);
            this.tbxIsbn.MaxLength = 17;
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(100, 20);
            this.tbxIsbn.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(84, 58);
            this.tbxName.MaxLength = 255;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblLastModified
            // 
            this.lblLastModified.AutoSize = true;
            this.lblLastModified.Location = new System.Drawing.Point(224, 9);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(76, 13);
            this.lblLastModified.TabIndex = 6;
            this.lblLastModified.Text = "Last Modified: \r\n";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(84, 84);
            this.tbxPrice.MaxLength = 6;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(8, 87);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Location = new System.Drawing.Point(8, 8);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(70, 13);
            this.lblGenreName.TabIndex = 13;
            this.lblGenreName.Text = "Genre Name:";
            // 
            // cbxGenreName
            // 
            this.cbxGenreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenreName.FormattingEnabled = true;
            this.cbxGenreName.Location = new System.Drawing.Point(84, 5);
            this.cbxGenreName.Name = "cbxGenreName";
            this.cbxGenreName.Size = new System.Drawing.Size(121, 21);
            this.cbxGenreName.TabIndex = 15;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 223);
            this.Controls.Add(this.cbxGenreName);
            this.Controls.Add(this.lblGenreName);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLastModified);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxIsbn);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBook";
            this.Text = "Book Form";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastModified;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.ComboBox cbxGenreName;
    }
}