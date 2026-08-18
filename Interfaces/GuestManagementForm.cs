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

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.codeCraftersDSTWO1.Client);
            ApplyTheme();
            // --- ADD THESE LINES TO HOOK UP THE EVENTS PROGRAMMATICALLY ---
            btnInactive.Click += btnInactive_Click;              // INACTIVE button
            btnBlacklisted.Click += btnBlacklisted_Click;        // BLACKLISTED button
            btnArchived.Click += btnArchived_Click;              // ARCHIVED button
            txtSearchEmail.TextChanged += txtSearchEmail_TextChanged_1; // SEARCH TEXTBOX
                                                                        // -------------------------------------------------------------
            LoadGuestsData();
        }

        private void ApplyTheme()
        {
            BackColor = Theme.Background;

            pnlSignUp.BackColor = Theme.Panel;
            panel2.BackColor = Theme.Panel;
            groupBox4.BackColor = Theme.Brown;

            ButtonStyler.Apply(btnSignUp);
            ButtonStyler.Apply(btnInactive);
        }

        #endregion

        #region Filtering and Grid Loading

        // Universal method to load data based on Status and Email search
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

                    // Append status filter if provided
                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        query += " AND [Client_Status] = @Status";
                    }

                    // Append email filter if text box contains value
                    if (!string.IsNullOrEmpty(emailSearch))
                    {
                        query += " AND [Email_Address] LIKE @Email";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(statusFilter))
                        {
                            cmd.Parameters.AddWithValue("@Status", statusFilter);
                        }

                        if (!string.IsNullOrEmpty(emailSearch))
                        {
                            cmd.Parameters.AddWithValue("@Email", "%" + emailSearch + "%");
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt; // Ensure your DataGridView control name matches your designer (e.g., dataGridView1 or similar)
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageService.Error(ex.Message);
            }
        }     

        #endregion

        #region Registration

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            SaveGuest();
        }

        private bool ValidateInput()
        {
            string firstName = txtName.Text.Trim();
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
                string firstName = txtName.Text.Trim();
                string surname = txtSurname.Text.Trim();
                string email = txtEmailAddress.Text.Trim();
                string address = txtPhysicalAddress.Text.Trim();
                string phone = txtContactNumber.Text.Trim();

                // Check if phone number already exists using direct SqlCommand
                using (SqlConnection connCheck = new SqlConnection(connectionString))
                {
                    connCheck.Open();
                    string checkQuery = "SELECT COUNT(*) FROM [GroupPmb2].[dbo].[Client] WHERE [Phone_Number] = @Phone";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, connCheck))
                    {
                        cmdCheck.Parameters.AddWithValue("@Phone", phone);
                        int phoneCount = (int)cmdCheck.ExecuteScalar();

                        if (phoneCount > 0)
                        {
                            MessageService.Warning("Phone number already exists.");
                            return;
                        }
                    }
                }

                // Password rule: Client Firstname @ (First two digits of phone no.)
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
                LoadGuestsData(); // Refresh grid after new registration
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
            txtName.Clear();
            txtSurname.Clear();
            txtEmailAddress.Clear();
            txtPhysicalAddress.Clear();
            txtContactNumber.Clear();

            txtName.Focus();
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

        #region Navigation

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently under development. Please check back later.", "Feature Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}