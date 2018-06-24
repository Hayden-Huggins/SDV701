// Created by Hayden Huggins 20/06/2018
// This form is our main one, we can start selecting from genres to add books into
// and open our orders form, this form also shows how many pending orders there are too
// As a note, i am aware of multi line commenting being /* * * */, I just perfer this method of commenting


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Admin_App
{
    public sealed partial class frmMain : Form
    {

        private static readonly frmMain _Instance = new frmMain();

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        private frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders.Instance.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void lstGenre_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstGenre.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmGenre.Run(lcKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        public async void UpdateDisplay()
        {
            lstGenre.DataSource = null;
            try
            {
                lstGenre.DataSource = await ServiceClient.GetGenreNamesAsync();
                List<clsOrder> lcOrders = await ServiceClient.GetOrdersAsync();
                lblPendingOrders.Text = "Pending Orders: " + clsOrder.CalculatePendingOrders(lcOrders).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
