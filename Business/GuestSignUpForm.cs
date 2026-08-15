using Code_Crafters_Interface_Prototype_1.Interfaces;
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
    public partial class GuestSignUpForm : Form
    {
        public GuestSignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign Up successful");

            new Login().Show();
            Hide();
        }
    }
}
