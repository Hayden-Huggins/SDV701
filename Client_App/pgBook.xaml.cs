// Created by Hayden Huggins 20/06/2018
// This page lets us view more details about the book that we selected on the previous page
// this page dynamically instansiates the correct user control based on the type of book
// Also, lets us place orders, does some error checking for us and if the system is happy, then it places the order for us to the database through the service client class

using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Client_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgBook : Page
    {
        private clsAllBook _Book;

        private Dictionary<string, Delegate> _BooksContent;

        private clsOrder _Order;

        private delegate void LoadBookControlDelegate(clsAllBook prBook);

        public pgBook()
        {
            this.InitializeComponent();
            _BooksContent = new Dictionary<string, Delegate>
            {
                {"P", new LoadBookControlDelegate(RunPhysical)},
                {"D", new LoadBookControlDelegate(RunDigital)}
            };

        }

        private void Button_Click(object sender, RoutedEventArgs e) // This control is called btnBack
        {
            this.Frame.Navigate(typeof(pgGenre), _Book.GenreName);
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {

            errorCheck();
        }

        private clsAllBook BuildBook(int prQuantity)
        {
            clsAllBook lcBook = new clsAllBook();
            lcBook.ISBN = _Book.ISBN;
            lcBook.Quantity = prQuantity;
            return lcBook;
        }

        private void dispatchBookContent(clsAllBook prBook)
        {
            _BooksContent[prBook.BookFormat].DynamicInvoke(prBook);
            updatePage(prBook);
        }

        private async void errorCheck()
        {
            try
            {
                int? lcRemainingStock = _Book.Quantity;
                int lcOrderCnt = Convert.ToInt32(tbxQuantity.Text);
                if (lcOrderCnt > lcRemainingStock)
                {
                    var dialogError = new MessageDialog("Sorry, We only have " + _Book.Quantity + " in stock!");
                    await dialogError.ShowAsync();
                }
                else if (lcOrderCnt <= 0 || string.IsNullOrWhiteSpace(tbxQuantity.Text))
                {
                    var dialogError = new MessageDialog("Please enter a valid Quantity!");
                    await dialogError.ShowAsync();
                }
                else if (string.IsNullOrWhiteSpace(tbxCustName.Text) || string.IsNullOrWhiteSpace(tbxCustEmailAddress.Text))
                {
                    var dialogError = new MessageDialog("Please fill in your details");
                    await dialogError.ShowAsync();
                }
                else
                {
                    sendOrder();
                }
            }
            catch (Exception)
            {
                var dialogErrorEmpty = new MessageDialog("Please fill in the fields properly");
                await dialogErrorEmpty.ShowAsync();
            }

        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                string lcBookName = e.Parameter.ToString();
                _Book = await ServiceClient.GetBookAsync(lcBookName);
                dispatchBookContent(_Book);
                updateDisplay();
            }
        }

        private void RunDigital(clsAllBook prBook)
        {
            ctcBookSpecs.Content = new ucDigital();
        }

        private void RunPhysical(clsAllBook prBook)
        {
            ctcBookSpecs.Content = new ucPhysical();
        }

        private async void sendOrder()
        { 
            try
            {
                setOrder();
                clsAllBook lcBook = BuildBook(Convert.ToInt32(tbxQuantity.Text));
                await ServiceClient.UpdateBookQuantityAsync(lcBook);
                await ServiceClient.InsertOrderAsync(_Order);
                var dialogOrderComplete = new MessageDialog("Order Completed successfully, Confirmation email sent to: " + tbxCustEmailAddress.Text);
                await dialogOrderComplete.ShowAsync();
                this.Frame.Navigate(typeof(pgMain));
            }
            catch (Exception)
            {


            }
        }

        private void setOrder()
        {
            decimal lcOrderTotal = Convert.ToInt32(tbxQuantity.Text) * _Book.Price;
            _Order = clsOrder.NewOrder(tbxCustName.Text, tbxCustEmailAddress.Text, _Book.ISBN, Convert.ToInt32(tbxQuantity.Text), lcOrderTotal, DateTime.Now, "P");
        }

        private void updateDisplay()
        {
            lblISBN.Text = "ISBN Number: " + _Book.ISBN;
            lblName.Text = "Name: " + _Book.Name;
            lblFormat.Text = "Format: " + _Book.BookFormat;
            lblPrice.Text = "Price: " + _Book.Price.ToString();
            lblGenre.Text = "Genre: " + _Book.GenreName;
        }

        private void updatePage(clsAllBook prBook)
        {
            (ctcBookSpecs.Content as IBookControl).UpdateControl(prBook);
        }
    }
}
