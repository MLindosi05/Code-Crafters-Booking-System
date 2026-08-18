using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PayPalPayment : Form
    {
        private int _bookingID;

        public PayPalPayment()
        {
            InitializeComponent();
        }

        public PayPalPayment(int bookingID)
        {
            InitializeComponent();
            _bookingID = bookingID;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}