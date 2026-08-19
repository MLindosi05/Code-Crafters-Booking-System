using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class RoomManagementForm : Form
    {
        public RoomManagementForm()
        {
            InitializeComponent();
        }

        
        private void txtRoomID_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomID.Text))
            {
                return;
            }

            if (int.TryParse(txtRoomID.Text, out int roomNo))
            {
                taRoomHotel.FillByRoomNo(codeCraftersDSTWO.Hotel_Room, roomNo);
            }
            else
            {
                MessageBox.Show("Please enter a valid positive room number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtRoomID.Clear();
            }

        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            new ADDNewRoomForm().Show();
            Hide();
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'codeCraftersDSTWO.Room_Assignment' table. You can move, or remove it, as needed.
            this.room_AssignmentTableAdapter.Fill(this.codeCraftersDSTWO.Room_Assignment);

            // TODO: This line of code loads data into the 'codeCraftersDS.Hotel_Room' table. You can move, or remove it, as needed.

        }
    }
}