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
            LoadFormIntoPanel(new ReceptionistHomeForm());
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
            

             DialogResult result = MessageBox.Show(
             "Are you sure you want to log out?",
             "Confirm Logout",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2); 

            if (result == DialogResult.Yes)
            {
                    
                Login login = new Login();
                login.Show();

                    
                this.Hide();
            }
                
            
        }

        private void ReceptionistMenuForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            panel1.BackColor = ColorTranslator.FromHtml("#966919");
            panel4.BackColor = ColorTranslator.FromHtml("#966919");

            LoadFormIntoPanel(new ReceptionistHomeForm());
        }

        private void ReceptionistMenuForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                pictureBox1.SendToBack();
            }
            else
            {
                pictureBox1.BringToFront();
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ReceptionistPanel_Paint(object sender, PaintEventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button1.ForeColor = Color.White;

            button2.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button2.ForeColor = Color.White;

            button3.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button3.ForeColor = Color.White;

            button4.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button4.ForeColor = Color.White;

            button5.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button5.ForeColor = Color.White;

           



            button9.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button9.ForeColor = Color.White;
        }
    }
}
