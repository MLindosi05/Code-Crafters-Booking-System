using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.Business;
using Code_Crafters_Interface_Prototype_1.Common;
using System;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    public partial class ManagerMenuForm : Form
    {
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        #region Form Load

        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            lblLoggedIn.Text = UserSession.Username;

            ApplyTheme();

            PanelLoader.Load(ManagerPanel, new ManagerHomeForm());
        }

        #endregion

        #region Theme

        private void ApplyTheme()
        {
            panel1.BackColor = Theme.Brown;
            panel3.BackColor = Theme.Brown;

            ManagerPanel.BackColor = Theme.Background;

            ButtonStyler.Apply(button2);
            ButtonStyler.Apply(button4);
            ButtonStyler.Apply(button6);
            ButtonStyler.Apply(button7);
            ButtonStyler.Apply(button8);
            ButtonStyler.Apply(button9);
        }

        #endregion

        #region Navigation

        private void button1_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(ManagerPanel, new GuestManagementForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(ManagerPanel, new ManagerHomeForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(ManagerPanel, new BookingManagement());
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(ManagerPanel, new PaymentForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(ManagerPanel, new ReportsForm());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(ManagerPanel, new RoomManagementForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PanelLoader.Load(ManagerPanel, new StaffManagementForm());
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

        #region Empty Events

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void lblLoggedIn_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}