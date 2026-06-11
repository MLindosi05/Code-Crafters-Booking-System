using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }


        private void LoadFormIntoPanel(Form form)
        {
            
            adminPanel.Controls.Clear();

            
            form.TopLevel = false;                
            form.FormBorderStyle = FormBorderStyle.None;  
            form.Dock = DockStyle.Fill;            

            
            adminPanel.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new SignUpForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                if (adminPanel.Controls.Count > 0)
                {

                    foreach (Control ctrl in adminPanel.Controls)
                    {
                        ctrl.Dispose();
                    }
                    adminPanel.Controls.Clear();
                }

            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new BookingForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ViewBookingForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new PaymentForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ReportsForm());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new RoomManagementForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new StaffManagementForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Login());
        }
    }
}
