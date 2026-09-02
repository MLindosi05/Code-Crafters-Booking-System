using Code_Crafters_Interface_Prototype_1.Common;
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

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class ForgotPasswordForm : Form
    {
        private codeCraftersDS.StaffRow currentStaff;

        public ForgotPasswordForm(codeCraftersDS.StaffRow staff)
        {
            InitializeComponent();
            currentStaff = staff;
            WireUpEvents();
        }

        public ForgotPasswordForm()
        {
            InitializeComponent();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            this.Load += ForgotPasswordForm_Load;
            button2.Click += button2_Click;
            textBox1.TextChanged += textBox1_TextChanged;

            // Explicitly hook up eye icons in case designer wiring is missed
            pictureShow.Click += pictureShow_Click;
            pictureHide.Click += pictureHide_Click;
            pictureShow1.Click += pictureShow1_Click;
            pictureHide1.Click += pictureHide1_Click;
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            panel4.BackColor = Color.FromArgb(15, 42, 74);
            panel5.BackColor = Color.FromArgb(15, 42, 74);
            panel2.BackColor = Color.FromArgb(15, 42, 74);

            ButtonStyler.Apply(button1);
            button1.BackColor = Color.FromArgb(15, 42, 74);
            button1.ForeColor = Color.White;

            button2.BackColor = Color.FromArgb(235, 130, 60);
            button2.ForeColor = Color.White;

            // Ensure textboxes are enabled for user entry
            textBox1.Enabled = true;
            textBox2.Enabled = true;

            // Use asterisks (*) for password masking
            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';

            UpdateValidationColors(string.Empty);

            // Initial visibility state for eye icons
            pictureShow.Visible = true;
            pictureHide.Visible = false;

            pictureShow1.Visible = true;
            pictureHide1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateValidationColors(textBox1.Text);
        }

        private void UpdateValidationColors(string password)
        {
            label5.ForeColor = password.Length >= 6 ? Color.Green : Color.White;
            label8.ForeColor = Regex.IsMatch(password, "[A-Z]") ? Color.Green : Color.White;
            label6.ForeColor = Regex.IsMatch(password, "[0-9]") ? Color.Green : Color.White;
            label7.ForeColor = Regex.IsMatch(password, @"[!@#$%^&*(),.?\-_+=~`""'{}|<>[\]/:]") ? Color.Green : Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = textBox1.Text.Trim();
            string confirmPassword = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 6 || !Regex.IsMatch(newPassword, "[A-Z]") ||
                !Regex.IsMatch(newPassword, "[0-9]") || !Regex.IsMatch(newPassword, @"[!@#$%^&*(),.?\-_+=~`""'{}|<>[\]/:]"))
            {
                MessageBox.Show("Password does not meet all complexity requirements.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (currentStaff != null)
                {
                    currentStaff.staff_Password = newPassword;

                    codeCraftersDSTableAdapters.StaffTableAdapter staffAdapter = new codeCraftersDSTableAdapters.StaffTableAdapter();
                    int rows = staffAdapter.Update(currentStaff);

                    if (rows > 0)
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password could not be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Staff session context is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureShow_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '\0'; // Show plain text
            pictureShow.Visible = false;
            pictureHide.Visible = true;
        }

        private void pictureHide_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*'; // Hide text with asterisks
            pictureShow.Visible = true;
            pictureHide.Visible = false;
        }

        private void pictureShow1_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0'; // Show plain text for confirm box
            pictureShow1.Visible = false;
            pictureHide1.Visible = true;
        }

        private void pictureHide1_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*'; // Hide text with asterisks for confirm box
            pictureShow1.Visible = true;
            pictureHide1.Visible = false;
        }
    }
}