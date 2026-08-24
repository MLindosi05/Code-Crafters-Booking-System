using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class RoomManagementForm : Form
    {
        public RoomManagementForm()
        {
            InitializeComponent();
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {   // Main form background
            this.BackColor = Color.FromArgb(247, 243, 234);
            button1.BackColor = Color.FromArgb(139, 100, 31);
            button1.ForeColor = Color.White;

            // Room information panels
            panel10.BackColor = Color.White;
            panel9.BackColor = Color.White;

            // Headings
            label19.ForeColor = Color.FromArgb(107, 72, 23);
            label5.ForeColor = Color.FromArgb(107, 72, 23);

            // Add New Room button
            button3.BackColor = Color.FromArgb(139, 100, 31);
            button3.ForeColor = Color.White;

            //// Clear button
            //btnClear.BackColor = Color.FromArgb(232, 223, 207);
            //btnClear.ForeColor = Color.FromArgb(74, 50, 24);
            taRoomHotel.Fill(codeCraftersDSTWO.Hotel_Room);
            DataTable dtRooms = codeCraftersDSTWO.Hotel_Room;

            // --- 1. POPULATE COUNTS ---
            lblTotalRooms.Text = dtRooms.Rows.Count.ToString();
            lblAvailableRooms.Text = dtRooms.AsEnumerable().Count(r => r.Field<string>("hotel_room_status") == "Available").ToString();
            lblOccupiedRooms.Text = dtRooms.AsEnumerable().Count(r => r.Field<string>("hotel_room_status") == "Occupied").ToString();
            lblRoomsUnderMaintenance.Text = dtRooms.AsEnumerable().Count(r => r.Field<string>("hotel_room_status") == "Maintenance").ToString();

            // --- 2. MATCHING COLOR THEME (Navy & Gold) ---
            Color navyHeaderColor = Color.FromArgb(16, 44, 87);    // Deep Navy from your table headers
            Color goldAccentColor = Color.FromArgb(212, 160, 23);   // Rich Gold/Mustard from your buttons
            Color darkTextColor = Color.FromArgb(30, 30, 30);

            // Style Title Labels (e.g., TOTAL ROOMS, AVAILABLE ROOMS)
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label lbl)
                {
                    if (lbl.Name.StartsWith("lbl") && (lbl.Name.Contains("Total") || lbl.Name.Contains("Available") || lbl.Name.Contains("Occupied") || lbl.Name.Contains("Maintenance") || lbl.Name.Contains("Under")))
                    {
                        // Check if it's the number or the title text
                        if (lbl.Font.Size > 14) // Assuming numbers have larger fonts
                        {
                            lbl.ForeColor = darkTextColor;
                            lbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
                        }
                        else
                        {
                            lbl.ForeColor = navyHeaderColor;
                            lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                        }
                    }
                }
            }
         
        }

        private void lblTotalRooms_Click(object sender, EventArgs e) { }
        private void lblAvailableRooms_Click(object sender, EventArgs e) { }
        private void lblOccupiedRooms_Click(object sender, EventArgs e) { }
        private void lblRoomsUnderMaintenance_Click(object sender, EventArgs e) { }
        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void tbpViewRooms_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Main form background
            this.BackColor = Color.FromArgb(247, 243, 234);

            // Room information panels
            panel10.BackColor = Color.White;
            panel9.BackColor = Color.White;

            // Headings
            label19.ForeColor = Color.FromArgb(107, 72, 23);
            label5.ForeColor = Color.FromArgb(107, 72, 23);

            // Add New Room button
            button3.BackColor = Color.FromArgb(139, 100, 31);
            button3.ForeColor = Color.White;

            //// Clear button
            //btnClear.BackColor = Color.FromArgb(232, 223, 207);
            //btnClear.ForeColor = Color.FromArgb(74, 50, 24);
        }

        
    }
    
}