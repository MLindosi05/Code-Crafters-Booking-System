using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class CardPayment : Form
    {
        private int _bookingID;

        public CardPayment()
        {
            InitializeComponent();
        }

        public CardPayment(int bookingID)
        {
            InitializeComponent();
            _bookingID = bookingID;
        }

        private void btnProcessPayment_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}