using Code_Crafters_Interface_Prototype_1;
using System;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PaymentForm : Form
    {
        private int _bookingID;
        private bool _allowPaymentSelection = false;

        public PaymentForm()
        {
            InitializeComponent();

            radCash.Checked = false;
            radCard.Checked = false;
            radPayPal.Checked = false;

            this.Shown += PaymentForm_Shown;
        }

        public PaymentForm(int bookingID) : this()
        {
            _bookingID = bookingID;
        }

        private void PaymentForm_Shown(object sender, EventArgs e)
        {
            _allowPaymentSelection = true;

            radCash.Checked = false;
            radCard.Checked = false;
            radPayPal.Checked = false;
        }

        private void radCash_Click(object sender, EventArgs e)
        {
            if (!_allowPaymentSelection)
                return;

            radCash.Checked = false;

            CashPayment cashForm = new CashPayment(_bookingID);
            cashForm.Show();
        }

        private void radCard_Click(object sender, EventArgs e)
        {
            if (!_allowPaymentSelection)
                return;

            radCard.Checked = false;

            CardPayment cardForm = new CardPayment(_bookingID);
            cardForm.Show();
        }

        private void radPayPal_Click(object sender, EventArgs e)
        {
            if (!_allowPaymentSelection)
                return;

            radPayPal.Checked = false;

            PayPalPayment paypalForm = new PayPalPayment(_bookingID);
            paypalForm.Show();
        }

        private void radCash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(15, 42, 74);
            panel2.BackColor = Color.FromArgb(250, 243, 221);
            panel3.BackColor = Color.FromArgb(250, 243, 221);
            panel5.BackColor = Color.FromArgb(250, 243, 221);
            paymentPanel.BackColor = Color.FromArgb(15, 42, 74);

            Color goldColor = Color.FromArgb(212, 175, 55);
            label1.ForeColor = goldColor;
            
        }
    }
}