// Created by Hayden Huggins 20/06/2018
// this form lets the administrative users know which orders have been placed from the client application
// here we can manage the orders by deleting them once complete
// This form also lets us calculate the total order value for all orders combined

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Admin_App
{
    public sealed partial class frmOrders : Form
    {
        private frmOrders()
        {
            InitializeComponent();
        }

        public static frmOrders Instance { get; } = new frmOrders();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstOrder.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteOrderAsync(lstOrder.SelectedItem as clsOrder));
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        public async void UpdateDisplay()
        {
            lstOrder.DataSource = null;
            List<clsOrder> lcOrders = await ServiceClient.GetOrdersAsync();
            lstOrder.DataSource = lcOrders;
            lblTotalValue.Text = "Total Order Value: " + clsOrder.CalculateTotalOrderValue(lcOrders).ToString();

        }
    }

    
}
