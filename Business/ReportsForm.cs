using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;

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
            CalculateBusinessMetrics();
        }

        private void CalculateBusinessMetrics()
        {
            try
            {
                using (var dynamicQueriesAdapter = new Booking1TableAdapter())
                {
                    DataTable reportData = dynamicQueriesAdapter.GetRevenueReport();

                    dgvReportSummary.DataSource = reportData;
                    dgvReportSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    decimal grandTotalRevenue = 0;

                    foreach (DataRow row in reportData.Rows)
                    {
                        if (row[0] != DBNull.Value)
                        {
                            string status = row[0].ToString().Trim().ToLower();

                            if (status == "confirmed" || status == "checked in" || status == "checked out")
                            {
                                if (row[2] != DBNull.Value)
                                {
                                    grandTotalRevenue += Convert.ToDecimal(row[2]);
                                }
                            }
                        }
                    }

                    txtTotalEnterpriseRevenue.Text = grandTotalRevenue.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Analytical report computation failed:\n\n" + ex.Message,
                                "Reporting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}