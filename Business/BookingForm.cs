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

        public BookingForm()
        {
            InitializeComponent();
            this.Load += BookingForm_Load;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            try
            {
                taClient.Fill(codeCraftersDS.Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error pulling client data from database: {ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

            mclCheckIn.TodayDate = DateTime.Today;
            mclCheckIn.SelectionStart = DateTime.Today;
            mclCheckOut.TodayDate = DateTime.Today;
            mclCheckOut.SelectionStart = DateTime.Today;

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

        private DataRow GetOrCreateCurrentInvoiceRow()
        {
            if (codeCraftersDS.Invoice.Rows.Count == 0)
            {
                return codeCraftersDS.Invoice.NewRow();
            }

            DataRow lastRow = codeCraftersDS.Invoice.Rows[codeCraftersDS.Invoice.Rows.Count - 1];
            if (lastRow[0] != DBNull.Value && lastRow[3] != DBNull.Value)
            {
                return codeCraftersDS.Invoice.NewRow();
            }

            return lastRow;
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

        private void dgvHotelRoomAvailable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHotelRoomAvailable.CurrentRow == null) return;

            int roomID = Convert.ToInt32(dgvHotelRoomAvailable.CurrentRow.Cells[0].Value);
            int roomNumber = Convert.ToInt32(dgvHotelRoomAvailable.CurrentRow.Cells[3].Value);
            decimal roomPrice = Convert.ToDecimal(dgvHotelRoomAvailable.CurrentRow.Cells[5].Value);

            DataRow row = GetOrCreateCurrentInvoiceRow();
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

            int tableID = Convert.ToInt32(dgvRestaurantTableAvailable.CurrentRow.Cells[0].Value);
            string tableNumber = dgvRestaurantTableAvailable.CurrentRow.Cells[2].Value.ToString();
            decimal tablePrice = Convert.ToDecimal(dgvRestaurantTableAvailable.CurrentRow.Cells[8].Value);

            DataRow row = GetOrCreateCurrentInvoiceRow();
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

        private void btnCreateBooking_Click(object sender, EventArgs e)
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

            int pk = (int)taBooking.InsertNewBooking(
                clientBookingID,
                cmbBranchID.SelectedItem.ToString(),
                DateTime.Now.ToString(),
                mclCheckIn.SelectionStart.ToShortDateString(),
                mclCheckOut.SelectionStart.ToShortDateString(),
                Convert.ToDecimal(txtTotalAmount.Text.Replace("R", "").Trim()),
                "Pending"
            );

            UserSession.BookingID = pk;
            UserSession.BookingReference = $"BR" + pk;
            UserSession.GuestName = txtFullName.Text;
            UserSession.EmailAddress = targetEmail;
            UserSession.PhysicalAddress = txtAddress.Text;
            UserSession.TotalPrice = txtTotalAmount.Text;

            PaymentForm paymentForm = new PaymentForm(this);
            paymentForm.Show();
        }
    }
}