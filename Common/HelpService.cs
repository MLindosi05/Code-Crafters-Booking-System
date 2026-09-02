using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Common
{
    public static class HelpService
    {
        private static readonly Dictionary<string, string> HelpDatabase =
            new Dictionary<string, string>()
        {
    { "Forgotten your password?", "Click the 'Forgot password?' link on the Account login page." +
                    " Enter your username (email), and follow the instructions to reset your credentials." },

    { "Invalid Credentials?", "Ensure you are entering the correct username (email) and password." +
                    " If errors persist, contact your system administrator or manager." },

    { "Role selection guide.", "Select your assigned role (e.g., Administrator, Manager) " +
                    "from the dropdown list on the Account login page before submitting your credentials." }
            };

        public static void LoadTopics(ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (string topic in HelpDatabase.Keys)
                listBox.Items.Add(topic);
        }

        public static void Search(string keyword, ListBox listBox)
        {
            listBox.Items.Clear();

            keyword = keyword.ToLower();

            foreach (var topic in HelpDatabase.Keys)
            {
                if (topic.ToLower().Contains(keyword))
                    listBox.Items.Add(topic);
            }
        }

        public static void ToggleDrawer(Panel panel)
        {
            panel.Visible = !panel.Visible;

            if (panel.Visible)
                panel.BringToFront();
        }

        public static void ShowSolution(ListBox listBox)
        {
            if (listBox.SelectedItem == null)
                return;

            string topic = listBox.SelectedItem.ToString();

            MessageBox.Show(
                HelpDatabase[topic],
                topic,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}