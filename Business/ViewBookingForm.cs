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
    public partial class ViewBookingForm : Form
    {
        public ViewBookingForm()
        {
            InitializeComponent();
        }

        private void ViewBookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codeCraftersDS.Booking' table. You can move, or remove it, as needed.
            this.taBookings.Fill(this.codeCraftersDS.Booking);

        }

        private void txtBookingID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                taBookings.Fill(codeCraftersDS.Booking);
            }
            else
            {
                int bookingID;

                if (int.TryParse(txtBookingID.Text, out bookingID) && bookingID > 0)
                {
                    taBookings.FillByBookingID(codeCraftersDS.Booking, bookingID);
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive Booking ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtBookingID.Clear();
                    taBookings.Fill(codeCraftersDS.Booking);
                }
            }
        }
    }
}
