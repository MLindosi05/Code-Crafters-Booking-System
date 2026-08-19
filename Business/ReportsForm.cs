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
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            taBookingReport.Fill(codeCraftersDS.Booking);
            taClientReport.Fill(codeCraftersDS.Client);
            taBranchReport.Fill(codeCraftersDS.Branch);
            taRoomAssignmentReport.Fill(codeCraftersDS.Room_Assignment);
            taTable.Fill(codeCraftersDS.Restuarant_Table);
            btnRevenueReport.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnRevenueReport.ForeColor = Color.White;
            btnRoomReport.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnRoomReport.ForeColor = Color.White;
            btnTableReport.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnTableReport.ForeColor = Color.White;
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");

        }
        
    }
}