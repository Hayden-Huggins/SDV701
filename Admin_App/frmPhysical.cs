// Created by Hayden Huggins 20/06/2018
// This is a subclass form coming from frmBook, here we can push and pull specific information related to this class here

using System.Windows.Forms;
namespace Admin_App
{
    public sealed partial class frmPhysical : Admin_App.frmBook
    { //Singleton
        public static readonly frmPhysical Instance = new frmPhysical();

        private frmPhysical()
        {
            InitializeComponent();
        }

        protected override void checkForNulls()
        {
            base.checkForNulls();
            if (string.IsNullOrEmpty(tbxQuantity.Text))
            {
                lcMessage = lcMessage + "\n" + "Please enter a Quantity";
            }
            if (string.IsNullOrEmpty(cbxCoverType.Text))
            {
                lcMessage = lcMessage + "\n" + "Please select a Cover Type";
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
            _Book.Quantity = int.Parse(tbxQuantity.Text);
            _Book.CoverType = cbxCoverType.Text;
            _Book.SerialKey = "";
            _Book.DownloadURL = "";
            _Book.BookFormat = "P";
        }

        public static void Run(clsAllBook prPhysical)
        {
            Instance.SetDetails(prPhysical);
        }

        protected override void updateForm()
        {
            base.updateForm();
            tbxQuantity.Text = _Book.Quantity.ToString();
            cbxCoverType.Text = _Book.CoverType;
        }   
    }
}
