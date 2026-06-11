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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //private void label6_MouseEnter(object sender, EventArgs e)
        //{
        //    groupBox1.Visible = true;
        //}

        //private void label6_MouseLeave(object sender, EventArgs e)
        //{
        //    groupBox1.Visible = false;
        //}

        //private void groupBox1_MouseHover(object sender, EventArgs e)
        //{
        //    groupBox1.Visible = true;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string aboutMessage =
               "Regal Inn Hotel Booking System\n" +
               "Version 1.0.0\n\n" +
               "Developed by Code Crafters\n" +
               "Copyright © 2026. All Rights Reserved.";

            MessageBox.Show(
                aboutMessage,
                "About Code Crafters Booking System",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contactDetails =
                "Regal Inn Hotels Support Desk\n\n" +
                "📞 Phone: +27 (0) 33 123 4567\n" +
                "✉️ Email: support@regalinn.co.za\n" +
                "📍 Address: 123 Central Street, Pietermaritzburg, South Africa\n\n" +
                "Hours: Monday - Sunday (24/7 Front Desk)";

            MessageBox.Show(
                contactDetails,
                "Contact Regal Inn Support",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void HomePageLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            btnLogin.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnLogin.ForeColor = Color.White;
            


            button1.BackColor= ColorTranslator.FromHtml("#C99A2E");
            button1.ForeColor = Color.White;

            button2.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button2.ForeColor = Color.White;
            panel8.BackColor = ColorTranslator.FromHtml("#966919");
            panel7.BackColor = ColorTranslator.FromHtml("#966919");
           
            panel4.BackColor = ColorTranslator.FromHtml("#966919");
           // panel5.BackColor = ColorTranslator.FromHtml("#F6F4F1");
            panel3.BackColor = ColorTranslator.FromHtml("#966919");
            panel14.BackColor = ColorTranslator.FromHtml("#F6F4F1");
            panel9.BackColor = ColorTranslator.FromHtml("#F6F4F1");
            
            panel11.BackColor = ColorTranslator.FromHtml("#F6F4F1");
            panel12.BackColor = ColorTranslator.FromHtml("#F6F4F1");
            panel13.BackColor = ColorTranslator.FromHtml("#F6F4F1");
            panel15.BackColor = ColorTranslator.FromHtml("#F6F4F1");
            pnlHomePage.BackColor = ColorTranslator.FromHtml("#F8F5F0");


            DateTime now = DateTime.Now;
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            label7.Text = "Date: " + now.ToString("MMMM dd, yyyy");
            label8.Text = "Time: " + now.ToString("h:mm tt") + " " + localZone.StandardName;
        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            SignUpForm SignUp = new SignUpForm();
            SignUp.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}