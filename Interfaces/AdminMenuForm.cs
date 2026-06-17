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
            LoadFormIntoPanel(new GuestRegistrationForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                LoadFormIntoPanel(new AdminHomeForm());
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

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblLoggedIn.Text = UserSession.Username;

            panel1.BackColor = ColorTranslator.FromHtml("#966919");
            panel2.BackColor = ColorTranslator.FromHtml("#966919");
            adminPanel.BackColor = ColorTranslator.FromHtml("#F9EED8");
            button2.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button2.ForeColor = Color.White;

            button1.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button1.ForeColor = Color.White;

            button2.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button2.ForeColor = Color.White;

            button3.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button3.ForeColor = Color.White;

            button4.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button4.ForeColor = Color.White;

           


            button7.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button7.ForeColor = Color.White;



            button9.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button9.ForeColor = Color.White;

            LoadFormIntoPanel(new AdminHomeForm());

        }

        private void lblLoggedIn_Click(object sender, EventArgs e)
        {

        }
    }
}
