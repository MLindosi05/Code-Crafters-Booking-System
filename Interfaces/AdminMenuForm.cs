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
               // MdiChildren.Close(); ;
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

        private void adminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminMenuForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                pictureBox1.SendToBack();
            }
            else
            {
                pictureBox1.BringToFront();
            }
            if (ActiveMdiChild != null)
            {
                label1.SendToBack();
            }
            else
            {
                label1.BringToFront();
            }
            if (ActiveMdiChild != null)
            {
                panel4.SendToBack();
            }
            else
            {
                panel4.BringToFront();
            }



        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#966919");
            panel2.BackColor = ColorTranslator.FromHtml("#966919");
            adminPanel.BackColor = ColorTranslator.FromHtml("#F9EED8");
        }
    }
}
