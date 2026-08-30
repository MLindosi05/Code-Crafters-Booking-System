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

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.BackColor = Color.FromArgb(235, 130, 43); // Matching orange color
            button1.ForeColor = Color.White;

            this.BackColor = Color.FromArgb(247, 243, 234);
            panel1.BackColor = Color.FromArgb(15, 42, 74);
            panel2.BackColor = Color.FromArgb(15, 42, 74);

            panel3.BackColor = Color.FromArgb(10, 25, 47);
            panel8.BackColor = Color.FromArgb(15, 42, 74);

            panel11.BackColor = Color.FromArgb(15, 42, 74);
            panel12.BackColor = Color.FromArgb(15, 42, 74);



            tabPage1.BackColor = Color.DarkGray;

            panel5.BackColor = Color.FromArgb(250, 243, 221);
            panel6.BackColor = Color.FromArgb(250, 243, 221);
            panel7.BackColor = Color.FromArgb(250, 243, 221);
            panel4.BackColor = Color.FromArgb(250, 243, 221);

            Color regalGold = Color.FromArgb(212, 175, 55);

            lblOccupiedRooms.ForeColor = regalGold;  
            lblRoomsUnderMaintenance.ForeColor = regalGold;  
            lblAvailableRooms.ForeColor = regalGold;
            lblTotalRooms.ForeColor = regalGold;
            
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
            //this.BackColor = Color.FromArgb(247, 243, 234);

        }

        
    }
    
}