using Code_Crafters_Interface_Prototype_1;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Code_Crafters_Interface_Prototype_1.Common;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PaymentForm : Form
    {
        private int _bookingID;
        private codeCraftersDSTWO _dataSet;
        private BookingTableAdapter _taBooking;
        private string _selectedPaymentMethod = "Card";

        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(int bookingID, codeCraftersDSTWO dataSet, BookingTableAdapter taBooking)
        {
            InitializeComponent();
            _bookingID = bookingID;
            _dataSet = dataSet;
            _taBooking = taBooking;

            
        }

        

        #region Load & Populate Booking Data

        
        #endregion

        #region Payment UI Interactivity

        private void SelectPaymentMethod(string method, Button selectedBtn)
        {
            _selectedPaymentMethod = method;

           

            selectedBtn.BackColor = Color.FromArgb(41, 128, 185);
            selectedBtn.ForeColor = Color.White;
        }

        private void numAmountPaid_ValueChanged(object sender, EventArgs e)
        {
            
        }

        

        #endregion

        #region Process Payment & Database Save

        

        #endregion
    }
}