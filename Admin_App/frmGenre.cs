// Created by Hayden Huggins 20/06/2018
// This form is a busy one, we can add books of a physical type or digital, we can delete books from the genre
// if we add books we dispatch the relevant form we need
// This form also displays helpful information for the current genre

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Admin_App
{
    public sealed partial class frmGenre : Form
    {

        private clsGenre _Genre;

        private static Dictionary<string, frmGenre> _GenreFormList =
        new Dictionary<string, frmGenre>();

        private static readonly frmGenre _Instance = new frmGenre();

        public static frmGenre Instance

        {
            get { return frmGenre._Instance; }

        }

        private frmGenre()
        {
            InitializeComponent();
            cbxChoice.Text = "Physical";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string lcChoice = cbxChoice.Text;
                if (cbxChoice.Text == "Physical")
                {
                    lcChoice = "P";
                }
                else if (cbxChoice.Text == "Digital")
                {
                    lcChoice = "D";
                }
                if (!string.IsNullOrEmpty(lcChoice))
                {
                    clsAllBook lcBook = clsAllBook.NewBook(lcChoice);
                    frmBook.DispatchBookForm(lcBook);
                    refreshFormFromDB(_Genre.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstBooks.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteBookAsync(lstBooks.SelectedItem as clsAllBook));
                refreshFormFromDB(_Genre.Name);
                frmMain.Instance.UpdateDisplay();
            }
        }

        public async void refreshFormFromDB(string prGenreName)
        {

            SetDetails(await ServiceClient.GetGenreAsync(prGenreName));

        }

        public static void Run(string prGenreName)
        {
            frmGenre lcGenreForm;
            if (string.IsNullOrEmpty(prGenreName)||
            !_GenreFormList.TryGetValue(prGenreName, out lcGenreForm))
            {
                lcGenreForm = new frmGenre();
                if (string.IsNullOrEmpty(prGenreName))
                    lcGenreForm.SetDetails(new clsGenre());
                else
                {
                    _GenreFormList.Add(prGenreName, lcGenreForm);
                    lcGenreForm.refreshFormFromDB(prGenreName);
                }
            }
            else
            {
                lcGenreForm.Show();
                lcGenreForm.Activate();
            }
        }

        private void lstBooks_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmBook.DispatchBookForm(lstBooks.SelectedValue as clsAllBook);
                refreshFormFromDB(_Genre.Name);
                frmMain.Instance.UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void SetDetails(clsGenre prGenre)
        {
            try
            {
                _Genre = prGenre;
                UpdateForm();
                lstBooks.DataSource = null;
                List<clsAllBook> lcGenreBooks = await ServiceClient.GetGenreBooksAsync(_Genre.Name);
                lstBooks.DataSource = lcGenreBooks;
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateForm()
        {
            lblGenreText.Text = _Genre.Name;
            lblGenreDescription.Text = "Genre Description: " + _Genre.Description;
            lblMaturityLvl.Text = "Maturity Level: " + _Genre.MaturityLevel;
        }
    }
}
