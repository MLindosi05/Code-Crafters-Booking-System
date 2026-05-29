using Code_Crafters_Interface_Prototype_1.Business;
using Code_Crafters_Booking_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
     
        }
        public void PrepareForm(Form form)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            if (form == null || form.IsDisposed)
            {
                return;
            }

            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;
            form.FormBorderStyle = FormBorderStyle.None;

            form.Show();
            form.BringToFront();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)  
            {
                c.Close();
            }
            LoginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            ToolStripTextBox msTextBox  = (ToolStripTextBox)menuStrip1.Items["msTextBox"];
            msTextBox.Text = "LOGGED OUT";
            msTextBox.ForeColor = Color.Red;
            signUpToolStripMenuItem.Enabled = true;
            bookingToolStripMenuItem.Enabled = false;
        }



       
        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccomodationBookingForm Booking = new AccomodationBookingForm();
            PrepareForm(Booking);
        }

       private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookingForm view = new ViewBookingForm();
            PrepareForm(view);
        }

       
        private void MainMenuForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                PB1.SendToBack();
            else
                PB1.BringToFront();


        }

        private void signUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            PrepareForm(signup);
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            PrepareForm(login);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void restaurentBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurentBookingForm restaurentForm = new RestaurentBookingForm();
            PrepareForm(restaurentForm);

        }

    }

}
