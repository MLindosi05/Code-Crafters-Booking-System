using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Common;
using Code_Crafters_Interface_Prototype_1.Interfaces;
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
        private static readonly TimeSpan StandardCheckInTime = new TimeSpan(15, 0, 0);   // 15:00 PM check-in rule[cite: 3]
        private static readonly TimeSpan StandardCheckOutTime = new TimeSpan(11, 0, 0); // 11:00 AM check-out rule[cite: 3]
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
            InitializePlaceholder();

            btnCheckAvailability.BackColor = Color.FromArgb(243, 166, 35); // Warm golden-orange tone
            btnCheckAvailability.ForeColor = Color.White;                    // Bold white text
            btnCheckAvailability.FlatStyle = FlatStyle.Flat;               // Removes the 3D button bevel
            btnCheckAvailability.FlatAppearance.BorderSize = 0;             // Removes the border outline                 

            codeCraftersDSTWO.EnforceConstraints = false;
            taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);
      
            PerformAvailabilityCheck();
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
                    numAdults.Value = 0;

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
                string clientStatus = existingClient.Table.Columns.Contains("Client_Status") && !existingClient.IsNull("Client_Status")
                    ? existingClient.Field<string>("Client_Status")?.Trim()
                    : "Active";

                if (string.Equals(clientStatus, "Blacklisted", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Cannot proceed with booking. This client is currently Blacklisted.", "Blacklisted Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }

                if (string.Equals(clientStatus, "Inactive", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Cannot proceed with booking. This client's account is Inactive.", "Inactive Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }

                return existingClient.Client_ID;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Client email does not exist in the system.\nWould you like to open Guest Registration and register this client now?",
                    "Client Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Please register the guest via Guest Management --- Guest Registration before proceeding with this booking.", "REGAL INN REGISTRATION REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (taClient != null)
                    {
                        codeCraftersDSTWO.Client.Clear();
                        taClient.Fill(codeCraftersDSTWO.Client);
                    }

                    var newlyAddedClient = codeCraftersDSTWO.Client.AsEnumerable()
                        .FirstOrDefault(c => string.Equals(c.Field<string>("Email_Address"), emailAddress.Trim(), StringComparison.OrdinalIgnoreCase));

                    if (newlyAddedClient != null)
                    {
                        return newlyAddedClient.Client_ID;
                    }
                }

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

                    string currentStatus = booking.Booking_Status?.Trim();
                    int roomNumber = ExtractRoomNumberFromBookingType(booking.Booking_Type);

                    if (currentDateTime >= checkInTime && currentDateTime < checkOutTime && (currentStatus == "Pending" || currentStatus == "Booked"))
                    {
                        booking.Booking_Status = "Checked-In";
                        UpdateHotelRoomStatus(booking.Branch_ID, roomNumber, "Occupied");
                    }
                    else if (currentDateTime >= checkOutTime && currentDateTime < cleaningEndTime && currentStatus == "Checked-In")
                    {
                        booking.Booking_Status = "Checked-Out";
                        UpdateHotelRoomStatus(booking.Branch_ID, roomNumber, "Cleaning");
                    }
                    else if (currentDateTime >= cleaningEndTime && (currentStatus == "Checked-Out" || currentStatus == "Checked-In" || currentStatus == "Booked"))
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

        // --- NEW METHOD: Powers Check Availability Logic ---
        private void PerformAvailabilityCheck()
        {
            try
            {
                string selectedBranchName = cmbBranchName.SelectedItem?.ToString() ?? cmbBranchName.Text;
                string branchID = GetBranchIDFromName(selectedBranchName);

                DateTime requestedCheckIn = dtpRoomCheckIn.Value.Date.Add(StandardCheckInTime);
                DateTime requestedCheckOut = dtpRoomCheckOut.Value.Date.Add(StandardCheckOutTime);

                if (requestedCheckOut <= requestedCheckIn)
                {
                    MessageBox.Show("Check-out date/time must be after check-in date/time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (taHotelRoom != null)
                {
                    codeCraftersDSTWO.Hotel_Room.Clear();
                    taHotelRoom.Fill(codeCraftersDSTWO.Hotel_Room);
                }

                if (taBooking != null)
                {
                    codeCraftersDSTWO.Booking.Clear();
                    taBooking.Fill(codeCraftersDSTWO.Booking);
                }

                // Fix: Use Cast to match the expected typed row list format
                var roomsInBranch = codeCraftersDSTWO.Hotel_Room.Rows.Cast<codeCraftersDSTWO.Hotel_RoomRow>()
                    .Where(r => r.Field<string>("Branch_ID")?.Trim() == branchID)
                    .ToList();

                // Evaluate each room button individually against dates
                ConfigureRoomButtonWithDates(btnRoomOneBook, "Standard Room 1 King Bed", roomsInBranch, branchID, requestedCheckIn, requestedCheckOut);
                ConfigureRoomButtonWithDates(btnRoomTwoBook, "Suite Room Twin Beds", roomsInBranch, branchID, requestedCheckIn, requestedCheckOut);
                ConfigureRoomButtonWithDates(btnRoomThreeBook, "Suite Room 1 King Bed", roomsInBranch, branchID, requestedCheckIn, requestedCheckOut);
                ConfigureRoomButtonWithDates(btnRoomFourBook, "Executive Room 1 King Bed", roomsInBranch, branchID, requestedCheckIn, requestedCheckOut);
                ConfigureRoomButtonWithDates(btnRoomFiveBook, "Deluxe Room 1 King Bed", roomsInBranch, branchID, requestedCheckIn, requestedCheckOut);
                ConfigureRoomButtonWithDates(btnRoomSixBook, "Standard Room 2 Double Beds", roomsInBranch, branchID, requestedCheckIn, requestedCheckOut);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking room availability: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureRoomButtonWithDates(Button btn, string roomTypeName, List<codeCraftersDSTWO.Hotel_RoomRow> roomsInBranch, string branchID, DateTime checkIn, DateTime checkOut)
        {
            if (btn == null) return;

            var roomsOfType = roomsInBranch
                .Where(r => string.Equals(r.hotel_room_type?.Trim(), roomTypeName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!roomsOfType.Any())
            {
                SetButtonUnavailable(btn);
                return;
            }

            bool hasAvailableRoom = roomsOfType.Any(r => !IsRoomBookedForDates(branchID, r.hotel_room_number, checkIn, checkOut));

            if (hasAvailableRoom)
            {
                btn.Enabled = true;
                btn.BackColor = Color.FromArgb(0, 113, 228);
                btn.ForeColor = Color.White;
                btn.Text = "BOOK NOW";
            }
            else
            {
                SetButtonUnavailable(btn);
            }
        }

        private void SetButtonUnavailable(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.Gray;      // Gray color for booked/unavailable rooms[cite: 3]
            btn.ForeColor = Color.DarkGray;
            btn.Text = "NOT AVAILABLE";
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

                if (!roomsOfType.Any(r => totalGuests <= GetRoomCapacity(roomType, r)))
                {
                    MessageBox.Show("The number of guests exceeds the maximum capacity allowed for this room type.", "Capacity Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var capacityValidRooms = roomsOfType
                    .Where(r => totalGuests <= GetRoomCapacity(roomType, r))
                    .ToList();

                if (!capacityValidRooms.Any())
                {
                    MessageBox.Show("The number of guests exceeds the maximum capacity allowed for this room type.", "Capacity Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var availableRoom = capacityValidRooms
                    .FirstOrDefault(r => !IsRoomBookedForDates(branchID, r.hotel_room_number, checkIn, checkOut));

                if (availableRoom == null)
                {
                    MessageBox.Show("All rooms of this type are already booked for the selected dates. Please choose different dates or another room type.", "Double Booking / Fully Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PerformAvailabilityCheck();
                    return;
                }

                int assignedRoomID = availableRoom.Hotel_Room_ID;
                int assignedRoomNumber = availableRoom.hotel_room_number;
                decimal finalBookingTotal = roomPricePerNight * totalNights;
                string bookingTypeStr = roomType + " (Room " + assignedRoomNumber + ")";
                int activeBookingID = 0;

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
                    "Optional Dining Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private bool isPlaceholderActive = true;
        private readonly string placeholderText = "e.g. john@regalinn.co.za";

        private void txtClientEmailAddress_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                txtClientEmailAddress.Text = "";
                txtClientEmailAddress.ForeColor = Color.Black;
                isPlaceholderActive = false;
            }
        }

        private void txtClientEmailAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientEmailAddress.Text))
            {
                txtClientEmailAddress.Text = placeholderText;
                txtClientEmailAddress.ForeColor = Color.Gray;
                isPlaceholderActive = true;
            }
        }

        private void InitializePlaceholder()
        {
            txtClientEmailAddress.Text = placeholderText;
            txtClientEmailAddress.ForeColor = Color.Gray;

            txtClientEmailAddress.Enter += txtClientEmailAddress_Enter;
            txtClientEmailAddress.Leave += txtClientEmailAddress_Leave;
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            string searchName = txtClientName.Text.Trim();
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

            if (string.IsNullOrEmpty(searchName))
            {
                clientBranchTableBookingBindingSource.Filter = string.Empty;
            }
            else
            {
                clientBranchTableBookingBindingSource.Filter = $"First_Name LIKE '{searchName}%'";
            }
        }

        private int GetSelectedBookingID()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                if (!row.IsNewRow)
                {
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

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            int bookingID = GetSelectedBookingID();
            if (bookingID == -1) return;

            var confirm = MessageBox.Show($"Are you sure you want to cancel Booking ID {bookingID}?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    decimal totalAmount = 0m;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string getAmountQuery = "SELECT Booking_Total_Amount FROM Booking WHERE Booking_ID = @BookingID";
                        using (SqlCommand cmdGet = new SqlCommand(getAmountQuery, conn))
                        {
                            cmdGet.Parameters.AddWithValue("@BookingID", bookingID);
                            object result = cmdGet.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                totalAmount = Convert.ToDecimal(result);
                            }
                        }

                        decimal penaltyAmount = totalAmount * 0.15m;
                        decimal refundAmount = totalAmount - penaltyAmount;
                        string cancellationReason = "Cancelled by administrator request.";
                        string adminNotes = $"Standard 15% cancellation fee applied. Total: {totalAmount:C}, Penalty: {penaltyAmount:C}, Refund: {refundAmount:C}";

                        string updateQuery = @"
                    UPDATE Booking 
                    SET Booking_Status = 'Cancelled',
                        Cancellation_Date = GETDATE(),
                        Cancellation_Reason = @Reason,
                        Admin_Notes = @Notes,
                        Penalty_Amount = @Penalty,
                        Credit_Amount = @Credit
                    WHERE Booking_ID = @BookingID";

                        using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@BookingID", bookingID);
                            cmdUpdate.Parameters.AddWithValue("@Reason", cancellationReason);
                            cmdUpdate.Parameters.AddWithValue("@Notes", adminNotes);
                            cmdUpdate.Parameters.AddWithValue("@Penalty", penaltyAmount);
                            cmdUpdate.Parameters.AddWithValue("@Credit", refundAmount);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            $"Booking successfully cancelled.\n\n" +
                            $"Total Booking Amount: R {totalAmount:N2}\n" +
                            $"15% Cancellation Penalty: R {penaltyAmount:N2}\n" +
                            $"Refund Amount Due (Credit): R {refundAmount:N2}",
                            "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.taClientBranchTableBooking.Fill(this.codeCraftersDSTWO.ClientBranchTableBooking);
                    PerformAvailabilityCheck();
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

            DataRowView selectedRow = dataGridView1.SelectedRows.Count > 0 ?
                dataGridView1.SelectedRows[0].DataBoundItem as DataRowView :
                (dataGridView1.SelectedCells.Count > 0 ? dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as DataRowView : null);

            if (selectedRow != null)
            {
                string status = selectedRow["Booking_Status"]?.ToString();
                if (status == "Cancelled" || status == "Completed")
                {
                    MessageBox.Show($"Cannot reschedule a booking with status '{status}'.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                MessageBox.Show($"Reschedule module invoked for Booking ID: {bookingID}.", "Reschedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing reschedule request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewEdit_Click(object sender, EventArgs e)
        {
            int bookingID = GetSelectedBookingID();
            if (bookingID == -1) return;

            try
            {
                MessageBox.Show($"Edit details module invoked for Booking ID: {bookingID}.", "Edit Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening edit form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLinkBookings_Click(object sender, EventArgs e)
        {
            int bookingID = GetSelectedBookingID();
            if (bookingID == -1) return;

            try
            {
                MessageBox.Show($"Link bookings module invoked for Booking ID: {bookingID}.", "Link Bookings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error linking bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchQuery_TextChanged(object sender, EventArgs e) { }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SetInitialDates();

                if (numAdults != null) numAdults.Value = 0;
                if (numChildren != null) numChildren.Value = 0;

                if (cmbBranchName != null && cmbBranchName.Items.Count > 0) cmbBranchName.SelectedIndex = 0;

                txtClientName.Clear();
                txtClientEmailAddress.Clear();

                if (clientBranchTableBookingBindingSource != null)
                {
                    clientBranchTableBookingBindingSource.Filter = string.Empty;
                }

                UpdateRoomAndBookingStatuses();
                RefreshDataSilent();
                PerformAvailabilityCheck();

                if (taClientBranchTableBooking != null)
                {
                    codeCraftersDSTWO.EnforceConstraints = false;
                    taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing page data:\n\n" + ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            PerformAvailabilityCheck();
        }

        private void txtSearchBooking_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBooking.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                clientBranchTableBookingBindingSource1.Filter = string.Empty;
            }
            else
            {
                string formattedSearch = char.ToUpper(searchText[0]) + (searchText.Length > 1 ? searchText.Substring(1) : string.Empty);

                if (int.TryParse(searchText, out int bookingID))
                {
                    clientBranchTableBookingBindingSource1.Filter = $"bookingID = {bookingID}";
                }
                else
                {
                    clientBranchTableBookingBindingSource1.Filter = $"First_Name LIKE '{formattedSearch}%'";
                }
            }
        }
    }
}