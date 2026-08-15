using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Business;
using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            passwordTxt.Enabled = false;
            passwordTxt.UseSystemPasswordChar = true;

            pictureBox2.Visible = true;
            pictureBox9.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            taStaff.Fill(codeCraftersDS.Staff);

            ThemeManager.ApplyLoginTheme(
                this,
                panel1,
                pnlLogin,
                panel3,
                panel4,
                pnlHelpDrawer,
                groupBox1,
                button1,
                button2,
                button3);

            HelpService.LoadTopics(lstHelpTopics);
        }

        #region Login


        private void login_Click(object sender, EventArgs e)
        {
            LoginService.Login(
                this,
                userNameTxt,
                passwordTxt,
                roleComboBox,
                taStaff,
                codeCraftersDS);
        }

        #endregion

        #region Password

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = false;
            pictureBox2.Visible = false;
            pictureBox9.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = true;
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
            HelpService.ToggleDrawer(pnlHelpDrawer);
        }

        private void txtSearchHelp_TextChanged(object sender, EventArgs e)
        {
            HelpService.Search(
                txtSearchHelp.Text,
                lstHelpTopics);
        }

        private void lstHelpTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            HelpService.ShowSolution(lstHelpTopics);
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
            new GuestSignUpForm().Show();
            Hide();
        }
    }
}