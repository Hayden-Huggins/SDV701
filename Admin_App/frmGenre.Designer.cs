namespace Admin_App
{
    partial class frmGenre
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
            this.lblGenreName = new System.Windows.Forms.Label();
            this.lblGenreDescription = new System.Windows.Forms.Label();
            this.lblMaturityLvl = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbxChoice = new System.Windows.Forms.ComboBox();
            this.lblGenreText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Location = new System.Drawing.Point(9, 8);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(70, 13);
            this.lblGenreName.TabIndex = 0;
            this.lblGenreName.Text = "Genre Name:";
            // 
            // lblGenreDescription
            // 
            this.lblGenreDescription.AutoSize = true;
            this.lblGenreDescription.Location = new System.Drawing.Point(9, 26);
            this.lblGenreDescription.Name = "lblGenreDescription";
            this.lblGenreDescription.Size = new System.Drawing.Size(95, 13);
            this.lblGenreDescription.TabIndex = 1;
            this.lblGenreDescription.Text = "Genre Description:";
            // 
            // lblMaturityLvl
            // 
            this.lblMaturityLvl.AutoSize = true;
            this.lblMaturityLvl.Location = new System.Drawing.Point(9, 54);
            this.lblMaturityLvl.Name = "lblMaturityLvl";
            this.lblMaturityLvl.Size = new System.Drawing.Size(79, 13);
            this.lblMaturityLvl.TabIndex = 2;
            this.lblMaturityLvl.Text = "Maturity Level :";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(12, 111);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(318, 160);
            this.lstBooks.TabIndex = 4;
            this.lstBooks.DoubleClick += new System.EventHandler(this.lstBooks_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(336, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(108, 95);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(39, 13);
            this.lblFormat.TabIndex = 10;
            this.lblFormat.Text = "Format";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(155, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // cbxChoice
            // 
            this.cbxChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChoice.FormattingEnabled = true;
            this.cbxChoice.Items.AddRange(new object[] {
            "Physical",
            "Digital"});
            this.cbxChoice.Location = new System.Drawing.Point(209, 3);
            this.cbxChoice.Name = "cbxChoice";
            this.cbxChoice.Size = new System.Drawing.Size(121, 21);
            this.cbxChoice.TabIndex = 12;
            // 
            // lblGenreText
            // 
            this.lblGenreText.AutoSize = true;
            this.lblGenreText.Location = new System.Drawing.Point(85, 8);
            this.lblGenreText.Name = "lblGenreText";
            this.lblGenreText.Size = new System.Drawing.Size(0, 13);
            this.lblGenreText.TabIndex = 13;
            // 
            // frmGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 282);
            this.Controls.Add(this.lblGenreText);
            this.Controls.Add(this.cbxChoice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lblMaturityLvl);
            this.Controls.Add(this.lblGenreDescription);
            this.Controls.Add(this.lblGenreName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenre";
            this.Text = "Genre Book Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.Label lblGenreDescription;
        private System.Windows.Forms.Label lblMaturityLvl;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbxChoice;
        private System.Windows.Forms.Label lblGenreText;
    }
}