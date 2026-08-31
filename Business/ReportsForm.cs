using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            this.Shown += ReportsForm_Shown; 
        }

        private async void ReportsForm_Shown(object sender, EventArgs e)
        {
            try
            {
                await wbReports.EnsureCoreWebView2Async(null);
                wbReports.CoreWebView2.Navigate("https://app.powerbi.com/view?r=eyJrIjoiYjMxZDExMjctZTk2MC00YjY1LWEwYjEtOGMzYTE4Nzk4MzgwIiwidCI6IjIyNjgyN2Q2LWE5ZDAtNDcwZC04YzE1LWIxNDZiMDE5MmQ1MSIsImMiOjh9");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing WebView2: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}