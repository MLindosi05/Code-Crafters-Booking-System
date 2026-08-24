using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Business;
using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        #region Form Load

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            lblLoggedIn.Text = UserSession.Username;

            ApplyTheme();

            PanelLoader.Load(adminPanel, new AdminDashboardForm());

            panel1.BackColor = Color.FromArgb(10, 25, 47);
            
            button1.BackColor = Color.FromArgb(15, 42, 74);
            button2.BackColor = Color.FromArgb(15, 42, 74);
            button7.BackColor = Color.FromArgb(15, 42, 74);
            button3.BackColor = Color.FromArgb(15, 42, 74);
            button9.BackColor = Color.FromArgb(15, 42, 74);

        }

        #endregion

        #region Theme

        private void ApplyTheme()
        {
            panel1.BackColor = Theme.Brown;
            panel2.BackColor = Theme.Brown;

            adminPanel.BackColor = Theme.Background;

            ButtonStyler.Apply(button1);
            ButtonStyler.Apply(button2);
            ButtonStyler.Apply(button3);
            ButtonStyler.Apply(button7);
            ButtonStyler.Apply(button9);
        }

        #endregion

        #region Navigation

        private void button1_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(adminPanel, new GuestManagementForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(adminPanel, new AdminDashboardForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(adminPanel, new BookingManagement());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(adminPanel, new StaffManagementForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(adminPanel, new ReportsForm());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(adminPanel, new RoomManagementForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(adminPanel, new StaffManagementForm());
        }

        #endregion

        #region Logout

        private void button9_Click(object sender, EventArgs e)
        {
            if (!MessageService.Confirm("Are you sure you want to log out?"))
                return;

            new Login().Show();
            Hide();
        }

        #endregion

      
    }
}