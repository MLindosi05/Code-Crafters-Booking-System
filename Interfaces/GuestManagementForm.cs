using Code_Crafters_Interface_Prototype_1.Common;
using Code_Crafters_Interface_Prototype_1.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    public partial class GuestManagementForm : Form
    {
        public GuestManagementForm()
        {
            InitializeComponent();
        }

        #region Form Load

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackColor = Theme.Background;

            pnlSignUp.BackColor = Theme.Panel;
            panel2.BackColor = Theme.Panel;
            groupBox4.BackColor = Theme.Brown;

            ButtonStyler.Apply(btnSignUp);
            ButtonStyler.Apply(button1);
        }

        #endregion

        #region Registration

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            SaveGuest();
        }

        private bool ValidateInput()
        {
            string firstName = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string phone = txtContactNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageService.Warning("Please complete all required fields.");
                return false;
            }

            if (firstName.Any(char.IsDigit) || surname.Any(char.IsDigit))
            {
                MessageService.Warning("Names may only contain alphabetic characters.");
                return false;
            }

            if (phone.Length != 10 || !phone.All(char.IsDigit))
            {
                MessageService.Warning("Phone number must contain exactly 10 digits.");
                return false;
            }

            return true;
        }

        private void SaveGuest()
        {
            try
            {
                string firstName = txtName.Text.Trim();
                string surname = txtSurname.Text.Trim();
                string address = txtPhysicalAddress.Text.Trim();
                string phone = txtContactNumber.Text.Trim();

                if (Convert.ToInt32(taClient.CheckPhoneExists(phone)) > 0)
                {
                    MessageService.Warning("Phone number already exists.");
                    return;
                }

                int clientID = Convert.ToInt32(
                    taClient.InsertNewClient(
                        firstName,
                        surname,
                        "",
                        "",
                        address,
                        phone));

                UserSession.ClientID = clientID;

                MessageService.Success("Client account created successfully.");

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageService.Error(ex.Message);
            }
        }

        #endregion

        #region Helpers

        private void ClearFields()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtEmailAddress.Clear();
            txtPhysicalAddress.Clear();
            txtContactNumber.Clear();

            txtName.Focus();
        }

        #endregion

        #region Validation

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)
                        && !char.IsControl(e.KeyChar)
                        && e.KeyChar != ' ';
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)
                        && !char.IsControl(e.KeyChar)
                        && e.KeyChar != ' ';
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)
                        && !char.IsControl(e.KeyChar);
        }

        #endregion

        #region Navigation

        private void button1_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            Close();
        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {
            

        }
    }
}