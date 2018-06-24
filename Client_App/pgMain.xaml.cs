// Created by Hayden Huggins 20/06/2018
// This is our main page, which gets populated with the same data from the same call as the administrator app does
// This helps our users choose a genre, and move on

using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Client_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgMain : Page
    {
        public pgMain()
        {
            this.InitializeComponent();

            this.btnSelect.Click += btnSelect_Click;
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            int lcIndex = lstGenre.SelectedIndex;
            if (lcIndex >= 0)
                this.Frame.Navigate(typeof(pgGenre), lstGenre.SelectedItem);
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                lstGenre.ItemsSource = await ServiceClient.GetGenreNamesAsync();
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog(ex.Message);
                await dialog.ShowAsync();
            }
        }
    }
}
