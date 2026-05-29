using Code_Crafters_Interface_Prototype_1;
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.taClient.Fill(this.codeCraftersDS.Client);
            passwordTxt.UseSystemPasswordChar = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (codeCraftersDS.ClientRow row in codeCraftersDS.Client)
            {
                if (row.Email_Address == userNameTxt.Text &&
                    row.Password == passwordTxt.Text)
                {
                    found = true;

                    MessageBox.Show(
                        $"Welcome to The Regal Inn.\n\n" +
                        $"Guest: {row.First_Name} {row.Last_Name}\n" +
                        $"Login successful. You may proceed to the main menu.",
                        "Authentication Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    Form frm = Application.OpenForms["MainMenuForm"];

                    if (frm != null)
                    {
                        MenuStrip ms = frm.Controls["menuStrip1"] as MenuStrip;

                        if (ms != null)
                        {
                            ms.Items["bookingToolStripMenuItem"].Enabled = true;
                            ms.Items["logoutToolStripMenuItem"].Enabled = true;
                            ms.Items["LoginToolStripMenuItem"].Enabled = false;
                            ms.Items["SignUpToolStripMenuItem"].Enabled = false;

                            ToolStripTextBox tuser = ms.Items["msTextBox"] as ToolStripTextBox;

                            if (tuser != null)
                            {
                                tuser.ForeColor = Color.Green;
                                tuser.Text = $"Logged in as {row.First_Name} {row.Last_Name}";
                            }
                        }
                    }

                    this.Close();
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show(
                    "Invalid email address or password.\nPlease verify your credentials and try again.",
                    "Authentication Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = !passwordTxt.UseSystemPasswordChar;
        }
    }
}

