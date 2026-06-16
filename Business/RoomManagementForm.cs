using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class RoomManagementForm : Form
    {
        public RoomManagementForm()
        {
            InitializeComponent();
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            panel2.BackColor = ColorTranslator.FromHtml("#966919");

            StyleButton(btnAddRoom);
            StyleButton(btnClearRoom);
            StyleButton(btnDeleteRoom);
            StyleButton(btnUpdateRoom);
        }

        private void StyleButton(Button btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btn.ForeColor = Color.White;
        }

        private void dgvHotelRoomManagement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHotelRoomManagement.CurrentRow == null || dgvHotelRoomManagement.CurrentRow.DataBoundItem == null) return;

            var row = dgvHotelRoomManagement.CurrentRow;

            cmbBranchID.Text = row.Cells["branchIDDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            cmbRoomTypeID.Text = row.Cells["hotelroomtypeIDDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            txtRoomNumber.Text = row.Cells["hotelroomnumberDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            cmbRoomStatus.Text = row.Cells["hotelroomstatusDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            txtRoomPrice.Text = row.Cells["hotelroomPriceDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
        }

        private bool ValidateRoomInputs(bool isUpdating = false)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text) || string.IsNullOrWhiteSpace(txtRoomPrice.Text))
            {
                MessageBox.Show("Fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtRoomNumber.Text.Trim(), out int targetRoomNumber))
            {
                MessageBox.Show("Room number must be a valid whole number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!isUpdating && codeCraftersDSTWO?.Hotel_Room != null)
            {
                taRoomHotel.Fill(codeCraftersDSTWO.Hotel_Room);

                foreach (DataRow row in codeCraftersDSTWO.Hotel_Room.Rows)
                {
                    if (row.RowState != DataRowState.Deleted &&
                        row["Hotel_Room_Number"] != DBNull.Value &&
                        Convert.ToInt32(row["Hotel_Room_Number"]) == targetRoomNumber)
                    {
                        MessageBox.Show($"Room No: {targetRoomNumber} already exists in the system. Please use a unique room number.",
                                        "Duplicate Room Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateRoomInputs(isUpdating: false)) return;

            try
            {
                string branchID = cmbBranchID.Text.Trim();
                int roomTypeID = Convert.ToInt32(cmbRoomTypeID.Text);
                int roomNumber = Convert.ToInt32(txtRoomNumber.Text.Trim());
                string roomStatus = cmbRoomStatus.Text.Trim();
                decimal roomPrice = Convert.ToDecimal(txtRoomPrice.Text.Trim());

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to add Room No: {roomNumber}?",
                    "Confirm Add Room",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    taRoomHotel.InsertNewRoom(branchID, roomTypeID, roomNumber, roomStatus, roomPrice);
                    dgvHotelRoomManagement.SelectionChanged -= dgvHotelRoomManagement_SelectionChanged;

                    taRoomHotel.Fill(codeCraftersDSTWO.Hotel_Room);
                    dgvHotelRoomManagement.SelectionChanged += dgvHotelRoomManagement_SelectionChanged;

                    MessageBox.Show("Room added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding room: " + ex.Message);
            }
        }

        private void ClearInputControls()
        {
            txtRoomNumber.Clear();
            txtRoomID.Clear();
            txtRoomPrice.Clear();

            cmbBranchID.SelectedIndex = -1;
            cmbRoomTypeID.SelectedIndex = -1;
            cmbRoomStatus.SelectedIndex = -1;

            cmbBranchID.Text = "";
            cmbRoomTypeID.Text = "";
            cmbRoomStatus.Text = "";
        }

        private void btnRoomClear_Click(object sender, EventArgs e)
        {
            ClearInputControls();

            if (codeCraftersDSTWO?.Hotel_Room != null)
            {
                codeCraftersDSTWO.Hotel_Room.Clear();
            }
        }

        private void btnRoomUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateRoomInputs(isUpdating: true)) return;

            try
            {
                if (dgvHotelRoomManagement.CurrentRow == null) return;

                int roomID = Convert.ToInt32(
                    dgvHotelRoomManagement.CurrentRow.Cells["hotelRoomIDDataGridViewTextBoxColumn"].Value
                );

                decimal roomPrice = Convert.ToDecimal(txtRoomPrice.Text.Trim());
                int roomTypeID = Convert.ToInt32(cmbRoomTypeID.Text);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to update Room ID {roomID}?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    taRoomHotel.UpdateRoom(
                        cmbBranchID.Text,
                        roomTypeID,
                        Convert.ToInt32(txtRoomNumber.Text),
                        cmbRoomStatus.Text,
                        roomPrice,
                        roomID
                    );
                    MessageBox.Show("Room updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        
        private void txtRoomID_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomID.Text))
            {
                return;
            }

            if (int.TryParse(txtRoomID.Text, out int roomNo))
            {
                taRoomHotel.FillByRoomNo(codeCraftersDSTWO.Hotel_Room, roomNo);
            }
            else
            {
                MessageBox.Show("Please enter a valid positive room number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtRoomID.Clear();
            }

        }
    }
}