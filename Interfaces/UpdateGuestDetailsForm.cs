using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    public partial class UpdateGuestDetailsForm : Form
    {
        public string UpdatedFirstName => txtFirstName.Text.Trim();
        public string UpdatedLastName => txtLastName.Text.Trim();
        public string UpdatedEmail => txtEmail.Text.Trim();
        public string UpdatedPhone => txtPhone.Text.Trim();
        public string UpdatedAddress => txtAddress.Text.Trim();

        private int _clientID;
        private string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnSave;
        private Button btnCancel;
        private Panel pnlContainer;

        public UpdateGuestDetailsForm(int clientID, string firstName, string lastName, string email, string phone, string address)
        {
            _clientID = clientID;
            InitializeComponentCustom();

            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtAddress.Text = address;
        }

        private void InitializeComponentCustom()
        {
            this.Text = "REGAL INN - UPDATE GUEST PERSONAL DETAILS";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(15, 23, 42);

            pnlContainer = new Panel()
            {
                Size = new Size(520, 420),
                BackColor = Color.FromArgb(10, 25, 47),
                BorderStyle = BorderStyle.FixedSingle
            };
            pnlContainer.Location = new Point((this.ClientSize.Width - pnlContainer.Width) / 2, (this.ClientSize.Height - pnlContainer.Height) / 2);
            this.Resize += (s, e) => {
                pnlContainer.Location = new Point((this.ClientSize.Width - pnlContainer.Width) / 2, (this.ClientSize.Height - pnlContainer.Height) / 2);
            };

            int lblX = 30;
            int txtX = 180;
            int startY = 40;
            int spacing = 50;

            Label lblFirstName = new Label() { Text = "FIRST NAME:", ForeColor = Color.White, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Location = new Point(lblX, startY), AutoSize = true };
            txtFirstName = new TextBox() { Location = new Point(txtX, startY - 2), Width = 280, Font = new Font("Segoe UI", 10f) };

            Label lblLastName = new Label() { Text = "LAST NAME:", ForeColor = Color.White, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Location = new Point(lblX, startY + spacing), AutoSize = true };
            txtLastName = new TextBox() { Location = new Point(txtX, startY + spacing - 2), Width = 280, Font = new Font("Segoe UI", 10f) };

            Label lblEmail = new Label() { Text = "EMAIL ADDRESS:", ForeColor = Color.White, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Location = new Point(lblX, startY + (spacing * 2)), AutoSize = true };
            txtEmail = new TextBox() { Location = new Point(txtX, startY + (spacing * 2) - 2), Width = 280, Font = new Font("Segoe UI", 10f) };

            Label lblPhone = new Label() { Text = "PHONE NO:", ForeColor = Color.White, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Location = new Point(lblX, startY + (spacing * 3)), AutoSize = true };
            txtPhone = new TextBox() { Location = new Point(txtX, startY + (spacing * 3) - 2), Width = 280, Font = new Font("Segoe UI", 10f) };

            Label lblAddress = new Label() { Text = "PHYSICAL ADDRESS:", ForeColor = Color.White, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Location = new Point(lblX, startY + (spacing * 4)), AutoSize = true };
            txtAddress = new TextBox() { Location = new Point(txtX, startY + (spacing * 4) - 2), Width = 280, Font = new Font("Segoe UI", 10f) };

            btnSave = new Button() { Text = "SAVE CHANGES", BackColor = Color.FromArgb(0, 113, 228), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(txtX, startY + (spacing * 5) + 10), Width = 130, Height = 38, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold) };
            btnSave.Click += BtnSave_Click;

            btnCancel = new Button() { Text = "CANCEL", DialogResult = DialogResult.Cancel, BackColor = Color.FromArgb(220, 53, 69), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(txtX + 140, startY + (spacing * 5) + 10), Width = 140, Height = 38, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold) };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            pnlContainer.Controls.Add(lblFirstName);
            pnlContainer.Controls.Add(txtFirstName);
            pnlContainer.Controls.Add(lblLastName);
            pnlContainer.Controls.Add(txtLastName);
            pnlContainer.Controls.Add(lblEmail);
            pnlContainer.Controls.Add(txtEmail);
            pnlContainer.Controls.Add(lblPhone);
            pnlContainer.Controls.Add(txtPhone);
            pnlContainer.Controls.Add(lblAddress);
            pnlContainer.Controls.Add(txtAddress);
            pnlContainer.Controls.Add(btnSave);
            pnlContainer.Controls.Add(btnCancel);

            this.Controls.Add(pnlContainer);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UpdatedFirstName) || string.IsNullOrWhiteSpace(UpdatedLastName) || string.IsNullOrWhiteSpace(UpdatedEmail))
            {
                MessageBox.Show("First Name, Last Name, and Email Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE [GroupPmb2].[dbo].[Client] 
                                     SET [First_Name] = @FirstName, 
                                         [Last_Name] = @LastName, 
                                         [Email_Address] = @Email, 
                                         [Phone_Number] = @Phone, 
                                         [Client_Address] = @Address 
                                     WHERE [Client_ID] = @ClientID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", UpdatedFirstName);
                        cmd.Parameters.AddWithValue("@LastName", UpdatedLastName);
                        cmd.Parameters.AddWithValue("@Email", UpdatedEmail);
                        cmd.Parameters.AddWithValue("@Phone", UpdatedPhone);
                        cmd.Parameters.AddWithValue("@Address", UpdatedAddress);
                        cmd.Parameters.AddWithValue("@ClientID", _clientID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Client details updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating client details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}