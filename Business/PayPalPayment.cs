using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PayPalPayment : Form
    {
        private int _bookingID;

        public PayPalPayment()
        {
            InitializeComponent();
        }

        public PayPalPayment(int bookingID)
        {
            InitializeComponent();
            _bookingID = bookingID;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void PayPalPayment_Load(object sender, EventArgs e)
        {
            label24.BackColor = Color.White;
            label25.BackColor = Color.FromArgb(234, 244, 251);
            label20.ForeColor = Color.FromArgb(85, 85, 85);
            label19.ForeColor = Color.FromArgb(51, 51, 51);

            btnPaypalRedirect.BackColor = Color.FromArgb(0, 112, 186);
            btnPaypalRedirect.ForeColor = Color.White;
            btnPaypalRedirect.FlatStyle = FlatStyle.Flat;
            btnPaypalRedirect.FlatAppearance.BorderSize = 0;

            btnCancel.BackColor = Color.FromArgb(211, 47, 47);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;

            btnProcessPayment.BackColor = Color.FromArgb(0, 48, 135);
            btnProcessPayment.ForeColor = Color.White;
            btnProcessPayment.FlatStyle = FlatStyle.Flat;
            btnProcessPayment.FlatAppearance.BorderSize = 0;


            panel12.BackColor = Color.FromArgb(0, 48, 135);
            label18.ForeColor = Color.White;
            label18.Font = new Font("Segoe UI", 20, FontStyle.Bold);




        }
    }
}