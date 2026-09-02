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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            panel4.BackColor = Color.FromArgb(15, 42, 74);
            panel5.BackColor = Color.FromArgb(15, 42, 74);

        }
    }
}
