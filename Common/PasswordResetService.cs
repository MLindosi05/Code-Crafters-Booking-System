using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public static class PasswordResetService
    {
        public static void ResetPassword(
            TextBox usernameTextBox,
            codeCraftersDSTableAdapters.StaffTableAdapter staffAdapter,
            codeCraftersDS dataSet)
        {
            string email = usernameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || email == "Username")
            {
                MessageBox.Show(
                    "Please enter your staff email first.",
                    "Email Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                usernameTextBox.Focus();
                return;
            }

            var staff = dataSet.Staff
                .AsEnumerable()
                .FirstOrDefault(x =>
                    x.staff_email.Equals(email,
                    StringComparison.OrdinalIgnoreCase));

            if (staff == null)
            {
                MessageBox.Show(
                    "Account not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string enteredId = Interaction.InputBox(
                "Enter your Staff ID.",
                "Verification");

            if (!int.TryParse(enteredId, out int id) ||
                id != staff.staff_ID)
            {
                MessageBox.Show(
                    "Invalid Staff ID.",
                    "Verification Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string newPassword = Interaction.InputBox(
                "Enter your new password.",
                "Password Reset");

            if (string.IsNullOrWhiteSpace(newPassword))
                return;

            if (newPassword.Length < 4)
            {
                MessageBox.Show(
                    "Password must contain at least 4 characters.",
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                staff.staff_Password = newPassword.Trim();

                int rows = staffAdapter.Update(dataSet.Staff);

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Password updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Password could not be saved.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}