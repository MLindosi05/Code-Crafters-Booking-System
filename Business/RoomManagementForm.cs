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

            panel5.BackColor = Color.FromArgb(250, 243, 221);
            panel6.BackColor = Color.FromArgb(250, 243, 221);
            panel7.BackColor = Color.FromArgb(250, 243, 221);
            panel4.BackColor = Color.FromArgb(250, 243, 221);
            panel12.BackColor = Color.FromArgb(15, 42, 74);

            if (dgvViewRooms != null) dgvViewRooms.CellClick += GridRow_CellClick;

            ResetAndReload();
        }

        private void ApplyStyling()
        {
            this.BackColor = Color.FromArgb(247, 243, 234);

            Color navyHeader = Color.FromArgb(15, 42, 74);
            Color darkNavy = Color.FromArgb(10, 25, 47);
            Color regalGold = Color.FromArgb(212, 175, 55);
            Color accentOrange = Color.FromArgb(235, 130, 43);

            if (panel1 != null) panel1.BackColor = navyHeader;

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

        private void ApplyCombinedFilters()
        {
            if (!isLoaded) return;
            string selectedBranch = cmbBranchName.SelectedItem?.ToString() ?? cmbBranchName.Text;
            string selectedRoomType = cmbHotelRoomType.SelectedItem?.ToString() ?? cmbHotelRoomType.Text;
            LoadRoomData(selectedBranch, selectedRoomType);
        }

        private void cmbBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyCombinedFilters();
        }

        private void cmbBranchName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ApplyCombinedFilters();
        }

        private void cmbHotelRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyCombinedFilters();
        }

        private void cmbHotelRoomType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ApplyCombinedFilters();
        }

        private void LoadRoomData(string branchName = null, string roomType = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT r.* FROM Hotel_Room r 
                                     INNER JOIN Branch b ON r.Branch_ID = b.Branch_ID 
                                     WHERE 1=1";

                    bool filterByBranch = !string.IsNullOrEmpty(branchName) &&
                      !branchName.Equals("All", StringComparison.OrdinalIgnoreCase) &&
                      !branchName.Equals("All Branches", StringComparison.OrdinalIgnoreCase) &&
                      !branchName.Equals("SELECT BRANCH", StringComparison.OrdinalIgnoreCase);

                    bool filterByType = !string.IsNullOrEmpty(roomType) &&
                                        !roomType.Equals("All", StringComparison.OrdinalIgnoreCase) &&
                                        !roomType.Equals("All Rooms", StringComparison.OrdinalIgnoreCase) &&
                                        !roomType.Equals("SELECT ROOM TYPE", StringComparison.OrdinalIgnoreCase);

                    if (filterByBranch)
                    {
                        query += " AND b.Branch_Name = @BranchName";
                    }

                    if (filterByType)
                    {
                        query += " AND r.hotel_room_type LIKE @RoomType";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (filterByBranch)
                    {
                        cmd.Parameters.AddWithValue("@BranchName", branchName);
                    }

                    if (filterByType)
                    {
                        string cleanRoomType = roomType.Replace("Rooms", "").Replace("rooms", "").Trim();
                        cmd.Parameters.AddWithValue("@RoomType", "%" + cleanRoomType + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtRooms = new DataTable();
                    da.Fill(dtRooms);

                    dgvViewRooms.DataSource = null;
                    BindingSource bsView = new BindingSource();
                    bsView.DataSource = dtRooms;
                    dgvViewRooms.DataSource = bsView;

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
            int occupied = dtRooms.AsEnumerable().Count(r => r.Field<string>("hotel_room_status")?.Trim().Equals("Booked", StringComparison.OrdinalIgnoreCase) == true);
            int maintenance = dtRooms.AsEnumerable().Count(r => r.Field<string>("hotel_room_status")?.Trim().Equals("Maintenance", StringComparison.OrdinalIgnoreCase) == true);

            if (lblTotalRooms != null) lblTotalRooms.Text = total.ToString();
            if (lblAvailableRooms != null) lblAvailableRooms.Text = available.ToString();
            if (lblOccupiedRooms != null) lblOccupiedRooms.Text = occupied.ToString();
            if (lblRoomsUnderMaintenance != null) lblRoomsUnderMaintenance.Text = maintenance.ToString();
        }

        private void ResetAndReload()
        {
            isLoaded = false;

            if (cmbBranchName.Items.Count > 0) cmbBranchName.SelectedIndex = 0;
            if (cmbHotelRoomType.Items.Count > 0) cmbHotelRoomType.SelectedIndex = 0;

            isLoaded = true;

            LoadRoomData();
        }

        private void btnRoomRefresh_Click(object sender, EventArgs e)
        {
            ResetAndReload();
        }

        private void GridRow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];

                if (cmbHotelRoomType != null) cmbHotelRoomType.Text = row.Cells["hotel_room_type"].Value?.ToString() ?? "";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetAndReload();
        }
    }
}