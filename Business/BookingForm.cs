using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class BookingForm : Form
    {
        private Timer liveEndTimeTimer;
        private bool isCheckOutEditedByUser = false;
        private bool isFormLoaded = false;

        public BookingForm()
        {
            InitializeComponent();
            this.Load += BookingForm_Load;

            dtpCheckIn.ValueChanged += DtpCheckIn_ValueChanged;
            dtpCheckOut.ValueChanged += DtpCheckOut_ValueChanged;
            cmbBranchID.SelectedIndexChanged += CmbBranchID_SelectedIndexChanged;

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
                taClient.Fill(codeCraftersDSTWO.Client);
                taRoomAssignment.Fill(codeCraftersDSTWO.Room_Assignment);
                taTableAllocation.Fill(codeCraftersDSTWO.Table_Allocation);

                InitializeDateControls();

                isFormLoaded = true;
                RefreshAvailableAccommodations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error pulling initial data from database: {ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDateControls()
        {
            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.CustomFormat = "yyyy/MM/dd HH:mm";

            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.CustomFormat = "yyyy/MM/dd HH:mm";

            dtpCheckIn.Value = DateTime.Now;
            isCheckOutEditedByUser = false;
            dtpCheckOut.Value = DateTime.Now.AddHours(2);

            liveEndTimeTimer.Start();
        }

        private void RefreshAvailableAccommodations()
        {
            if (!isFormLoaded) return;

            if (cmbBranchID.SelectedItem == null || string.IsNullOrEmpty(cmbBranchID.SelectedItem.ToString()))
            {
                codeCraftersDSTWO.Hotel_Room.Clear();
                codeCraftersDSTWO.Restuarant_Table.Clear();
                return;
            }

            string branchID = cmbBranchID.SelectedItem.ToString();
            DateTime startTimeline = dtpCheckIn.Value;
            DateTime endTimeline = dtpCheckOut.Value;

            if (endTimeline <= startTimeline) return;

            try
            {
                taHotelRoom.FillAvailableRoomsByDate(
                    codeCraftersDSTWO.Hotel_Room,
                    branchID,
                    startTimeline,
                    endTimeline
                );
                dgvHotelRoomAvailable.DataSource = codeCraftersDSTWO.Hotel_Room;

                taRestaurantTable.FillAvailableTablesByDate(
                    codeCraftersDSTWO.Restuarant_Table,
                    branchID,
                    startTimeline,
                    endTimeline
                );
                dgvRestaurantTableAvailable.DataSource = codeCraftersDSTWO.Restuarant_Table;

                // If a manual search keyword exists in the filters, apply local view sorting safely 
                ApplyLocalSearchFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering live reservation grids: {ex.Message}",
                                "Filtering Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyLocalSearchFilters()
        {
            // Room Filter Apply
            if (!string.IsNullOrWhiteSpace(txtHotelRoomAvailable.Text) && int.TryParse(txtHotelRoomAvailable.Text, out int roomNo))
            {
                DataView dvRooms = new DataView(codeCraftersDSTWO.Hotel_Room);
                dvRooms.RowFilter = $"hotel_room_number = {roomNo}";
                dgvHotelRoomAvailable.DataSource = dvRooms;
            }

            // Table Filter Apply
            if (!string.IsNullOrWhiteSpace(txtRestaurantTableAvailable.Text))
            {
                DataView dvTables = new DataView(codeCraftersDSTWO.Restuarant_Table);
                dvTables.RowFilter = $"RestuarantTableNum LIKE '%{txtRestaurantTableAvailable.Text.Replace("'", "''")}%'";
                dgvRestaurantTableAvailable.DataSource = dvTables;
            }
        }

        private void CmbBranchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAvailableAccommodations();
        }

        private void DtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                dtpCheckOut.Value = dtpCheckIn.Value.AddHours(1);
            }
            RefreshAvailableAccommodations();
        }

        private void DtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Focused)
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
            RefreshAvailableAccommodations();
        }

        private void dgvHotelRoomAvailable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHotelRoomAvailable.CurrentRow == null) return;

            try
            {
                int roomID = Convert.ToInt32(dgvHotelRoomAvailable.CurrentRow.Cells[0].Value);
                int roomNumber = Convert.ToInt32(dgvHotelRoomAvailable.CurrentRow.Cells[3].Value);
                decimal roomPrice = Convert.ToDecimal(dgvHotelRoomAvailable.CurrentRow.Cells[5].Value);

                bool exists = codeCraftersDSTWO.Invoice.AsEnumerable().Any(r =>
                    r.Field<object>(0) != DBNull.Value && Convert.ToInt32(r.Field<object>(0)) == roomID);

                if (exists)
                {
                    MessageBox.Show("This hotel room has already been added to your current booking selection.",
                                    "Duplicate Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool isNewRow = false;
                DataRow row = GetOrCreateCurrentInvoiceRow(isRoomInsertion: true);
                if (row.RowState == DataRowState.Detached || row.Table == null)
                {
                    isNewRow = true;
                }

                row[0] = roomID;
                row[1] = roomNumber;
                row[2] = roomPrice;

                if (isNewRow)
                {
                    codeCraftersDSTWO.Invoice.Rows.Add(row);
                }

                dgvInvoice.DataSource = null;
                dgvInvoice.DataSource = codeCraftersDSTWO.Invoice;
                UpdateInvoiceTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding room: {ex.Message}",
                                "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRestaurantTableAvailable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvRestaurantTableAvailable.CurrentRow == null) return;

            int tableID = Convert.ToInt32(dgvRestaurantTableAvailable.CurrentRow.Cells[0].Value);
            string tableNumber = dgvRestaurantTableAvailable.CurrentRow.Cells[2].Value.ToString();
            decimal tablePrice = Convert.ToDecimal(dgvRestaurantTableAvailable.CurrentRow.Cells[8].Value);

            bool exists = codeCraftersDSTWO.Invoice.AsEnumerable().Any(r => r.Field<object>(3) != DBNull.Value && Convert.ToInt32(r.Field<object>(3)) == tableID);
            if (exists)
            {
                MessageBox.Show("This restaurant table has already been added to your current booking selection.", "Duplicate Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool isNewRow = false;
            DataRow row = GetOrCreateCurrentInvoiceRow(isRoomInsertion: false);
            if (row.RowState == DataRowState.Detached || row.Table == null)
            {
                isNewRow = true;
            }

            row[3] = tableID;
            row[4] = tableNumber;
            row[5] = tablePrice;

            if (isNewRow)
            {
                codeCraftersDSTWO.Invoice.Rows.Add(row);
            }

            dgvInvoice.DataSource = null;
            dgvInvoice.DataSource = codeCraftersDSTWO.Invoice;
            UpdateInvoiceTotal();
        }

        private void btnCreateBooking_Click_1(object sender, EventArgs e)
        {
            string targetEmail = txtEmailAddress.Text.Trim();

            DataRow clientRow = codeCraftersDSTWO.Client.AsEnumerable()
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

            if (codeCraftersDSTWO.Invoice.Rows.Count == 0)
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

            // Refreshes the dataset data layout directly from DB before saving to detect mid-session conflicts
            taRoomAssignment.Fill(codeCraftersDSTWO.Room_Assignment);
            taTableAllocation.Fill(codeCraftersDSTWO.Table_Allocation);

            // Double Check Overlapping Timelines immediately before transaction executes
            foreach (DataRow invoiceRow in codeCraftersDSTWO.Invoice.Rows)
            {
                if (invoiceRow[0] != DBNull.Value)
                {
                    int targetRoomID = Convert.ToInt32(invoiceRow[0]);
                    bool roomConflict = codeCraftersDSTWO.Room_Assignment.AsEnumerable().Any(ra =>
                        ra.Hotel_Room_ID == targetRoomID &&
                        dtpCheckIn.Value < ra.Actual_CheckOut_Time && dtpCheckOut.Value > ra.Actual_CheckIn_Time);

                    if (roomConflict)
                    {
                        MessageBox.Show($"Room {invoiceRow[1]} has just been booked by another user for this timeline. Please select a different room.", "Timeline Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RefreshAvailableAccommodations();
                        return;
                    }
                }

                if (invoiceRow[3] != DBNull.Value)
                {
                    int targetTableID = Convert.ToInt32(invoiceRow[3]);
                    bool tableConflict = codeCraftersDSTWO.Table_Allocation.AsEnumerable().Any(ta =>
                        ta.Restuarant_Table_ID == targetTableID &&
                        dtpCheckIn.Value < ta.End_Time && dtpCheckOut.Value > ta.Start_Time);

                    if (tableConflict)
                    {
                        MessageBox.Show($"Table {invoiceRow[4]} has just been reserved by another user for this timeline. Please select a different option.", "Timeline Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RefreshAvailableAccommodations();
                        return;
                    }
                }
            }

            if (!decimal.TryParse(txtTotalAmount.Text, NumberStyles.Currency, null, out decimal cleanBookingTotal))
            {
                string fallbackText = txtTotalAmount.Text.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();
                decimal.TryParse(fallbackText, out cleanBookingTotal);
            }

            int pk = Convert.ToInt32(taBooking.InsertNewBooking(
                clientBookingID,
                cmbBranchID.SelectedItem.ToString(),
                DateTime.Now,
                dtpCheckIn.Value,
                dtpCheckOut.Value,
                cleanBookingTotal,
                "Pending"
            ));

            foreach (DataRow invoiceRow in codeCraftersDSTWO.Invoice.Rows)
            {
                if (invoiceRow[0] != DBNull.Value && Convert.ToInt32(invoiceRow[0]) > 0)
                {
                    int hotelRoomID = Convert.ToInt32(invoiceRow[0]);
                    taRoomAssignment.InsertRoomAssignment(pk, hotelRoomID, dtpCheckIn.Value, dtpCheckOut.Value);
                }

                if (invoiceRow[3] != DBNull.Value && Convert.ToInt32(invoiceRow[3]) > 0)
                {
                    int restaurantTableID = Convert.ToInt32(invoiceRow[3]);
                    taTableAllocation.InsertTableAllocation(pk, restaurantTableID, dtpCheckIn.Value, dtpCheckOut.Value);
                }
            }

            UserSession.BookingID = pk;
            UserSession.BookingReference = "BR" + pk;
            UserSession.GuestName = txtFullName.Text;
            UserSession.EmailAddress = targetEmail;
            UserSession.PhysicalAddress = txtAddress.Text;
            UserSession.TotalPrice = txtTotalAmount.Text;

            MessageBox.Show("Booking successfully created with all selected accommodations!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PaymentForm payment = new PaymentForm();
            payment.Show();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string inputPhone = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(inputPhone))
            {
                ClearClientFields();
                return;
            }

            try
            {
                codeCraftersDSTWO.ClientDataTable clientTable = new codeCraftersDSTWO.ClientDataTable();
                taClient.FillByPhoneNo(clientTable, inputPhone);

                if (clientTable.Rows.Count > 0)
                {
                    codeCraftersDSTWO.ClientRow clientRow = (codeCraftersDSTWO.ClientRow)clientTable.Rows[0];

                    txtFullName.Text = $"{clientRow.First_Name} {clientRow.Last_Name}";
                    txtEmailAddress.Text = clientRow.IsEmail_AddressNull() ? "" : clientRow.Email_Address;
                    txtAddress.Text = clientRow.IsClient_AddressNull() ? "" : clientRow.Client_Address;
                }
                else
                {
                    ClearClientFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving client data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearClientFields()
        {
            txtFullName.Clear();
            txtEmailAddress.Clear();
            txtAddress.Clear();
        }

        private void txtHotelRoomAvailable_TextChanged(object sender, EventArgs e)
        {
            // Runs our central timeline checker to populate all truly safe rooms, then sorts locally based on user text entry
            RefreshAvailableAccommodations();
        }

        private void txtRestaurantTableAvailable_TextChanged(object sender, EventArgs e)
        {
            // Runs our central timeline checker to populate all truly safe tables, then sorts locally based on user text entry
            RefreshAvailableAccommodations();
        }

        private void ClearControls()
        {
            txtFullName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtTotalAmount.Clear();
            cmbBranchID.SelectedIndex = -1;

            codeCraftersDSTWO.Invoice.Clear();
            codeCraftersDSTWO.Hotel_Room.Clear();
            codeCraftersDSTWO.Restuarant_Table.Clear();

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

        private DataRow GetOrCreateCurrentInvoiceRow(bool isRoomInsertion)
        {
            foreach (DataRow row in codeCraftersDSTWO.Invoice.Rows)
            {
                if (isRoomInsertion)
                {
                    if (row[0] == DBNull.Value && row[3] != DBNull.Value) return row;
                }
                else
                {
                    if (row[3] == DBNull.Value && row[0] != DBNull.Value) return row;
                }
            }
            return codeCraftersDSTWO.Invoice.NewRow();
        }

        private void UpdateInvoiceTotal()
        {
            decimal totalBookingAmount = 0;
            foreach (DataRow row in codeCraftersDSTWO.Invoice.Rows)
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
    }
}