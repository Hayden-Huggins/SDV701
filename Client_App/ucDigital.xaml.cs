// Created by Hayden Huggins 20/06/2018
// This is a user control, a custom object which will be instansiated within the content control dynamically
// This control is also responsible for updating the relevant data to the clsAllBook passed in
// This way, we are able to "mimic" inherited forms in a way, with the content control being the placeholder
// I have chosen not to include the other field being serial key, otherwise the customer could get the books for free
// Providing the download link, means that i can provide something for this kind of "form" presented to them, and they can start pre downloading it during payment input

using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Client_App
{
    public sealed partial class ucDigital : UserControl, IBookControl
    {
        public ucDigital()
        {
            this.InitializeComponent();
        }

        public void UpdateControl(clsAllBook prBook)
        {
            txtDownloadURL.Text = "Download URL: " + prBook.DownloadURL;
        }
    }
}
