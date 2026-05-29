namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class AccomodationBookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRoomBooking = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.llbBookingTotalAmount = new System.Windows.Forms.Label();
            this.txtBookingTotalAmount = new System.Windows.Forms.TextBox();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.cmbBranchID = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox4.Controls.Add(this.cmbBranchID);
            this.groupBox4.Controls.Add(this.txtBookingTotalAmount);
            this.groupBox4.Controls.Add(this.llbBookingTotalAmount);
            this.groupBox4.Controls.Add(this.dtpBookingDate);
            this.groupBox4.Controls.Add(this.lblClientID);
            this.groupBox4.Controls.Add(this.dtpCheckOutDate);
            this.groupBox4.Controls.Add(this.dtpCheckInDate);
            this.groupBox4.Controls.Add(this.lblBranchID);
            this.groupBox4.Controls.Add(this.txtClientID);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(40, 39);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(793, 466);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Make Booking";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Location = new System.Drawing.Point(178, 237);
            this.dtpCheckOutDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(270, 24);
            this.dtpCheckOutDate.TabIndex = 22;
            this.dtpCheckOutDate.Value = new System.DateTime(2026, 4, 15, 22, 42, 0, 0);
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Location = new System.Drawing.Point(178, 191);
            this.dtpCheckInDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(270, 24);
            this.dtpCheckInDate.TabIndex = 21;
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Location = new System.Drawing.Point(26, 89);
            this.lblBranchID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(87, 18);
            this.lblBranchID.TabIndex = 19;
            this.lblBranchID.Text = "Branch ID:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(178, 43);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(71, 24);
            this.txtClientID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Check-Out Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Check-In Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Booking Date:";
            // 
            // btnRoomBooking
            // 
            this.btnRoomBooking.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRoomBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomBooking.Location = new System.Drawing.Point(656, 526);
            this.btnRoomBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoomBooking.Name = "btnRoomBooking";
            this.btnRoomBooking.Size = new System.Drawing.Size(177, 31);
            this.btnRoomBooking.TabIndex = 20;
            this.btnRoomBooking.Text = "Make a Booking";
            this.btnRoomBooking.UseVisualStyleBackColor = false;
            this.btnRoomBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(26, 46);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(77, 18);
            this.lblClientID.TabIndex = 23;
            this.lblClientID.Text = "Client ID:";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(178, 139);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(270, 24);
            this.dtpBookingDate.TabIndex = 24;
            // 
            // llbBookingTotalAmount
            // 
            this.llbBookingTotalAmount.AutoSize = true;
            this.llbBookingTotalAmount.Location = new System.Drawing.Point(26, 282);
            this.llbBookingTotalAmount.Name = "llbBookingTotalAmount";
            this.llbBookingTotalAmount.Size = new System.Drawing.Size(113, 18);
            this.llbBookingTotalAmount.TabIndex = 25;
            this.llbBookingTotalAmount.Text = "Total Amount:";
            // 
            // txtBookingTotalAmount
            // 
            this.txtBookingTotalAmount.Location = new System.Drawing.Point(178, 279);
            this.txtBookingTotalAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingTotalAmount.Name = "txtBookingTotalAmount";
            this.txtBookingTotalAmount.Size = new System.Drawing.Size(144, 24);
            this.txtBookingTotalAmount.TabIndex = 26;
            // 
            // codeCraftersDS
            // 
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // cmbBranchID
            // 
            this.cmbBranchID.FormattingEnabled = true;
            this.cmbBranchID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBranchID.Location = new System.Drawing.Point(178, 89);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(121, 25);
            this.cmbBranchID.TabIndex = 27;
            // 
            // AccomodationBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 616);
            this.Controls.Add(this.btnRoomBooking);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccomodationBookingForm";
            this.Text = "MakeBookingForm";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRoomBooking;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.TextBox txtBookingTotalAmount;
        private System.Windows.Forms.Label llbBookingTotalAmount;
        private codeCraftersDS codeCraftersDS;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBooking;
        private System.Windows.Forms.ComboBox cmbBranchID;
    }
}