using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (btndummy.Focus())
            {
                MessageBox.Show($" Welcome To The Regal Inn, {userNameTxt.Text} ");
                Form frm = (Form)Application.OpenForms["MainMenuForm"];
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
                ms.Items["bookingToolStripMenuItem"].Enabled = true;
                ms.Items["logoutToolStripMenuItem"].Enabled = true;
                ms.Items["LoginToolStripMenuItem"].Enabled = false;
                ms.Items["SignUpToolStripMenuItem"].Enabled = false;
                ToolStripTextBox tuser = (ToolStripTextBox)ms.Items["msTextBox"];
                tuser.ForeColor = Color.Green;
                tuser.Text = "Logged in as " + userNameTxt.Text;
                this.Close();
               
            }

            else

            {
                MessageBox.Show(" Provide Correct Login Details");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userNameTxt.Text = "Zanenhlanhla";
            passwordTxt.Text = "Regal112";
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = '*';
        }
    }
}

