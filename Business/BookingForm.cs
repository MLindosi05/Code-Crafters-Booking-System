using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();

            this.Load += BookingForm_Load;

            chkRoom.CheckedChanged += chkRoom_CheckedChanged;
            chkRestaurant.CheckedChanged += chkRestaurant_CheckedChanged;

            txtRoomPrice.TextChanged += txtRoomPrice_TextChanged;
            txtTablePrice.TextChanged += txtTablePrice_TextChanged;

            pnlBooking.Dock = DockStyle.Fill;
            pnlBooking.AutoScroll = true;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            taClient.Fill(codeCraftersDS.Client);
            taBranch.Fill(codeCraftersDS.Branch);
            taHotelRoom.Fill(codeCraftersDS.Hotel_Room);
            taRestaurantTable.Fill(codeCraftersDS.Restuarant_Table);
            taRatePlan.Fill(codeCraftersDS.Rate_Plan);

            dtpCheckInDate.ValueChanged += dtpCheckInDate_ValueChanged;
            dtpCheckOutDate.ValueChanged += dtpCheckOutDate_ValueChanged;

            dtpCheckInDate.Format = DateTimePickerFormat.Custom;
            dtpCheckInDate.CustomFormat = "dd MMM yyyy HH:mm";
            dtpCheckInDate.ShowUpDown = true;

            dtpCheckOutDate.Format = DateTimePickerFormat.Custom;
            dtpCheckOutDate.CustomFormat = "dd MMM yyyy HH:mm";
            dtpCheckOutDate.ShowUpDown = true;

            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "dd MMM yyyy HH:mm";
            dtpStartTime.ShowUpDown = true;

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "dd MMM yyyy HH:mm";
            dtpEndTime.ShowUpDown = true;

            cmbClient.DataSource = codeCraftersDS.Client;
            cmbClient.DisplayMember = "First_Name";
            cmbClient.ValueMember = "Client_ID";

            cmbBranch.DataSource = codeCraftersDS.Branch;
            cmbBranch.DisplayMember = "Branch_Name";
            cmbBranch.ValueMember = "Branch_ID";

            cmbRoom.DataSource = codeCraftersDS.Hotel_Room;
            cmbRoom.DisplayMember = "hotel_room_number";
            cmbRoom.ValueMember = "Hotel_Room_ID";

            cmbRestaurantTable.DataSource = codeCraftersDS.Restuarant_Table;
            cmbRestaurantTable.DisplayMember = "RestaurantTableNum";
            cmbRestaurantTable.ValueMember = "RestaurantTableID";
        }

        private void ClearControls()
        {
            cmbClient.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            cmbRestaurantTable.SelectedIndex = -1;

            dtpCheckInDate.Value = DateTime.Now;
            dtpCheckOutDate.Value = DateTime.Now.AddHours(1);

            txtRoomPrice.Clear();
            txtTablePrice.Clear();
            txtTotalAmount.Clear();
        }

        private void CalculateTotalAmount()
        {
            decimal roomPrice = 0;
            decimal tablePrice = 0;

            if (chkRoom.Checked)
                decimal.TryParse(txtRoomPrice.Text, out roomPrice);

            if (chkRestaurant.Checked)
                decimal.TryParse(txtTablePrice.Text, out tablePrice);

            txtTotalAmount.Text = (roomPrice + tablePrice).ToString("0.00");
        }

        private void chkRoom_CheckedChanged(object sender, EventArgs e) => CalculateTotalAmount();
        private void chkRestaurant_CheckedChanged(object sender, EventArgs e) => CalculateTotalAmount();
        private void txtRoomPrice_TextChanged(object sender, EventArgs e) => CalculateTotalAmount();
        private void txtTablePrice_TextChanged(object sender, EventArgs e) => CalculateTotalAmount();

        private void chkRoom_CheckedChanged_1(object sender, EventArgs e)
        {
            CalculateTotalAmount();

            if (chkRoom.Checked)
            {
                dtpStartTime.Enabled = true;
                dtpEndTime.Enabled = true;
            }
            else if (chkRestaurant.Checked)
            {
                dtpStartTime.Enabled = false;
                dtpEndTime.Enabled = false;
            }
        }

        private void chkRestaurant_CheckedChanged_1(object sender, EventArgs e)
        {
            CalculateTotalAmount();

            if (chkRestaurant.Checked && !chkRoom.Checked)
            {
                dtpStartTime.Enabled = false;
                dtpEndTime.Enabled = false;

                dtpStartTime.Value = dtpCheckInDate.Value;
                dtpEndTime.Value = dtpCheckOutDate.Value;
            }
            else
            {
                dtpStartTime.Enabled = true;
                dtpEndTime.Enabled = true;
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartTime.Value = dtpCheckInDate.Value;
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndTime.Value = dtpCheckOutDate.Value;
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClient.SelectedIndex == -1) { MessageBox.Show("Please select a client."); return; }
                if (cmbBranch.SelectedIndex == -1) { MessageBox.Show("Please select a branch."); return; }
                if (!chkRoom.Checked && !chkRestaurant.Checked) { MessageBox.Show("Please select Room Booking, Restaurant Booking or both."); return; }
                if (dtpCheckOutDate.Value <= dtpCheckInDate.Value) { MessageBox.Show("Check-out must be after check-in (including time)."); return; }
                if (!decimal.TryParse(txtTotalAmount.Text, out decimal bookingAmount)) { MessageBox.Show("Invalid booking amount."); return; }

                int clientID = Convert.ToInt32(cmbClient.SelectedValue);
                int branchID = Convert.ToInt32(cmbBranch.SelectedValue);
                DateTime bookingDate = dtpBookingDate.Value;
                DateTime checkInDate = dtpCheckInDate.Value;
                DateTime checkOutDate = dtpCheckOutDate.Value;

                if (chkRoom.Checked)
                {
                    if (cmbRoom.SelectedValue == null) { MessageBox.Show("Please select a room."); return; }
                    int roomID = Convert.ToInt32(cmbRoom.SelectedValue);

                    int conflictingRooms = Convert.ToInt32(taRoomAssignment.CheckRoomConflict(roomID, checkInDate, checkOutDate));

                    if (conflictingRooms > 0)
                    {
                        MessageBox.Show("Sorry, this room is already booked for the selected dates/times.",
                                        "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (chkRestaurant.Checked)
                {
                    if (cmbRestaurantTable.SelectedValue == null) { MessageBox.Show("Please select a restaurant table."); return; }
                    int tableID = Convert.ToInt32(cmbRestaurantTable.SelectedValue);
                    DateTime startTime = dtpStartTime.Value;
                    DateTime endTime = dtpEndTime.Value;

                    if (endTime <= startTime) { MessageBox.Show("Table booking end time must be after start time."); return; }

                    int conflictingTables = Convert.ToInt32(taTableAllocation.CheckTableConflict(tableID, startTime, endTime));

                    if (conflictingTables > 0)
                    {
                        MessageBox.Show("Sorry, this restaurant table is already reserved for the selected timeframe.",
                                        "Table Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string bookingStatus = "Pending";

                taBooking.InsertNewBooking(
                    clientID,
                    branchID,
                    bookingDate.ToString("yyyy-MM-dd HH:mm"),
                    checkInDate.ToString("yyyy-MM-dd HH:mm"),
                    checkOutDate.ToString("yyyy-MM-dd HH:mm"),
                    bookingAmount,
                    bookingStatus);

                int bookingID = Convert.ToInt32(taBooking.GetLatestBookingID());

                if (chkRoom.Checked)
                {
                    int roomID = Convert.ToInt32(cmbRoom.SelectedValue);
                    taRoomAssignment.InsertRoomAssignment(bookingID, roomID, checkInDate, checkOutDate);
                }

                if (chkRestaurant.Checked)
                {
                    int tableID = Convert.ToInt32(cmbRestaurantTable.SelectedValue);
                    taTableAllocation.InsertTableAllocation(bookingID, tableID, 1, "Restaurant Table", dtpStartTime.Value, dtpEndTime.Value);
                }

                string bookingType = chkRoom.Checked && chkRestaurant.Checked ? "Room & Restaurant" : chkRoom.Checked ? "Room" : "Restaurant";

                MessageBox.Show(
                    "BOOKING SUCCESSFULLY CREATED\n\n" +
                    "Booking Reference : " + bookingID +
                    "\nClient : " + cmbClient.Text +
                    "\nBooking Type : " + bookingType +
                    "\nCheck-In : " + checkInDate.ToString("dd MMM yyyy HH:mm") +
                    "\nStatus : Pending",
                    "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataRowView selectedClientRow = (DataRowView)cmbClient.SelectedItem;
                if (selectedClientRow != null && selectedClientRow.Row.Table.Columns.Contains("Email_Address"))
                {
                    string clientEmail = selectedClientRow["Email_Address"].ToString();
                    string clientName = selectedClientRow["First_Name"].ToString();

                    if (!string.IsNullOrEmpty(clientEmail))
                    {
                        string emailSubject = $"The Regal Inn - Booking Received! Ref: #{bookingID}";
                        string emailBody = $@"
                        <div style='font-family: Arial, sans-serif; max-width: 600px; border: 1px solid #dcdcdc; padding: 20px;'>
                            <h2 style='color: #4A154B;'>Hello {clientName},</h2>
                            <p>Your booking request has been successfully created and is currently <b>Pending Payment</b>.</p>
                            <hr style='border: 0; border-top: 1px solid #eee;' />
                            <p><b>Booking Details:</b></p>
                            <ul>
                                <li><b>Booking Reference:</b> #{bookingID}</li>
                                <li><b>Type:</b> {bookingType}</li>
                                <li><b>Check-In:</b> {checkInDate.ToString("dd MMM yyyy HH:mm")}</li>
                                <li><b>Total Amount:</b> R {bookingAmount:0.00}</li>
                            </ul>
                            <hr style='border: 0; border-top: 1px solid #eee;' />
                            <p style='font-size: 12px; color: #888;'>This is an automated system confirmation notification. Please do not reply directly to this message.</p>
                        </div>";

                        EmailService.SendEmail(clientEmail, emailSubject, emailBody);
                    }
                }

                ClearControls();

                PaymentForm paymentForm = new PaymentForm(bookingID, bookingAmount, clientID);
                paymentForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}