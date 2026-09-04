using Code_Crafters_Interface_Prototype_1.Common;
using Code_Crafters_Interface_Prototype_1.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class StaffManagementForm : Form
    {
        private string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";

        public StaffManagementForm()
        {
            InitializeComponent();
        }

        #region Form Load

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            LoadBranchComboBox();

            btnStaffOnleave.Click += btnStaffOnleave_Click;
            btnStaffSuspended.Click += btnStaffSuspended_Click;
            txtSearchStaffEmail.TextChanged += txtSearchStaffEmail_TextChanged;
            txtManageStaffEmailAddress.TextChanged += txtManageStaffEmailAddress_TextChanged;

            // Load data into both grids on startup
            LoadStaffData();
            LoadManageStaffData();

            panel7.BackColor = Color.FromArgb(15, 42, 74);
            panel3.BackColor = Color.FromArgb(10, 25, 47);
            panel9.BackColor = Color.FromArgb(15, 42, 74);
            panel4.BackColor = Color.FromArgb(10, 25, 47);
            panel2.BackColor = Color.FromArgb(15, 42, 74);

            Color goldColor = Color.FromArgb(212, 175, 55);
            label2.ForeColor = goldColor;
            label5.ForeColor = goldColor;
            label6.ForeColor = goldColor;
            label4.ForeColor = goldColor;
            label1.ForeColor = goldColor;
            lblStaffEmailAddress.ForeColor = goldColor;

            panel8.BackColor = Color.FromArgb(15, 42, 74);
            panel5.BackColor = Color.FromArgb(10, 25, 47);




        }

        private void LoadBranchComboBox()
        {
            // Assuming your combo box is named cmbBranchID (update if named differently)
            if (cmbBranchID != null)
            {
                cmbBranchID.Items.Clear();
                cmbBranchID.Items.AddRange(new string[] { "BR01", "BR02", "BR03", "BR04", "BR05" });
                if (cmbBranchID.Items.Count > 0) cmbBranchID.SelectedIndex = 0;
            }
        }

        private void ApplyTheme()
        {
            BackColor = System.Drawing.Color.FromArgb(242, 244, 247);
            panel2.BackColor = System.Drawing.Color.White;

            ButtonStyler.Apply(btnRegisterStaff);
            ButtonStyler.Apply(btnStaffOnleave);
            ButtonStyler.Apply(btnStaffSuspended);

            ButtonStyler.Apply(btnSuspend);
            ButtonStyler.Apply(btnAuthorize);
            ButtonStyler.Apply(btnActivateStaff);
            ButtonStyler.Apply(btnUpdateStaffPersonalDetails);



            ConfigureDataGridViewTheme();
        }

        private void ConfigureDataGridViewTheme()
        {
            ConfigureSingleGridTheme(dgvStaffs);
            ConfigureSingleGridTheme(dgvManageStaff);
        }

        private void ConfigureSingleGridTheme(DataGridView grid)
        {
            grid.BackgroundColor = System.Drawing.Color.White;
            grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 53, 128);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            grid.ColumnHeadersHeight = 35;

            grid.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            grid.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);

            grid.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 113, 228);
            grid.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            grid.RowTemplate.Height = 28;
        }

        #endregion

        #region Filtering and Grid Loading

        private void LoadStaffData(string statusFilter = "", string emailSearch = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT [staff_ID], [Branch_ID], [staff_First_Name], [staff_Surname], [staff_Email], [staff_phone_number], [staff_role], [staff_status], [date_joined] 
                        FROM [GroupPmb2].[dbo].[Staff] 
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        query += " AND RTRIM([staff_status]) = RTRIM(@Status)";
                    }

                    if (!string.IsNullOrEmpty(emailSearch))
                    {
                        query += " AND [staff_Email] LIKE @Email + '%'";
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
                            dgvStaffs.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading view staff: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadManageStaffData(string emailSearch = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT [staff_ID], [Branch_ID], [staff_First_Name], [staff_Surname], [staff_Email], [staff_phone_number], [staff_role], [staff_status], [date_joined] 
                        FROM [GroupPmb2].[dbo].[Staff] 
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(emailSearch))
                    {
                        query += " AND [staff_Email] LIKE @Email + '%'";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(emailSearch))
                        {
                            cmd.Parameters.AddWithValue("@Email", emailSearch);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvManageStaff.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading manage staff: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Status Button Handlers & Search

        private void btnStaffActive_Click(object sender, EventArgs e)
        {
            LoadStaffData("Active", txtSearchStaffEmail.Text.Trim());
        }

        private void btnStaffInactive_Click(object sender, EventArgs e)
        {
            LoadStaffData("Inactive", txtSearchStaffEmail.Text.Trim());
        }

        private void btnStaffOnleave_Click(object sender, EventArgs e)
        {
            LoadStaffData("On Leave", txtSearchStaffEmail.Text.Trim());
        }

        private void btnStaffSuspended_Click(object sender, EventArgs e)
        {
            LoadStaffData("Suspended", txtSearchStaffEmail.Text.Trim());
        }

        private void txtSearchStaffEmail_TextChanged(object sender, EventArgs e)
        {
            LoadStaffData("", txtSearchStaffEmail.Text.Trim());
        }

        private void txtManageStaffEmailAddress_TextChanged(object sender, EventArgs e)
        {
            LoadManageStaffData(txtManageStaffEmailAddress.Text.Trim());
        }

        #endregion

        #region Registration

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            SaveStaff();
        }

        private bool ValidateInput()
        {
            string firstName = txtStaffName.Text.Trim();
            string surname = txtStaffSurname.Text.Trim();
            string email = txtStaffEmailAddress.Text.Trim();
            string phone = txtStaffContactNumber.Text.Trim();

            if (cmbBranchID.SelectedItem == null ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageService.Warning("Please select a Branch ID and complete all required fields.");
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

        private void SaveStaff()
        {
            try
            {
                string branchId = cmbBranchID.SelectedItem.ToString();
                string firstName = txtStaffName.Text.Trim();
                string surname = txtStaffSurname.Text.Trim();
                string email = txtStaffEmailAddress.Text.Trim();
                string address = txtStaffAddress.Text.Trim();
                string phone = txtStaffContactNumber.Text.Trim();

                using (SqlConnection connCheck = new SqlConnection(connectionString))
                {
                    connCheck.Open();
                    string checkQuery = "SELECT COUNT(*) FROM [GroupPmb2].[dbo].[Staff] WHERE [staff_phone_number] = @Phone";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, connCheck))
                    {
                        cmdCheck.Parameters.AddWithValue("@Phone", phone);
                        int phoneCount = (int)cmdCheck.ExecuteScalar();

                        if (phoneCount > 0)
                        {
                            MessageService.Warning("Staff phone number already exists.");
                            return;
                        }
                    }
                }

                string password = firstName + "@" + phone.Substring(0, 2);
                string staffStatus = "Active";
                string staffRole = email.EndsWith("@regalinn.co.za", StringComparison.OrdinalIgnoreCase) ? "Administrator" : "Manager";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insert into Staff Table
                            string insertStaffQuery = @"
                                INSERT INTO [GroupPmb2].[dbo].[Staff] 
                                ([Branch_ID], [staff_First_Name], [staff_Surname], [staff_Address], [staff_phone_number], [staff_email], [staff_role], [date_joined], [staff_status], [staff_Password], [Failed_Login_Count], [Password_Changed_Date])
                                VALUES 
                                (@BranchID, @FirstName, @LastName, @Address, @Phone, @Email, @Role, GETDATE(), @Status, @Password, NULL, NULL);";

                            using (SqlCommand cmdStaff = new SqlCommand(insertStaffQuery, conn, transaction))
                            {
                                cmdStaff.Parameters.AddWithValue("@BranchID", branchId);
                                cmdStaff.Parameters.AddWithValue("@FirstName", firstName);
                                cmdStaff.Parameters.AddWithValue("@LastName", surname);
                                cmdStaff.Parameters.AddWithValue("@Address", address);
                                cmdStaff.Parameters.AddWithValue("@Phone", phone);
                                cmdStaff.Parameters.AddWithValue("@Email", email);
                                cmdStaff.Parameters.AddWithValue("@Role", staffRole);
                                cmdStaff.Parameters.AddWithValue("@Status", staffStatus);
                                cmdStaff.Parameters.AddWithValue("@Password", password);

                                cmdStaff.ExecuteNonQuery();
                            }

                            // 2. Insert into Client Table (removed [Last_Login] column since it doesn't exist on the Client table)
                            string insertClientQuery = @"
                                INSERT INTO [GroupPmb2].[dbo].[Client] 
                                ([First_Name], [Last_Name], [Password], [Email_Address], [Client_Address], [Phone_Number], [Client_Status], [Date_Registered])
                                VALUES 
                                (@FirstName, @LastName, @Password, @Email, @Address, @Phone, @Status, GETDATE());";

                            using (SqlCommand cmdClient = new SqlCommand(insertClientQuery, conn, transaction))
                            {
                                cmdClient.Parameters.AddWithValue("@FirstName", firstName);
                                cmdClient.Parameters.AddWithValue("@LastName", surname);
                                cmdClient.Parameters.AddWithValue("@Password", password);
                                cmdClient.Parameters.AddWithValue("@Email", email);
                                cmdClient.Parameters.AddWithValue("@Address", address);
                                cmdClient.Parameters.AddWithValue("@Phone", phone);
                                cmdClient.Parameters.AddWithValue("@Status", staffStatus);

                                cmdClient.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageService.Success("Staff account created and added to both staffs and clients successfully.");

                ClearFields();
                LoadStaffData();
                LoadManageStaffData();
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
            if (cmbBranchID.Items.Count > 0) cmbBranchID.SelectedIndex = 0;
            txtStaffName.Clear();
            txtStaffSurname.Clear();
            txtStaffEmailAddress.Clear();
            txtStaffAddress.Clear();
            txtStaffContactNumber.Clear();

            cmbBranchID.Focus();
        }

        #endregion

        #region Management & Status Updates

        private void UpdateStaffStatus(string newStatus)
        {
            if (dgvManageStaff.SelectedRows.Count == 0 && dgvManageStaff.CurrentRow == null)
            {
                MessageBox.Show("Please select a staff member from the grid first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvManageStaff.SelectedRows.Count > 0 ? dgvManageStaff.SelectedRows[0] : dgvManageStaff.CurrentRow;

            if (row.Cells["staff_ID"].Value == null || row.Cells["staff_Email"].Value == null)
            {
                MessageBox.Show("Selected row contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int staffId = Convert.ToInt32(row.Cells["staff_ID"].Value);
            string emailAddress = row.Cells["staff_Email"].Value.ToString();
            DateTime actionTime = DateTime.Now;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE [GroupPmb2].[dbo].[Staff] SET [staff_status] = @Status WHERE [staff_ID] = @StaffID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@StaffID", staffId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Staff Status updated to '{newStatus}'.\n\nEmail Address: {emailAddress}\nDateTime: {actionTime:yyyy-MM-dd HH:mm:ss}",
                        "REGAL INN HOTEL - STAFF STATUS UPDATED",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                LoadStaffData();
                LoadManageStaffData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            UpdateStaffStatus("Suspended");
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            UpdateStaffStatus("On Leave");
        }

        #endregion

        #region Extra Control Event Placeholders

        private void txtStaffName_TextChanged(object sender, EventArgs e) { }
        private void txtStaffSurname_TextChanged(object sender, EventArgs e) { }
        private void txtStaffAddress_TextChanged(object sender, EventArgs e) { }
        private void txtStaffContactNumber_TextChanged(object sender, EventArgs e) { }
        private void txtStaffEmailAddress_TextChanged(object sender, EventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void dgvStaffs_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void dgvManageStaff_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        #endregion

        private void btnActivateStaff_Click(object sender, EventArgs e)
        {
            UpdateStaffStatus("Active");
        }

        private void btnUpdateStaffPersonalDetails_Click(object sender, EventArgs e)
        {
            if (dgvManageStaff.SelectedRows.Count == 0 && dgvManageStaff.CurrentRow == null)
            {
                MessageBox.Show("Please select a staff member from the grid first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvManageStaff.SelectedRows.Count > 0 ? dgvManageStaff.SelectedRows[0] : dgvManageStaff.CurrentRow;

            if (row.Cells["staff_ID"].Value == null)
            {
                MessageBox.Show("Selected row contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int staffId = Convert.ToInt32(row.Cells["staff_ID"].Value);
            string firstName = row.Cells["staff_First_Name"]?.Value?.ToString() ?? "";
            string lastName = row.Cells["staff_Surname"]?.Value?.ToString() ?? "";
            string email = row.Cells["staff_Email"]?.Value?.ToString() ?? "";
            string phone = row.Cells["staff_phone_number"]?.Value?.ToString() ?? "";

            // Fetch address directly from DB since it isn't bound in the default grid load query
            string address = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT [staff_Address] FROM [GroupPmb2].[dbo].[Staff] WHERE [staff_ID] = @StaffID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffId);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            address = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching staff address: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (UpdateStaffDetailsForm updateForm = new UpdateStaffDetailsForm(staffId, firstName, lastName, email, phone, address))
            {
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStaffData();
                    LoadManageStaffData();
                }
            }
        }
    }
}