using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;
using Code_Crafters_Interface_Prototype_1.Common;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public static class LoginService
    {


        public static codeCraftersDS.StaffRow Authenticate(
            string username,
            string password,
            string role,
            codeCraftersDS dataSet)
        {
            return dataSet.Staff.FirstOrDefault(x =>
                x.staff_email.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) &&
                x.staff_Password.Trim() == password.Trim() &&
                x.staff_role.Trim().Equals(role.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static bool ValidateInputs(
            string username,
            string password,
            string role)
        {
            if (string.IsNullOrWhiteSpace(username) || username == "Username")
                return false;

            if (string.IsNullOrWhiteSpace(password) || password == "Password")
                return false;

            if (string.IsNullOrWhiteSpace(role) || role == "Select Role")
                return false;

            return true;
        }

        public static void CreateSession(codeCraftersDS.StaffRow staff)
        {
            UserSession.Username = staff.staff_email;
            UserSession.Email = staff.staff_email;
            UserSession.EmailAddress = staff.staff_email;

            if (staff.Table.Columns.Contains("staff_role"))
            {
                UserSession.UserRole = staff.staff_role;
            }
        }

        public static bool Login(
            Form loginForm,
            TextBox usernameTxt,
            TextBox passwordTxt,
            ComboBox roleComboBox,
            StaffTableAdapter taStaff,
            codeCraftersDS dataSet)
        {
            string username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            string role = roleComboBox.Text.Trim();

            // 1. Validate Input Controls
            if (!ValidateInputs(username, password, role))
            {
                MessageBox.Show("Please fill in all fields (Username, Password, and Role).",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                // 2. Refresh/Fill Data from Database
                taStaff.Fill(dataSet.Staff);

                // 3. Authenticate User
                codeCraftersDS.StaffRow authenticatedStaff = Authenticate(username, password, role, dataSet);

                if (authenticatedStaff != null)
                {
                    // 4. Create Session
                    CreateSession(authenticatedStaff);

                    MessageBox.Show($"Welcome back, {authenticatedStaff.staff_email}!\nRole: {authenticatedStaff.staff_role}",
                                    "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Open Menu Form based on User Role
                    string userRole = authenticatedStaff.staff_role.Trim();

                    if (userRole.Equals("Administrator", StringComparison.OrdinalIgnoreCase) ||
                        userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        NavigationManager.OpenForm(loginForm, new AdminMenuForm());
                    }
                    else if (userRole.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                    {
                        NavigationManager.OpenForm(loginForm, new ManagerMenuForm());
                    }
                    else
                    {
                        // Default fallback for general staff / receptionist
                        NavigationManager.OpenForm(loginForm, new HomeForm());
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Username, Password, or Role combination. Please try again.",
                                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during authentication: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}