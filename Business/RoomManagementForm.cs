using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        {
            taHotelRoom.Fill(codeCraftersDS.Hotel_Room);
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            panel2.BackColor = ColorTranslator.FromHtml("#966919");

            btnAddRoom.BackColor = ColorTranslator.FromHtml("#C99A2E");
           btnAddRoom.ForeColor = Color.White;

           btnClearRoom.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnClearRoom.ForeColor = Color.White;

           btnDeleteRoom.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnDeleteRoom.ForeColor = Color.White;

           btnUpdateRoom.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnUpdateRoom.ForeColor = Color.White;
        }

        private void cmbRoomTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
