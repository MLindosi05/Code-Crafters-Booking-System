using Code_Crafters_Booking_System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PaymentForm : Form
    {
        private int bookingID;
        private decimal bookingAmount;
        private int clientID;

        private BookingForm mainBookingFormInstance;

        public PaymentForm(BookingForm callingForm = null)
        {
            InitializeComponent();
            this.mainBookingFormInstance = callingForm;
            this.Load += PaymentForm_Load;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            this.bookingID = UserSession.BookingID;
            this.clientID = UserSession.ClientID;

            txtBookingID.Text = UserSession.BookingReference;
            txtGuestName.Text = UserSession.GuestName;
            txtEmailAddress.Text = UserSession.EmailAddress;
            txtPhysicalAddress.Text = UserSession.PhysicalAddress;
            txtTotalPrice.Text = UserSession.TotalPrice;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount;
                string cleanPrice = txtTotalPrice.Text.Replace("R", "").Trim();

                if (!decimal.TryParse(cleanPrice, out amount))
                {
                    MessageBox.Show("Invalid payment amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string paymentType = cmbPaymentMethod.Text;
                if (string.IsNullOrWhiteSpace(paymentType))
                {
                    MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                taFolio.InsertNewPayment(bookingID, paymentType, amount, DateTime.Now, "Settled", "Room, Accommodation/Room and Accommodation");
                taBooking.UpdateBookingStatus("Confirmed", bookingID);

                MessageBox.Show("Payment successfully processed and booking has been confirmed!", "Booking Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment failed.\n\n" + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    taBooking.UpdateBookingStatus("Cancelled", bookingID);

                    decimal zeroAmount = 0;
                    taFolio.InsertNewPayment(bookingID, "N/A", zeroAmount, DateTime.Now, "Written-Off", "Booking Cancelled/No Charge");

                    MessageBox.Show("Booking cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cancellation failed.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.bookingID > 0)
                {
                    taBooking.DeleteBooking(this.bookingID);
                }
            }
            catch (Exception dbEx)
            {
                MessageBox.Show("UI resetting, but could not remove database record: " + dbEx.Message,
                                "Database Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cmbPaymentMethod.SelectedIndex = -1;
            txtBookingID.Clear();
            txtGuestName.Clear();
            txtEmailAddress.Clear();
            txtPhysicalAddress.Clear();
            txtTotalPrice.Clear();

            if (mainBookingFormInstance != null && !mainBookingFormInstance.IsDisposed)
            {
                mainBookingFormInstance.ResetBookingFormData();
            }

            MessageBox.Show("All input controls and temporary database entries have been successfully deleted.",
                            "System Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void PaymentForm_Load_1(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            grbPayments.BackColor = ColorTranslator.FromHtml("#966919");
            pnlPayments.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            btnReset.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnReset.ForeColor = Color.White;

            btnCancel.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnCancel.ForeColor = Color.White;

            btnDone.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnDone.ForeColor = Color.White;
        }
    }
}