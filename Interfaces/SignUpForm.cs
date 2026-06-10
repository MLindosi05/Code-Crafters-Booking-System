using Code_Crafters_Interface_Prototype_1.Interfaces;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

            // 1. Validation Checks
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (name.Any(char.IsDigit) || surname.Any(char.IsDigit))
            {
                MessageBox.Show("First Name and Surname can only contain letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Contact number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d).+$"))
            {
                MessageBox.Show("Password must contain at least one letter and one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Duplicate Checks
                int emailExists = Convert.ToInt32(taClient.CheckEmailExists(email));
                if (emailExists > 0)
                {
                    MessageBox.Show("Email address already exists!", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int phoneExists = Convert.ToInt32(taClient.CheckPhoneExists(phoneNumber));
                if (phoneExists > 0)
                {
                    MessageBox.Show("Phone number already exists!", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Insert into Client Table (Happens for EVERYONE)
                int pk = Convert.ToInt32(taClient.InsertNewClient(name, surname, password, email, physicalAddress, phoneNumber));
                UserSession.ClientID = pk;

                // 4. Double Insert Condition (If Staff Email)
                if (email.EndsWith("@regalinn.co.za", StringComparison.OrdinalIgnoreCase))
                {
                    var taStaff = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter();

                    // Setup the available branches array
                    string[] branches = { "BR01", "BR02", "BR03", "BR04", "BR05" };

                    // Generate a random index between 0 and 4
                    Random rand = new Random();
                    int randomIndex = rand.Next(0, branches.Length);
                    string branchId = branches[randomIndex];

                    // Insert into Staff Table with the randomly assigned branch
                    taStaff.InsertNewStaff(
                        branchId,
                        name,
                        surname,
                        physicalAddress,
                        phoneNumber,
                        email,
                        "Admin",
                        DateTime.Now,
                        "Full Time"
                    );

                    MessageBox.Show($"Staff and Client accounts created successfully!\nAssigned to Branch: {branchId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Client account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 5. Send Confirmation Email
                string subject = "Welcome to The Regal Inn";
                string body = $@"
        <div style='font-family: Arial; max-width:600px; padding:20px; border:1px solid #ccc;'>
            <h2>Welcome {name}</h2>
            <p>Your account has been created successfully.</p>
            <p><b>Login Email:</b> {email}</p>
        </div>";

                EmailService.SendEmail(email, subject, body);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            button1.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button1.ForeColor = Color.White;
            btnSignUp.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnSignUp.ForeColor = Color.White;
            panel2.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            groupBox4.BackColor = ColorTranslator.FromHtml("#966919");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }


    }
}