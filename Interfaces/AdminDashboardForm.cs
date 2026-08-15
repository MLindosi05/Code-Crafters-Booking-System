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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            LoadLineChartData();
            LoadDonutChartData();
        }



        private void LoadLineChartData()
        {
            // Clear any default sample data
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear(); // Assuming chart2 is second series or light blue line

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            int[] currentYearRevenue = { 10, 15, 38, 30, 32, 40, 40 };
            int[] lastYearRevenue = { 5, 20, 25, 40, 25, 30, 30 };

            // Plot data points (X = Month, Y = Value)
            for (int i = 0; i < months.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY(months[i], currentYearRevenue[i]);
                chart1.Series["Series2"].Points.AddXY(months[i], lastYearRevenue[i]);
            }
        }

        private void LoadDonutChartData()
        {
            chart2.Series["Series1"].Points.Clear();

            // Add slices: Label and Percentage/Value
            chart2.Series["Series1"].Points.AddXY("Q1 (13.1%)", 13.1);
            chart2.Series["Series1"].Points.AddXY("Q2 (28.6%)", 28.6);
            chart2.Series["Series1"].Points.AddXY("Q3 (28.0%)", 28.0);
            chart2.Series["Series1"].Points.AddXY("Q4 (30.3%)", 30.3);
        }







    }
}
