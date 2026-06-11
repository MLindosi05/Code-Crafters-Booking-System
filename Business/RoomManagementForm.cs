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
            taHotelRoom.Fill(codeCraftersDS.Hotel_Room);
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            panel2.BackColor = ColorTranslator.FromHtml("#966919");

            btnAddRoom.BackColor = ColorTranslator.FromHtml("#C99A2E");
           btnAddRoom.ForeColor = Color.White;

           btnClearRoom.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnClearRoom.ForeColor = Color.White;

           btnDeleteRoom.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnDeleteRoom.ForeColor = Color.White;

           btnUpdateRoom.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnUpdateRoom.ForeColor = Color.White;
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