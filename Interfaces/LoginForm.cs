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

                    UserSession.Email = row.Email_Address;
                    UserSession.FullName = $"{row.First_Name} {row.Last_Name}";

                    MessageBox.Show(
                        $"Welcome to The Regal Inn.\n\n" +
                        $"Guest: {row.First_Name} {row.Last_Name}\n" +
                        $"Login successful. You may proceed to the main menu.",
                        "Authentication Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    

                    string loginSubject = "The Regal Inn - New Account Login Detected";
                    string loginBody = $@"
                    <div style='font-family: Arial, sans-serif; max-width: 600px; border: 1px solid #dcdcdc; padding: 20px;'>
                        <h2 style='color: #1976D2;'>New Account Login Detected</h2>
                        <p>Hello {row.First_Name} {row.Last_Name},</p>
                        <p>We detected a successful security session sign-in to your Regal Inn profile associated with this account.</p>
                        <hr style='border: 0; border-top: 1px solid #eee;' />
                        <p><b>Account Email Address:</b> {row.Email_Address}</p>
                        <p><b>Login Date & Time:</b> {DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")}</p>
                        <hr style='border: 0; border-top: 1px solid #eee;' />
                        <p style='font-size: 12px; color: #888;'>This is an automated system application security notice. No direct reply is required.</p>
                    </div>";

                    EmailService.SendEmail(row.Email_Address, loginSubject, loginBody);

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

                            string userEmail = userNameTxt.Text.Trim().ToLower();

                            if (ms.Items["reportsToolStripMenuItem"] != null)
                            {
                                if (userEmail.EndsWith("@regalinn.co.za"))
                                {
                                    ms.Items["reportsToolStripMenuItem"].Visible = true;

                                    MessageBox.Show("Welcome back, administrator! Access to managerial reporting dashboards has been granted.",
                                                    "Admin Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    ms.Items["reportsToolStripMenuItem"].Visible = false;
                                }
                            }

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