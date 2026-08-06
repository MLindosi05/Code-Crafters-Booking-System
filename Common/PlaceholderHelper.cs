using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Common
{
    public static class PlaceholderHelper
    {
        public static void Enter(TextBox txt, string placeholder)
        {
            if (txt.Text == placeholder)
            {
                txt.Clear();
                txt.ForeColor = Color.Black;
            }
        }

        public static void Leave(TextBox txt, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = placeholder;
                txt.ForeColor = Color.Gray;
            }
        }

        public static bool EnablePassword(TextBox usernameTextBox)
        {
            return !string.IsNullOrWhiteSpace(usernameTextBox.Text)
                   && usernameTextBox.Text != "Username";
        }
    }
}