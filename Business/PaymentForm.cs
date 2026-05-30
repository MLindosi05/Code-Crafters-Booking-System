using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PaymentForm : Form
    {
        private int bookingID;
        private decimal bookingAmount;

        public PaymentForm(int bookingID, decimal bookingAmount)
        {
            InitializeComponent();

            this.bookingID = bookingID;
            this.bookingAmount = bookingAmount;

            this.Load += PaymentForm_Load;

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            cmbPaymentMethods.Items.Clear();
            cmbPaymentMethods.Items.Add("Cash");
            cmbPaymentMethods.Items.Add("EFT/Bank Card");
            cmbPaymentMethods.SelectedIndex = 0;

            txtPayBookingID.ReadOnly = true;
            txtPayPrice.ReadOnly = true;

            txtPayBookingID.Text = bookingID.ToString();
            txtPayPrice.Text = bookingAmount.ToString("0.00");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount;

                if (!decimal.TryParse(txtPayPrice.Text, out amount))
                {
                    MessageBox.Show("Invalid payment amount.");
                    return;
                }

                string paymentType = cmbPaymentMethods.Text;

                if (string.IsNullOrWhiteSpace(paymentType))
                {
                    MessageBox.Show("Please select a payment method.");
                    return;
                }

                taFolio.InsertPayment(
                    bookingID,
                    amount,
                    paymentType);

                taBooking.UpdateBookingStatus(
                    "Confirmed",
                    bookingID);

                taFolio.UpdatePaymentDetails(
                    "Settled",
                    "Room and Accommodation",
                    bookingID);

                MessageBox.Show(
                    "Payment successful.\nBooking Confirmed.",
                    "Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Payment failed.\n\n" +
                    ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to cancel this booking and payment?",
                    "Cancel Booking",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    taBooking.UpdateBookingStatus(
                        "Cancelled",
                        bookingID);

                    taFolio.InsertWrittenOffPayment(
                        bookingID);

                    MessageBox.Show(
                        "Booking cancelled successfully.",
                        "Cancelled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cancellation failed.\n\n" + ex.Message);
            }
        }
    }
}