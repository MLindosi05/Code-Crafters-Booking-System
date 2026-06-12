using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class BookingForm : Form
    {
        decimal totalBookingRoomAmount = 0;
        decimal totalBookingRestaurantTableAmount = 0;

        private Timer liveEndTimeTimer;
        private bool isCheckOutEditedByUser = false;

        public BookingForm()
        {
            InitializeComponent();
            this.Load += BookingForm_Load;

            mclCheckIn.DateChanged += MclCheckIn_DateChanged;
            mclCheckOut.DateChanged += MclCheckOut_DateChanged;

            dtpCheckIn.ValueChanged += DtpCheckIn_ValueChanged;
            dtpCheckOut.ValueChanged += DtpCheckOut_ValueChanged;

            InitializeLiveTimer();
        }

        private void InitializeLiveTimer()
        {
            liveEndTimeTimer = new Timer();
            liveEndTimeTimer.Interval = 1000;
            liveEndTimeTimer.Tick += LiveEndTimeTimer_Tick;
        }

        private void LiveEndTimeTimer_Tick(object sender, EventArgs e)
        {
            if (!isCheckOutEditedByUser)
            {
                dtpCheckOut.ValueChanged -= DtpCheckOut_ValueChanged;
                dtpCheckOut.Value = DateTime.Now.AddHours(2);
                dtpCheckOut.ValueChanged += DtpCheckOut_ValueChanged;
            }
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            try
            {
                taClient.Fill(codeCraftersDS.Client);
                InitializeDateControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error pulling client data from database: {ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDateControls()
        {
            DateTime today = DateTime.Today;

            mclCheckIn.TodayDate = today;
            mclCheckIn.SelectionStart = today;
            mclCheckOut.TodayDate = today;
            mclCheckOut.SelectionStart = today;

            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.CustomFormat = "yyyy/MM/dd HH:mm";

            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.CustomFormat = "yyyy/MM/dd HH:mm";

            dtpCheckIn.Value = DateTime.Now;
            isCheckOutEditedByUser = false;
            dtpCheckOut.Value = DateTime.Now.AddHours(2);

            liveEndTimeTimer.Start();
        }

        #region Real-Time Date & Time Synchronization Logic

        private void MclCheckIn_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime calendarDate = mclCheckIn.SelectionStart;
            dtpCheckIn.Value = calendarDate.Date + dtpCheckIn.Value.TimeOfDay;

            if (mclCheckOut.SelectionStart < calendarDate)
            {
                mclCheckOut.SelectionStart = calendarDate;
            }
        }

        private void MclCheckOut_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime calendarDate = mclCheckOut.SelectionStart;

            if (calendarDate < mclCheckIn.SelectionStart)
            {
                MessageBox.Show("The checkout date cannot be earlier than your check-in date.",
                                "Date Validation Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mclCheckOut.SelectionStart = mclCheckIn.SelectionStart;
                return;
            }

            isCheckOutEditedByUser = true;
            liveEndTimeTimer.Stop();

            dtpCheckOut.Value = calendarDate.Date + dtpCheckOut.Value.TimeOfDay;
        }

        private void dgvHotelRoomAvailable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHotelRoomAvailable.CurrentRow == null) return;

            string roomStatus = dgvHotelRoomAvailable.CurrentRow.Cells[4].Value?.ToString().Trim();

            if (!string.Equals(roomStatus, "Available", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("This room cannot be added because its current status is not 'Available'.",
                                "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomID = Convert.ToInt32(dgvHotelRoomAvailable.CurrentRow.Cells[0].Value);

            bool exists = codeCraftersDS.Invoice.AsEnumerable().Any(r => r.Field<object>(0) != DBNull.Value && Convert.ToInt32(r.Field<object>(0)) == roomID);
            if (exists)
            {
                MessageBox.Show("This hotel room has already been added to your current booking selection.", "Duplicate Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int roomNumber = Convert.ToInt32(dgvHotelRoomAvailable.CurrentRow.Cells[3].Value);
            decimal roomPrice = Convert.ToDecimal(dgvHotelRoomAvailable.CurrentRow.Cells[5].Value);

            DataRow row = GetOrCreateCurrentInvoiceRow(isRoomInsertion: true);
            row[0] = roomID;
            row[1] = roomNumber;
            row[2] = roomPrice;

            if (row.RowState == DataRowState.Detached)
            {
                codeCraftersDS.Invoice.Rows.Add(row);
            }

            dgvInvoice.DataSource = codeCraftersDS.Invoice;
            UpdateInvoiceTotal();
        }

        private void dgvRestaurantTableAvailable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvRestaurantTableAvailable.CurrentRow == null) return;

            string tableStatus = dgvRestaurantTableAvailable.CurrentRow.Cells[5].Value?.ToString().Trim();

            if (!string.Equals(tableStatus, "Available", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("This restaurant table cannot be added because its current status is not 'Available'.",
                                "Table Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tableID = Convert.ToInt32(dgvRestaurantTableAvailable.CurrentRow.Cells[0].Value);

            bool exists = codeCraftersDS.Invoice.AsEnumerable().Any(r => r.Field<object>(3) != DBNull.Value && Convert.ToInt32(r.Field<object>(3)) == tableID);
            if (exists)
            {
                MessageBox.Show("This restaurant table has already been added to your current booking selection.", "Duplicate Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tableNumber = dgvRestaurantTableAvailable.CurrentRow.Cells[2].Value.ToString();
            decimal tablePrice = Convert.ToDecimal(dgvRestaurantTableAvailable.CurrentRow.Cells[8].Value);

            DataRow row = GetOrCreateCurrentInvoiceRow(isRoomInsertion: false);
            row[3] = tableID;
            row[4] = tableNumber;
            row[5] = tablePrice;

            if (row.RowState == DataRowState.Detached)
            {
                codeCraftersDS.Invoice.Rows.Add(row);
            }

            dgvInvoice.DataSource = codeCraftersDS.Invoice;
            UpdateInvoiceTotal();
        }

        private void DtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            mclCheckIn.SelectionStart = dtpCheckIn.Value.Date;

            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                dtpCheckOut.Value = dtpCheckIn.Value.AddHours(1);
            }
        }

        private void DtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Focused || mclCheckOut.Focused)
            {
                isCheckOutEditedByUser = true;
                liveEndTimeTimer.Stop();
            }

            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                MessageBox.Show("The checkout time/date cannot fall before the check-in time/date.",
                                "Time Validation Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpCheckOut.Value = dtpCheckIn.Value.AddHours(1);
                return;
            }

            mclCheckOut.SelectionStart = dtpCheckOut.Value.Date;
        }

        #endregion

        private void ClearControls()
        {
            txtFullName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtHotelRoomAvailable.Clear();
            txtRestaurantTableAvailable.Clear();
            txtTotalAmount.Clear();

            cmbBranchID.SelectedIndex = -1;

            codeCraftersDS.Invoice.Clear();
            codeCraftersDS.Hotel_Room.Clear();
            codeCraftersDS.Restuarant_Table.Clear();

            InitializeDateControls();

            UserSession.BookingID = 0;
            UserSession.ClientID = 0;
            UserSession.BookingReference = string.Empty;
            UserSession.GuestName = string.Empty;
            UserSession.EmailAddress = string.Empty;
            UserSession.PhysicalAddress = string.Empty;
            UserSession.TotalPrice = string.Empty;
        }

        public void ResetBookingFormData()
        {
            ClearControls();
        }

        private void txtHotelRoomAvailable_TextChanged_1(object sender, EventArgs e)
        {
            string input = txtHotelRoomAvailable.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                codeCraftersDS.Hotel_Room.Clear();
                return;
            }

            if (!int.TryParse(input, out int roomId) || roomId < 0)
            {
                MessageBox.Show("Only positive integer input required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHotelRoomAvailable.Clear();
                codeCraftersDS.Hotel_Room.Clear();
                return;
            }

            taHotelRoom.FillByHotelRoomID(codeCraftersDS.Hotel_Room, roomId);
        }

        private void txtRestaurantTableAvailable_TextChanged_1(object sender, EventArgs e)
        {
            string input = txtRestaurantTableAvailable.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                codeCraftersDS.Restuarant_Table.Clear();
                return;
            }

            if (!int.TryParse(input, out int tableId) || tableId < 0)
            {
                MessageBox.Show("Only positive integer input required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRestaurantTableAvailable.Clear();
                codeCraftersDS.Restuarant_Table.Clear();
                return;
            }

            taRestaurantTable.FillByRestaurantTableID(codeCraftersDS.Restuarant_Table, tableId);
        }

        private DataRow GetOrCreateCurrentInvoiceRow(bool isRoomInsertion)
        {
            foreach (DataRow row in codeCraftersDS.Invoice.Rows)
            {
                if (isRoomInsertion)
                {
                    if (row[0] == DBNull.Value && row[3] != DBNull.Value)
                    {
                        return row;
                    }
                }
                else
                {
                    if (row[3] == DBNull.Value && row[0] != DBNull.Value)
                    {
                        return row;
                    }
                }
            }
            return codeCraftersDS.Invoice.NewRow();
        }

        private void UpdateInvoiceTotal()
        {
            decimal totalBookingAmount = 0;
            foreach (DataRow row in codeCraftersDS.Invoice.Rows)
            {
                if (row[2] != DBNull.Value)
                    totalBookingAmount += Convert.ToDecimal(row[2]);

                if (row[5] != DBNull.Value)
                    totalBookingAmount += Convert.ToDecimal(row[5]);
            }
            txtTotalAmount.Text = totalBookingAmount.ToString("C2");
        }

        private void BookingForm_Load_1(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            pnlBooking.BackColor = ColorTranslator.FromHtml("#966919");
            btnCreateBooking.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnCreateBooking.ForeColor = Color.White;
            grpBookingDetails.BackColor = ColorTranslator.FromHtml("#F8F5F0");
        }

        private void btnCreateBooking_Click_1(object sender, EventArgs e)
        {
            string targetEmail = txtEmailAddress.Text.Trim();

            DataRow clientRow = codeCraftersDS.Client.AsEnumerable()
                .FirstOrDefault(row => row.Field<string>("Email_Address")
                .Equals(targetEmail, StringComparison.OrdinalIgnoreCase));

            if (clientRow == null)
            {
                MessageBox.Show("No client record found matching that email address. Please verify or register first.",
                                "Client Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clientBookingID = Convert.ToInt32(clientRow["Client_ID"]);
            UserSession.ClientID = clientBookingID;

            if (cmbBranchID.SelectedItem == null)
            {
                MessageBox.Show("Please select a branch first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (codeCraftersDS.Invoice.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one room or restaurant table to create a booking.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                MessageBox.Show("Invalid timeline parameters. Please double-check your check-out selection.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            liveEndTimeTimer.Stop();

            int pk = (int)taBooking.InsertNewBooking(
                clientBookingID,
                cmbBranchID.SelectedItem.ToString(),
                DateTime.Now.ToString(),
                dtpCheckIn.Value.ToShortDateString(),
                dtpCheckOut.Value.ToShortDateString(),
                Convert.ToDecimal(txtTotalAmount.Text.Replace("R", "").Replace("$", "").Replace(" ", "").Trim()),
                "Pending"
            );

            foreach (DataRow invoiceRow in codeCraftersDS.Invoice.Rows)
            {
                if (invoiceRow[0] != DBNull.Value && Convert.ToInt32(invoiceRow[0]) > 0)
                {
                    int hotelRoomID = Convert.ToInt32(invoiceRow[0]);

                    taRoomAssignment.InsertRoomAssignment(
                        pk,
                        hotelRoomID,
                        dtpCheckIn.Value.ToShortDateString(),
                        dtpCheckOut.Value.ToShortDateString()
                    );

                    try
                    {
                        taHotelRoom.UpdateRoomStatus("Booked", hotelRoomID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Room status update failed: {ex.Message}", "Database Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (invoiceRow[3] != DBNull.Value && Convert.ToInt32(invoiceRow[3]) > 0)
                {
                    int restaurantTableID = Convert.ToInt32(invoiceRow[3]);

                    taTableAllocation.InsertTableAllocation(
                        pk,
                        restaurantTableID,
                        dtpCheckIn.Value,
                        dtpCheckOut.Value
                    );

                    try
                    {
                        taRestaurantTable.UpdateTableStatus("Booked", restaurantTableID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Table status update failed: {ex.Message}", "Database Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            UserSession.BookingID = pk;
            UserSession.BookingReference = "BR" + pk;
            UserSession.GuestName = txtFullName.Text;
            UserSession.EmailAddress = targetEmail;
            UserSession.PhysicalAddress = txtAddress.Text;
            UserSession.TotalPrice = txtTotalAmount.Text;

            MessageBox.Show("Booking successfully created with all selected accommodations!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}