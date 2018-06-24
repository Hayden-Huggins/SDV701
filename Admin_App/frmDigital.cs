// Created by Hayden Huggins 20/06/2018
// This is a subclass form coming from frmBook, here we can push and pull specific information related to this class here

using System.Windows.Forms;
namespace Admin_App
{
    public partial class frmDigital : Admin_App.frmBook
    { //Singleton
        public static readonly frmDigital Instance = new frmDigital();

        private frmDigital()
        {
            InitializeComponent();
        }

        protected override void checkForNulls()
        {
            base.checkForNulls();
            if (string.IsNullOrEmpty(tbxSerialKey.Text))
            {
                lcMessage = lcMessage + "\n" + "Please enter a Serial Key";
            }
            if (string.IsNullOrEmpty(tbxKeyUrl.Text))
            {
                lcMessage = lcMessage + "\n" + "Please enter a Download URL";
            }
            if (!string.IsNullOrEmpty(lcMessage))
            {
                MessageBox.Show(lcMessage);
            }

            lcMessage = "";
        }

        protected override void pushData()
        {
            base.pushData();
            _Book.SerialKey = tbxSerialKey.Text;
            _Book.DownloadURL = tbxKeyUrl.Text;
            _Book.Quantity = 0;
            _Book.CoverType = "";
            _Book.BookFormat = "D";
        }

        public static void Run(clsAllBook prDigital)
        {
            Instance.SetDetails(prDigital);
        }

        protected override void updateForm()
        {
            base.updateForm();
            tbxSerialKey.Text = _Book.SerialKey;
            tbxKeyUrl.Text = _Book.DownloadURL;
        }
   
    }
}
