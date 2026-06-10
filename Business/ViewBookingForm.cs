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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            groupBox1.BackColor = ColorTranslator.FromHtml("#966919");
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");

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
                if (dgvBookings.CurrentRow == null || dgvBookings.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Please select a booking from the list below first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedBookingID = Convert.ToInt32(dgvBookings.CurrentRow.Cells[0].Value);
                string newStatus = cmbStatusActions.Text;

                DialogResult confirmation = MessageBox.Show(
                    $"Are you sure you want to change the status of Booking Reference #{selectedBookingID} to '{newStatus}'?",
                    "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    taClientBranchBooking.UpdateStatusByID(newStatus, selectedBookingID);

                    MessageBox.Show($"Booking status successfully updated to '{newStatus}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        var taClientLookup = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
                        var clientTable = taClientLookup.GetData();

                        if (dgvBookings.CurrentRow.Cells["Client_ID"].Value != null)
                        {
                            int selectedClientID = Convert.ToInt32(dgvBookings.CurrentRow.Cells["Client_ID"].Value);

                            var matchedClientRow = clientTable.FirstOrDefault(row => row.Client_ID == selectedClientID);

                            if (matchedClientRow != null)
                            {
                                string clientEmail = matchedClientRow.Email_Address;
                                string clientName = matchedClientRow.First_Name;

                                if (!string.IsNullOrWhiteSpace(clientEmail))
                                {
                                    string emailSubject = $"The Regal Inn - Booking Status Updated: Reference #{selectedBookingID}";
                                    string emailBody = $@"
                                <div style='font-family: Arial, sans-serif; max-width: 600px; border: 1px solid #dcdcdc; padding: 20px;'>
                                    <h2 style='color: #4A154B;'>Hello {clientName},</h2>
                                    <p>We are writing to let you know that the status of your reservation at <b>The Regal Inn</b> has been updated.</p>
                                    <hr style='border: 0; border-top: 1px solid #eee;' />
                                    <p><b>Updated Booking Summary:</b></p>
                                    <ul>
                                        <li><b>Booking Reference:</b> #{selectedBookingID}</li>
                                        <li><b>New Status Update:</b> <span style='font-weight: bold; color: #2E7D32;'>{newStatus}</span></li>
                                    </ul>
                                    <p>If you have any queries regarding this status change, please do not hesitate to contact management.</p>
                                    <hr style='border: 0; border-top: 1px solid #eee;' />
                                    <p style='font-size: 12px; color: #888;'>This is an automated system administration message. Please do not reply directly to this email.</p>
                                </div>";

                                    Code_Crafters_Booking_System.EmailService.SendEmail(clientEmail, emailSubject, emailBody);
                                }
                            }
                        }
                    }
                    catch (Exception emailEx)
                    {
                        MessageBox.Show("Status updated successfully, but the notification email failed to send: " + emailEx.Message,
                                        "Mailing System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

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