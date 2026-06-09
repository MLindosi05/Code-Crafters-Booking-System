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

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class Login : Form
    {
        // Add this field to your Login class to hold a reference to the dataset
        private codeCraftersDS codeCraftersDS = new codeCraftersDS();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = true;
        }

        private Dictionary<string, string> helpDatabase = new Dictionary<string, string>()
        {
            { "How to make a booking?", "Navigate to Booking -> Make Booking on the top menu to open the registration wizard." },
            { "Staff access to view bookings", "Only corporate staff accounts registered with a '@regalinn.co.za' email can view active bookings." },
            { "Generating hotel analytics reports", "Go to Reports -> Generate Reports. You must be a corporate user to view these metrics." },
            { "How do users change accounts?", "Click 'Logout' from the menu bar to safely terminate your current session and switch profiles." }
        };

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlHelpDrawer.Visible = !pnlHelpDrawer.Visible;

            if (pnlHelpDrawer.Visible)
            {
                pnlHelpDrawer.BringToFront();

                if (lstHelpTopics.Items.Count == 0)
                {
                    ResetHelpTopics();
                }
            }
        }

        private void ResetHelpTopics()
        {
            lstHelpTopics.Items.Clear();
            foreach (var topic in helpDatabase.Keys)
            {
                lstHelpTopics.Items.Add(topic);
            }
        }

        private void txtSearchHelp_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchHelp.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                ResetHelpTopics();
                return;
            }

            lstHelpTopics.Items.Clear();
            foreach (var topic in helpDatabase.Keys)
            {
                if (topic.ToLower().Contains(keyword))
                {
                    lstHelpTopics.Items.Add(topic);
                }
            }
        }

        private void lstHelpTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHelpTopics.SelectedItem != null)
            {
                string selectedTopic = lstHelpTopics.SelectedItem.ToString();
                string solutionText = helpDatabase[selectedTopic];

                MessageBox.Show(solutionText, selectedTopic, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnContactSupport_Click(object sender, EventArgs e)
        {
            string helpdeskUrl = "https://www.regalinn.co.za/support";

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = helpdeskUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open the website automatically. Please visit: {helpdeskUrl}",
                                "Open Link Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlHelpDrawer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

            bool found = false;

            foreach (codeCraftersDS.ClientRow row in codeCraftersDS1.Client)
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

     
    }
}
