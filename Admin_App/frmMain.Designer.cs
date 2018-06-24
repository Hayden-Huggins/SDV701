namespace Admin_App
{
    partial class frmMain
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
            this.lstGenre = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstGenre
            // 
            this.lstGenre.FormattingEnabled = true;
            this.lstGenre.Location = new System.Drawing.Point(12, 28);
            this.lstGenre.Name = "lstGenre";
            this.lstGenre.Size = new System.Drawing.Size(184, 238);
            this.lstGenre.TabIndex = 0;
            this.lstGenre.DoubleClick += new System.EventHandler(this.lstGenre_DoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(212, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(12, 313);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 9);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genres:";
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.Location = new System.Drawing.Point(12, 278);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(93, 13);
            this.lblPendingOrders.TabIndex = 7;
            this.lblPendingOrders.Text = "Pending Orders: X";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 348);
            this.Controls.Add(this.lblPendingOrders);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstGenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGenre;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPendingOrders;
    }
}

