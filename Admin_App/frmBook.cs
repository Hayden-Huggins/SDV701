// Created by Hayden Huggins 20/06/2018
// This form is the parent form from which frmDigital and frmPhysical inherit common controls and code from
// This form does alot of the heavy lifting for them, by pushing and pulling base data, sending all of the calls to the service
// Starts a null checking chain and helps dispatch those forms when need be

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Admin_App
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        protected clsAllBook _Book;

        public static Dictionary<string, Delegate> _BooksForm = new Dictionary<string, Delegate>
        {
            {"P", new LoadWorkFormDelegate(frmPhysical.Run)},
            {"D", new LoadWorkFormDelegate(frmDigital.Run)}
        };

        protected string lcMessage = "";

        public delegate void LoadWorkFormDelegate(clsAllBook prBook);


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                checkForNulls();
                pushData();
                if (tbxIsbn.Enabled)
                    MessageBox.Show(await ServiceClient.InsertBookAsync(_Book));
                else
                    MessageBox.Show(await ServiceClient.UpdateBookAsync(_Book));
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void checkForNulls()
        {

            if (String.IsNullOrEmpty(tbxIsbn.Text))
            {
                lcMessage = lcMessage + "Please enter an ISBN Number";
            }
            if (String.IsNullOrEmpty(tbxName.Text))
            {
                lcMessage = lcMessage + "\n" + "Please enter a Book Name";
            }
            if (String.IsNullOrEmpty(tbxPrice.Text))
            {
                lcMessage = lcMessage + "\n" + "Please enter a Price";
            }
        }

        public static void DispatchBookForm(clsAllBook prBook)
        {
            _BooksForm[prBook.BookFormat].DynamicInvoke(prBook);
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            getCbxGenreNames();
        }

        private async void getCbxGenreNames()
        {
            cbxGenreName.DataSource = null;
            cbxGenreName.DataSource = await ServiceClient.GetGenreNamesAsync();
        }

        protected virtual void pushData()
        {
            _Book.ISBN = tbxIsbn.Text;
            _Book.Name = tbxName.Text;
            _Book.Price = decimal.Parse(tbxPrice.Text);
            _Book.GenreName = cbxGenreName.Text;
            _Book.LastModified = DateTime.Now;
        }

        public void SetDetails(clsAllBook prBook)
        {
            _Book = prBook;
            updateForm();
            ShowDialog();
        }

        protected virtual void updateForm()
        {
            tbxIsbn.Enabled = string.IsNullOrEmpty(_Book.Name);
            tbxIsbn.Text = _Book.ISBN;
            tbxName.Text = _Book.Name;
            tbxPrice.Text = _Book.Price.ToString();
            cbxGenreName.Text = _Book.GenreName;
            lblLastModified.Text = "Last Modified: " + _Book.LastModified;
        }
        
    }
}
