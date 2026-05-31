using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtEmailAddress.Clear();
            txtPhysicalAddress.Clear();
            txtContactNumber.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            txtName.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string physicalAddress = txtPhysicalAddress.Text.Trim();
            string phoneNumber = txtContactNumber.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d).+$"))
            {
                MessageBox.Show("Password must contain at least one letter and one number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                taClient.InsertNewClient(name, surname, password, email, physicalAddress, phoneNumber);

                if (email.EndsWith("@regalinn.co.za", StringComparison.OrdinalIgnoreCase))
                {
                    Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter taBranch = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter();
                    Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter taStaff = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter();

                    int automatedBranchId = Convert.ToInt32(taBranch.GetFirstBranchId());

                    if (automatedBranchId <= 0)
                    {
                        automatedBranchId = 1;
                    }

                    string automatedRole = "Receptionist";
                    string automatedStatus = "Full Time";
                    DateTime dateJoined = DateTime.Now;

                    taStaff.Insert(
                        automatedBranchId,
                        name,
                        surname,
                        physicalAddress,
                        phoneNumber,
                        email,
                        automatedRole,
                        dateJoined,
                        automatedStatus
                    );

                    MessageBox.Show($"Staff and Client accounts created successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Client account created successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the account.\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}