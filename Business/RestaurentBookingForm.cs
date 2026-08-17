using System;
using Code_Crafters_Booking_System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class RestaurentBookingForm : Form
    {
        private string _branchID;
        private DateTime _checkIn;
        private DateTime _checkOut;
        private int _totalGuests;
        private int _existingBookingID;

        private codeCraftersDSTWO codeCraftersDSTWOInstance = new codeCraftersDSTWO();
        private string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";

        public RestaurentBookingForm(string branchID, DateTime checkIn, DateTime checkOut, int guests, int existingBookingID)
        {
            InitializeComponent();
            _branchID = branchID;
            _checkIn = checkIn;
            _checkOut = checkOut;
            _totalGuests = guests;
            _existingBookingID = existingBookingID;
        }

        private void RestaurentBookingForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (taRestuarant_Table != null)
                {
                    taRestuarant_Table.Fill(codeCraftersDSTWOInstance.Restuarant_Table);
                }

                if (cmbTableArea.Items.Count == 0 && codeCraftersDSTWOInstance.Restuarant_Table.Rows.Count > 0)
                {
                    var distinctFeatures = codeCraftersDSTWOInstance.Restuarant_Table.AsEnumerable()
                        .Where(t => string.Equals(t.Field<string>("Branch_ID"), _branchID, StringComparison.OrdinalIgnoreCase) && !t.IsNull("TableFeatures"))
                        .Select(t => t.Field<string>("TableFeatures").Trim())
                        .Distinct();

                    foreach (var feature in distinctFeatures)
                    {
                        cmbTableArea.Items.Add(feature);
                    }
                }

                if (cmbTableArea.Items.Count > 0 && cmbTableArea.SelectedIndex == -1)
                {
                    cmbTableArea.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading restaurant table data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContinueToPayment_Click_1(object sender, EventArgs e)
        {
            try
            {
                string selectedArea = cmbTableArea.SelectedItem?.ToString() ?? cmbTableArea.Text;

                if (string.IsNullOrWhiteSpace(selectedArea))
                {
                    MessageBox.Show("Please select a table area.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (taRestuarant_Table != null)
                {
                    taRestuarant_Table.Fill(codeCraftersDSTWOInstance.Restuarant_Table);
                }

                var availableTable = codeCraftersDSTWOInstance.Restuarant_Table.AsEnumerable().FirstOrDefault(t =>
                    string.Equals(t.Field<string>("Branch_ID"), _branchID, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals((t.IsNull("TableFeatures") ? "" : t.Field<string>("TableFeatures")).Trim(), selectedArea.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    string.Equals((t.IsNull("TableStatus") ? "Available" : t.Field<string>("TableStatus")).Trim(), "Available", StringComparison.OrdinalIgnoreCase)
                );

                if (availableTable != null)
                {
                    int tableID = availableTable.RestaurantTableID;
                    decimal baseTablePrice = availableTable.TablePrice;

                    int totalNights = (int)(_checkOut.Date - _checkIn.Date).TotalDays;
                    if (totalNights <= 0) totalNights = 1;

                    decimal totalRestaurantCost = baseTablePrice * totalNights;

                    availableTable.TableStatus = "Reserved";
                    if (taRestuarant_Table != null)
                    {
                        taRestuarant_Table.Update(codeCraftersDSTWOInstance.Restuarant_Table);
                    }

                    if (taBooking != null)
                    {
                        taBooking.Fill(codeCraftersDSTWOInstance.Booking);
                        var bookingRow = codeCraftersDSTWOInstance.Booking.AsEnumerable()
                            .FirstOrDefault(b => b.Field<int>("Booking_ID") == _existingBookingID);

                        if (bookingRow != null)
                        {
                            bookingRow.Booking_Total_Amount += totalRestaurantCost;
                            taBooking.Update(codeCraftersDSTWOInstance.Booking);
                        }
                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        // Correct column name matching your Table_Allocation schema: Restuarant_Table_ID
                        string query = @"
                            IF EXISTS (SELECT 1 FROM Table_Allocation WHERE Booking_ID = @BookingID)
                                UPDATE Table_Allocation SET Restuarant_Table_ID = @RestaurantTableID, Start_Time = @StartTime, End_Time = @EndTime, Allocation_Status = 'Reserved' WHERE Booking_ID = @BookingID;
                            ELSE
                                INSERT INTO Table_Allocation (Booking_ID, Restuarant_Table_ID, Start_Time, End_Time, Allocation_Status) 
                                VALUES (@BookingID, @RestaurantTableID, @StartTime, @EndTime, 'Reserved');";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BookingID", _existingBookingID);
                            cmd.Parameters.AddWithValue("@RestaurantTableID", tableID);
                            cmd.Parameters.AddWithValue("@StartTime", _checkIn);
                            cmd.Parameters.AddWithValue("@EndTime", _checkOut);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show(
                        $"Restaurant table #{availableTable.RestuarantTableNum} successfully added!\nTotal Duration: {totalNights} Night(s)\nAdded Cost: R {totalRestaurantCost:N2}",
                        "Reservation Confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.DialogResult = DialogResult.OK;
                    BookingSummaryForm summaryForm = new BookingSummaryForm(_existingBookingID);
                    summaryForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No available tables match your selected area for this branch.", "Table Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error completing restaurant reservation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}