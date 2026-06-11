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
    public partial class ReceptionistMenuForm : Form
    {
        public ReceptionistMenuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ReceptionistPanel.Controls.Count > 0)
            {

                foreach (Control ctrl in ReceptionistPanel.Controls)
                {
                    ctrl.Dispose();
                }
                ReceptionistPanel.Controls.Clear();
            }
        }

        private void LoadFormIntoPanel(Form form)
        {

            ReceptionistPanel.Controls.Clear();


            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            ReceptionistPanel.Controls.Add(form);
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new SignUpForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new BookingForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new PaymentForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ViewBookingForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Login());
        }

        private void ReceptionistMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
