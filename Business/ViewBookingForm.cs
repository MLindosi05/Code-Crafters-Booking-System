using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class ViewBookingForm : Form
    {
        public ViewBookingForm()
        {
            InitializeComponent();
        }

        private void ViewBookingForm_Load(object sender, EventArgs e)
        {
            taClientBranchBooking.Fill(codeCraftersDS.ClientBranchBooking);

            if (cmbStatusActions.Items.Count > 0)
                cmbStatusActions.SelectedIndex = 0;
        }

        private void txtBookingID_TextChanged(object sender, EventArgs e)
        {
            string input = txtBookingID.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                taClientBranchBooking.Fill(codeCraftersDS.ClientBranchBooking);
                return;
            }

            if (!int.TryParse(input, out int bookingID) || bookingID <= 0)
            {
                MessageBox.Show("No negative numbers, zero, or strings allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Clear();
                taClientBranchBooking.Fill(codeCraftersDS.ClientBranchBooking);
                return;
            }

            taClientBranchBooking.FillByBookingID(codeCraftersDS.ClientBranchBooking, bookingID);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                // Double-check that a row is actually clicked/highlighted
                if (dgvBookings.CurrentRow == null || dgvBookings.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Please select a booking from the list below first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Safely grabs the value from the very first column (Column 0), avoiding naming string mismatches
                int selectedBookingID = Convert.ToInt32(dgvBookings.CurrentRow.Cells[0].Value);
                string newStatus = cmbStatusActions.Text;

                DialogResult confirmation = MessageBox.Show(
                    $"Are you sure you want to change the status of Booking Reference #{selectedBookingID} to '{newStatus}'?",
                    "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    // Fire the database modification query
                    taClientBranchBooking.UpdateStatusByID(newStatus, selectedBookingID);

                    MessageBox.Show($"Booking status successfully updated to '{newStatus}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh visual layer to pull fresh data
                    string searchInput = txtBookingID.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(searchInput) && int.TryParse(searchInput, out int searchID))
                    {
                        taClientBranchBooking.FillByBookingID(codeCraftersDS.ClientBranchBooking, searchID);
                    }
                    else
                    {
                        taClientBranchBooking.Fill(codeCraftersDS.ClientBranchBooking);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change booking status:\n\n" + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}