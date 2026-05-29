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
    public partial class AccomodationBookingForm : Form
    {
        public AccomodationBookingForm()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtClientID.Text))
                {
                    MessageBox.Show("Please enter Client ID.");
                    return;
                }

                int clientID;

                if (!int.TryParse(txtClientID.Text, out clientID))
                {
                    MessageBox.Show("Client ID must be a valid number.");
                    return;
                }

                if (cmbBranchID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Branch ID.");
                    return;
                }

                int branchID = Convert.ToInt32(cmbBranchID.SelectedItem);

                if (dtpCheckInDate.Value.Date < dtpBookingDate.Value.Date)
                {
                    MessageBox.Show("Check-In date cannot be before Booking date.");
                    return;
                }

                if (dtpCheckOutDate.Value.Date <= dtpCheckInDate.Value.Date)
                {
                    MessageBox.Show("Check-Out date must be after Check-In date.");
                    return;
                }

                string bookingDate =
                    dtpBookingDate.Value.ToString("yyyy-MM-dd");

                string checkInDate =
                    dtpCheckInDate.Value.ToString("yyyy-MM-dd");

                string checkOutDate =
                    dtpCheckOutDate.Value.ToString("yyyy-MM-dd");

                if (string.IsNullOrWhiteSpace(txtBookingTotalAmount.Text))
                {
                    MessageBox.Show("Please enter booking total amount.");
                    return;
                }

                decimal totalAmount;

                if (!decimal.TryParse(txtBookingTotalAmount.Text, out totalAmount))
                {
                    MessageBox.Show("Please enter a valid amount.");
                    return;
                }

                string bookingStatus = "Confirmed";

                int pk = Convert.ToInt32(
                    taBooking.InsertBooking(clientID, branchID, bookingDate, checkInDate, checkOutDate, totalAmount, bookingStatus));

                if (pk > 0)
                {
                    MessageBox.Show(
                        "Booking created successfully!\nBooking ID: " + pk,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    txtClientID.Clear();
                    txtBookingTotalAmount.Clear();

                    cmbBranchID.SelectedIndex = -1;

                    dtpBookingDate.Value = DateTime.Today;
                    dtpCheckInDate.Value = DateTime.Today;
                    dtpCheckOutDate.Value = DateTime.Today.AddDays(1);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to create booking.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
