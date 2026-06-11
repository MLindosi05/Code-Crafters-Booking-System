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
    public partial class RoomManagementForm : Form
    {
        public RoomManagementForm()
        {
            InitializeComponent();
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHotelRoomManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvHotelRoomManagement.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load room data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateRoomInputs()
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text) || string.IsNullOrWhiteSpace(txtRoomPrice.Text))
            {
                MessageBox.Show("Please fill in both the Room Number and Room Price fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbBranchID.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbBranchID.Text))
            {
                MessageBox.Show("Please select a valid Branch ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbRoomTypeID.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbRoomTypeID.Text))
            {
                MessageBox.Show("Please select a valid Room Type ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbRoomStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbRoomStatus.Text))
            {
                MessageBox.Show("Please select a valid Room Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtRoomPrice.Text.Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive numeric amount for the Room Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (!ValidateRoomInputs()) return;

            try
            {
                int roomTypeID = Convert.ToInt32(cmbRoomTypeID.Text);
                decimal roomPrice = Convert.ToDecimal(txtRoomPrice.Text.Trim());

                taHotelRoom.InsertNewRoom(
                    cmbBranchID.Text,
                    roomTypeID,
                    Convert.ToInt32(txtRoomNumber.Text),
                    cmbRoomStatus.Text,
                    roomPrice
                );

                MessageBox.Show("New room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taHotelRoom.Fill(codeCraftersDS.Hotel_Room);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the room: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (dgvHotelRoomManagement.CurrentRow == null || dgvHotelRoomManagement.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a room record from the grid to update.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateRoomInputs()) return;

            try
            {
                int roomID = Convert.ToInt32(dgvHotelRoomManagement.CurrentRow.Cells["hotelRoomIDDataGridViewTextBoxColumn"].Value);
                decimal roomPrice = Convert.ToDecimal(txtRoomPrice.Text.Trim());

                DialogResult result = MessageBox.Show($"Are you sure you want to update Room ID {roomID}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int roomTypeID = Convert.ToInt32(cmbRoomTypeID.Text);

                    taHotelRoom.UpdateRoom(
                        cmbBranchID.Text,
                        roomTypeID,
                        Convert.ToInt32(txtRoomNumber.Text),
                        cmbRoomStatus.Text,
                        roomPrice,
                        roomID
                    );

                    MessageBox.Show("Room details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taHotelRoom.Fill(codeCraftersDS.Hotel_Room);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvHotelRoomManagement.CurrentRow == null || dgvHotelRoomManagement.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a room record from the grid to delete.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int roomID = Convert.ToInt32(dgvHotelRoomManagement.CurrentRow.Cells["hotelRoomIDDataGridViewTextBoxColumn"].Value);
                string roomNo = dgvHotelRoomManagement.CurrentRow.Cells["hotelroomnumberDataGridViewTextBoxColumn"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to permanently delete Room No: {roomNo} (ID: {roomID})?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    taHotelRoom.DeleteRoomQuery(roomID);
                    MessageBox.Show("Room removed successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnClearRoom_Click(this, EventArgs.Empty);
                    taHotelRoom.Fill(codeCraftersDS.Hotel_Room);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearRoom_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Clear();
            txtRoomPrice.Clear();
            txtRoomID.Clear();

            cmbBranchID.SelectedIndex = -1;
            cmbRoomTypeID.SelectedIndex = -1;
            cmbRoomStatus.SelectedIndex = -1;

            codeCraftersDS.Hotel_Room.Clear();
        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {
            string InputText = txtRoomID.Text.Trim();

            if (string.IsNullOrWhiteSpace(InputText))
            {
                codeCraftersDS.Hotel_Room.Clear();
                return;
            }

            if (!int.TryParse(InputText, out int parsedRoomID))
            {
                codeCraftersDS.Hotel_Room.Clear();
                MessageBox.Show("Please enter a valid numeric Room ID. Special characters, symbols ('-'), and letters are not allowed.",
                                "Invalid Search Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                taHotelRoom.FillByHotelRoomID(codeCraftersDS.Hotel_Room, parsedRoomID);
            }
        }

        private void dgvHotelRoomManagement_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHotelRoomManagement.CurrentRow != null && !dgvHotelRoomManagement.CurrentRow.IsNewRow)
            {
                var row = dgvHotelRoomManagement.CurrentRow;

                cmbBranchID.Text = row.Cells["branchIDDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                cmbRoomTypeID.Text = row.Cells["hotelroomtypeIDDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                txtRoomNumber.Text = row.Cells["hotelroomnumberDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                cmbRoomStatus.Text = row.Cells["hotelroomstatusDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                txtRoomPrice.Text = row.Cells["hotelroomPriceDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            }
        }
    }
}