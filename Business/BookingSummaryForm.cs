using System;
using Code_Crafters_Booking_System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class BookingSummaryForm : Form
    {
        private int _bookingID;
        string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";
        private codeCraftersDSTWO codeCraftersDSTWOInstance = new codeCraftersDSTWO();

        public BookingSummaryForm()
        {
            InitializeComponent();
        }

        public BookingSummaryForm(int bookingID)
        {
            InitializeComponent();
            _bookingID = bookingID;
        }

        private void BookingSummaryForm_Load(object sender, EventArgs e)
        {
            LoadBookingDetails();
        }

        private void LoadBookingDetails()
        {
            try
            {
                if (_bookingID > 0)
                {
                    if (taBooking != null) taBooking.Fill(codeCraftersDSTWOInstance.Booking);
                    if (taClient != null) taClient.Fill(codeCraftersDSTWOInstance.Client);

                    var bookingRow = codeCraftersDSTWOInstance.Booking.AsEnumerable()
                        .FirstOrDefault(b => b.Field<int>("Booking_ID") == _bookingID);

                    if (bookingRow != null)
                    {
                        lblBookingRefValue.Text = "BKR" + bookingRow.Booking_ID.ToString("D5");
                        lblRoomTypeValue.Text = bookingRow.Booking_Type;
                        lblCheckInValue.Text = bookingRow.Checkin_Date.ToString("yyyy/MM/dd") + " 15:00 PM";
                        lblCheckOutValue.Text = bookingRow.Checkout_Date.ToString("yyyy/MM/dd") + " 11:00 AM";
                        lblTotalAmountValue.Text = "R " + bookingRow.Booking_Total_Amount.ToString("N2");

                        int clientID = bookingRow.Field<int>("Client_ID");
                        var clientRow = codeCraftersDSTWOInstance.Client.AsEnumerable()
                            .FirstOrDefault(c => c.Field<int>("Client_ID") == clientID);

                        if (clientRow != null)
                        {
                            lblGuestNameValue.Text = clientRow.First_Name + " " + clientRow.Last_Name;
                            lblGuestEmailValue.Text = clientRow.Email_Address;
                        }
                        else
                        {
                            lblGuestNameValue.Text = "Walk-in Guest";
                            lblGuestEmailValue.Text = "N/A";
                        }

                        int adults = bookingRow.Field<int>("Number_Adults");
                        int children = bookingRow.Field<int>("Number_Children");
                        lblNumOfGuestsValue.Text = (adults + children).ToString() + $" ({adults} Adults, {children} Children)";

                        string branchID = bookingRow.Field<string>("Branch_ID");
                        string roomType = bookingRow.Booking_Type;
                        lblRoomNoValue.Text = GetAssignedRoomNumber(branchID, roomType);

                        // Fetch and display both table area features and the table number
                        lblTableAreaValue.Text = GetAssignedTableDetails(_bookingID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking summary: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAssignedTableDetails(int bookingID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Query both TableFeatures and RestuarantTableNum from Restuarant_Table joined through Table_Allocation
                    string query = @"SELECT rt.RestuarantTableNum, rt.TableFeatures 
                                   FROM Table_Allocation ta
                                   INNER JOIN Restuarant_Table rt ON ta.Restuarant_Table_ID = rt.RestaurantTableID
                                   WHERE ta.Booking_ID = @BookingID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tableNum = reader["RestuarantTableNum"]?.ToString() ?? "";
                                string tableFeatures = reader["TableFeatures"]?.ToString() ?? "";

                                if (!string.IsNullOrEmpty(tableNum))
                                {
                                    return $"Table {tableNum} ({tableFeatures})";
                                }
                                else if (!string.IsNullOrEmpty(tableFeatures))
                                {
                                    return tableFeatures;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Fallback if any error occurs
            }

            return "N/A";
        }    

        private string GetAssignedRoomNumber(string branchID, string roomType)
        {
            try
            {
                if (!string.IsNullOrEmpty(roomType) && roomType.Contains("("))
                {
                    int startIndex = roomType.LastIndexOf("Room");
                    if (startIndex != -1)
                    {
                        string cleanStr = roomType.Substring(startIndex + 4).Replace("(", "").Replace(")", "").Trim();
                        if (int.TryParse(cleanStr, out int roomNo))
                        {
                            return roomNo.ToString();
                        }
                    }
                }
            }
            catch
            {
                // Fallback
            }

            return "Not Assigned";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PaymentForm(_bookingID).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BookingManagement().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BookingManagement().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preparing summary for printing...", "Print Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}