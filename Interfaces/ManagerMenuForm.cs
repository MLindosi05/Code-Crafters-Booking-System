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
    public partial class ManagerMenuForm : Form
    {
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void LoadFormIntoPanel(Form form)
        {

            ManagerPanel.Controls.Clear();


            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            ManagerPanel.Controls.Add(form);
            form.Show();
        }

        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            panel1.BackColor = ColorTranslator.FromHtml("#966919");
            panel3.BackColor = ColorTranslator.FromHtml("#966919");
            //panel2.BackColor = ColorTranslator.FromHtml("#966919");
            ManagerPanel.BackColor = ColorTranslator.FromHtml("#F9EED8");
            button2.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button2.ForeColor = Color.White;



            button2.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button2.ForeColor = Color.White;

           
            button4.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button4.ForeColor = Color.White;


            button6.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button6.ForeColor = Color.White;

            button7.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button7.ForeColor = Color.White;

            button8.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button8.ForeColor = Color.White;



            button9.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button9.ForeColor = Color.White;

            LoadFormIntoPanel(new ManagerHomeForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ManagerHomeForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new GuestRegistrationForm());
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

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
    }
}
