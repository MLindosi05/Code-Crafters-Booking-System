using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Business;
using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

using System.Data;
using System.Linq;

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            passwordTxt.Enabled = false;
            passwordTxt.PasswordChar = '*';
            passwordTxt.UseSystemPasswordChar = false;

            pictureBox2.Visible = true; // Show Password Picture
            pictureBox9.Visible = false; // Hidden Password Picture
        }

        private void Login_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized; //Load full screen/form

            taStaff.Fill(codeCraftersDS.Staff);

            button2.BackColor = Color.FromArgb(235, 130, 60);
            button2.ForeColor = Color.White;

            panel2.BackColor = Color.FromArgb(15, 42, 74); //Dark Navy
            panel5.BackColor = Color.FromArgb(15, 42, 74);
            panel3.BackColor = Color.FromArgb(15, 42, 74);
            panel4.BackColor = Color.FromArgb(15, 42, 74);

            panel1.BackColor = Color.FromArgb(10, 25, 47); //Navy


            Color goldColor = Color.FromArgb(212, 175, 55); // Gold (Text)

            label1.ForeColor = goldColor; 
            label2.ForeColor = goldColor; 
            label3.ForeColor = goldColor; 
            label7.ForeColor = goldColor;

            label4.Text = "ACCOUNT LOGIN";
            label4.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(212, 175, 55);
            label4.TextAlign = ContentAlignment.MiddleCenter;


        }


        public void ResetLoginForm()
        {
            // Clear text and restore placeholders
            userNameTxt.Text = "Username";
            userNameTxt.ForeColor = Color.Gray; // Adjust based on your PlaceholderHelper style

            passwordTxt.Text = "Password";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Enabled = false; // Disable password until username is re-entered

            // Reset eye icons to default hidden state
            pictureBox2.Visible = true;
            pictureBox9.Visible = false;

            // Reset role selection if needed
            if (roleComboBox.Items.Count > 0)
            {
                roleComboBox.SelectedIndex = -1;
            }

            userNameTxt.Focus();
        }

        #region Login


        private void login_Click(object sender, EventArgs e)
        {
            bool loginSuccess = ValidateLogin();

            if (!loginSuccess)
            {
                ResetLoginForm();
            }
            else
            {
                // Handle successful login navigation here
            }
        }

        private bool ValidateLogin()
        {
            string username = userNameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            string selectedRole = roleComboBox.SelectedItem?.ToString();

            // Refreshes data and queries using the form's existing taStaff and codeCraftersDS
            taStaff.Fill(codeCraftersDS.Staff);

            var staffRow = codeCraftersDS.Staff.AsEnumerable().FirstOrDefault(row =>
                row.Field<string>("staff_email") == username &&
                row.Field<string>("staff_Password") == password &&
                row.Field<string>("staff_role") == selectedRole);

            if (staffRow != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid login details, email, or role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Password

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Show password text in plain view
            passwordTxt.PasswordChar = '\0';
            pictureBox2.Visible = false;
            pictureBox9.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Hide password and mask with stars
            passwordTxt.PasswordChar = '*';
            pictureBox2.Visible = true;
            pictureBox9.Visible = false;
        }

        #endregion

        #region Placeholders

        private void userNameTxt_MouseEnter(object sender, EventArgs e)
        {
            PlaceholderHelper.Enter(userNameTxt, "Username");
        }

        private void userNameTxt_MouseLeave(object sender, EventArgs e)
        {
            PlaceholderHelper.Leave(userNameTxt, "Username");
        }

        private void passwordTxt_MouseEnter(object sender, EventArgs e)
        {
            PlaceholderHelper.Enter(passwordTxt, "Password");
        }

        private void passwordTxt_MouseLeave(object sender, EventArgs e)
        {
            PlaceholderHelper.Leave(passwordTxt, "Password");
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            passwordTxt.Enabled =
                PlaceholderHelper.EnablePassword(userNameTxt);
        }

        #endregion

        #region Help

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //HelpService.ToggleDrawer(pnlHelpDrawer);
            new HelpForm().Show();
            Hide();
        }

        

        

        #endregion

        #region Forgot Password

        private void button3_Click(object sender, EventArgs e)
        {
            PasswordResetService.ResetPassword(
                userNameTxt,
                taStaff,
                codeCraftersDS);
        }

        #endregion

        #region Navigation

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationManager.OpenForm(this, new HomeForm());
        }

        private void btnContactSupport_Click(object sender, EventArgs e)
        {
            NavigationManager.OpenWebsite(
                "https://www.regalinn.co.za/support");
        }

        #endregion

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PasswordResetService.ResetPassword(
               userNameTxt,
               taStaff,
               codeCraftersDS);
        }

        private void pnlHelpDrawer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}