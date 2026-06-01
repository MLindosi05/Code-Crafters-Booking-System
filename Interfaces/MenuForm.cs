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

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            reportsToolStripMenuItem.Visible = false;
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
            DialogResult confirmLogout = MessageBox.Show(
                "Are you sure you want to terminate your current session?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmLogout == DialogResult.Yes)
            {
                UserSession.Email = null;
                UserSession.FullName = null;

                foreach (Form c in this.MdiChildren)
                {
                    c.Close();
                }

                LoginToolStripMenuItem.Enabled = true;
                signUpToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = false;
                bookingToolStripMenuItem.Enabled = false;

                reportsToolStripMenuItem.Visible = false;

                ToolStripTextBox msTextBox = (ToolStripTextBox)menuStrip1.Items["msTextBox"];
                if (msTextBox != null)
                {
                    msTextBox.Text = "LOGGED OUT";
                    msTextBox.ForeColor = Color.Red;
                }

                MessageBox.Show("You have logged out successfully.", "Session Terminated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingForm Booking = new BookingForm();
            PrepareForm(Booking);
        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserSession.Email != null && UserSession.Email.Trim().ToLower().EndsWith("@regalinn.co.za"))
            {
                ViewBookingForm view = new ViewBookingForm();
                PrepareForm(view);
            }
            else
            {
                MessageBox.Show(
                    "Access denied. Only staff with @regalinn.co.za email can view bookings.",
                    "Permission Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserSession.Email))
            {
                MessageBox.Show("Access Denied. Please authenticate first.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string currentSessionEmail = UserSession.Email.Trim().ToLower();

            if (currentSessionEmail.EndsWith("@regalinn.co.za"))
            {
                ReportsForm analyticsDashboard = new ReportsForm();
                PrepareForm(analyticsDashboard);
            }
            else
            {
                MessageBox.Show("Access Denied. You must be logged in with a corporate '@regalinn.co.za' account to review business analytics summaries.",
                                "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}