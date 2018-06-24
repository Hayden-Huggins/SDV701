// Created by Hayden Huggins 20/06/2018
// This page manages our genere specific books, we can go back to the home page, or click on a book to take us to the order page
// We can also search for books and that will repopulate the list for us, this is non genre specfic which was a design descision by me
// one issue i could not resolve is two button back click events, when removed the program demands it, when i take it away from the form designer
// then try to build the program, it changes the code, i cannot build the application without it

using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgGenre : Page
    {
        private clsGenre _Genre;

        public pgGenre()
        {
            this.InitializeComponent();
            this.btnSelect.Click += btnSelect_Click;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pgMain));
        }

        private void btnBack_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pgMain));
        }

        private async void btnGo_Click(object sender, RoutedEventArgs e)
        {
            lstGenreBooks.ItemsSource = null;
            lstGenreBooks.ItemsSource = await ServiceClient.GetBookQueryAsync(tbxSearch.Text);
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                clsAllBook lcBook = (clsAllBook)lstGenreBooks.SelectedItem;
                string lcName = lcBook.Name;
                this.Frame.Navigate(typeof(pgBook), lcName);
            }
            catch (Exception)
            {


            }
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                string lcGenreName = e.Parameter.ToString();
                _Genre = await ServiceClient.GetGenreAsync(lcGenreName);
                lstGenreBooks.ItemsSource = await ServiceClient.GetGenreBooksAsync(lcGenreName);
                updateDisplay();
            }
        }

        private void updateDisplay()
        {
            lblGenreName.Text = "Genre Name: " + _Genre.Name;
            lblGenreDescription.Text = "Genre Description: " + _Genre.Description;
            lblMaturityLevel.Text = "Maturity Level: " + _Genre.MaturityLevel;
        }
    }
}
