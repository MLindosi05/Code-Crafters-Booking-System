using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class StaffManagementForm : Form
    {
        public StaffManagementForm()
        {
            InitializeComponent();
        }

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            panel3.BackColor = ColorTranslator.FromHtml("#966919");

            btnStaffAdd.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnStaffAdd.ForeColor = Color.White;

            btnStaffClear.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnStaffClear.ForeColor = Color.White;

            btnStaffDelete.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnStaffDelete.ForeColor = Color.White;

            btnStaffUpdate.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnStaffUpdate.ForeColor = Color.White;

        }

        /// <summary>
        /// Centralized validation method to handle all text box and combo box criteria.
        /// </summary>
        private bool ValidateStaffInputs()
        {
            if (string.IsNullOrWhiteSpace(txtStaffName.Text) ||
                string.IsNullOrWhiteSpace(txtStaffSurname.Text) ||
                string.IsNullOrWhiteSpace(txtStaffAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text) ||
                string.IsNullOrWhiteSpace(txtStaffPassword.Text))
            {
                MessageBox.Show("All text fields must be filled in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbBranchID.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbBranchID.Text))
            {
                MessageBox.Show("Please select a valid Branch ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbStaffRole.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbStaffRole.Text))
            {
                MessageBox.Show("Please select a valid Staff Role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbStaffStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbStaffStatus.Text))
            {
                MessageBox.Show("Please select a valid Staff Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string cleanPhone = Regex.Replace(txtPhoneNumber.Text.Trim(), @"\s+", "");
            if (!Regex.IsMatch(cleanPhone, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit numeric phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string emailPattern = @"^[^@\s]+@regalinn\.co\.za$";
            if (!Regex.IsMatch(txtEmailAddress.Text.Trim(), emailPattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Staff members must use an official corporate email address ending with @regalinn.co.za",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtStaffPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; 
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateStaffInputs()) return;

            try
            {
                taStaffs.Fill(codeCraftersDS.Staff);

                string inputPhone = Regex.Replace(txtPhoneNumber.Text.Trim(), @"\s+", "");
                string inputEmail = txtEmailAddress.Text.Trim();

                bool duplicateExists = codeCraftersDS.Staff.AsEnumerable().Any(row =>
                    string.Equals(Regex.Replace(row.Field<string>("staff_phone_number") ?? "", @"\s+", ""), inputPhone, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(row.Field<string>("staff_email") ?? "", inputEmail, StringComparison.OrdinalIgnoreCase)
                );

                if (duplicateExists)
                {
                    MessageBox.Show("A staff member with this phone number or email address already exists.",
                                    "Duplicate Record Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; 
                }

                taStaffs.InsertNewStaff(
                    cmbBranchID.Text,
                    txtStaffName.Text,
                    txtStaffSurname.Text,
                    txtStaffAddress.Text,
                    txtPhoneNumber.Text,
                    txtEmailAddress.Text,
                    cmbStaffRole.Text,
                    DateTime.Now,
                    cmbStaffStatus.Text,
                    txtStaffPassword.Text
                );

                taClients.InsertNewClient(
                    txtStaffName.Text,
                    txtStaffSurname.Text,
                    txtStaffPassword.Text,
                    txtEmailAddress.Text,
                    txtStaffAddress.Text,
                    txtPhoneNumber.Text
                );

                MessageBox.Show("New staff member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                taStaffs.Fill(codeCraftersDS.Staff);
                taClients.Fill(codeCraftersDS.Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStaffClear_Click(object sender, EventArgs e)
        {
            txtStaffID.Clear();
            txtStaffName.Clear();
            txtStaffSurname.Clear();
            txtStaffAddress.Clear();
            txtPhoneNumber.Clear();
            txtStaffPassword.Clear();
            txtEmailAddress.Clear();

            cmbBranchID.SelectedIndex = -1;
            cmbStaffRole.SelectedIndex = -1;
            cmbStaffStatus.SelectedIndex = -1;

            codeCraftersDS.Staff.Clear();
        }

        private void btnStaffUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text) || !int.TryParse(txtStaffID.Text, out int staffID))
            {
                MessageBox.Show("Please search for or enter a valid numeric Staff ID before updating.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateStaffInputs()) return;

            DialogResult result = MessageBox.Show($"Are you sure you want to save updates for Staff ID {txtStaffID.Text}?",
                                                  "Confirm Update",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    taStaffs.UpdateStaff(
                        cmbBranchID.Text,
                        txtStaffName.Text,
                        txtStaffSurname.Text,
                        txtStaffAddress.Text,
                        txtPhoneNumber.Text,
                        txtEmailAddress.Text,
                        cmbStaffRole.Text,
                        cmbStaffStatus.Text,
                        txtStaffPassword.Text,
                        staffID
                    );

                    MessageBox.Show("Staff record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    taStaffs.Fill(codeCraftersDS.Staff);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text) || !int.TryParse(txtStaffID.Text, out int staffID))
            {
                MessageBox.Show("Please enter or search for a valid numeric Staff ID to delete.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete Staff ID {txtStaffID.Text}?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    taStaffs.DeleteQuery(staffID);

                    MessageBox.Show("Staff record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtStaffID.Clear();
                    taStaffs.Fill(codeCraftersDS.Staff);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            string input = txtStaffID.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                ClearInputFieldsValuesOnly();
                codeCraftersDS.Staff.Clear();
                return;
            }

            if (!int.TryParse(input, out int staffID))
            {
                return;
            }

            try
            {
                taStaffs.FillByStaffID(codeCraftersDS.Staff, staffID);

                if (codeCraftersDS.Staff.Rows.Count > 0)
                {
                    DataRow row = codeCraftersDS.Staff.Rows[0];

                    cmbBranchID.Text = row["Branch_ID"]?.ToString() ?? "";
                    txtStaffName.Text = row["staff_First_Name"]?.ToString() ?? "";
                    txtStaffSurname.Text = row["staff_Surname"]?.ToString() ?? "";
                    txtStaffAddress.Text = row["staff_Address"]?.ToString() ?? "";
                    txtPhoneNumber.Text = row["staff_phone_number"]?.ToString() ?? "";
                    txtEmailAddress.Text = row["staff_email"]?.ToString() ?? "";
                    cmbStaffRole.Text = row["staff_role"]?.ToString() ?? "";
                    cmbStaffStatus.Text = row["staff_status"]?.ToString() ?? "";
                    txtStaffPassword.Text = row["staff_Password"]?.ToString() ?? "";
                }
                else
                {
                    ClearInputFieldsValuesOnly();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFieldsValuesOnly()
        {
            txtStaffName.Clear();
            txtStaffSurname.Clear();
            txtStaffAddress.Clear();
            txtPhoneNumber.Clear();
            txtStaffPassword.Clear();
            txtEmailAddress.Clear();

            cmbBranchID.SelectedIndex = -1;
            cmbStaffRole.SelectedIndex = -1;
            cmbStaffStatus.SelectedIndex = -1;

            cmbBranchID.Text = "";
            cmbStaffRole.Text = "";
            cmbStaffStatus.Text = "";
        }


    }
}