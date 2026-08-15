using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class BookingManagement : Form
    {
        private decimal _calculatedTotal = 0.00m;

        // Standard Hotel Policy Constants
        private static readonly TimeSpan StandardCheckInTime = new TimeSpan(15, 0, 0);  // 15:00 PM
        private static readonly TimeSpan StandardCheckOutTime = new TimeSpan(11, 0, 0); // 11:00 AM

        public BookingManagement()
        {
            InitializeComponent();
        }

       

        
        #region Form Load & Initialization

       

        
        private void DgvBookingList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           // if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvBookingList.Columns[e.ColumnIndex].Name == "Booking_Status")
            {
                e.PaintBackground(e.CellBounds, true);

                string status = e.Value?.ToString() ?? "Pending";
                Color badgeColor = Color.FromArgb(241, 196, 15);

                if (status.Equals("Confirmed", StringComparison.OrdinalIgnoreCase) || status.Equals("Deposit Paid", StringComparison.OrdinalIgnoreCase))
                    badgeColor = Color.FromArgb(76, 175, 80);
                else if (status.Equals("Checked In", StringComparison.OrdinalIgnoreCase) || status.Equals("Checked Out", StringComparison.OrdinalIgnoreCase))
                    badgeColor = Color.FromArgb(52, 152, 219);
                else if (status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) || status.Equals("No Show", StringComparison.OrdinalIgnoreCase))
                    badgeColor = Color.FromArgb(231, 76, 60);

                int paddingX = 10;
                int paddingY = 6;
                Rectangle pillRect = new Rectangle(
                    e.CellBounds.X + paddingX,
                    e.CellBounds.Y + paddingY,
                    e.CellBounds.Width - (paddingX * 2),
                    e.CellBounds.Height - (paddingY * 2)
                );

                using (Brush brush = new SolidBrush(badgeColor))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    int cornerRadius = pillRect.Height;

                    using (System.Drawing.Drawing2D.GraphicsPath path = GetRoundedPath(pillRect, cornerRadius))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    TextRenderer.DrawText(
                        e.Graphics,
                        status,
                        new Font("Segoe UI", 8.5F, FontStyle.Bold),
                        pillRect,
                        Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                    );
                }

                e.Handled = true;
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            float diameter = radius;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        public class BranchOption
        {
            public string BranchID { get; set; }
            public string BranchName { get; set; }

            public BranchOption(string id, string name)
            {
                BranchID = id;
                BranchName = name;
            }
        }

        private string GetSelectedBranchID()
        {
            if (cmbBranchName.SelectedValue != null)
                return cmbBranchName.SelectedValue.ToString();

            switch (cmbBranchName.Text.Trim())
            {
                case "Pietermaritzburg": return "BR01";
                case "Durban Umhlanga": return "BR02";
                case "Durban North Beach": return "BR03";
                case "Durban Ballito": return "BR04";
                case "JHB Midrand": return "BR05";
                default: return "BR01";
            }
        }

        private void InitializeDropdowns()
        {
            try
            {
                cmbBranchName.DataSource = null;
                cmbBranchName.Items.Clear();

                var branches = new List<BranchOption>
                {
                    new BranchOption("BR01", "Pietermaritzburg"),
                    new BranchOption("BR02", "Durban Umhlanga"),
                    new BranchOption("BR03", "Durban North Beach"),
                    new BranchOption("BR04", "Durban Ballito"),
                    new BranchOption("BR05", "JHB Midrand")
                };

                cmbBranchName.DataSource = branches;
                cmbBranchName.DisplayMember = "BranchName";
                cmbBranchName.ValueMember = "BranchID";
                cmbBranchName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Branch dropdown error: " + ex.Message);
            }
        }



        private void BookingForm_Load(object sender, EventArgs e)
        {
            InitializeDropdowns();
            SetInitialDates();
           

            
            ClearAllDropdowns();


        }

        private void ClearAllDropdowns()
        {
            
            cmbSearchBy.SelectedIndex = -1;
            cmbBranchName.SelectedIndex = -1;
        }

        private void SetInitialDates()
        {
            dtpRoomCheckIn.Value = DateTime.Today.Add(StandardCheckInTime);
            dtpRoomCheckOut.Value = DateTime.Today.AddDays(1).Add(StandardCheckOutTime);

            
        }

        

        #endregion

        #region Status Lifecycle

        private void AutoUpdateBookingStatuses()
        {
            bool hasUpdates = false;
            DateTime now = DateTime.Now;

            foreach (DataRow booking in codeCraftersDSTWO.Booking.Rows)
            {
                if (booking.RowState == DataRowState.Deleted) continue;
                if (booking["Checkin_Date"] == DBNull.Value || booking["Checkout_Date"] == DBNull.Value) continue;

                string currentStatus = booking["Booking_Status"]?.ToString() ?? "";
                DateTime checkIn = Convert.ToDateTime(booking["Checkin_Date"]);
                DateTime checkOut = Convert.ToDateTime(booking["Checkout_Date"]);

                if (checkOut <= checkIn) continue;

                if ((currentStatus.Equals("Confirmed", StringComparison.OrdinalIgnoreCase) || currentStatus.Equals("Deposit Paid", StringComparison.OrdinalIgnoreCase)) && now >= checkIn && now < checkOut)
                {
                    booking["Booking_Status"] = "Checked In";
                    hasUpdates = true;
                }
                else if (currentStatus.Equals("Checked In", StringComparison.OrdinalIgnoreCase) && now >= checkOut)
                {
                    booking["Booking_Status"] = "Checked Out";
                    hasUpdates = true;
                }
                else if (currentStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase) && now > checkIn.AddHours(2))
                {
                    booking["Booking_Status"] = "No Show";
                    hasUpdates = true;
                }
            }

            if (hasUpdates)
            {
                taBooking.Update(codeCraftersDSTWO.Booking);
            }
        }

        #endregion

        #region Availability & Dynamic Price Calculation

        private decimal CalculateBookingAmount(string bookingType, DataRow assignedRoom, DataRow assignedTable, int nights)
        {
            decimal total = 0.00m;
            int stayNights = nights > 0 ? nights : 1;

            if (assignedRoom != null && assignedRoom.Table.Columns.Contains("Hotel_Room_Price") && assignedRoom["Hotel_Room_Price"] != DBNull.Value)
            {
                decimal roomPricePerNight = Convert.ToDecimal(assignedRoom["Hotel_Room_Price"]);
                if (bookingType == "Room Booking" || bookingType == "Room & Table")
                {
                    total += (roomPricePerNight * stayNights);
                }
            }
            else if (bookingType == "Room Booking" || bookingType == "Room & Table")
            {
                throw new Exception("Room price is missing or not configured in the database for this room.");
            }

            if (assignedTable != null && assignedTable.Table.Columns.Contains("TablePrice") && assignedTable["TablePrice"] != DBNull.Value)
            {
                decimal tablePrice = Convert.ToDecimal(assignedTable["TablePrice"]);
                if (bookingType == "Table Booking" || bookingType == "Room & Table")
                {
                    total += tablePrice;
                }
            }

            return total;
        }

        private DataRow AssignAvailableTable(string requestedArea, DateTime checkIn, DateTime checkOut)
        {
            taRestaurantTable.Fill(codeCraftersDSTWO.Restuarant_Table);

            var candidateTables = codeCraftersDSTWO.Restuarant_Table.AsEnumerable().Where(t =>
                (t.Field<string>("TableFeatures") ?? "").Equals(requestedArea, StringComparison.OrdinalIgnoreCase) &&
                (t.Field<string>("TableStatus") ?? "Available").Equals("Available", StringComparison.OrdinalIgnoreCase)
            );

            foreach (var table in candidateTables)
            {
                int tableID = Convert.ToInt32(table["RestaurantTableID"]);

                bool isOccupied = codeCraftersDSTWO.Table_Allocation.AsEnumerable().Any(ta =>
                    ta.Field<int>("Restuarant_Table_ID") == tableID &&
                    checkIn < ta.Field<DateTime>("End_Time") &&
                    checkOut > ta.Field<DateTime>("Start_Time")
                );

                if (!isOccupied)
                {
                    return table;
                }
            }

            return null;
        }

        #endregion

        #region Dropdown Handlers

        
       

        
        #endregion

        #region Data Refresh & Search

        

        private void RefreshDataSilent()
        {
            try
            {
                taHotelRoom.Fill(codeCraftersDSTWO.Hotel_Room);
                taRestaurantTable.Fill(codeCraftersDSTWO.Restuarant_Table);
                taBooking.Fill(codeCraftersDSTWO.Booking);
                taRoomAssignment.Fill(codeCraftersDSTWO.Room_Assignment);
                taTableAllocation.Fill(codeCraftersDSTWO.Table_Allocation);
                taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);

                AutoUpdateBookingStatuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data from database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchQuery.Clear();
            ClearAllDropdowns();
            SetInitialDates();
        }

        #endregion

        #region Automatic Room Assignment

        private DataRow AssignAvailableRoom(string requestedCategory, int adults, int children, int infants, DateTime checkIn, DateTime checkOut)
        {
            taRoomAssignment.Fill(codeCraftersDSTWO.Room_Assignment);

            var candidateRooms = codeCraftersDSTWO.Hotel_Room.AsEnumerable().Where(r =>
                (r.Field<string>("hotel_room_type") ?? "").Equals(requestedCategory, StringComparison.OrdinalIgnoreCase) &&
                (r.Field<string>("hotel_room_status") ?? "Available").Equals("Available", StringComparison.OrdinalIgnoreCase)
            );

            foreach (var room in candidateRooms)
            {
                int maxA = room.Table.Columns.Contains("Max_Adults") && room["Max_Adults"] != DBNull.Value ? Convert.ToInt32(room["Max_Adults"]) : 2;
                int maxC = room.Table.Columns.Contains("Max_Children") && room["Max_Children"] != DBNull.Value ? Convert.ToInt32(room["Max_Children"]) : 2;
                int maxI = room.Table.Columns.Contains("Max_Infants") && room["Max_Infants"] != DBNull.Value ? Convert.ToInt32(room["Max_Infants"]) : 1;

                if (adults > maxA || children > maxC || infants > maxI)
                    continue;

                int roomID = Convert.ToInt32(room["Hotel_Room_ID"]);

                bool isOccupied = codeCraftersDSTWO.Room_Assignment.AsEnumerable().Any(ra =>
                    ra.Field<int>("Hotel_Room_ID") == roomID &&
                    checkIn < ra.Field<DateTime>("Actual_Checkout_Time") &&
                    checkOut > ra.Field<DateTime>("Actual_Checkin_Time")
                );

                if (!isOccupied)
                    return room;
            }

            return null;
        }

        #endregion

        #region Booking Actions

        

       
       

        

        #endregion

        #region Helpers

        

        #endregion

        #region Client ID Lookup

        private int GetOrCreateClientID(string fullName, string phoneNumber, string email, string identityNumber)
        {
            string[] nameParts = fullName.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstName = nameParts.Length > 0 ? nameParts[0] : fullName.Trim();
            string lastName = nameParts.Length > 1 ? string.Join(" ", nameParts.Skip(1)) : "N/A";

            taClient.Fill(codeCraftersDSTWO.Client);

            DataRow existingClient = codeCraftersDSTWO.Client.AsEnumerable().FirstOrDefault(c =>
                c.Field<string>("Phone_Number") == phoneNumber ||
                (c.Field<string>("First_Name").Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                 c.Field<string>("Last_Name").Equals(lastName, StringComparison.OrdinalIgnoreCase))
            );

            if (existingClient != null)
            {
                return Convert.ToInt32(existingClient["Client_ID"]);
            }

            DataRow newClient = codeCraftersDSTWO.Client.NewRow();
            newClient["First_Name"] = firstName;
            newClient["Last_Name"] = lastName;
            newClient["Phone_Number"] = phoneNumber;
            newClient["Email_Address"] = string.IsNullOrWhiteSpace(email) ? DBNull.Value : (object)email;
            newClient["Client_Status"] = "Active";
            newClient["Date_Registered"] = DateTime.Now;

            codeCraftersDSTWO.Client.Rows.Add(newClient);
            taClient.Update(codeCraftersDSTWO.Client);

            taClient.Fill(codeCraftersDSTWO.Client);

            DataRow createdClient = codeCraftersDSTWO.Client.AsEnumerable().FirstOrDefault(c =>
                c.Field<string>("Phone_Number") == phoneNumber
            );

            return createdClient != null ? Convert.ToInt32(createdClient["Client_ID"]) : 1;
        }

        #endregion

        #region New Booking Creation

        

        #endregion

        #region Search & View Edit

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                RefreshDataSilent();

                DataView dv = new DataView(codeCraftersDSTWO.ClientBranchTableBooking);
                string filter = "1=1";

                string query = txtSearchQuery.Text.Trim().Replace("'", "''");
                string searchBy = cmbSearchBy.Text;

                if (!string.IsNullOrEmpty(query))
                {
                    switch (searchBy)
                    {
                        case "Guest Full Name":
                            filter += $" AND (First_Name + ' ' + Last_Name = '{query}')";
                            break;
                        case "Phone No":
                            filter += $" AND Phone_Number LIKE '%{query}%'";
                            break;
                        case "ID/Passport No":
                            if (codeCraftersDSTWO.ClientBranchTableBooking.Columns.Contains("Identity_Number"))
                                filter += $" AND Identity_Number LIKE '%{query}%'";
                            break;
                    }
                }

                dv.RowFilter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter application error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

       
        private void tabPage2_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            pnlViewBookings.BackColor = ColorTranslator.FromHtml("#966919");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");

            try
            {
                this.taClientBranchTableBooking.Fill(this.codeCraftersDSTWO.ClientBranchTableBooking);
            }
            catch (DataException ex)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                if (this.codeCraftersDSTWO.ClientBranchTableBooking.HasErrors)
                {
                    foreach (DataRow row in this.codeCraftersDSTWO.ClientBranchTableBooking.GetErrors())
                    {
                        sb.AppendLine($"Row Error: {row.RowError}");
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            sb.AppendLine($"--- Column '{col.ColumnName}' failed. Current value: '{row[col]}'");
                        }
                    }
                }

                MessageBox.Show($"Constraint Error Details:\n\n{sb.ToString() ?? ex.Message}",
                                "Dataset Constraint Broken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }


        private void txtBookingID_TextChanged_1(object sender, EventArgs e)
        {
            string input = txtBookingID.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);
                return;
            }

            if (input.StartsWith("-"))
            {
                MessageBox.Show("Negative ID patterns are not allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Clear();
                taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);
                return;
            }

            taClientBranchTableBooking.FillByFirstName(codeCraftersDSTWO.ClientBranchTableBooking, input);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BookingSummaryForm().Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new BookingSummaryForm().Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new BookingSummaryForm().Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new BookingSummaryForm().Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new BookingSummaryForm().Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new BookingSummaryForm().Show();
            Hide();
        }
    }
}