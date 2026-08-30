using System;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class RescheduleDialog : Form
    {
        public DateTime NewCheckIn => dtpNewCheckIn.Value;
        public DateTime NewCheckOut => dtpNewCheckOut.Value;

        private DateTimePicker dtpNewCheckIn;
        private DateTimePicker dtpNewCheckOut;
        private Button btnConfirm;
        private Button btnCancel;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private Panel pnlContainer;

        public RescheduleDialog(DateTime currentCheckIn, DateTime currentCheckOut)
        {
            InitializeComponentCustom();

            dtpNewCheckIn.MinDate = DateTime.Today;
            dtpNewCheckIn.Value = currentCheckIn >= DateTime.Today ? currentCheckIn : DateTime.Today;

            dtpNewCheckOut.MinDate = dtpNewCheckIn.Value.AddDays(1);
            dtpNewCheckOut.Value = currentCheckOut > dtpNewCheckIn.Value ? currentCheckOut : dtpNewCheckIn.Value.AddDays(1);
        }

        private void InitializeComponentCustom()
        {
            this.Text = "REGAL INN RESCHEDULE - SELECT NEW BOOKING DATES";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(15, 23, 42);

            pnlContainer = new Panel()
            {
                Size = new Size(480, 280),
                BackColor = Color.FromArgb(10, 25, 47),
                BorderStyle = BorderStyle.FixedSingle
            };
            pnlContainer.Location = new Point((this.ClientSize.Width - pnlContainer.Width) / 2, (this.ClientSize.Height - pnlContainer.Height) / 2);
            this.Resize += (s, e) => {
                pnlContainer.Location = new Point((this.ClientSize.Width - pnlContainer.Width) / 2, (this.ClientSize.Height - pnlContainer.Height) / 2);
            };

            lblCheckIn = new Label() { Text = "NEW CHECK-IN DATE:", ForeColor = Color.White, Font = new Font("Segoe UI", 95f / 10f, FontStyle.Bold), Location = new Point(30, 50), AutoSize = true };
            dtpNewCheckIn = new DateTimePicker() { Format = DateTimePickerFormat.Short, Location = new Point(210, 48), Width = 220, Font = new Font("Segoe UI", 10) };
            dtpNewCheckIn.ValueChanged += DtpNewCheckIn_ValueChanged;

            lblCheckOut = new Label() { Text = "NEW CHECK-OUT DATE:", ForeColor = Color.White, Font = new Font("Segoe UI", 95f / 10f, FontStyle.Bold), Location = new Point(30, 110), AutoSize = true };
            dtpNewCheckOut = new DateTimePicker() { Format = DateTimePickerFormat.Short, Location = new Point(210, 108), Width = 220, Font = new Font("Segoe UI", 10) };

            btnConfirm = new Button() { Text = "CONFIRM", DialogResult = DialogResult.OK, BackColor = Color.FromArgb(0, 113, 228), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(210, 180), Width = 105, Height = 35, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold) };
            btnConfirm.Click += (s, e) => {
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            btnCancel = new Button() { Text = "CANCEL", DialogResult = DialogResult.Cancel, BackColor = Color.FromArgb(220, 53, 69), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(325, 180), Width = 105, Height = 35, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold) };
            btnCancel.Click += (s, e) => {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            pnlContainer.Controls.Add(lblCheckIn);
            pnlContainer.Controls.Add(dtpNewCheckIn);
            pnlContainer.Controls.Add(lblCheckOut);
            pnlContainer.Controls.Add(dtpNewCheckOut);
            pnlContainer.Controls.Add(btnConfirm);
            pnlContainer.Controls.Add(btnCancel);

            this.Controls.Add(pnlContainer);
        }

        private void DtpNewCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dtpNewCheckOut.MinDate = dtpNewCheckIn.Value.AddDays(1);
            if (dtpNewCheckOut.Value <= dtpNewCheckIn.Value)
            {
                dtpNewCheckOut.Value = dtpNewCheckIn.Value.AddDays(1);
            }
        }
    }
}