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
            taFolioReport.Fill(codeCraftersDS.Folio);
            taRoomAssignmentReport.Fill(codeCraftersDS.Room_Assignment);
            taHotelRoomReport.Fill(codeCraftersDS.Hotel_Room);
            btnRevenueReport.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnRevenueReport.ForeColor = Color.White;
            btnRoomReport.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnRoomReport.ForeColor = Color.White;
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
        }


        private void btnRevenueReport_Click(object sender, EventArgs e)
        {
            rptRevenueAnalysis rpt = new rptRevenueAnalysis();
            rpt.SetDataSource(codeCraftersDS);
            crystalReportViewerRegalInn.ReportSource = rpt;
            crystalReportViewerRegalInn.Refresh();

        }

        private void btnRoomReport_Click(object sender, EventArgs e)
        {
            rptOccupancyReport rpt = new rptOccupancyReport();
            rpt.SetDataSource(codeCraftersDS);
            crystalReportViewerRegalInn.ReportSource = rpt;
            crystalReportViewerRegalInn.Refresh();

        }
    }
}