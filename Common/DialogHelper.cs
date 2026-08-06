using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Common
{
    public static class DialogHelper
    {
        public static void ShowInformation(string message, string title = "Information")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void ShowWarning(string message, string title = "Warning")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static DialogResult Confirm(string message,
                                           string title = "Confirmation")
        {
            return MessageBox.Show(message,
                                   title,
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button2);
        }
    }
}