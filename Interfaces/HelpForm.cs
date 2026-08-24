using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }
        private void HelpForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            // Load help topics transferred from Login
            HelpService.LoadTopics(lstHelpTopics);

            // Apply Regal Inn Dark Theme
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackColor = Color.FromArgb(10, 25, 47);

            panel2.BackColor = Color.FromArgb(15, 42, 74);

            //lstHelpTopics.BackColor = Color.FromArgb(20, 50, 85);
            //lstHelpTopics.ForeColor = Color.FromArgb(212, 175, 55); 

            //txtSearchHelp.BackColor = Color.FromArgb(20, 50, 85);
            //txtSearchHelp.ForeColor = Color.White;

            btnContactSupport.BackColor = Color.FromArgb(235, 130, 60);
            btnContactSupport.ForeColor = Color.White;

            button1.BackColor = Color.FromArgb(235, 130, 60);
            button1.ForeColor = Color.White;
        }

        private void txtSearchHelp_TextChanged(object sender, EventArgs e)
        {
            HelpService.Search(txtSearchHelp.Text, lstHelpTopics);
        }

        private void lstHelpTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            HelpService.ShowSolution(lstHelpTopics);
        }

        private void btnContactSupport_Click(object sender, EventArgs e)
        {
            NavigationManager.OpenWebsite("https://www.regalinn.co.za/support");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }
    }
}
