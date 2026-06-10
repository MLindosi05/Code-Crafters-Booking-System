using Code_Crafters_Interface_Prototype_1.Business;
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
    public partial class ManagerMenuForm : Form
    {
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void PrepareForm(Form form)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }


        private void vIEWREPORTSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            PrepareForm(reportsForm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
