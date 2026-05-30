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
            taClientBranchBooking.Fill(codeCraftersDS.ClientBranchBooking);
               
        }

        private void txtBookingID_TextChanged(object sender, EventArgs e)
        {
            string input = txtBookingID.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                taClientBranchBooking.Fill(codeCraftersDS.ClientBranchBooking);
                return;
            }

            if (!int.TryParse(input, out int bookingID) || bookingID <= 0)
            {
                MessageBox.Show(
                    "No negative numbers, zero, or strings allowed.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtBookingID.Clear();
                taClientBranchBooking.Fill(codeCraftersDS.ClientBranchBooking);
                return;
            }

            taClientBranchBooking.FillByBookingID(codeCraftersDS.ClientBranchBooking, bookingID);
        }
    }
}
