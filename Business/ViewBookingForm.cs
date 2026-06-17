using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class ViewBookingForm : Form
    {
        public ViewBookingForm()
        {
            InitializeComponent();
        }

        private void ViewBookingForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            pnlViewBookings.BackColor = ColorTranslator.FromHtml("#966919");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");

            try
            {
                this.taClientBranchTableBooking.Fill(this.codeCraftersDSTWO.ClientBranchTableBooking);
            }
            catch (DataException ex)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                if (this.codeCraftersDSTWO.ClientBranchTableBooking.HasErrors)
                {
                    foreach (DataRow row in this.codeCraftersDSTWO.ClientBranchTableBooking.GetErrors())
                    {
                        sb.AppendLine($"Row Error: {row.RowError}");
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            sb.AppendLine($"--- Column '{col.ColumnName}' failed. Current value: '{row[col]}'");
                        }
                    }
                }

                MessageBox.Show($"Constraint Error Details:\n\n{sb.ToString() ?? ex.Message}",
                                "Dataset Constraint Broken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; 
            }

        }

    

        private void txtBookingID_TextChanged_1(object sender, EventArgs e)
        {
            string input = txtBookingID.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);
                return;
            }

            if (input.StartsWith("-"))
            {
                MessageBox.Show("Negative ID patterns are not allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Clear();
                taClientBranchTableBooking.Fill(codeCraftersDSTWO.ClientBranchTableBooking);
                return;
            }

            taClientBranchTableBooking.FillByFirstName(codeCraftersDSTWO.ClientBranchTableBooking, input);

        }

    }
}