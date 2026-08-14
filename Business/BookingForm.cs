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
    public partial class BookingForm : Form
    {
        private decimal _calculatedTotal = 0.00m;

        // Standard Hotel Policy Constants
        private static readonly TimeSpan StandardCheckInTime = new TimeSpan(15, 0, 0);  // 15:00 PM
        private static readonly TimeSpan StandardCheckOutTime = new TimeSpan(11, 0, 0); // 11:00 AM

        public BookingForm()
        {
            InitializeComponent();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnReschedule.Click += new System.EventHandler(this.btnReschedule_Click);
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            this.btnLinkBookings.Click += new System.EventHandler(this.btnLinkBookings_Click);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click_1);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);

            this.cmbRoomCategory.DropDown += new System.EventHandler(this.cmbRoomCategory_DropDown);
            this.cmbTableArea.DropDown += new System.EventHandler(this.cmbTableArea_DropDown);
            this.cmbSearchBy.DropDown += new System.EventHandler(this.cmbSearchBy_DropDown);
            this.cmbBookingType.DropDown += new System.EventHandler(this.cmbBookingType_DropDown);
            this.cmbBookingType.SelectedIndexChanged += new System.EventHandler(this.cmbBookingType_SelectedIndexChanged);

            this.dtpRoomCheckIn.ValueChanged += new System.EventHandler(this.DtpRoomDates_ValueChanged);
            this.dtpRoomCheckOut.ValueChanged += new System.EventHandler(this.DtpRoomDates_ValueChanged);
        }

        private void DtpRoomDates_ValueChanged(object sender, EventArgs e)
        {
            CalculateNights();
        }

        private void CalculateNights()
        {
            if (dtpRoomCheckOut.Value.Date >= dtpRoomCheckIn.Value.Date)
            {
                int nights = (int)(dtpRoomCheckOut.Value.Date - dtpRoomCheckIn.Value.Date).TotalDays;
                numNoOfNights.Text = (nights > 0 ? nights : 1).ToString();
            }
            else
            {
                numNoOfNights.Text = "1";
            }
        }

        #region Form Load & Initialization

        private void SetupCustomGridView()
        {
            dgvBookingList.AutoGenerateColumns = false;
            dgvBookingList.AllowUserToAddRows = false;
            dgvBookingList.RowHeadersVisible = false;
            dgvBookingList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookingList.BackgroundColor = Color.White;
            dgvBookingList.BorderStyle = BorderStyle.FixedSingle;
            dgvBookingList.RowTemplate.Height = 40;

            dgvBookingList.EnableHeadersVisualStyles = false;
            dgvBookingList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvBookingList.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dgvBookingList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvBookingList.ColumnHeadersHeight = 42;

            dgvBookingList.Columns.Clear();

            // 1. CheckBox Column
            dgvBookingList.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colSelect",
                HeaderText = "",
                Width = 40,
                FlatStyle = FlatStyle.Standard
            });

            // 2. Booking ID Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Booking_ID",
                DataPropertyName = "Booking_ID",
                HeaderText = "BOOKING ID",
                Width = 110
            });

            // 3. Type Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Booking_Type",
                HeaderText = "BOOKING TYPE",
                Width = 130
            });

            // 4. Guest Name Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Guest_Name",
                HeaderText = "GUEST NAME",
                Width = 140
            });

            // 5. Phone Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone_Number",
                DataPropertyName = "Phone_Number",
                HeaderText = "PHONE NO",
                Width = 110
            });

            // 6. Room / Table Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Room_Table",
                HeaderText = "ROOM / TABLE",
                Width = 150
            });

            // 7. Category / Area Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Category_Area",
                HeaderText = "CATEGORY / AREA",
                Width = 160
            });

            // 8. Check-in Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Checkin_Date",
                DataPropertyName = "Checkin_Date",
                HeaderText = "CHECK-IN",
                Width = 130
            });

            // 9. Check-out Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Checkout_Date",
                DataPropertyName = "Checkout_Date",
                HeaderText = "CHECK-OUT",
                Width = 130
            });

            // 10. Status Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Booking_Status",
                DataPropertyName = "Booking_Status",
                HeaderText = "BOOKING STATUS",
                Width = 150
            });

            // 11. Total Amount Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Booking_Total_Amount",
                DataPropertyName = "Booking_Total_Amount",
                HeaderText = "TOTAL AMOUNT",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvBookingList.CellFormatting += DgvBookingList_CellFormatting;
            dgvBookingList.CellPainting += DgvBookingList_CellPainting;
        }

        private void DgvBookingList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBookingList.Rows.Count) return;

            DataGridViewRow row = dgvBookingList.Rows[e.RowIndex];
            DataRowView drv = row.DataBoundItem as DataRowView;

            if (drv == null) return;

            string colName = dgvBookingList.Columns[e.ColumnIndex].Name;
            int bookingID = Convert.ToInt32(drv.Row["Booking_ID"]);

            if (colName == "Booking_ID" && e.Value != null)
            {
                e.Value = $"BKG{bookingID:D4}";
                e.FormattingApplied = true;
                row.Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(41, 128, 185);
                row.Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                return;
            }

            if (colName == "Booking_Type")
            {
                e.Value = drv["Booking_Type"].ToString();
                e.FormattingApplied = true;
                return;
            }

            if (colName == "Guest_Name")
            {
                string firstName = drv.Row.Table.Columns.Contains("First_Name") ? drv.Row["First_Name"].ToString() : "";
                string lastName = drv.Row.Table.Columns.Contains("Last_Name") ? drv.Row["Last_Name"].ToString() : "";
                e.Value = $"{firstName} {lastName}".Trim();
                e.FormattingApplied = true;
                return;
            }

            if (colName == "Room_Table")
            {
                string bookingType = Convert.ToString(drv["Booking_Type"]);
                string room = drv.Row.Table.Columns.Contains("hotel_room_number") ? Convert.ToString(drv["hotel_room_number"]) : "";
                string tableNo = drv.Row.Table.Columns.Contains("RestuarantTableNum") ? Convert.ToString(drv["RestuarantTableNum"]) : "";

                if (bookingType == "Room & Table")
                    e.Value = room + " / " + tableNo;
                else if (bookingType == "Room Booking")
                    e.Value = room;
                else if (bookingType == "Table Booking")
                    e.Value = tableNo;
                else
                    e.Value = "";

                e.FormattingApplied = true;
                return;
            }

            if (colName == "Category_Area")
            {
                string bookingType = Convert.ToString(drv["Booking_Type"]);
                string roomType = drv.Row.Table.Columns.Contains("hotel_room_type") ? Convert.ToString(drv["hotel_room_type"]) : "";
                string tableArea = drv.Row.Table.Columns.Contains("TableFeatures") ? Convert.ToString(drv["TableFeatures"]) : "";

                if (bookingType == "Room & Table")
                    e.Value = roomType + " / " + tableArea;
                else if (bookingType == "Room Booking")
                    e.Value = roomType;
                else if (bookingType == "Table Booking")
                    e.Value = tableArea;
                else
                    e.Value = "";

                e.FormattingApplied = true;
                return;
            }

            if ((colName == "Checkin_Date" || colName == "Checkout_Date") && e.Value != DBNull.Value && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dateVal))
                {
                    e.Value = dateVal.ToString("yyyy/MM/dd");
                    e.FormattingApplied = true;
                }
                return;
            }

            if (colName == "Booking_Total_Amount" && e.Value != DBNull.Value && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal total))
                {
                    e.Value = $"R {total:N2}";
                    e.FormattingApplied = true;
                }
            }
        }

        private void DgvBookingList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvBookingList.Columns[e.ColumnIndex].Name == "Booking_Status")
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
            SetupCustomGridView();

            dgvBookingList.DataSource = null;

            cmbBookingType.Items.Clear();
            cmbBookingType.Items.AddRange(new string[] { "Room Booking", "Table Booking", "Room & Table" });

            ClearAllDropdowns();


        }

        private void ClearAllDropdowns()
        {
            cmbBookingType.SelectedIndex = -1;
            cmbRoomCategory.SelectedIndex = -1;
            cmbTableArea.SelectedIndex = -1;
            cmbSearchBy.SelectedIndex = -1;
            cmbBranchName.SelectedIndex = -1;
        }

        private void SetInitialDates()
        {
            dtpRoomCheckIn.Value = DateTime.Today.Add(StandardCheckInTime);
            dtpRoomCheckOut.Value = DateTime.Today.AddDays(1).Add(StandardCheckOutTime);

            dtpTableCheckIn.Value = DateTime.Now;
            dtpTableCheckOut.Value = DateTime.Now.AddHours(2);

            CalculateNights();
        }

        private void cmbBookingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbBookingType.SelectedItem?.ToString();

            bool isRoom = selectedType == "Room Booking" || selectedType == "Room & Table";
            bool isTable = selectedType == "Table Booking" || selectedType == "Room & Table";

            cmbRoomCategory.Enabled = isRoom;
            numAdults.Enabled = isRoom;
            numChildren.Enabled = isRoom;
            numInfants.Enabled = isRoom;
            dtpRoomCheckIn.Enabled = isRoom;
            dtpRoomCheckOut.Enabled = isRoom;

            cmbTableArea.Enabled = isTable;
            dtpTableCheckIn.Enabled = isTable;
            dtpTableCheckOut.Enabled = isTable;
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

        private void cmbRoomCategory_DropDown(object sender, EventArgs e)
        {
            if (cmbRoomCategory.DataSource != null) return;

            try
            {
                if (codeCraftersDSTWO.Hotel_Room.Rows.Count > 0)
                {
                    DataView dvCategories = new DataView(codeCraftersDSTWO.Hotel_Room);
                    DataTable dtCategories = dvCategories.ToTable(true, "hotel_room_type");
                    cmbRoomCategory.DataSource = dtCategories;
                    cmbRoomCategory.DisplayMember = "hotel_room_type";
                    cmbRoomCategory.ValueMember = "hotel_room_type";
                }
                else
                {
                    cmbRoomCategory.Items.Clear();
                    cmbRoomCategory.Items.AddRange(new string[] { "Standard", "Deluxe", "Executive", "Suite" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Room Category load error: " + ex.Message);
            }
        }

        private void cmbTableArea_DropDown(object sender, EventArgs e)
        {
            try
            {
                // Always ensure the table adapter populates the data table from the database first
                taRestaurantTable.Fill(codeCraftersDSTWO.Restuarant_Table);

                if (codeCraftersDSTWO.Restuarant_Table.Rows.Count > 0)
                {
                    DataView dvAreas = new DataView(codeCraftersDSTWO.Restuarant_Table);
                    DataTable dtAreas = dvAreas.ToTable(true, "TableFeatures");

                    cmbTableArea.DataSource = null; // Clear existing binding to refresh properly
                    cmbTableArea.DataSource = dtAreas;
                    cmbTableArea.DisplayMember = "TableFeatures";
                    cmbTableArea.ValueMember = "TableFeatures";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Table Area load error: " + ex.Message);
            }
        }

        private void cmbSearchBy_DropDown(object sender, EventArgs e)
        {
            if (cmbSearchBy.Items.Count > 0) return;
            cmbSearchBy.Items.AddRange(new string[] { "Guest Full Name", "Phone No", "ID/Passport No" });
        }

        private void cmbBookingType_DropDown(object sender, EventArgs e)
        {
            if (cmbBookingType.Items.Count > 0) return;
            cmbBookingType.Items.AddRange(new string[] { "Room Booking", "Table Booking", "Room & Table" });
        }

        #endregion

        #region Data Refresh & Search

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFormInputs();
            dgvBookingList.DataSource = null;
        }

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
            dgvBookingList.DataSource = null;
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

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            if (dgvBookingList.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking from the list to reschedule.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int bookingID = Convert.ToInt32(dgvBookingList.CurrentRow.Cells["Booking_ID"].Value);
                DataRow bookingRow = codeCraftersDSTWO.Booking.FindByBooking_ID(bookingID);

                if (bookingRow == null) return;

                string bookingType = bookingRow["Booking_Type"]?.ToString() ?? "Room Booking";
                DateTime newCheckIn = dtpRoomCheckIn.Value.Date.Add(StandardCheckInTime);
                DateTime newCheckOut = dtpRoomCheckOut.Value.Date.Add(StandardCheckOutTime);

                int newNights = (int)(newCheckOut.Date - newCheckIn.Date).TotalDays;
                if (newNights <= 0) newNights = 1;

                if (newCheckOut <= newCheckIn)
                {
                    MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow assignedRoom = null;
                DataRow assignedTable = null;

                if (bookingType == "Room Booking" || bookingType == "Room & Table")
                {
                    DataRow roomAssign = codeCraftersDSTWO.Room_Assignment.AsEnumerable()
                        .FirstOrDefault(ra => ra.Field<int>("Booking_ID") == bookingID);

                    if (roomAssign != null)
                    {
                        int roomID = roomAssign.Field<int>("Hotel_Room_ID");
                        bool isRoomOccupied = codeCraftersDSTWO.Room_Assignment.AsEnumerable().Any(ra =>
                            ra.Field<int>("Hotel_Room_ID") == roomID &&
                            ra.Field<int>("Booking_ID") != bookingID &&
                            newCheckIn < ra.Field<DateTime>("Actual_Checkout_Time") &&
                            newCheckOut > ra.Field<DateTime>("Actual_Checkin_Time")
                        );

                        if (isRoomOccupied)
                        {
                            MessageBox.Show("The assigned room is already booked for these new dates. Please choose different dates or select another room.", "Room Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        assignedRoom = codeCraftersDSTWO.Hotel_Room.FindByHotel_Room_ID(roomID);
                    }
                }

                if (bookingType == "Table Booking" || bookingType == "Room & Table")
                {
                    DataRow tableAlloc = codeCraftersDSTWO.Table_Allocation.AsEnumerable()
                        .FirstOrDefault(ta => ta.Field<int>("Booking_ID") == bookingID);

                    if (tableAlloc != null)
                    {
                        int tableID = tableAlloc.Field<int>("Restuarant_Table_ID");
                        assignedTable = codeCraftersDSTWO.Restuarant_Table.FindByRestaurantTableID(tableID);
                    }
                }

                decimal originalTotal = bookingRow["Booking_Total_Amount"] != DBNull.Value ? Convert.ToDecimal(bookingRow["Booking_Total_Amount"]) : 0.00m;
                decimal newTotalAmount = CalculateBookingAmount(bookingType, assignedRoom, assignedTable, newNights);

                decimal priceDifference = newTotalAmount - originalTotal;
                decimal penaltyAmount = 0.00m;
                decimal creditAmount = 0.00m;

                if (priceDifference > 0)
                {
                    penaltyAmount = priceDifference;
                }
                else if (priceDifference < 0)
                {
                    creditAmount = Math.Abs(priceDifference);
                }

                bookingRow["Checkin_Date"] = newCheckIn;
                bookingRow["Checkout_Date"] = newCheckOut;
                bookingRow["Booking_Total_Amount"] = newTotalAmount;

                if (codeCraftersDSTWO.Booking.Columns.Contains("Penalty_Amount"))
                    bookingRow["Penalty_Amount"] = penaltyAmount;

                if (codeCraftersDSTWO.Booking.Columns.Contains("Credit_Amount"))
                    bookingRow["Credit_Amount"] = creditAmount;

                var roomAssignRow = codeCraftersDSTWO.Room_Assignment.AsEnumerable().FirstOrDefault(ra => ra.Field<int>("Booking_ID") == bookingID);
                if (roomAssignRow != null)
                {
                    roomAssignRow["Actual_Checkin_Time"] = newCheckIn;
                    roomAssignRow["Actual_Checkout_Time"] = newCheckOut;
                    roomAssignRow["Assignment_Status"] = "Reserved";
                    taRoomAssignment.Update(codeCraftersDSTWO.Room_Assignment);
                }

                var tableAllocRow = codeCraftersDSTWO.Table_Allocation.AsEnumerable().FirstOrDefault(ta => ta.Field<int>("Booking_ID") == bookingID);
                if (tableAllocRow != null)
                {
                    tableAllocRow["Start_Time"] = dtpTableCheckIn.Value;
                    tableAllocRow["End_Time"] = dtpTableCheckOut.Value;
                    tableAllocRow["Allocation_Status"] = "Reserved";
                    taTableAllocation.Update(codeCraftersDSTWO.Table_Allocation);
                }

                if (codeCraftersDSTWO.Booking.Columns.Contains("Admin_Notes"))
                {
                    string financialNote = priceDifference > 0 ? $"Penalty: R{penaltyAmount:N2}" : (priceDifference < 0 ? $"Credit: R{creditAmount:N2}" : "No Change");
                    string newNote = $"Rescheduled {newCheckIn:yyyy-MM-dd} ({newNights}n). {financialNote}";

                    if (newNote.Length > 200)
                        newNote = newNote.Substring(0, 200);

                    bookingRow["Admin_Notes"] = newNote;
                }

                if (penaltyAmount > 0)
                {
                    MessageBox.Show($"Rescheduling extends the stay. An additional amount of R {penaltyAmount:N2} is due.\nPlease complete payment to confirm this booking.",
                                    "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    using (PaymentForm paymentForm = new PaymentForm(bookingID, codeCraftersDSTWO, taBooking))
                    {
                        if (paymentForm.ShowDialog() == DialogResult.OK)
                        {
                            bookingRow["Booking_Status"] = "Confirmed";
                        }
                    }
                }
                else
                {
                    bookingRow["Booking_Status"] = "Confirmed";
                    MessageBox.Show($"Booking successfully rescheduled!\nNew Total Amount: R {newTotalAmount:N2}\nCredit/Refund Issued: R {creditAmount:N2}\nStatus updated to Confirmed.",
                                    "Reschedule Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                taBooking.Update(codeCraftersDSTWO.Booking);
                btnSearch_Click_1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while rescheduling: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookingList.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking from the list to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookingList.CurrentRow.Cells["Booking_ID"].Value);
            DataRow bookingRow = codeCraftersDSTWO.Booking.FindByBooking_ID(bookingID);

            if (bookingRow == null) return;

            DialogResult result = MessageBox.Show($"Are you sure you want to cancel booking BKG{bookingID:D4}?\n(A standard 5% cancellation penalty will apply to paid bookings).",
                                                  "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    decimal totalAmount = bookingRow["Booking_Total_Amount"] != DBNull.Value ? Convert.ToDecimal(bookingRow["Booking_Total_Amount"]) : 0.00m;

                    decimal penaltyAmount = totalAmount * 0.05m;
                    decimal refundCreditAmount = totalAmount - penaltyAmount;

                    bookingRow["Booking_Status"] = "Cancelled";

                    if (codeCraftersDSTWO.Booking.Columns.Contains("Cancellation_Date"))
                        bookingRow["Cancellation_Date"] = DateTime.Now;

                    if (codeCraftersDSTWO.Booking.Columns.Contains("Cancellation_Reason"))
                        bookingRow["Cancellation_Reason"] = "Cancelled via Booking Management Interface";

                    if (codeCraftersDSTWO.Booking.Columns.Contains("Penalty_Amount"))
                        bookingRow["Penalty_Amount"] = penaltyAmount;

                    if (codeCraftersDSTWO.Booking.Columns.Contains("Credit_Amount"))
                        bookingRow["Credit_Amount"] = refundCreditAmount;

                    if (codeCraftersDSTWO.Booking.Columns.Contains("Admin_Notes"))
                    {
                        string cancelNote = $"Cancelled. Penalty (5%): R{penaltyAmount:N2}, Refundable Credit: R{refundCreditAmount:N2}";
                        if (cancelNote.Length > 200) cancelNote = cancelNote.Substring(0, 200);
                        bookingRow["Admin_Notes"] = cancelNote;
                    }

                    taBooking.Update(codeCraftersDSTWO.Booking);

                    MessageBox.Show($"Booking BKG{bookingID:D4} has been successfully CANCELLED.\n\n" +
                                    $"Total Paid: R {totalAmount:N2}\n" +
                                    $"5% Penalty Deducted: R {penaltyAmount:N2}\n" +
                                    $"Refund / Credit Amount: R {refundCreditAmount:N2}",
                                    "Cancellation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnSearch_Click_1(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while cancelling the booking: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLinkBookings_Click(object sender, EventArgs e)
        {
            if (dgvBookingList.CurrentRow == null)
            {
                MessageBox.Show("Please select an existing booking in the grid to link items to.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int existingBookingID = Convert.ToInt32(dgvBookingList.CurrentRow.Cells["Booking_ID"].Value);
                DataRow existingBookingRow = codeCraftersDSTWO.Booking.FindByBooking_ID(existingBookingID);

                if (existingBookingRow == null)
                {
                    MessageBox.Show("Selected booking record not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbBookingType.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid booking type to link.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbBookingType.Focus();
                    return;
                }

                string additionalBookingType = cmbBookingType.SelectedItem.ToString();
                DateTime checkIn = dtpRoomCheckIn.Value;
                DateTime checkOut = dtpRoomCheckOut.Value;
                int nights = (int)(checkOut.Date - checkIn.Date).TotalDays;
                if (nights <= 0) nights = 1;

                DataRow assignedRoom = null;
                DataRow assignedTable = null;

                if (additionalBookingType == "Room Booking" || additionalBookingType == "Room & Table")
                {
                    if (cmbRoomCategory.SelectedItem == null && cmbRoomCategory.Text == "")
                    {
                        MessageBox.Show("Please select or specify a room category to add.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbRoomCategory.Focus();
                        return;
                    }

                    string roomCategory = cmbRoomCategory.Text.Trim();
                    assignedRoom = AssignAvailableRoom(roomCategory, (int)numAdults.Value, (int)numChildren.Value, (int)numInfants.Value, checkIn, checkOut);

                    if (assignedRoom == null)
                    {
                        MessageBox.Show($"No available rooms found for category '{roomCategory}'.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (additionalBookingType == "Table Booking" || additionalBookingType == "Room & Table")
                {
                    if (cmbTableArea.SelectedItem == null && cmbTableArea.Text == "")
                    {
                        MessageBox.Show("Please select or specify a restaurant table area to add.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbTableArea.Focus();
                        return;
                    }

                    string tableArea = cmbTableArea.Text.Trim();
                    assignedTable = AssignAvailableTable(tableArea, checkIn, checkOut);

                    if (assignedTable == null)
                    {
                        MessageBox.Show($"No available restaurant tables found in area '{tableArea}'.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                decimal additionalCost = CalculateBookingAmount(additionalBookingType, assignedRoom, assignedTable, nights);
                decimal currentTotal = existingBookingRow["Booking_Total_Amount"] != DBNull.Value ? Convert.ToDecimal(existingBookingRow["Booking_Total_Amount"]) : 0.00m;

                existingBookingRow["Booking_Total_Amount"] = currentTotal + additionalCost;

                string currentType = existingBookingRow["Booking_Type"]?.ToString() ?? "";
                if (currentType != additionalBookingType && currentType != "Room & Table")
                {
                    existingBookingRow["Booking_Type"] = "Room & Table";
                }

                string existingNotes = existingBookingRow.Table.Columns.Contains("Admin_Notes") ? (existingBookingRow["Admin_Notes"]?.ToString() ?? "") : "";
                existingBookingRow["Admin_Notes"] = $"{existingNotes} | Linked {additionalBookingType} on {DateTime.Now:yyyy-MM-dd HH:mm}".TrimStart(' ', '|');

                taBooking.Update(codeCraftersDSTWO.Booking);

                if (assignedRoom != null)
                {
                    DataRow roomAssignRow = codeCraftersDSTWO.Room_Assignment.NewRow();
                    roomAssignRow["Booking_ID"] = existingBookingID;
                    roomAssignRow["Hotel_Room_ID"] = Convert.ToInt32(assignedRoom["Hotel_Room_ID"]);
                    roomAssignRow["Actual_Checkin_Time"] = checkIn;
                    roomAssignRow["Actual_Checkout_Time"] = checkOut;
                    roomAssignRow["Assignment_Status"] = "Reserved";

                    codeCraftersDSTWO.Room_Assignment.Rows.Add(roomAssignRow);
                    taRoomAssignment.Update(codeCraftersDSTWO.Room_Assignment);
                }

                if (assignedTable != null)
                {
                    DataRow tableAllocRow = codeCraftersDSTWO.Table_Allocation.NewRow();
                    tableAllocRow["Booking_ID"] = existingBookingID;
                    tableAllocRow["Restuarant_Table_ID"] = Convert.ToInt32(assignedTable["RestaurantTableID"]);
                    tableAllocRow["Start_Time"] = dtpTableCheckIn.Value;
                    tableAllocRow["End_Time"] = dtpTableCheckOut.Value;
                    tableAllocRow["Allocation_Status"] = "Reserved";

                    codeCraftersDSTWO.Table_Allocation.Rows.Add(tableAllocRow);
                    taTableAllocation.Update(codeCraftersDSTWO.Table_Allocation);
                }

                MessageBox.Show($"Successfully linked items to booking BKG{existingBookingID:D4}!\nAdded Cost: R {additionalCost:N2}\nUpdated Total: R {(currentTotal + additionalCost):N2}",
                                "Booking Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFormInputs();
                btnSearch_Click_1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while linking to the booking: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvBookingList.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking from the list to print the invoice.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataRowView drv = dgvBookingList.CurrentRow.DataBoundItem as DataRowView;
                if (drv == null) return;

                int bookingID = Convert.ToInt32(drv["Booking_ID"]);
                string bookingType = drv.Row.Table.Columns.Contains("Booking_Type") ? drv["Booking_Type"].ToString() : "N/A";
                string firstName = drv.Row.Table.Columns.Contains("First_Name") ? drv["First_Name"].ToString() : "";
                string lastName = drv.Row.Table.Columns.Contains("Last_Name") ? drv["Last_Name"].ToString() : "";
                string phone = drv.Row.Table.Columns.Contains("Phone_Number") ? drv["Phone_Number"].ToString() : "N/A";
                string status = drv.Row.Table.Columns.Contains("Booking_Status") ? drv["Booking_Status"].ToString() : "Pending";

                string checkIn = drv.Row.Table.Columns.Contains("Checkin_Date") && drv["Checkin_Date"] != DBNull.Value
                    ? Convert.ToDateTime(drv["Checkin_Date"]).ToString("yyyy/MM/dd") : "N/A";
                string checkOut = drv.Row.Table.Columns.Contains("Checkout_Date") && drv["Checkout_Date"] != DBNull.Value
                    ? Convert.ToDateTime(drv["Checkout_Date"]).ToString("yyyy/MM/dd") : "N/A";

                decimal totalAmount = drv.Row.Table.Columns.Contains("Booking_Total_Amount") && drv["Booking_Total_Amount"] != DBNull.Value
                    ? Convert.ToDecimal(drv["Booking_Total_Amount"]) : 0.00m;

                string roomTable = drv.Row.Table.Columns.Contains("hotel_room_number") ? drv["hotel_room_number"].ToString() : "";
                string categoryArea = drv.Row.Table.Columns.Contains("hotel_room_type") ? drv["hotel_room_type"].ToString() : "";

                System.Drawing.Printing.PrintDocument printDoc = new System.Drawing.Printing.PrintDocument();
                printDoc.PrintPage += (s, ev) =>
                {
                    Graphics g = ev.Graphics;
                    Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold);
                    Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
                    Font regularFont = new Font("Segoe UI", 10, FontStyle.Regular);
                    Font boldRegFont = new Font("Segoe UI", 10, FontStyle.Bold);

                    int startX = 50;
                    int startY = 50;
                    int offsetX = 200;

                    g.DrawString("REGAL INN HOTEL & RESTAURANT", titleFont, Brushes.DarkBlue, startX, startY);
                    g.DrawString("Official Booking Tax Invoice", headerFont, Brushes.DimGray, startX, startY + 30);
                    g.DrawLine(Pens.Black, startX, startY + 60, 800, startY + 60);

                    int currentY = startY + 80;

                    g.DrawString("Invoice Reference:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"BKG{bookingID:D4}", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 25;

                    g.DrawString("Date Issued:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"{DateTime.Now:yyyy/MM/dd HH:mm}", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 25;

                    g.DrawString("Booking Status:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"{status}", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 35;

                    g.DrawString("GUEST INFORMATION", headerFont, Brushes.DarkBlue, startX, currentY);
                    currentY += 25;
                    g.DrawLine(Pens.LightGray, startX, currentY, 800, currentY);
                    currentY += 10;

                    g.DrawString("Guest Full Name:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"{firstName} {lastName}", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 25;

                    g.DrawString("Phone Number:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"{phone}", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 35;

                    g.DrawString("BOOKING PARTICULARS", headerFont, Brushes.DarkBlue, startX, currentY);
                    currentY += 25;
                    g.DrawLine(Pens.LightGray, startX, currentY, 800, currentY);
                    currentY += 10;

                    g.DrawString("Booking Type:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"{bookingType}", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 25;

                    g.DrawString("Assigned Unit:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"{roomTable} ({categoryArea})", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 25;

                    g.DrawString("Check-In Date:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"{checkIn}", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 25;

                    g.DrawString("Check-Out Date:", boldRegFont, Brushes.Black, startX, currentY);
                    g.DrawString($"{checkOut}", regularFont, Brushes.Black, startX + offsetX, currentY);
                    currentY += 40;

                    g.DrawLine(Pens.Black, startX, currentY, 800, currentY);
                    currentY += 15;

                    g.DrawString("TOTAL AMOUNT DUE:", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.DarkBlue, startX, currentY);
                    g.DrawString($"R {totalAmount:N2}", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.DarkGreen, startX + offsetX + 100, currentY - 2);
                    currentY += 50;

                    g.DrawLine(Pens.LightGray, startX, currentY, 800, currentY);
                    currentY += 15;
                    g.DrawString("Thank you for choosing Regal Inn. We look forward to hosting you!", new Font("Segoe UI", 9, FontStyle.Italic), Brushes.Gray, startX, currentY);
                };

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDoc;
                previewDialog.Width = 800;
                previewDialog.Height = 600;
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the invoice: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helpers

        private void ClearFormInputs()
        {
            txtFullName.Clear();
            txtPhoneNo.Clear();
            txtEmailAddress.Clear();
            txtIdPassportNo.Clear();

            numAdults.Value = 0;
            numChildren.Value = 0;
            numInfants.Value = 0;

            numNoOfNights.Clear();
            numNoOfRooms.Value = 0;

            ClearAllDropdowns();
            SetInitialDates();
        }

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

        private void btnNewBooking_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Please enter the guest's full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFullName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhoneNo.Text))
                {
                    MessageBox.Show("Please enter the guest's phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhoneNo.Focus();
                    return;
                }

                if (cmbBookingType.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid booking type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbBookingType.Focus();
                    return;
                }

                string bookingType = cmbBookingType.SelectedItem.ToString();

                int validatedAdults = (int)numAdults.Value;
                if (bookingType.Contains("Room") && validatedAdults <= 0)
                {
                    MessageBox.Show("At least 1 adult is required for a room booking.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numAdults.Focus();
                    return;
                }

                string branchID = GetSelectedBranchID();
                int clientID = GetOrCreateClientID(txtFullName.Text.Trim(), txtPhoneNo.Text.Trim(), txtEmailAddress.Text.Trim(), txtIdPassportNo.Text.Trim());

                DateTime checkIn = dtpRoomCheckIn.Value;
                DateTime checkOut = dtpRoomCheckOut.Value;
                int nights = (int)(checkOut.Date - checkIn.Date).TotalDays;
                if (nights <= 0) nights = 1;

                DataRow assignedRoom = null;
                DataRow assignedTable = null;

                if (bookingType == "Room Booking" || bookingType == "Room & Table")
                {
                    if (cmbRoomCategory.SelectedItem == null && cmbRoomCategory.Text == "")
                    {
                        MessageBox.Show("Please select or specify a room category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbRoomCategory.Focus();
                        return;
                    }

                    string roomCategory = cmbRoomCategory.Text.Trim();
                    assignedRoom = AssignAvailableRoom(roomCategory, validatedAdults, (int)numChildren.Value, (int)numInfants.Value, checkIn, checkOut);

                    if (assignedRoom == null)
                    {
                        MessageBox.Show($"No available rooms found for category '{roomCategory}'.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (bookingType == "Table Booking" || bookingType == "Room & Table")
                {
                    if (cmbTableArea.SelectedItem == null && cmbTableArea.Text == "")
                    {
                        MessageBox.Show("Please select or specify a restaurant table area.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbTableArea.Focus();
                        return;
                    }

                    string tableArea = cmbTableArea.Text.Trim();
                    assignedTable = AssignAvailableTable(tableArea, checkIn, checkOut);

                    if (assignedTable == null)
                    {
                        MessageBox.Show($"No available restaurant tables found in area '{tableArea}'.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                decimal totalAmount = CalculateBookingAmount(bookingType, assignedRoom, assignedTable, nights);

                DataRow newBooking = codeCraftersDSTWO.Booking.NewRow();
                newBooking["Client_ID"] = clientID;
                newBooking["Branch_ID"] = branchID;
                newBooking["Booking_Date"] = DateTime.Now;
                newBooking["Checkin_Date"] = checkIn;
                newBooking["Checkout_Date"] = checkOut;
                newBooking["Booking_Total_Amount"] = totalAmount;
                newBooking["Booking_Status"] = "Pending";
                newBooking["Number_Adults"] = validatedAdults > 0 ? validatedAdults : 1;
                newBooking["Number_Children"] = (int)numChildren.Value;
                newBooking["Booking_Type"] = bookingType;
                newBooking["Special_Request"] = string.Empty;

                string staffFullName = $"{UserSession.StaffFirstName} {UserSession.StaffSurname}".Trim();
                newBooking["Staff_Created_By"] = string.IsNullOrEmpty(staffFullName) ? "Administrator" : staffFullName;

                codeCraftersDSTWO.Booking.Rows.Add(newBooking);
                taBooking.Update(codeCraftersDSTWO.Booking);

                int newBookingID = Convert.ToInt32(newBooking["Booking_ID"]);

                if (assignedRoom != null)
                {
                    DataRow roomAssignRow = codeCraftersDSTWO.Room_Assignment.NewRow();
                    roomAssignRow["Booking_ID"] = newBookingID;
                    roomAssignRow["Hotel_Room_ID"] = Convert.ToInt32(assignedRoom["Hotel_Room_ID"]);
                    roomAssignRow["Actual_Checkin_Time"] = checkIn;
                    roomAssignRow["Actual_Checkout_Time"] = checkOut;
                    roomAssignRow["Assignment_Status"] = "Reserved";

                    codeCraftersDSTWO.Room_Assignment.Rows.Add(roomAssignRow);
                    taRoomAssignment.Update(codeCraftersDSTWO.Room_Assignment);
                }

                if (assignedTable != null)
                {
                    DataRow tableAllocRow = codeCraftersDSTWO.Table_Allocation.NewRow();
                    tableAllocRow["Booking_ID"] = newBookingID;
                    tableAllocRow["Restuarant_Table_ID"] = Convert.ToInt32(assignedTable["RestaurantTableID"]);
                    tableAllocRow["Start_Time"] = dtpTableCheckIn.Value;
                    tableAllocRow["End_Time"] = dtpTableCheckOut.Value;
                    tableAllocRow["Allocation_Status"] = "Reserved";

                    codeCraftersDSTWO.Table_Allocation.Rows.Add(tableAllocRow);
                    taTableAllocation.Update(codeCraftersDSTWO.Table_Allocation);
                }

                MessageBox.Show($"New booking successfully created!\nBooking Reference: BKG{newBookingID:D4}\nTotal Amount: R {totalAmount:N2}",
                                "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (PaymentForm paymentForm = new PaymentForm(newBookingID, codeCraftersDSTWO, taBooking))
                {
                    paymentForm.ShowDialog();
                }

                ClearFormInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the booking: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                dgvBookingList.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter application error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnViewEdit_Click(object sender, EventArgs e)
        {
            if (dgvBookingList.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking from the list to view or edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataRowView drv = dgvBookingList.CurrentRow.DataBoundItem as DataRowView;
                if (drv == null) return;

                string firstName = drv.Row.Table.Columns.Contains("First_Name") && drv["First_Name"] != DBNull.Value ? drv["First_Name"].ToString() : "";
                string lastName = drv.Row.Table.Columns.Contains("Last_Name") && drv["Last_Name"] != DBNull.Value ? drv["Last_Name"].ToString() : "";
                txtFullName.Text = $"{firstName} {lastName}".Trim();

                txtPhoneNo.Text = drv.Row.Table.Columns.Contains("Phone_Number") && drv["Phone_Number"] != DBNull.Value ? drv["Phone_Number"].ToString() : "";
                txtEmailAddress.Text = drv.Row.Table.Columns.Contains("Email_Address") && drv["Email_Address"] != DBNull.Value ? drv["Email_Address"].ToString() : "";
                txtIdPassportNo.Text = drv.Row.Table.Columns.Contains("Identity_Number") && drv["Identity_Number"] != DBNull.Value ? drv["Identity_Number"].ToString() : "";
                cmbBookingType.Text = drv.Row.Table.Columns.Contains("Booking_Type") && drv["Booking_Type"] != DBNull.Value ? drv["Booking_Type"].ToString() : "";

                if (drv.Row.Table.Columns.Contains("Number_Adults") && drv["Number_Adults"] != DBNull.Value)
                    numAdults.Value = Convert.ToDecimal(drv["Number_Adults"]);

                if (drv.Row.Table.Columns.Contains("Number_Children") && drv["Number_Children"] != DBNull.Value)
                    numChildren.Value = Convert.ToDecimal(drv["Number_Children"]);

                if (drv.Row.Table.Columns.Contains("Checkin_Date") && drv["Checkin_Date"] != DBNull.Value)
                    dtpRoomCheckIn.Value = Convert.ToDateTime(drv["Checkin_Date"]);

                if (drv.Row.Table.Columns.Contains("Checkout_Date") && drv["Checkout_Date"] != DBNull.Value)
                    dtpRoomCheckOut.Value = Convert.ToDateTime(drv["Checkout_Date"]);

                int bookingID = drv.Row.Table.Columns.Contains("Booking_ID") && drv["Booking_ID"] != DBNull.Value ? Convert.ToInt32(drv["Booking_ID"]) : 0;
                MessageBox.Show(bookingID > 0 ? $"Booking BKG{bookingID:D4} loaded successfully." : "Booking loaded successfully.", "View/Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading booking details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvBookingList.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking from the list to save the invoice.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataRowView drv = dgvBookingList.CurrentRow.DataBoundItem as DataRowView;
                if (drv == null) return;

                int bookingID = Convert.ToInt32(drv["Booking_ID"]);
                string bookingType = drv.Row.Table.Columns.Contains("Booking_Type") ? drv["Booking_Type"].ToString() : "N/A";
                string firstName = drv.Row.Table.Columns.Contains("First_Name") ? drv["First_Name"].ToString() : "";
                string lastName = drv.Row.Table.Columns.Contains("Last_Name") ? drv["Last_Name"].ToString() : "";
                string phone = drv.Row.Table.Columns.Contains("Phone_Number") ? drv["Phone_Number"].ToString() : "N/A";
                string status = drv.Row.Table.Columns.Contains("Booking_Status") ? drv["Booking_Status"].ToString() : "Pending";

                string checkIn = drv.Row.Table.Columns.Contains("Checkin_Date") && drv["Checkin_Date"] != DBNull.Value
                    ? Convert.ToDateTime(drv["Checkin_Date"]).ToString("yyyy/MM/dd") : "N/A";
                string checkOut = drv.Row.Table.Columns.Contains("Checkout_Date") && drv["Checkout_Date"] != DBNull.Value
                    ? Convert.ToDateTime(drv["Checkout_Date"]).ToString("yyyy/MM/dd") : "N/A";

                decimal totalAmount = drv.Row.Table.Columns.Contains("Booking_Total_Amount") && drv["Booking_Total_Amount"] != DBNull.Value
                    ? Convert.ToDecimal(drv["Booking_Total_Amount"]) : 0.00m;

                string invoiceContent =
                    "========================================\r\n" +
                    "      REGAL INN HOTEL & RESTAURANT     \r\n" +
                    "         Official Tax Invoice          \r\n" +
                    "========================================\r\n\r\n" +
                    $"Invoice Reference : BKG{bookingID:D4}\r\n" +
                    $"Date Issued       : {DateTime.Now:yyyy/MM/dd HH:mm}\r\n" +
                    $"Booking Status    : {status}\r\n\r\n" +
                    "----------------------------------------\r\n" +
                    " GUEST INFORMATION\r\n" +
                    "----------------------------------------\r\n" +
                    $"Guest Full Name   : {firstName} {lastName}\r\n" +
                    $"Phone Number      : {phone}\r\n\r\n" +
                    "----------------------------------------\r\n" +
                    " BOOKING PARTICULARS\r\n" +
                    "----------------------------------------\r\n" +
                    $"Booking Type      : {bookingType}\r\n" +
                    $"Check-In Date     : {checkIn}\r\n" +
                    $"Check-Out Date    : {checkOut}\r\n\r\n" +
                    "========================================\r\n" +
                    $"TOTAL AMOUNT DUE  : R {totalAmount:N2}\r\n" +
                    "========================================\r\n" +
                    "Thank you for choosing Regal Inn!";

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.Title = "Save Invoice Receipt";
                    saveFileDialog.FileName = $"Invoice_BKG{bookingID:D4}.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, invoiceContent);
                        MessageBox.Show("Invoice successfully saved to file.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the invoice: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

    }
}