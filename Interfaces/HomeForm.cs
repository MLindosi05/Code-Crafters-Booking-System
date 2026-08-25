using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Drawing;
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

            panel3.BackColor = Color.FromArgb(15, 42, 74);
            panel6.BackColor = Color.FromArgb(15, 42, 74);
            panel8.BackColor = Color.FromArgb(10, 25, 47);
            panel5.BackColor = Color.FromArgb(15, 42, 74);

            panel11.BackColor = Color.FromArgb(250, 243, 221); 
            panel12.BackColor = Color.FromArgb(250, 243, 221);
            panel13.BackColor = Color.FromArgb(250, 243, 221);
            panel14.BackColor = Color.FromArgb(250, 243, 221);
            panel15.BackColor = Color.FromArgb(250, 243, 221);

            label1.ForeColor = Color.FromArgb(26, 26, 26);
            label2.ForeColor = Color.FromArgb(26, 26, 26);
            label3.ForeColor = Color.FromArgb(26, 26, 26);
            label4.ForeColor = Color.FromArgb(26, 26, 26);
            label5.ForeColor = Color.FromArgb(26, 26, 26);

            ButtonStyler.Apply(btnLogin);
            btnLogin.BackColor = Color.FromArgb(235, 130, 60); 
            btnLogin.ForeColor = Color.White;

            ButtonStyler.Apply(button1);
            button1.BackColor = Color.FromArgb(15, 42, 74);
            button1.ForeColor = Color.White;

            ButtonStyler.Apply(button2);
            button2.BackColor = Color.FromArgb(15, 42, 74);
            button2.ForeColor = Color.White;
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
            new GuestManagementForm().Show();
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHomePage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}