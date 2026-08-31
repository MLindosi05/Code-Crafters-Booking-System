using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class RoomManagementForm : Form
    {
        private string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";
        private bool isLoaded = false;

        public RoomManagementForm()
        {
            InitializeComponent();
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            ApplyStyling();
            LoadBranches();
            LoadRoomData();

            panel5.BackColor = Color.FromArgb(250, 243, 221);
            panel6.BackColor = Color.FromArgb(250, 243, 221);
            panel7.BackColor = Color.FromArgb(250, 243, 221);
            panel4.BackColor = Color.FromArgb(250, 243, 221);
            panel11.BackColor = Color.FromArgb(15, 42, 74);
            panel12.BackColor = Color.FromArgb(15, 42, 74);
            



        }

        private void ApplyStyling()
        {

            

            this.BackColor = Color.FromArgb(247, 243, 234);

            Color navyHeader = Color.FromArgb(15, 42, 74);
            Color darkNavy = Color.FromArgb(10, 25, 47);
            Color regalGold = Color.FromArgb(212, 175, 55);
            Color accentOrange = Color.FromArgb(235, 130, 43);

            if (panel1 != null) panel1.BackColor = navyHeader;
            if (panel2 != null) panel2.BackColor = navyHeader;
            if (panel3 != null) panel3.BackColor = darkNavy;
            if (panel8 != null) panel8.BackColor = navyHeader;

            if (btnRoomRefresh != null)
            {
                btnRoomRefresh.FlatStyle = FlatStyle.Flat;
                btnRoomRefresh.FlatAppearance.BorderSize = 1;
                btnRoomRefresh.FlatAppearance.BorderColor = Color.White;
                btnRoomRefresh.BackColor = accentOrange;
                btnRoomRefresh.ForeColor = Color.White;
            }

            if (btnRefresh != null)
            {
                btnRefresh.FlatStyle = FlatStyle.Flat;
                btnRefresh.FlatAppearance.BorderSize = 1;
                btnRefresh.FlatAppearance.BorderColor = Color.White;
                btnRefresh.BackColor = accentOrange;
                btnRefresh.ForeColor = Color.White;
            }

            if (lblOccupiedRooms != null) lblOccupiedRooms.ForeColor = regalGold;
            if (lblRoomsUnderMaintenance != null) lblRoomsUnderMaintenance.ForeColor = regalGold;
            if (lblAvailableRooms != null) lblAvailableRooms.ForeColor = regalGold;
            if (lblTotalRooms != null) lblTotalRooms.ForeColor = regalGold;
        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            string selectedBranch = cmbBranches.SelectedItem?.ToString() ?? cmbBranches.Text;
            LoadRoomData(selectedBranch);
        }

        private void cmbBranches_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            string selectedBranch = cmbBranches.SelectedItem?.ToString() ?? cmbBranches.Text;
            LoadRoomData(selectedBranch);
        }

        private void LoadRoomData(string branchName = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Join Hotel_Room with Branch table to filter by the hardcoded Branch Name string
                    string query = @"SELECT r.* FROM Hotel_Room r 
                                     INNER JOIN Branch b ON r.Branch_ID = b.Branch_ID";

                    bool filterByBranch = !string.IsNullOrEmpty(branchName) &&
                                          !branchName.Equals("All", StringComparison.OrdinalIgnoreCase) &&
                                          !branchName.Equals("SELECT BRANCH", StringComparison.OrdinalIgnoreCase);

                    if (filterByBranch)
                    {
                        query += " WHERE b.Branch_Name = @BranchName";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (filterByBranch)
                    {
                        cmd.Parameters.AddWithValue("@BranchName", branchName);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtRooms = new DataTable();
                    da.Fill(dtRooms);

                    dgvViewRooms.DataSource = null;
                    dgvManageRooms.DataSource = null;

                    dgvViewRooms.DataSource = dtRooms;
                    dgvManageRooms.DataSource = dtRooms;

                    UpdateMetrics(dtRooms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateMetrics(DataTable dtRooms)
        {
            int total = dtRooms.Rows.Count;
            int available = dtRooms.AsEnumerable().Count(r => r.Field<string>("hotel_room_status")?.Trim().Equals("Available", StringComparison.OrdinalIgnoreCase) == true);
            int occupied = dtRooms.AsEnumerable().Count(r => r.Field<string>("hotel_room_status")?.Trim().Equals("Occupied", StringComparison.OrdinalIgnoreCase) == true);
            int maintenance = dtRooms.AsEnumerable().Count(r => r.Field<string>("hotel_room_status")?.Trim().Equals("Maintenance", StringComparison.OrdinalIgnoreCase) == true);

            if (lblTotalRooms != null) lblTotalRooms.Text = total.ToString();
            if (lblAvailableRooms != null) lblAvailableRooms.Text = available.ToString();
            if (lblOccupiedRooms != null) lblOccupiedRooms.Text = occupied.ToString();
            if (lblRoomsUnderMaintenance != null) lblRoomsUnderMaintenance.Text = maintenance.ToString();
        }

        private void btnRoomRefresh_Click(object sender, EventArgs e)
        {
            string selectedBranch = cmbBranches.SelectedItem?.ToString() ?? cmbBranches.Text;
            LoadRoomData(selectedBranch);
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];

                txtRoomNo.Text = row.Cells["hotel_room_number"].Value?.ToString() ?? "";
                txtPricePerNight.Text = row.Cells["Hotel_Room_Price"].Value?.ToString() ?? "";
                cmbRoomType.Text = row.Cells["hotel_room_type"].Value?.ToString() ?? "";
                cmbRoomStatus.Text = row.Cells["hotel_room_status"].Value?.ToString() ?? "";
                cmbMaxAdults.Text = row.Cells["Max_Adults"].Value?.ToString() ?? "";
                cmbMaxChild.Text = row.Cells["Max_Children"].Value?.ToString() ?? "";
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Hotel_Room 
                                     SET Hotel_Room_Price = @Price, 
                                         hotel_room_type = @Type, 
                                         hotel_room_status = @Status, 
                                         Max_Adults = @MaxAdults, 
                                         Max_Children = @MaxChildren 
                                     WHERE hotel_room_number = @RoomNo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPricePerNight.Text));
                        cmd.Parameters.AddWithValue("@Type", cmbRoomType.Text);
                        cmd.Parameters.AddWithValue("@Status", cmbRoomStatus.Text);
                        cmd.Parameters.AddWithValue("@MaxAdults", int.Parse(cmbMaxAdults.Text));
                        cmd.Parameters.AddWithValue("@MaxChildren", int.Parse(cmbMaxChild.Text));
                        cmd.Parameters.AddWithValue("@RoomNo", txtRoomNo.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Room details updated successfully in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string selectedBranch = cmbBranches.SelectedItem?.ToString() ?? cmbBranches.Text;
                LoadRoomData(selectedBranch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update room details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}