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
        

        public Login()
        {
            InitializeComponent();
            passwordTxt.Enabled = false;

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

            passwordTxt.UseSystemPasswordChar = true;

            pictureBox9.Visible = false;
            pictureBox2.Visible = true;

            this.WindowState = FormWindowState.Maximized;

            this.taStaff.Fill(this.codeCraftersDS1.Staff);

            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            button2.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
        
            button1.BackColor = ColorTranslator.FromHtml("#C99A2E");
            button1.ForeColor = Color.White;

            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;

            button3.BackColor = ColorTranslator.FromHtml("#C99A2E");

            groupBox1.BackColor = ColorTranslator.FromHtml("#966919");
            pnlLogin.BackColor = ColorTranslator.FromHtml("#F8F5F0");
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

        private void login_Click(object sender, EventArgs e)
        {
            string enteredUsername = userNameTxt.Text.Trim();


            string enteredPassword = passwordTxt.Text.Trim();
            string selectedRole = comboBox1.Text.Trim();

            bool found = false;

            foreach (codeCraftersDS.StaffRow row in codeCraftersDS1.Staff)
            {
                string databaseUsername =
                    (row.staff_email);

                string databasePassword = row.staff_Password.Trim();
                string databaseRole = row.staff_role.Trim();

                if (databaseUsername == enteredUsername &&
                    databasePassword == enteredPassword &&
                    databaseRole == selectedRole)
                {
                    found = true;

                    UserSession.Username = enteredUsername;  
                    UserSession.Email = row.staff_email;
                    UserSession.EmailAddress = row.staff_email;

                    MessageBox.Show($"Welcome to The Regal Inn.\n\n" +
                    $"Staff Member: {row.staff_email} \n" +
                    $"Role: {row.staff_role}\n\n" +
                    $"Login successful. You may proceed.",
                    "Authentication Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    if (databaseRole == "Manager")
                    {
                        new ManagerMenuForm().Show();
                    }
                    else if (databaseRole == "Admin")
                    {
                        new AdminMenuForm().Show();
                    }
                    else if (databaseRole == "Receptionist")
                    {
                        new ReceptionistMenuForm().Show();
                    }

                    
                    this.Hide();
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show(
                    "Invalid username, password, or role selected.\nPlease try again.",
                    "Authentication Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                passwordTxt.Clear();
                passwordTxt.Focus();
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = false;

            pictureBox9.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm homePage = new HomeForm();
            homePage.Show();
            this.Hide();
        }

        private void userNameTxt_MouseEnter(object sender, EventArgs e)
        {
            if (userNameTxt.Text == "Username")
            {
                userNameTxt.Text = "";
                userNameTxt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void userNameTxt_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTxt.Text))
            {
                userNameTxt.Text = "Username";
                userNameTxt.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void passwordTxt_MouseEnter(object sender, EventArgs e)
        {
            if (passwordTxt.Text =="Password")
            {
                passwordTxt.Text = "";
                userNameTxt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void passwordTxt_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                passwordTxt.Text = "Password";
                passwordTxt.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(userNameTxt.Text) && userNameTxt.Text != "Username")
            {
                
                passwordTxt.Enabled = true;
            }
            else
            {
               passwordTxt.Enabled = false;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = true;

            pictureBox9.Visible = false;
            pictureBox2.Visible = true;

           
        }
    
    }
}