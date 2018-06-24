// Created by Hayden Huggins 20/06/2018
// This is a user control, a custom object which will be instansiated within the content control dynamically
// This control is also responsible for updating the relevant data to the clsAllBook passed in
// This way, we are able to "mimic" inherited forms in a way, with the content control being the placeholder

using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Client_App
{
    public sealed partial class ucPhysical : UserControl, IBookControl
    {
        public ucPhysical()
        {
            this.InitializeComponent();
        }

        public void UpdateControl(clsAllBook prBook)
        {
            txtQuantity.Text = "Quantity: " + prBook.Quantity.ToString();
            txtCoverType.Text = "Cover Type: " + prBook.CoverType;
        }
    }
}
