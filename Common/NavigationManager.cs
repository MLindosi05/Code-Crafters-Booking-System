using Code_Crafters_Interface_Prototype_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Common
{
    public static class NavigationManager
    {
        public static void OpenForm(Form currentForm, Form nextForm)
        {
            nextForm.Show();
            currentForm.Hide();
        }

        public static void OpenWebsite(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                DialogHelper.ShowError(
                    $"Unable to open:\n\n{url}",
                    "Website");
            }
        }

        public static void OpenDashboard(Form currentForm, string role)
        {
            switch (role)
            {
                case "Administrator":
                    OpenForm(currentForm, new AdminMenuForm());
                    break;

                case "Manager":
                    OpenForm(currentForm, new ManagerMenuForm());
                    break;

            }
        }
    }
}