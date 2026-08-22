using Code_Crafters_Interface_Prototype_1.Common;
using Code_Crafters_Interface_Prototype_1.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    public partial class GuestManagementForm : Form
    {
        private string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";

        public GuestManagementForm()
        {
            InitializeComponent();
        }

        #region Form Load

        private void GuestManagementForm_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.codeCraftersDSTWO1.Client);
            ApplyTheme();

            btnBlacklisted.Click += btnBlacklisted_Click;
            btnArchived.Click += btnArchived_Click;
            txtSearchEmail.TextChanged += txtSearchEmail_TextChanged_1;

            LoadGuestsData();
        }

        private void ApplyTheme()
        {
            BackColor = System.Drawing.Color.FromArgb(242, 244, 247);
            panel2.BackColor = System.Drawing.Color.White;

            ButtonStyler.Apply(btnSignUp);
            ButtonStyler.Apply(btnBlacklisted);
            ButtonStyler.Apply(btnArchived);

            ButtonStyler.Apply(btnBlackList);
            ButtonStyler.Apply(btnArchive);

            groupBox4.BackColor = System.Drawing.Color.FromArgb(30, 42, 58);
            groupBox4.ForeColor = System.Drawing.Color.White;

            ConfigureDataGridViewTheme();
        }

        private void ConfigureDataGridViewTheme()
        {
            dgvBookings.BackgroundColor = System.Drawing.Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.EnableHeadersVisualStyles = false;

            dgvBookings.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 53, 128);
            dgvBookings.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvBookings.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvBookings.ColumnHeadersHeight = 35;

            dgvBookings.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvBookings.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            dgvBookings.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);

            dgvBookings.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 113, 228);
            dgvBookings.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvBookings.RowTemplate.Height = 28;

            dgvManageClients.BackgroundColor = System.Drawing.Color.White;
            dgvManageClients.BorderStyle = BorderStyle.None;
            dgvManageClients.EnableHeadersVisualStyles = false;

            dgvManageClients.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 53, 128);
            dgvManageClients.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvManageClients.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvManageClients.ColumnHeadersHeight = 35;

            dgvManageClients.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvManageClients.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            dgvManageClients.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);

            dgvManageClients.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 113, 228);
            dgvManageClients.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvManageClients.RowTemplate.Height = 28;
        }

        #endregion

        #region Filtering and Grid Loading

        private void LoadGuestsData(string statusFilter = "", string emailSearch = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT [Client_ID], [First_Name], [Last_Name], [Email_Address], [Phone_Number], [Client_Status], [Date_Registered] 
                    FROM [GroupPmb2].[dbo].[Client] 
                    WHERE 1=1";

                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        query += " AND [Client_Status] = @Status";
                    }

                    if (!string.IsNullOrEmpty(emailSearch))
                    {
                        query += " AND [Email_Address] LIKE @Email + '%'";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(statusFilter))
                        {
                            cmd.Parameters.AddWithValue("@Status", statusFilter);
                        }

                        if (!string.IsNullOrEmpty(emailSearch))
                        {
                            cmd.Parameters.AddWithValue("@Email", emailSearch);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBookings.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Status Button Handlers & Search

        private void btnActive_Click(object sender, EventArgs e)
        {
            LoadGuestsData("Active", txtSearchEmail.Text.Trim());
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            LoadGuestsData("Inactive", txtSearchEmail.Text.Trim());
        }

        private void btnBlacklisted_Click(object sender, EventArgs e)
        {
            LoadGuestsData("Blacklisted", txtSearchEmail.Text.Trim());
        }

        private void btnArchived_Click(object sender, EventArgs e)
        {
            LoadGuestsData("Archived", txtSearchEmail.Text.Trim());
        }

        private void txtSearchEmail_TextChanged_1(object sender, EventArgs e)
        {
            LoadGuestsData("", txtSearchEmail.Text.Trim());
        }

        #endregion

        #region Registration & Status Validation

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string email = txtEmailAddress.Text.Trim();
            string phone = txtContactNumber.Text.Trim();

            // Check if guest exists under Blacklisted, Archived, or Existing states
            if (!CheckExistingGuestStatus(email, phone))
                return;

            SaveGuest();
        }

        private bool CheckExistingGuestStatus(string email, string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Client_Status FROM [GroupPmb2].[dbo].[Client] WHERE [Email_Address] = @Email OR [Phone_Number] = @Phone";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string status = result.ToString();

                        if (status.Equals("Blacklisted", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("This guest is currently blacklisted and cannot create a new profile.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else if (status.Equals("Archived", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("This profile is archived. Please contact administration to restore it.", "Profile Archived", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("An account with this email address or phone number already exists.", "Existing Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool ValidateInput()
        {
            string firstName = txtFirstName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string phone = txtContactNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageService.Warning("Please complete all required fields.");
                return false;
            }

            if (firstName.Any(char.IsDigit) || surname.Any(char.IsDigit))
            {
                MessageService.Warning("Names may only contain alphabetic characters.");
                return false;
            }

            if (phone.Length != 10 || !phone.All(char.IsDigit))
            {
                MessageService.Warning("Phone number must contain exactly 10 digits.");
                return false;
            }

            return true;
        }

        private void SaveGuest()
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string surname = txtSurname.Text.Trim();
                string email = txtEmailAddress.Text.Trim();
                string address = txtPhysicalAddress.Text.Trim();
                string phone = txtContactNumber.Text.Trim();

                string password = firstName + "@" + phone.Substring(0, 2);
                string clientStatus = "Active";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
                        INSERT INTO [GroupPmb2].[dbo].[Client] 
                        ([First_Name], [Last_Name], [Password], [Email_Address], [Client_Address], [Phone_Number], [Client_Status], [Date_Registered], [Last_Login])
                        VALUES 
                        (@FirstName, @LastName, @Password, @Email, @Address, @Phone, @Status, GETDATE(), NULL);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", surname);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Status", clientStatus);

                        int newClientID = (int)cmd.ExecuteScalar();
                        UserSession.ClientID = newClientID;
                    }
                }

                MessageService.Success("Client account created successfully.");

                ClearFields();
                LoadGuestsData();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageService.Error(ex.Message);
            }
        }

        #endregion

        #region Helpers

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtSurname.Clear();
            txtEmailAddress.Clear();
            txtPhysicalAddress.Clear();
            txtContactNumber.Clear();

            txtFirstName.Focus();
        }

        #endregion

        #region Validation

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)
                        && !char.IsControl(e.KeyChar)
                        && e.KeyChar != ' ';
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)
                        && !char.IsControl(e.KeyChar)
                        && e.KeyChar != ' ';
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)
                        && !char.IsControl(e.KeyChar);
        }

        #endregion

        #region Client Status Updates

        private void UpdateClientStatus(string newStatus)
        {
            if (dgvManageClients.SelectedRows.Count == 0 && dgvManageClients.CurrentRow == null)
            {
                MessageBox.Show("Please select a guest from the grid first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvManageClients.SelectedRows.Count > 0 ? dgvManageClients.SelectedRows[0] : dgvManageClients.CurrentRow;

            if (row.Cells["Client_ID"].Value == null || row.Cells["Email_Address"].Value == null)
            {
                MessageBox.Show("Selected row contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int clientId = Convert.ToInt32(row.Cells["Client_ID"].Value);
            string emailAddress = row.Cells["Email_Address"].Value.ToString();
            DateTime actionTime = DateTime.Now;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE [GroupPmb2].[dbo].[Client] SET [Client_Status] = @Status WHERE [Client_ID] = @ClientID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@ClientID", clientId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Client Status updated to '{newStatus}'.\n\nEmail Address: {emailAddress}\nDateTime: {actionTime:yyyy-MM-dd HH:mm:ss}",
                            "REGAL INN HOTEL - STATUS UPDATED SUCCESSFULLY",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                LoadGuestsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            UpdateClientStatus("Inactive");
        }

        private void btnBlackList_Click(object sender, EventArgs e)
        {
            UpdateClientStatus("Blacklisted");
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            UpdateClientStatus("Archived");
        }

        private void txtManageEmailAddress_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT [Client_ID], [First_Name], [Last_Name], [Email_Address], [Phone_Number], [Client_Status], [Date_Registered] 
                        FROM [GroupPmb2].[dbo].[Client] 
                        WHERE [Email_Address] LIKE @Email + '%'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtManageEmailAddress.Text.Trim());

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvManageClients.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}