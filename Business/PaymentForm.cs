using Code_Crafters_Interface_Prototype_1;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PaymentForm : Form
    {
        private int _bookingID;
        private decimal _amountDue;
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

        public PaymentForm(int bookingID, decimal amountDue) : this(bookingID)
        {
            _amountDue = amountDue;
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
            // If your CashPayment form can accept the amount due, you can pass it here if needed:
            // CashPayment cashForm = new CashPayment(_bookingID, _amountDue);

            if (cashForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void radCard_Click(object sender, EventArgs e)
        {
            if (!_allowPaymentSelection)
                return;

            radCard.Checked = false;

            CardPayment cardForm = new CardPayment(_bookingID);
            if (cardForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void radPayPal_Click(object sender, EventArgs e)
        {
            if (!_allowPaymentSelection)
                return;

            radPayPal.Checked = false;

            PayPalPayment paypalForm = new PayPalPayment(_bookingID);
            if (paypalForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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