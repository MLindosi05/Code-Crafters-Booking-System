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

            this.cmbRoomCategory.DropDown += new System.EventHandler(this.cmbRoomCategory_DropDown);
            this.cmbTableArea.DropDown += new System.EventHandler(this.cmbTableArea_DropDown);
            this.cmbSearchBy.DropDown += new System.EventHandler(this.cmbSearchBy_DropDown);
            this.cmbBookingType.DropDown += new System.EventHandler(this.cmbBookingType_DropDown);
            this.cmbFilterBookingStatus.DropDown += new System.EventHandler(this.cmbFilterBookingStatus_DropDown);
            this.cmbFilterBookingType.DropDown += new System.EventHandler(this.cmbFilterBookingType_DropDown);
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

            // 9. Check-out / Time Column
            dgvBookingList.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Checkout_Date",
                DataPropertyName = "Checkout_Date",
                HeaderText = "CHECK-OUT",
                Width = 130
            });

            // 10. Status Column (Custom Drawn Badge)
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

            // 1. Format Booking ID (BKG0001)
            if (colName == "Booking_ID" && e.Value != null)
            {
                e.Value = $"BKG{bookingID:D4}";
                e.FormattingApplied = true;
                row.Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(41, 128, 185);
                row.Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                return;
            }

            // 2. Read BOOKING TYPE from saved database record
            if (colName == "Booking_Type")
            {
                e.Value = drv["Booking_Type"].ToString();

                e.FormattingApplied = true;

                return;
            }

            // 3. Guest Name
            if (colName == "Guest_Name")
            {
                string firstName = drv.Row.Table.Columns.Contains("First_Name") ? drv.Row["First_Name"].ToString() : "";
                string lastName = drv.Row.Table.Columns.Contains("Last_Name") ? drv.Row["Last_Name"].ToString() : "";
                e.Value = $"{firstName} {lastName}".Trim();
                e.FormattingApplied = true;
                return;
            }

            // --- LOOK UP REAL DATABASE ASSIGNMENT RECORDS ---
            DataRow roomAssign = codeCraftersDSTWO.Room_Assignment.AsEnumerable()
                .FirstOrDefault(ra => ra.Field<int>("Booking_ID") == bookingID);

            DataRow tableAlloc = codeCraftersDSTWO.Table_Allocation.AsEnumerable()
                .FirstOrDefault(ta => ta.Field<int>("Booking_ID") == bookingID);

            DataRow actualRoom = roomAssign != null ? codeCraftersDSTWO.Hotel_Room.FindByHotel_Room_ID(roomAssign.Field<int>("Hotel_Room_ID")) : null;
            DataRow actualTable = tableAlloc != null ? codeCraftersDSTWO.Restuarant_Table.FindByRestaurantTableID(tableAlloc.Field<int>("Restuarant_Table_ID")) : null;

            // 4. ROOM / TABLE COLUMN: Reads exact Room/Table numbers from database tables
            if (colName == "Room_Table")
            {
                string bookingType = Convert.ToString(drv["Booking_Type"]);

                string room = drv.Row.Table.Columns.Contains("hotel_room_number")
                    ? Convert.ToString(drv["hotel_room_number"])
                    : "";

                string tableNo = drv.Row.Table.Columns.Contains("RestuarantTableNum")
                    ? Convert.ToString(drv["RestuarantTableNum"])
                    : "";

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

            // 5. CATEGORY / AREA COLUMN: Reads exact Room Category & Table Area from database tables
            if (colName == "Category_Area")
            {
                string bookingType = Convert.ToString(drv["Booking_Type"]);

                string roomType = drv.Row.Table.Columns.Contains("hotel_room_type")
                    ? Convert.ToString(drv["hotel_room_type"])
                    : "";

                string tableArea = drv.Row.Table.Columns.Contains("TableFeatures")
                    ? Convert.ToString(drv["TableFeatures"])
                    : "";

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

            // 6. Check-in & Check-out Date Formatting
            // 6. Check-in & Check-out Date Formatting (Date only)
            if ((colName == "Checkin_Date" || colName == "Checkout_Date") && e.Value != DBNull.Value && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dateVal))
                {
                    e.Value = dateVal.ToString("yyyy/MM/dd");
                    e.FormattingApplied = true;
                }
                return;
            }

            // 7. Total Amount Formatting
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
                Color badgeColor = Color.FromArgb(241, 196, 15); // Yellow (Pending)

                if (status.Equals("Confirmed", StringComparison.OrdinalIgnoreCase))
                    badgeColor = Color.FromArgb(76, 175, 80); // Green
                else if (status.Equals("Checked In", StringComparison.OrdinalIgnoreCase) || status.Equals("Checked Out", StringComparison.OrdinalIgnoreCase))
                    badgeColor = Color.FromArgb(52, 152, 219); // Blue
                else if (status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) || status.Equals("No Show", StringComparison.OrdinalIgnoreCase))
                    badgeColor = Color.FromArgb(231, 76, 60); // Red

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
            RefreshData();

            // Populate Dropdowns immediately on Load
            cmbBookingType.Items.Clear();
            cmbBookingType.Items.AddRange(new string[] { "Room Booking", "Table Booking", "Room & Table" });

            cmbFilterBookingType.Items.Clear();
            cmbFilterBookingType.Items.AddRange(new string[] { "All", "Room Booking", "Table Booking", "Room & Table" });

            cmbFilterBookingStatus.Items.Clear();
            cmbFilterBookingStatus.Items.AddRange(new string[] { "All", "Pending", "Confirmed", "Checked In", "Checked Out", "Cancelled", "No Show" });

            ClearAllDropdowns();
        }

        private void ClearAllDropdowns()
        {
            cmbBookingType.SelectedIndex = -1;
            cmbRoomCategory.SelectedIndex = -1;
            cmbTableArea.SelectedIndex = -1;
            cmbSearchBy.SelectedIndex = -1;
            cmbFilterBookingType.SelectedIndex = -1;
            cmbFilterBookingStatus.SelectedIndex = -1;
            cmbBranchName.SelectedIndex = -1;
        }

        private void SetInitialDates()
        {
            dtpRoomCheckIn.Value = DateTime.Today.Add(StandardCheckInTime);
            dtpRoomCheckOut.Value = DateTime.Today.AddDays(1).Add(StandardCheckOutTime);

            dtpTableCheckIn.Value = DateTime.Now;
            dtpTableCheckOut.Value = DateTime.Now.AddHours(2);

            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now.AddMonths(1);
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

                if (currentStatus.Equals("Confirmed", StringComparison.OrdinalIgnoreCase) && now >= checkIn && now < checkOut)
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

        private int GetAvailableTableCount(string tableArea, DateTime checkIn, DateTime checkOut)
        {
            var candidateTables = codeCraftersDSTWO.Restuarant_Table.AsEnumerable().Where(t =>
                (t.Field<string>("TableFeatures") ?? "").Equals(tableArea, StringComparison.OrdinalIgnoreCase) &&
                (t.Field<string>("TableStatus") ?? "Available").Equals("Available", StringComparison.OrdinalIgnoreCase)
            );

            return candidateTables.Count();
        }

        /// <summary>
        /// Calculates dynamic booking total directly from database tables:
        /// Hotel_Room.Hotel_Room_Price and Restuarant_Table.TablePrice
        /// </summary>
        private decimal CalculateBookingAmount(string bookingType, DataRow assignedRoom, DataRow assignedTable, int nights)
        {
            decimal total = 0.00m;
            int stayNights = nights > 0 ? nights : 1;

            // 1. Fetch Room Price from database row
            if (assignedRoom != null && assignedRoom.Table.Columns.Contains("Hotel_Room_Price") && assignedRoom["Hotel_Room_Price"] != DBNull.Value)
            {
                decimal roomPricePerNight = Convert.ToDecimal(assignedRoom["Hotel_Room_Price"]);
                if (bookingType == "Room Booking" || bookingType == "Room & Table")
                {
                    total += (roomPricePerNight * stayNights);
                }
            }

            // 2. Fetch Table Price from database row
            if (assignedTable != null && assignedTable.Table.Columns.Contains("TablePrice") && assignedTable["TablePrice"] != DBNull.Value)
            {
                decimal tablePrice = Convert.ToDecimal(assignedTable["TablePrice"]);
                if (bookingType == "Table Booking" || bookingType == "Room & Table")
                {
                    total += tablePrice;
                }
            }

            // Fallback if no specific row prices were loaded yet
            if (total == 0.00m)
            {
                total = 1200.00m * stayNights;
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

            return candidateTables.FirstOrDefault();
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
                    cmbRoomCategory.Items.AddRange(new string[] { "Standard", "Deluxe", "Family", "Executive", "Presidential" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Room Category load error: " + ex.Message);
            }
        }

        private void cmbTableArea_DropDown(object sender, EventArgs e)
        {
            if (cmbTableArea.DataSource != null) return;

            try
            {
                if (codeCraftersDSTWO.Restuarant_Table.Rows.Count > 0)
                {
                    DataView dvAreas = new DataView(codeCraftersDSTWO.Restuarant_Table);
                    DataTable dtAreas = dvAreas.ToTable(true, "TableFeatures");
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
            cmbSearchBy.Items.AddRange(new string[] { "Booking ID", "Guest Name", "Phone No", "ID/Passport No", "Room Type" });
        }

        private void cmbBookingType_DropDown(object sender, EventArgs e)
        {
            if (cmbBookingType.Items.Count > 0) return;
            cmbBookingType.Items.AddRange(new string[] { "Room Booking", "Table Booking", "Room & Table" });
        }

        private void cmbFilterBookingStatus_DropDown(object sender, EventArgs e)
        {
            if (cmbFilterBookingStatus.Items.Count > 0) return;
            cmbFilterBookingStatus.Items.AddRange(new string[] { "All", "Pending", "Confirmed", "Checked In", "Checked Out", "Cancelled", "No Show" });
        }

        private void cmbFilterBookingType_DropDown(object sender, EventArgs e)
        {
            if (cmbFilterBookingType.Items.Count > 0) return;
            cmbFilterBookingType.Items.AddRange(new string[] { "All", "Room Booking", "Table Booking", "Room & Table" });
        }

        #endregion

        #region Data Refresh & Search

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFormInputs();
            RefreshData();
        }

        private void RefreshData()
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

                dgvBookingList.DataSource = codeCraftersDSTWO.ClientBranchTableBooking;
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
            RefreshData();
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

        public void ProcessPaymentForBooking(int bookingID, decimal paymentAmount)
        {
            DataRow bookingRow = codeCraftersDSTWO.Booking.FindByBooking_ID(bookingID);

            if (bookingRow != null)
            {
                bookingRow["Booking_Status"] = "Confirmed";
                taBooking.Update(codeCraftersDSTWO.Booking);

                MessageBox.Show($"Payment of R{paymentAmount:N2} received for Booking BR{bookingID}.\nStatus changed to: CONFIRMED",
                                "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
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

            int bookingID = Convert.ToInt32(dgvBookingList.CurrentRow.Cells["Booking_ID"].Value);
            DataRow bookingRow = codeCraftersDSTWO.Booking.FindByBooking_ID(bookingID);

            if (bookingRow == null) return;

            DateTime oldCheckIn = Convert.ToDateTime(bookingRow["Checkin_Date"]);
            double hoursDiff = (oldCheckIn - DateTime.Now).TotalHours;
            decimal penalty = 0.00m;

            DialogResult creditChoice = MessageBox.Show("Do you want to credit the balance to the guest account? (No penalties will be applied)",
                                                        "Account Crediting Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (creditChoice == DialogResult.No)
            {
                if (hoursDiff < 24)
                {
                    penalty = Convert.ToDecimal(bookingRow["Booking_Total_Amount"]) * 0.50m;
                    MessageBox.Show($"Rescheduling under 24 hours incurs a 50% penalty fee: R{penalty:F2}", "Penalty Applied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (hoursDiff < 48)
                {
                    penalty = Convert.ToDecimal(bookingRow["Booking_Total_Amount"]) * 0.20m;
                    MessageBox.Show($"Rescheduling under 48 hours incurs a 20% penalty fee: R{penalty:F2}", "Penalty Applied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            bookingRow["Checkin_Date"] = dtpRoomCheckIn.Value.Date.Add(StandardCheckInTime);
            bookingRow["Checkout_Date"] = dtpRoomCheckOut.Value.Date.Add(StandardCheckOutTime);

            if (codeCraftersDSTWO.Booking.Columns.Contains("Admin_Notes"))
            {
                string oldNotes = bookingRow["Admin_Notes"]?.ToString() ?? "";
                string penaltyNote = creditChoice == DialogResult.Yes ? "Credited to Account (No Penalty)" : $"Penalty: R{penalty:F2}";
                bookingRow["Admin_Notes"] = $"{oldNotes} | Rescheduled on {DateTime.Now:yyyy-MM-dd HH:mm}. {penaltyNote}".TrimStart(' ', '|');
            }

            taBooking.Update(codeCraftersDSTWO.Booking);

            MessageBox.Show("Booking rescheduled successfully.", "Reschedule Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshData();
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

            DialogResult result = MessageBox.Show($"Are you sure you want to cancel booking BR{bookingID}?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bookingRow["Booking_Status"] = "Cancelled";

                if (codeCraftersDSTWO.Booking.Columns.Contains("Cancellation_Date"))
                    bookingRow["Cancellation_Date"] = DateTime.Now;

                if (codeCraftersDSTWO.Booking.Columns.Contains("Cancellation_Reason"))
                    bookingRow["Cancellation_Reason"] = "Cancelled via Booking Management Interface";

                taBooking.Update(codeCraftersDSTWO.Booking);

                MessageBox.Show($"Booking BR{bookingID} has been successfully CANCELLED.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
        }

        private void btnLinkBookings_Click(object sender, EventArgs e)
        {
            if (dgvBookingList.SelectedRows.Count < 2)
            {
                MessageBox.Show("Please select at least two bookings in the grid using Ctrl+Click to link them together.", "Multiple Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int parentID = Convert.ToInt32(dgvBookingList.SelectedRows[0].Cells["Booking_ID"].Value);

            for (int i = 1; i < dgvBookingList.SelectedRows.Count; i++)
            {
                int childID = Convert.ToInt32(dgvBookingList.SelectedRows[i].Cells["Booking_ID"].Value);
                DataRow childRow = codeCraftersDSTWO.Booking.FindByBooking_ID(childID);

                if (childRow != null)
                {
                    if (codeCraftersDSTWO.Booking.Columns.Contains("Admin_Notes"))
                    {
                        string currentNotes = childRow["Admin_Notes"]?.ToString() ?? "";
                        childRow["Admin_Notes"] = $"{currentNotes} | Linked under Primary Ref BR{parentID}".TrimStart(' ', '|');
                    }
                }
            }

            taBooking.Update(codeCraftersDSTWO.Booking);

            MessageBox.Show("Selected bookings successfully linked under primary reference.", "Link Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvBookingList.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking from the list to print.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Sending booking invoice/summary to printer...", "Print Document", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            numNoOfNights.Value = 0;
            numNoOfRooms.Value = 0;

            ClearAllDropdowns();
            SetInitialDates();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(
                e.Graphics,
                pnlGuestDetails.ClientRectangle,
                Color.LightGray,
                ButtonBorderStyle.Solid);
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
                // 1. Basic Input Validations
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
                    MessageBox.Show("Please select a valid booking type (Room Booking, Table Booking, or Room & Table).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbBookingType.Focus();
                    return;
                }

                string bookingType = cmbBookingType.SelectedItem.ToString();
                string branchID = GetSelectedBranchID();
                int clientID = GetOrCreateClientID(txtFullName.Text.Trim(), txtPhoneNo.Text.Trim(), txtEmailAddress.Text.Trim(), txtIdPassportNo.Text.Trim());

                DateTime checkIn = dtpRoomCheckIn.Value;
                DateTime checkOut = dtpRoomCheckOut.Value;
                int nights = (int)(checkOut.Date - checkIn.Date).TotalDays;
                if (nights <= 0) nights = 1;

                DataRow assignedRoom = null;
                DataRow assignedTable = null;

                // 2. Validate and Assign Room if applicable
                if (bookingType == "Room Booking" || bookingType == "Room & Table")
                {
                    if (cmbRoomCategory.SelectedItem == null && cmbRoomCategory.Text == "")
                    {
                        MessageBox.Show("Please select or specify a room category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbRoomCategory.Focus();
                        return;
                    }

                    string roomCategory = cmbRoomCategory.Text.Trim();
                    int adults = (int)numAdults.Value;
                    int children = (int)numChildren.Value;
                    int infants = (int)numInfants.Value;

                    assignedRoom = AssignAvailableRoom(roomCategory, adults, children, infants, checkIn, checkOut);

                    if (assignedRoom == null)
                    {
                        MessageBox.Show($"No available rooms found for category '{roomCategory}' matching the guest capacity and dates.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 3. Validate and Assign Table if applicable
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
                        MessageBox.Show($"No available restaurant tables found in area '{tableArea}' for the selected time slot.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 4. Calculate Total Booking Cost Dynamically
                decimal totalAmount = CalculateBookingAmount(bookingType, assignedRoom, assignedTable, nights);

                // 5. Create New Booking Record
                DataRow newBooking = codeCraftersDSTWO.Booking.NewRow();
                newBooking["Client_ID"] = clientID;
                newBooking["Branch_ID"] = branchID;
                newBooking["Booking_Date"] = DateTime.Now;
                newBooking["Checkin_Date"] = checkIn;
                newBooking["Checkout_Date"] = checkOut;
                newBooking["Booking_Total_Amount"] = totalAmount;
                newBooking["Booking_Status"] = "Pending";
                newBooking["Number_Adults"] = (int)numAdults.Value;
                newBooking["Number_Children"] = (int)numChildren.Value;
                newBooking["Booking_Type"] = bookingType;
                newBooking["Special_Request"] = string.Empty;

                string staffFirstName = UserSession.StaffFirstName;
                string staffSurname = UserSession.StaffSurname;
                string staffFullName = $"{staffFirstName} {staffSurname}".Trim();

                newBooking["Staff_Created_By"] = string.IsNullOrEmpty(staffFullName) ? "Administrator" : staffFullName;

                codeCraftersDSTWO.Booking.Rows.Add(newBooking);
                taBooking.Update(codeCraftersDSTWO.Booking);

                // Fetch back the newly created Booking_ID securely
                int newBookingID = Convert.ToInt32(newBooking["Booking_ID"]);

                // 6. Save Room Assignment Mapping if applicable
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

                // 7. Save Table Allocation Mapping if applicable
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

                // 8. Success Feedback & Payment Form Integration & Cleanup
                MessageBox.Show($"New booking successfully created!\nBooking Reference: BKG{newBookingID:D4}\nTotal Amount: R {totalAmount:N2}",
                                "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the PaymentForm passing the newly generated booking ID, dataset, and table adapter
                using (PaymentForm paymentForm = new PaymentForm(newBookingID, codeCraftersDSTWO, taBooking))
                {
                    // Show as a dialog; if payment is completed successfully (DialogResult.OK), refresh the grid
                    if (paymentForm.ShowDialog() == DialogResult.OK)
                    {
                        // Optional: any extra logic post-payment completion if needed
                    }
                }

                ClearFormInputs();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the booking: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Search & View Edit

        private void btnViewEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvBookingList.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking from the list to view or edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView drv = dgvBookingList.CurrentRow.DataBoundItem as DataRowView;

            if (drv != null)
            {
                string firstName = drv.Row.Table.Columns.Contains("First_Name") ? drv.Row["First_Name"]?.ToString() : "";
                string lastName = drv.Row.Table.Columns.Contains("Last_Name") ? drv.Row["Last_Name"]?.ToString() : "";

                txtFullName.Text = $"{firstName} {lastName}".Trim();
                txtPhoneNo.Text = drv.Row.Table.Columns.Contains("Phone_Number") ? drv.Row["Phone_Number"]?.ToString() : "";
                txtEmailAddress.Text = drv.Row.Table.Columns.Contains("Email_Address") ? drv.Row["Email_Address"]?.ToString() : "";

                if (txtIdPassportNo != null && drv.Row.Table.Columns.Contains("Identity_Number"))
                {
                    txtIdPassportNo.Text = drv.Row["Identity_Number"]?.ToString();
                }

                MessageBox.Show("Booking details loaded into editor fields.", "Details Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(codeCraftersDSTWO.ClientBranchTableBooking);
                string filter = "1=1";

                string query = txtSearchQuery.Text.Trim().Replace("'", "''");
                string searchBy = cmbSearchBy.Text;

                if (!string.IsNullOrEmpty(query))
                {
                    switch (searchBy)
                    {
                        case "Booking ID":
                            filter += $" AND Convert(Booking_ID, 'System.String') LIKE '%{query}%'";
                            break;
                        case "Guest Name":
                            filter += $" AND (First_Name LIKE '%{query}%' OR Last_Name LIKE '%{query}%')";
                            break;
                        case "Phone No":
                            filter += $" AND Phone_Number LIKE '%{query}%'";
                            break;
                        case "ID/Passport No":
                            if (codeCraftersDSTWO.ClientBranchTableBooking.Columns.Contains("Identity_Number"))
                                filter += $" AND Identity_Number LIKE '%{query}%'";
                            break;
                        case "Room Type":
                            if (codeCraftersDSTWO.ClientBranchTableBooking.Columns.Contains("hotel_room_type"))
                                filter += $" AND hotel_room_type LIKE '%{query}%'";
                            break;
                    }
                }

                string typeColName = codeCraftersDSTWO.ClientBranchTableBooking.Columns.Contains("Booking_Type") ? "Booking_Type" : "TYPE";

                if (!string.IsNullOrEmpty(cmbFilterBookingType.Text) && cmbFilterBookingType.Text != "All")
                {
                    if (codeCraftersDSTWO.ClientBranchTableBooking.Columns.Contains(typeColName))
                    {
                        filter += $" AND {typeColName} = '{cmbFilterBookingType.Text.Replace("'", "''")}'";
                    }
                }

                if (!string.IsNullOrEmpty(cmbFilterBookingStatus.Text) && cmbFilterBookingStatus.Text != "All")
                {
                    filter += $" AND Booking_Status = '{cmbFilterBookingStatus.Text.Replace("'", "''")}'";
                }

                DateTime fromDate = dtpFromDate.Value.Date;
                DateTime toDate = dtpToDate.Value.Date.AddDays(1).AddTicks(-1);

                filter += $" AND Checkin_Date >= #{fromDate:yyyy-MM-dd HH:mm:ss}# AND Checkout_Date <= #{toDate:yyyy-MM-dd HH:mm:ss}#";

                dv.RowFilter = filter;
                dgvBookingList.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter application error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}