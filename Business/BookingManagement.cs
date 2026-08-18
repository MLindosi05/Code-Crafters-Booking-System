using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class BookingManagement : Form
    {
        private static readonly TimeSpan StandardCheckInTime = new TimeSpan(15, 0, 0);   // 15:00 PM check-in rule
        private static readonly TimeSpan StandardCheckOutTime = new TimeSpan(11, 0, 0); // 11:00 AM check-out rule
        private string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";
        public BookingManagement()
        {
            InitializeComponent();
            SetInitialDates();
        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {
            InitializeDropdowns();
            SetInitialDates();
            RefreshDataSilent();
            UpdateRoomAndBookingStatuses();

            // Populate search combo items safely
            cmbSearchBy.Items.Clear();
            cmbSearchBy.Items.Add("Booking ID");
            cmbSearchBy.Items.Add("Status");
            cmbSearchBy.Items.Add("Branch");

            taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);

        }

        private void InitializeDropdowns()
        {
            try
            {
                if (cmbBranchName.Items.Count > 0 && cmbBranchName.SelectedIndex == -1)
                {
                    cmbBranchName.SelectedIndex = 0;
                }

                if (taHotelRoom != null)
                {
                    taHotelRoom.Fill(codeCraftersDSTWO.Hotel_Room);
                }

                if (numAdults != null && numAdults.Value == 0)
                    numAdults.Value = 1;

                if (numChildren != null)
                    numChildren.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form data:\n\n" + ex.ToString(), "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetInitialDates()
        {
            DateTime today = DateTime.Today;

            if (dtpRoomCheckIn != null)
            {
                dtpRoomCheckIn.Format = DateTimePickerFormat.Short;
                dtpRoomCheckIn.MinDate = today;
                dtpRoomCheckIn.Value = today;
            }
            if (dtpRoomCheckOut != null)
            {
                dtpRoomCheckOut.Format = DateTimePickerFormat.Short;
                dtpRoomCheckOut.MinDate = today;
                dtpRoomCheckOut.Value = today.AddDays(1);
            }
        }

        private void dtpRoomCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (dtpRoomCheckOut != null && dtpRoomCheckIn.Value >= dtpRoomCheckOut.Value)
            {
                dtpRoomCheckOut.Value = dtpRoomCheckIn.Value.AddDays(1);
            }
        }

        private void RefreshDataSilent()
        {
            try
            {
                if (taBooking != null)
                {
                    codeCraftersDSTWO.Booking.Clear();
                    taBooking.Fill(codeCraftersDSTWO.Booking);
                }
                if (taClient != null)
                {
                    codeCraftersDSTWO.Client.Clear();
                    taClient.Fill(codeCraftersDSTWO.Client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data refresh error: " + ex.Message);
            }
        }

        private string GetBranchIDFromName(string branchName)
        {
            switch (branchName?.Trim())
            {
                case "Pietermaritzburg": return "BR01";
                case "Durban Umhlanga": return "BR02";
                case "Durban North Beach": return "BR03";
                case "Durban Ballito": return "BR04";
                case "JHB Midrand": return "BR05";
                default: return "BR01";
            }
        }

        private int GetOrCreateClientIDByEmail(string emailAddress)
        {
            if (string.IsNullOrWhiteSpace(emailAddress))
                return -1;

            if (taClient != null)
            {
                codeCraftersDSTWO.Client.Clear();
                taClient.Fill(codeCraftersDSTWO.Client);
            }

            var existingClient = codeCraftersDSTWO.Client.AsEnumerable()
                .FirstOrDefault(c => string.Equals(c.Field<string>("Email_Address"), emailAddress.Trim(), StringComparison.OrdinalIgnoreCase));

            if (existingClient != null)
            {
                return existingClient.Client_ID;
            }
            else
            {
                MessageBox.Show(
                    "Client email does not exist in the system.\nYou must first register / add the client to the system before proceeding with a booking.",
                    "Client Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return -1;
            }
        }

        private void UpdateRoomAndBookingStatuses()
        {
            try
            {
                DateTime currentDateTime = DateTime.Now;

                if (taBooking != null)
                {
                    codeCraftersDSTWO.Booking.Clear();
                    taBooking.Fill(codeCraftersDSTWO.Booking);
                }
                if (taHotelRoom != null)
                {
                    codeCraftersDSTWO.Hotel_Room.Clear();
                    taHotelRoom.Fill(codeCraftersDSTWO.Hotel_Room);
                }

                foreach (var booking in codeCraftersDSTWO.Booking.Rows.Cast<codeCraftersDSTWO.BookingRow>())
                {
                    if (booking.RowState == DataRowState.Deleted) continue;

                    DateTime checkInTime = booking.Checkin_Date;
                    DateTime checkOutTime = booking.Checkout_Date;
                    DateTime cleaningEndTime = checkOutTime.AddHours(1);

                    string currentStatus = booking.Booking_Status;
                    int roomNumber = ExtractRoomNumberFromBookingType(booking.Booking_Type);

                    if (currentDateTime >= checkInTime && currentDateTime < checkOutTime && currentStatus == "Pending")
                    {
                        booking.Booking_Status = "Checked-In";
                        UpdateHotelRoomStatus(booking.Branch_ID, roomNumber, "Occupied");
                    }
                    else if (currentDateTime >= checkOutTime && currentDateTime < cleaningEndTime && currentStatus == "Checked-In")
                    {
                        booking.Booking_Status = "Checked-Out";
                        UpdateHotelRoomStatus(booking.Branch_ID, roomNumber, "Cleaning");
                    }
                    else if (currentDateTime >= cleaningEndTime && (currentStatus == "Checked-Out" || currentStatus == "Checked-In"))
                    {
                        booking.Booking_Status = "Completed";
                        UpdateHotelRoomStatus(booking.Branch_ID, roomNumber, "Available");
                    }
                }

                if (taBooking != null) taBooking.Update(codeCraftersDSTWO.Booking);
                if (taHotelRoom != null) taHotelRoom.Update(codeCraftersDSTWO.Hotel_Room);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating room and booking statuses: " + ex.Message);
            }
        }

        private int ExtractRoomNumberFromBookingType(string bookingType)
        {
            try
            {
                if (string.IsNullOrEmpty(bookingType)) return 0;

                int lastIndex = bookingType.LastIndexOf("Room");
                if (lastIndex != -1)
                {
                    string cleanStr = bookingType.Substring(lastIndex + 4).Replace("(", "").Replace(")", "").Trim();
                    if (int.TryParse(cleanStr, out int roomNo))
                    {
                        return roomNo;
                    }
                }
            }
            catch { }
            return 0;
        }

        private bool IsRoomBookedForDates(string branchID, int roomNumber, DateTime requestedCheckIn, DateTime requestedCheckOut)
        {
            if (taBooking != null)
            {
                codeCraftersDSTWO.Booking.Clear();
                taBooking.Fill(codeCraftersDSTWO.Booking);
            }

            return codeCraftersDSTWO.Booking.AsEnumerable()
                .Where(b => b.RowState != DataRowState.Deleted &&
                            b.Branch_ID?.Trim() == branchID?.Trim() &&
                            (b.Booking_Status == "Pending" || b.Booking_Status == "Checked-In" || b.Booking_Status == "Booked"))
                .Any(b =>
                {
                    int assignedRoomNo = ExtractRoomNumberFromBookingType(b.Booking_Type);
                    if (assignedRoomNo != roomNumber) return false;

                    DateTime existingCheckIn = b.Checkin_Date;
                    DateTime existingCheckOut = b.Checkout_Date;

                    return existingCheckIn < requestedCheckOut && existingCheckOut > requestedCheckIn;
                });
        }

        private void UpdateHotelRoomStatus(string branchID, int roomNumber, string newStatus)
        {
            if (roomNumber <= 0) return;

            var roomRow = codeCraftersDSTWO.Hotel_Room.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("Branch_ID") == branchID && r.hotel_room_number == roomNumber);

            if (roomRow != null)
            {
                roomRow.hotel_room_status = newStatus;
                if (newStatus == "Cleaning")
                {
                    roomRow.Cleaning_Status = "Pending Cleaning";
                }
                else if (newStatus == "Available")
                {
                    roomRow.Cleaning_Status = "Cleaned";
                    roomRow.Last_Cleaned = DateTime.Now;
                }
            }
        }

        private int GetRoomCapacity(string roomType, DataRow r)
        {
            int dbAdults = (r.Table.Columns.Contains("Max_Adults") && !r.IsNull("Max_Adults")) ? r.Field<int>("Max_Adults") : 0;
            int dbChildren = (r.Table.Columns.Contains("Max_Children") && !r.IsNull("Max_Children")) ? r.Field<int>("Max_Children") : 0;
            int totalDbCapacity = dbAdults + dbChildren;

            if (totalDbCapacity > 0)
            {
                return totalDbCapacity;
            }

            switch (roomType?.Trim())
            {
                case "Standard Room 1 King Bed": return 2;
                case "Executive Room 1 King Bed": return 2;
                case "Suite Room 1 King Bed": return 3;
                case "Deluxe Room 1 King Bed": return 3;
                case "Suite Room Twin Beds": return 4;
                case "Standard Room 2 Double Beds": return 6;
                default: return 2;
            }
        }

        private void ProcessRoomBooking(string roomType, decimal roomPricePerNight)
        {
            try
            {
                string clientEmail = txtClientEmailAddress.Text.Trim();
                if (string.IsNullOrEmpty(clientEmail))
                {
                    MessageBox.Show("Please enter the client's email address.", "Email Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClientEmailAddress.Focus();
                    return;
                }

                int clientID = GetOrCreateClientIDByEmail(clientEmail);
                if (clientID == -1) return;

                string selectedBranchName = cmbBranchName.SelectedItem?.ToString() ?? cmbBranchName.Text;
                if (string.IsNullOrWhiteSpace(selectedBranchName))
                {
                    MessageBox.Show("Please select a valid hotel branch.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string branchID = GetBranchIDFromName(selectedBranchName);

                DateTime selectedCheckInDate = dtpRoomCheckIn.Value.Date;
                DateTime selectedCheckOutDate = dtpRoomCheckOut.Value.Date;

                DateTime checkIn = selectedCheckInDate.Add(StandardCheckInTime);
                DateTime checkOut = selectedCheckOutDate.Add(StandardCheckOutTime);

                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out date/time must be after check-in date/time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int totalNights = (int)(checkOut.Date - checkIn.Date).TotalDays;
                if (totalNights <= 0) totalNights = 1;

                int adults = numAdults != null ? (int)numAdults.Value : 1;
                int children = numChildren != null ? (int)numChildren.Value : 0;
                int totalGuests = adults + children;

                if (totalGuests <= 0)
                {
                    MessageBox.Show("Please select at least one guest (Adults or Children) before proceeding.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numAdults.Focus();
                    return;
                }

                if (taHotelRoom != null)
                {
                    codeCraftersDSTWO.Hotel_Room.Clear();
                    taHotelRoom.Fill(codeCraftersDSTWO.Hotel_Room);
                }

                var roomsOfType = codeCraftersDSTWO.Hotel_Room.AsEnumerable()
                    .Where(r => r.Field<string>("Branch_ID") == branchID && r.Field<string>("hotel_room_type") == roomType)
                    .ToList();

                // 1. Check if ANY room of this type can ever support this total guest capacity
                if (!roomsOfType.Any(r => totalGuests <= GetRoomCapacity(roomType, r)))
                {
                    MessageBox.Show("The number of guests exceeds the maximum capacity allowed for this room type.", "Capacity Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Filter rooms that meet the guest capacity requirement first
                var capacityValidRooms = roomsOfType
                    .Where(r => totalGuests <= GetRoomCapacity(roomType, r))
                    .ToList();

                if (!capacityValidRooms.Any())
                {
                    MessageBox.Show("The number of guests exceeds the maximum capacity allowed for this room type.", "Capacity Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Look for an available room from the capacity-valid rooms that isn't booked for these dates
                var availableRoom = capacityValidRooms
                    .FirstOrDefault(r => !IsRoomBookedForDates(branchID, r.hotel_room_number, checkIn, checkOut));

                if (availableRoom == null)
                {
                    // This now triggers exclusively when capacity is fine, but all matching rooms are fully booked / date clashed
                    MessageBox.Show("All rooms of this type are already booked for the selected dates. Please choose different dates or another room type.", "Double Booking / Fully Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int assignedRoomID = availableRoom.Hotel_Room_ID;
                int assignedRoomNumber = availableRoom.hotel_room_number;
                decimal finalBookingTotal = roomPricePerNight * totalNights;
                string bookingTypeStr = roomType + " (Room " + assignedRoomNumber + ")";
                int activeBookingID = 0;

                string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertBookingQuery = @"
                INSERT INTO Booking 
                (Client_ID, Branch_ID, Booking_Date, Checkin_Date, Checkout_Date, Booking_Total_Amount, Booking_Status, Number_Adults, Number_Children, Booking_Type, Staff_Created_By)
                VALUES 
                (@ClientID, @BranchID, GETDATE(), @CheckIn, @CheckOut, @TotalAmount, 'Pending', @Adults, @Children, @BookingType, @StaffCreatedBy);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmdBooking = new SqlCommand(insertBookingQuery, conn))
                    {
                        cmdBooking.Parameters.AddWithValue("@ClientID", clientID);
                        cmdBooking.Parameters.AddWithValue("@BranchID", branchID);
                        cmdBooking.Parameters.AddWithValue("@CheckIn", checkIn);
                        cmdBooking.Parameters.AddWithValue("@CheckOut", checkOut);
                        cmdBooking.Parameters.AddWithValue("@TotalAmount", finalBookingTotal);
                        cmdBooking.Parameters.AddWithValue("@Adults", adults);
                        cmdBooking.Parameters.AddWithValue("@Children", children);
                        cmdBooking.Parameters.AddWithValue("@BookingType", bookingTypeStr);
                        cmdBooking.Parameters.AddWithValue("@StaffCreatedBy", "Administrator");

                        activeBookingID = (int)cmdBooking.ExecuteScalar();
                    }

                    string roomAssignQuery = @"
                INSERT INTO Room_Assignment (Booking_ID, Hotel_Room_ID, Actual_CheckIn_Time, Actual_CheckOut_Time, Assignment_Status, Room_Notes, Assigned_By, Assigned_Date)
                VALUES (@BookingID, @HotelRoomID, @CheckIn, @CheckOut, 'Assigned', @RoomNotes, 'Administrator', GETDATE())";

                    string generatedRoomNotes = "Standard room assignment completed successfully.";

                    using (SqlCommand cmdAssign = new SqlCommand(roomAssignQuery, conn))
                    {
                        cmdAssign.Parameters.AddWithValue("@BookingID", activeBookingID);
                        cmdAssign.Parameters.AddWithValue("@HotelRoomID", assignedRoomID);
                        cmdAssign.Parameters.AddWithValue("@CheckIn", checkIn);
                        cmdAssign.Parameters.AddWithValue("@CheckOut", checkOut);
                        cmdAssign.Parameters.AddWithValue("@RoomNotes", generatedRoomNotes);
                        cmdAssign.ExecuteNonQuery();
                    }
                }

                DialogResult dialogResult = MessageBox.Show(
                    "Would you like to include an optional restaurant table reservation with your room booking?",
                    "Optional Dining Reservation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    RestaurentBookingForm restForm = new RestaurentBookingForm(branchID, checkIn, checkOut, totalGuests, activeBookingID);
                    if (restForm.ShowDialog() == DialogResult.OK)
                    {
                        new BookingSummaryForm(activeBookingID).Show();
                        this.Hide();
                    }
                }
                else
                {
                    new BookingSummaryForm(activeBookingID).Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRoomOneBook_Click(object sender, EventArgs e) => ProcessRoomBooking("Standard Room 1 King Bed", 1600.00m);
        private void btnRoomTwoBook_Click(object sender, EventArgs e) => ProcessRoomBooking("Suite Room Twin Beds", 2700.00m);
        private void btnRoomThreeBook_Click(object sender, EventArgs e) => ProcessRoomBooking("Suite Room 1 King Bed", 3000.00m);
        private void btnRoomFourBook_Click(object sender, EventArgs e) => ProcessRoomBooking("Executive Room 1 King Bed", 2100.00m);
        private void btnRoomFiveBook_Click(object sender, EventArgs e) => ProcessRoomBooking("Deluxe Room 1 King Bed", 2300.00m);
        private void btnRoomSixBook_Click(object sender, EventArgs e) => ProcessRoomBooking("Standard Room 2 Double Beds", 1900.00m);

        private void numAdults_ValueChanged(object sender, EventArgs e) { }
        private void txtClientEmailAddress_TextChanged(object sender, EventArgs e) { }


        private void button3_Click(object sender, EventArgs e)
        {
            string searchName = txtClientName.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                clientBranchTableBookingBindingSource.Filter = "Booking_Status = 'Cancelled'";
            }
            else
            {
                clientBranchTableBookingBindingSource.Filter = $"Booking_Status = 'Cancelled' AND First_Name LIKE '{searchName}%'";
            }
        }

        // 2. CURRENT BOOKINGS
        private void button1_Click(object sender, EventArgs e)
        {
            string searchName = txtClientName.Text.Trim();
            string todayDate = DateTime.Today.ToString("yyyy-MM-dd");

            string filterExpression = $"Checkin_Date <= #{todayDate}# AND Checkout_Date >= #{todayDate}# AND Booking_Status <> 'Cancelled'";

            if (!string.IsNullOrEmpty(searchName))
            {
                filterExpression += $" AND First_Name LIKE '{searchName}%'";
            }

            clientBranchTableBookingBindingSource.Filter = filterExpression;
        }

        // 3. FUTURE BOOKINGS
        private void button2_Click(object sender, EventArgs e)
        {
            string searchName = txtClientName.Text.Trim(); // Fixed missing control name reference here
            string todayDate = DateTime.Today.ToString("yyyy-MM-dd");

            string filterExpression = $"Checkin_Date > #{todayDate}# AND Booking_Status <> 'Cancelled'";

            if (!string.IsNullOrEmpty(searchName))
            {
                filterExpression += $" AND First_Name LIKE '{searchName}%'";
            }

            clientBranchTableBookingBindingSource.Filter = filterExpression;
        }

        private void txtBookingID_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtClientName.Text.Trim();
            string todayDate = DateTime.Today.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(searchName))
            {
                clientBranchTableBookingBindingSource.Filter = string.Empty;
            }
            else
            {
                clientBranchTableBookingBindingSource.Filter = $"First_Name LIKE '{searchName}%'";
            }
        }

        //private void BookingManagement_Load_1(object sender, EventArgs e)
        //{

        //   taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);

        //}

        private int GetSelectedBookingID()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                if (!row.IsNewRow)
                {
                    // Use the exact (Name) shown in your properties window: bookingIDDataGridViewTextBoxColumn
                    if (dataGridView1.Columns.Contains("bookingID") && row.Cells["bookingID"].Value != null)
                    {
                        var cellValue = row.Cells["bookingID"].Value;
                        if (int.TryParse(cellValue.ToString(), out int bookingID))
                        {
                            return bookingID;
                        }
                    }
                }
            }
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                if (!row.IsNewRow && dataGridView1.Columns.Contains("bookingID") && row.Cells["bookingID"].Value != null)
                {
                    var cellValue = row.Cells["bookingID"].Value;
                    if (int.TryParse(cellValue.ToString(), out int bookingID))
                    {
                        return bookingID;
                    }
                }
            }

            MessageBox.Show("Please select a valid booking row from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBy = cmbSearchBy.SelectedItem?.ToString() ?? cmbSearchBy.Text.Trim();
            string query = txtSearchQuery.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                clientBranchTableBookingBindingSource.Filter = string.Empty;
                return;
            }

            if (searchBy == "Booking ID")
            {
                if (int.TryParse(query, out int bookingId))
                {
                    clientBranchTableBookingBindingSource.Filter = $"Booking_ID = {bookingId}";
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric Booking ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (searchBy == "Status")
            {
                clientBranchTableBookingBindingSource.Filter = $"Booking_Status LIKE '%{query}%'";
            }
            else if (searchBy == "Branch")
            {
                clientBranchTableBookingBindingSource.Filter = $"Branch_Name LIKE '%{query}%'";
            }
            else
            {
                MessageBox.Show("Please select a search filter category from the dropdown.", "Filter Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchQuery.Clear();
            cmbSearchBy.SelectedIndex = -1;
            clientBranchTableBookingBindingSource.Filter = string.Empty;
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            int bookingID = GetSelectedBookingID();
            if (bookingID == -1) return;

            var confirm = MessageBox.Show($"Are you sure you want to cancel Booking ID {bookingID}?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Booking SET Booking_Status = 'Cancelled' WHERE Booking_ID = @BookingID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BookingID", bookingID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Booking successfully cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh your table adapter data here
                    this.taClientBranchTableBooking.Fill(this.codeCraftersDSTWO.ClientBranchTableBooking);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while cancelling the booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            int bookingID = GetSelectedBookingID();
            if (bookingID == -1) return;

            // TODO: Open your reschedule form and pass bookingID
            // RescheduleForm frm = new RescheduleForm(bookingID);
            // frm.ShowDialog();
            // this.clientBranchTableBookingTableAdapter.Fill(this.groupPmb2DataSet.ClientBranchTableBooking);
        }

        private void btnViewEdit_Click(object sender, EventArgs e)
        {
            int bookingID = GetSelectedBookingID();
            if (bookingID == -1) return;

            // TODO: Open your edit details form and pass bookingID
        }

        private void btnLinkBookings_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchQuery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
