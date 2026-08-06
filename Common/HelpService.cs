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
            { "How to make a booking?", "Navigate to Booking -> Make Booking to create a reservation." },
            { "Staff access to view bookings", "Only authorised staff can view hotel bookings." },
            { "Generating hotel reports", "Managers and Admins can generate reports." },
            { "How do users change accounts?", "Logout then login using another account." }
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