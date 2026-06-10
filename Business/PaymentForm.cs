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

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PaymentForm : Form
    {
        private int bookingID;
        private decimal bookingAmount;
        private int clientID;

        public PaymentForm()
        {
            InitializeComponent();
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
                    MessageBox.Show("Invalid payment amount.");
                    return;
                }

                string paymentType = cmbPaymentMethod.Text;

                if (string.IsNullOrWhiteSpace(paymentType))
                {
                    MessageBox.Show("Please select a payment method.");
                    return;
                }

                taFolio.InsertNewPayment(bookingID, paymentType, amount, DateTime.Now, "Settled", "Room, Accommodation/Room and Accommodation");
                taBooking.UpdateBookingStatus("Confirmed", bookingID);

                try
                {
                    var taClientLookup = new ClientTableAdapter();
                    var clientTable = taClientLookup.GetData();
                    var matchedClientRow = clientTable.FirstOrDefault(row => row.Client_ID == this.clientID);

                    if (matchedClientRow != null && !string.IsNullOrWhiteSpace(matchedClientRow.Email_Address))
                    {
                        string clientEmail = matchedClientRow.Email_Address;
                        string clientName = matchedClientRow.First_Name;

                        string emailSubject = $"The Regal Inn - Booking Confirmed! Ref: #{bookingID}";
                        string emailBody = $@"
                        <div style='font-family: Arial, sans-serif; max-width: 600px; border: 1px solid #dcdcdc; padding: 20px;'>
                            <h2 style='color: #2E7D32;'>Booking Confirmed, {clientName}!</h2>
                            <p>Thank you! We have successfully processed your payment of <b>R {amount:0.00}</b> via <b>{paymentType}</b>.</p>
                            <hr style='border: 0; border-top: 1px solid #eee;' />
                            <p><b>Reservation Summary:</b></p>
                            <ul>
                                <li><b>Booking Reference:</b> #{bookingID}</li>
                                <li><b>Payment Status:</b> Settled / Paid</li>
                                <li><b>Booking Status:</b> Confirmed</li>
                            </ul>
                            <p>We look forward to hosting you at The Regal Inn!</p>
                            <hr style='border: 0; border-top: 1px solid #eee;' />
                            <p style='font-size: 12px; color: #888;'>This is an automated system receipt. Please do not reply directly to this message.</p>
                        </div>";

                        EmailService.SendEmail(clientEmail, emailSubject, emailBody);
                    }
                }
                catch (Exception emailEx)
                {
                    MessageBox.Show("Payment updated, but receipt could not process: " + emailEx.Message,
                                    "Mailing Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show(
                    "An email has been sent. You are all done with your booking!",
                    "Booking Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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
                    taFolio.InsertWrittenOffPayment(bookingID);

                    MessageBox.Show("Booking cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cancellation failed.\n\n" + ex.Message);
            }
        }
    }
}