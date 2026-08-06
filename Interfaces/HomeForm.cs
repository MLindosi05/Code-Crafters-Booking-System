using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        #region Form Load

        private void HomePage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            ApplyTheme();
            InitializeClock();
        }

        #endregion

        #region Theme

        private void ApplyTheme()
        {
            BackColor = Theme.Background;

            pnlHomePage.BackColor = Theme.Panel;

            panel3.BackColor = Theme.Brown;
            panel4.BackColor = Theme.Brown;
            panel6.BackColor = Theme.Brown;
            panel7.BackColor = Theme.Brown;
            panel8.BackColor = Theme.Brown;

            panel9.BackColor = Theme.Panel;
            panel11.BackColor = Theme.Panel;
            panel12.BackColor = Theme.Panel;
            panel13.BackColor = Theme.Panel;
            panel14.BackColor = Theme.Panel;
            panel15.BackColor = Theme.Panel;

            ButtonStyler.Apply(btnLogin);
            ButtonStyler.Apply(button1);
            ButtonStyler.Apply(button2);
        }

        #endregion

        #region Clock

        private void InitializeClock()
        {
            timer1.Interval = 1000;
            timer1.Start();

            UpdateClock();
        }

        private void UpdateClock()
        {
            DateTime now = DateTime.Now;

            label7.Text = now.ToString("dd/MM/yyyy");
            label8.Text = now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        #endregion

        #region Navigation

        private void HomePageLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new GuestRegistrationForm().Show();
            Hide();
        }

        #endregion

        #region Information

        private void button1_Click(object sender, EventArgs e)
        {
            string aboutMessage =
                "Regal Inn Hotel Booking System\n" +
                "Version 1.0.0\n\n" +
                "Developed by Code Crafters\n" +
                "Copyright © 2026\n" +
                "All Rights Reserved.";

            MessageService.Information(
                "About Regal Inn Hotel Booking System",
                aboutMessage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contactMessage =
                "Regal Inn Hotels Support Desk\n\n" +
                "Phone : +27 (0) 33 123 4567\n" +
                "Email : support@regalinn.co.za\n" +
                "Address : 123 Central Street,\n" +
                "Pietermaritzburg,\n" +
                "South Africa\n\n" +
                "Support Hours\n" +
                "24 Hours | 7 Days a Week";

            MessageService.Information(
                "Contact Regal Inn",
                contactMessage);
        }

        #endregion
    }
}