using Code_Crafters_Interface_Prototype_1.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public static class PasswordResetService
    {
        public static void ResetPassword(
     Form parentForm,
     codeCraftersDSTableAdapters.StaffTableAdapter staffAdapter,
     codeCraftersDS dataSet)
        {
            string email = Interaction.InputBox(
                "Enter your staff email.",
                "Email Verification");

            if (string.IsNullOrWhiteSpace(email))
                return;

            email = email.Trim();

            var staff = dataSet.Staff
                .AsEnumerable()
                .FirstOrDefault(x =>
                    x.staff_email.Equals(email,
                    StringComparison.OrdinalIgnoreCase));

            if (staff == null)
            {
                MessageBox.Show(
                    "The email address entered does not exist.",
                    "Account Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            ForgotPasswordForm forgotForm = new ForgotPasswordForm(staff);
            forgotForm.FormClosed += (s, args) => parentForm.Show();
            parentForm.Hide();
            forgotForm.Show();
        }
    }
}