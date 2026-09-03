using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class CashPayment : Form
    {
        private int _bookingID;
        private string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";

        public CashPayment()
        {
            InitializeComponent();
        }

        public CashPayment(int bookingID)
        {
            InitializeComponent();
            _bookingID = bookingID;
        }

        private void CashPayment_Load(object sender, EventArgs e)
        {
            LoadTotalAmount();
            panel12.BackColor = Color.FromArgb(15, 42, 74);

            btnCancel.BackColor = Color.FromArgb(211, 47, 47);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;

            btnProcessPayment.BackColor = Color.FromArgb(0, 48, 135);
            btnProcessPayment.ForeColor = Color.White;
            btnProcessPayment.FlatStyle = FlatStyle.Flat;
            btnProcessPayment.FlatAppearance.BorderSize = 0;

        }

        private void LoadTotalAmount()
        {
            try
            {
                if (_bookingID > 0)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT Booking_Total_Amount FROM [GroupPmb2].[dbo].[Booking] WHERE Booking_ID = @BookingID";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@BookingID", _bookingID);
                            object result = cmd.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                decimal totalAmount = Convert.ToDecimal(result);
                                // Replace 'lblTotalDueValue' with the exact name of your label control displaying R 0.00 in the designer
                                lblTotalDue.Text = "R " + totalAmount.ToString("N2");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total amount: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            try
            {
                string generatedReceipt = ProcessCashPaymentTransaction(_bookingID);

                MessageBox.Show($"Cash payment recorded successfully.\nReceipt Number: {generatedReceipt}\nFolio generated and booking is now confirmed ('Booked')!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
                PaymentForm form = new PaymentForm();
                form.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing cash payment and generating folio: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
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

        private string ProcessCashPaymentTransaction(int bookingID)
        {
            string receiptNo = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        decimal totalAmount = 0.00m;
                        string getAmountQuery = "SELECT Booking_Total_Amount FROM [GroupPmb2].[dbo].[Booking] WHERE Booking_ID = @BookingID";

                        using (SqlCommand cmdGet = new SqlCommand(getAmountQuery, connection, transaction))
                        {
                            cmdGet.Parameters.AddWithValue("@BookingID", bookingID);
                            object result = cmdGet.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                totalAmount = Convert.ToDecimal(result);
                            }
                        }

                        receiptNo = "REC-" + DateTime.Now.ToString("yyyyMMdd") + "-" + bookingID.ToString("D4");
                        string insertFolioQuery = @"
                            INSERT INTO [GroupPmb2].[dbo].[Folio] 
                            ([Booking_ID], [Payment_Amount], [Payment_Date], [Payment_Status], [Payment_Description], [Payment_Method], [Receipt_Number])
                            VALUES 
                            (@BookingID, @PaymentAmount, GETDATE(), 'Paid', 'Cash Payment for Accommodation and Amenities', 'Cash', @ReceiptNumber)";

                        using (SqlCommand cmdFolio = new SqlCommand(insertFolioQuery, connection, transaction))
                        {
                            cmdFolio.Parameters.AddWithValue("@BookingID", bookingID);
                            cmdFolio.Parameters.AddWithValue("@PaymentAmount", totalAmount);
                            cmdFolio.Parameters.AddWithValue("@ReceiptNumber", receiptNo);
                            cmdFolio.ExecuteNonQuery();
                        }

                        string updateBookingQuery = "UPDATE [GroupPmb2].[dbo].[Booking] SET [Booking_Status] = 'Booked' WHERE [Booking_ID] = @BookingID";
                        using (SqlCommand cmdBooking = new SqlCommand(updateBookingQuery, connection, transaction))
                        {
                            cmdBooking.Parameters.AddWithValue("@BookingID", bookingID);
                            cmdBooking.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            return receiptNo;
        }

        private void UpdateBookingStatus(int bookingID, string status)
        {
            string query = "UPDATE [GroupPmb2].[dbo].[Booking] SET [Booking_Status] = @Status WHERE [Booking_ID] = @BookingID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@BookingID", bookingID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}