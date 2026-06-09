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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

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
    }
}