using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class CashPayment : Form
    {
        private int _bookingID;

        public CashPayment()
        {
            InitializeComponent();
        }

        public CashPayment(int bookingID)
        {
            InitializeComponent();
            _bookingID = bookingID;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Replace with your actual database/backend call to update status to "Booked"
                UpdateBookingStatus(_bookingID, "Booked");

                MessageBox.Show("Cash payment recorded successfully. Booking is now Booked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing cash payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Update status to "Cancelled" when cancel is clicked
                UpdateBookingStatus(_bookingID, "Cancelled");

                MessageBox.Show("Booking has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBookingStatus(int bookingID, string status)
        {
            string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";

            string query = "UPDATE [GroupPmb2].[dbo].[Booking] SET [Booking_Status] = @Status WHERE [Booking_ID] = @BookingID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@BookingID", bookingID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}