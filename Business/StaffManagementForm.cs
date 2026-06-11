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
    public partial class StaffManagementForm : Form
    {
        public StaffManagementForm()
        {
            InitializeComponent();
        }

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {
            taStaff.Fill(codeCraftersDS.Staff);
            this.BackColor = ColorTranslator.FromHtml("#F9EED8");
            panel1.BackColor = ColorTranslator.FromHtml("#F8F5F0");
            panel3.BackColor = ColorTranslator.FromHtml("#966919");

            btnStaffAdd.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnStaffAdd.ForeColor = Color.White;

           btnStaffClear.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnStaffClear.ForeColor = Color.White;

            btnStaffDelete.BackColor = ColorTranslator.FromHtml("#C99A2E");
           btnStaffDelete.ForeColor = Color.White;

            btnStaffUpdate.BackColor = ColorTranslator.FromHtml("#C99A2E");
            btnStaffUpdate.ForeColor = Color.White;

        }

        private void cmbStaffRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
