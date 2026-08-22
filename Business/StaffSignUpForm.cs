using Code_Crafters_Interface_Prototype_1.Interfaces;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class StaffSignUpForm : Form
    {
        private string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";

        public StaffSignUpForm()
        {
            InitializeComponent();
            LoadComboBoxItems();
        }

        private void LoadComboBoxItems()
        {
            // Populate Branch IDs
            cmbBranchID.Items.Clear();
            cmbBranchID.Items.AddRange(new string[] { "BR01", "BR02", "BR03", "BR04", "BR05" });
            if (cmbBranchID.Items.Count > 0) cmbBranchID.SelectedIndex = 0;

            // Populate Staff Roles
            cmbStaffRole.Items.Clear();
            cmbStaffRole.Items.AddRange(new string[] { "Administrator", "Manager", "Cleaner" }); // Add other roles if needed
            if (cmbStaffRole.Items.Count > 0) cmbStaffRole.SelectedIndex = 0;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // 1. Basic Field Validation
            if (cmbBranchID.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbStaffRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields and make selections.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Check Password Match
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert query mapping to your Staff table columns using ComboBox values
                    string insertQuery = @"
                        INSERT INTO Staff (
                            Branch_ID, 
                            staff_First_Name, 
                            staff_Surname, 
                            staff_Address, 
                            staff_phone_number, 
                            staff_email, 
                            staff_role, 
                            date_joined, 
                            staff_status, 
                            staff_Password
                        ) VALUES (
                            @BranchID, 
                            @FirstName, 
                            @LastName, 
                            @Address, 
                            @Phone, 
                            @Email, 
                            @Role, 
                            GETDATE(), 
                            'Active', 
                            @Password
                        )";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BranchID", cmbBranchID.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtPhysicalAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhoneNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", cmbStaffRole.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Staff account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Return to login form
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}