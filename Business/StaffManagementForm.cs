using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            taStaff.Fill(codeCraftersDS1.Staff);
        }
    }
}
