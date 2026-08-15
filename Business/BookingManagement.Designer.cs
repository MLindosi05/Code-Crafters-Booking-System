namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class BookingManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.cmbBranchName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRegalBooking = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpRoomCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpRoomCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numNoOfRooms = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDSTWO = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWO();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restuarantTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.BookingTableAdapter();
            this.taBranch = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.BranchTableAdapter();
            this.taClientBranchTableBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.ClientBranchTableBookingTableAdapter();
            this.taClient = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.ClientTableAdapter();
            this.taFolio = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.FolioTableAdapter();
            this.taHotelRoom = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Hotel_RoomTableAdapter();
            this.taRatePlan = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Rate_PlanTableAdapter();
            this.taRestaurantTable = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Restuarant_TableTableAdapter();
            this.taRoomAssignment = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Room_AssignmentTableAdapter();
            this.taStaff = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.StaffTableAdapter();
            this.taTableAllocation = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Table_AllocationTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlViewBookings = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTotalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberAdultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberChildrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffCreatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlGuestDetails = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchQuery = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnLinkBookings = new System.Windows.Forms.Button();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.btnViewEdit = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTotalAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationReasonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminNotesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberAdultsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberChildrenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialRequestDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffCreatedByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel15 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBooking.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnlViewBookings.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnlGuestDetails.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBooking
            // 
            this.pnlBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBooking.Controls.Add(this.cmbBranchName);
            this.pnlBooking.Controls.Add(this.label9);
            this.pnlBooking.Controls.Add(this.btnRefresh);
            this.pnlBooking.Controls.Add(this.lblRegalBooking);
            this.pnlBooking.Location = new System.Drawing.Point(45, 31);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(1290, 100);
            this.pnlBooking.TabIndex = 0;
            // 
            // cmbBranchName
            // 
            this.cmbBranchName.FormattingEnabled = true;
            this.cmbBranchName.Items.AddRange(new object[] {
            "Pietermaritzburg",
            "Durban Umhlanga",
            "Durban North Beach",
            "Durban Ballito",
            "JHB Midrand"});
            this.cmbBranchName.Location = new System.Drawing.Point(201, 44);
            this.cmbBranchName.Name = "cmbBranchName";
            this.cmbBranchName.Size = new System.Drawing.Size(168, 29);
            this.cmbBranchName.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(12, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "🏨 REGAL INN HOTELS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Location = new System.Drawing.Point(1123, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblRegalBooking
            // 
            this.lblRegalBooking.AutoSize = true;
            this.lblRegalBooking.ForeColor = System.Drawing.Color.Navy;
            this.lblRegalBooking.Location = new System.Drawing.Point(16, 13);
            this.lblRegalBooking.Name = "lblRegalBooking";
            this.lblRegalBooking.Size = new System.Drawing.Size(171, 21);
            this.lblRegalBooking.TabIndex = 1;
            this.lblRegalBooking.Text = "REGAL INN BOOKING";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpRoomCheckIn);
            this.panel1.Controls.Add(this.dtpRoomCheckOut);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(45, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 176);
            this.panel1.TabIndex = 11;
            // 
            // dtpRoomCheckIn
            // 
            this.dtpRoomCheckIn.CustomFormat = "yyyy/MM/dd";
            this.dtpRoomCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRoomCheckIn.Location = new System.Drawing.Point(152, 61);
            this.dtpRoomCheckIn.Name = "dtpRoomCheckIn";
            this.dtpRoomCheckIn.Size = new System.Drawing.Size(129, 29);
            this.dtpRoomCheckIn.TabIndex = 40;
            this.dtpRoomCheckIn.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // dtpRoomCheckOut
            // 
            this.dtpRoomCheckOut.CustomFormat = "yyyy/MM/dd ";
            this.dtpRoomCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRoomCheckOut.Location = new System.Drawing.Point(152, 112);
            this.dtpRoomCheckOut.Name = "dtpRoomCheckOut";
            this.dtpRoomCheckOut.Size = new System.Drawing.Size(129, 29);
            this.dtpRoomCheckOut.TabIndex = 39;
            this.dtpRoomCheckOut.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(18, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 35;
            this.label12.Text = "CHECK-OUT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(18, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "CHECK-IN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 1);
            this.panel3.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "🛏 SELECT DATES";
            // 
            // numNoOfRooms
            // 
            this.numNoOfRooms.Location = new System.Drawing.Point(205, 152);
            this.numNoOfRooms.Name = "numNoOfRooms";
            this.numNoOfRooms.Size = new System.Drawing.Size(85, 29);
            this.numNoOfRooms.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(46, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 37;
            this.label10.Text = "NO. OF ROOMS";
            // 
            // hotelRoomBindingSource
            // 
            this.hotelRoomBindingSource.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource.DataSource = this.codeCraftersDSTWO;
            // 
            // codeCraftersDSTWO
            // 
            this.codeCraftersDSTWO.DataSetName = "codeCraftersDSTWO";
            this.codeCraftersDSTWO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.numChildren);
            this.panel6.Controls.Add(this.numNoOfRooms);
            this.panel6.Controls.Add(this.numAdults);
            this.panel6.Controls.Add(this.lblChildren);
            this.panel6.Controls.Add(this.lblAdults);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label20);
            this.panel6.ForeColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(45, 353);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(328, 211);
            this.panel6.TabIndex = 44;
            // 
            // numChildren
            // 
            this.numChildren.Location = new System.Drawing.Point(205, 104);
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(85, 29);
            this.numChildren.TabIndex = 50;
            // 
            // numAdults
            // 
            this.numAdults.Location = new System.Drawing.Point(205, 61);
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(85, 29);
            this.numAdults.TabIndex = 49;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.ForeColor = System.Drawing.Color.Black;
            this.lblChildren.Location = new System.Drawing.Point(46, 112);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(89, 21);
            this.lblChildren.TabIndex = 40;
            this.lblChildren.Text = "CHILDREN";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.ForeColor = System.Drawing.Color.Black;
            this.lblAdults.Location = new System.Drawing.Point(46, 61);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(70, 21);
            this.lblAdults.TabIndex = 39;
            this.lblAdults.Text = "ADULTS";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Location = new System.Drawing.Point(3, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(650, 1);
            this.panel7.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(192, 21);
            this.label20.TabIndex = 32;
            this.label20.Text = "👤 SELECT OCCUPANCY";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.codeCraftersDSTWO;
            // 
            // restuarantTableBindingSource
            // 
            this.restuarantTableBindingSource.DataMember = "Restuarant_Table";
            this.restuarantTableBindingSource.DataSource = this.codeCraftersDSTWO;
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // taBranch
            // 
            this.taBranch.ClearBeforeFill = true;
            // 
            // taClientBranchTableBooking
            // 
            this.taClientBranchTableBooking.ClearBeforeFill = true;
            // 
            // taClient
            // 
            this.taClient.ClearBeforeFill = true;
            // 
            // taFolio
            // 
            this.taFolio.ClearBeforeFill = true;
            // 
            // taHotelRoom
            // 
            this.taHotelRoom.ClearBeforeFill = true;
            // 
            // taRatePlan
            // 
            this.taRatePlan.ClearBeforeFill = true;
            // 
            // taRestaurantTable
            // 
            this.taRestaurantTable.ClearBeforeFill = true;
            // 
            // taRoomAssignment
            // 
            this.taRoomAssignment.ClearBeforeFill = true;
            // 
            // taStaff
            // 
            this.taStaff.ClearBeforeFill = true;
            // 
            // taTableAllocation
            // 
            this.taTableAllocation.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1429, 1061);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.pnlBooking);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1421, 1027);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MAKE BOOKING";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel16);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel17);
            this.panel4.Controls.Add(this.panel18);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(418, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 872);
            this.panel4.TabIndex = 45;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.button15);
            this.panel16.Controls.Add(this.button7);
            this.panel16.Controls.Add(this.label27);
            this.panel16.Controls.Add(this.label28);
            this.panel16.Controls.Add(this.label29);
            this.panel16.Controls.Add(this.label30);
            this.panel16.Controls.Add(this.label31);
            this.panel16.Controls.Add(this.pictureBox5);
            this.panel16.Location = new System.Drawing.Point(633, 447);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(238, 379);
            this.panel16.TabIndex = 9;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(16, 334);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(76, 27);
            this.button15.TabIndex = 10;
            this.button15.Text = "Amenities";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 286);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 29);
            this.button7.TabIndex = 6;
            this.button7.Text = "BOOK NOW";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(154, 251);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 21);
            this.label27.TabIndex = 5;
            this.label27.Text = "R1,900";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(13, 254);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 17);
            this.label28.TabIndex = 4;
            this.label28.Text = "Max 4 Guests";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(16, 231);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(48, 17);
            this.label29.TabIndex = 3;
            this.label29.Text = "2 Beds";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(15, 205);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 17);
            this.label30.TabIndex = 2;
            this.label30.Text = "1 Bedroom";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(14, 174);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(223, 20);
            this.label31.TabIndex = 1;
            this.label31.Text = "Standard Room 2 Double Beds";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.standard_2_double_beds;
            this.pictureBox5.Location = new System.Drawing.Point(16, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(207, 149);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button12);
            this.panel11.Controls.Add(this.button6);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Controls.Add(this.label23);
            this.panel11.Controls.Add(this.label24);
            this.panel11.Controls.Add(this.label25);
            this.panel11.Controls.Add(this.label26);
            this.panel11.Controls.Add(this.pictureBox4);
            this.panel11.Location = new System.Drawing.Point(633, 34);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(238, 374);
            this.panel11.TabIndex = 2;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(16, 330);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(76, 27);
            this.button12.TabIndex = 8;
            this.button12.Text = "Amenities";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "BOOK NOW";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(154, 251);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 21);
            this.label22.TabIndex = 5;
            this.label22.Text = "R3,000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 254);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 17);
            this.label23.TabIndex = 4;
            this.label23.Text = "Max 4 Guests";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(16, 231);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 17);
            this.label24.TabIndex = 3;
            this.label24.Text = "3 Beds";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(15, 205);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 17);
            this.label25.TabIndex = 2;
            this.label25.Text = "1 Bedroom";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 173);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(217, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Suite Room 1 King/Twin Beds";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.suite3_beds2;
            this.pictureBox4.Location = new System.Drawing.Point(16, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(207, 149);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button14);
            this.panel17.Controls.Add(this.button8);
            this.panel17.Controls.Add(this.label32);
            this.panel17.Controls.Add(this.label33);
            this.panel17.Controls.Add(this.label34);
            this.panel17.Controls.Add(this.label35);
            this.panel17.Controls.Add(this.label36);
            this.panel17.Controls.Add(this.pictureBox6);
            this.panel17.Location = new System.Drawing.Point(345, 447);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(238, 379);
            this.panel17.TabIndex = 8;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(16, 334);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(76, 27);
            this.button14.TabIndex = 10;
            this.button14.Text = "Amenities";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(16, 286);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(205, 29);
            this.button8.TabIndex = 6;
            this.button8.Text = "BOOK NOW";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(154, 251);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 21);
            this.label32.TabIndex = 5;
            this.label32.Text = "R2,300";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(13, 254);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(90, 17);
            this.label33.TabIndex = 4;
            this.label33.Text = "Max 2 Guests";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(16, 231);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 17);
            this.label34.TabIndex = 3;
            this.label34.Text = "1 Bed";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(15, 205);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(73, 17);
            this.label35.TabIndex = 2;
            this.label35.Text = "1 Bedroom";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(15, 174);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(183, 20);
            this.label36.TabIndex = 1;
            this.label36.Text = "Deluxe Room 1 King Bed";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.deluxe_1_king;
            this.pictureBox6.Location = new System.Drawing.Point(16, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(207, 149);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.button13);
            this.panel18.Controls.Add(this.button9);
            this.panel18.Controls.Add(this.label37);
            this.panel18.Controls.Add(this.label38);
            this.panel18.Controls.Add(this.label39);
            this.panel18.Controls.Add(this.label40);
            this.panel18.Controls.Add(this.label41);
            this.panel18.Controls.Add(this.pictureBox7);
            this.panel18.Location = new System.Drawing.Point(43, 447);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(238, 379);
            this.panel18.TabIndex = 7;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(19, 334);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(76, 27);
            this.button13.TabIndex = 10;
            this.button13.Text = "Amenities";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(16, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(205, 29);
            this.button9.TabIndex = 6;
            this.button9.Text = "BOOK NOW";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(154, 251);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 21);
            this.label37.TabIndex = 5;
            this.label37.Text = "R2,100";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(13, 254);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 17);
            this.label38.TabIndex = 4;
            this.label38.Text = "Max 2 Guests";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(16, 231);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(40, 17);
            this.label39.TabIndex = 3;
            this.label39.Text = "1 Bed";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(15, 205);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(73, 17);
            this.label40.TabIndex = 2;
            this.label40.Text = "1 Bedroom";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(15, 174);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(201, 20);
            this.label41.TabIndex = 1;
            this.label41.Text = "Executive Room 1 King Bed";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.executive;
            this.pictureBox7.Location = new System.Drawing.Point(16, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(207, 149);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button11);
            this.panel10.Controls.Add(this.button5);
            this.panel10.Controls.Add(this.label15);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.label18);
            this.panel10.Controls.Add(this.label19);
            this.panel10.Controls.Add(this.pictureBox3);
            this.panel10.Location = new System.Drawing.Point(345, 33);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(238, 375);
            this.panel10.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(18, 332);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(76, 27);
            this.button11.TabIndex = 8;
            this.button11.Text = "Amenities";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "BOOK NOW";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 21);
            this.label15.TabIndex = 5;
            this.label15.Text = "R2,700";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Max 4 Guests";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "2 Beds";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "1 Bedroom";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Suite Room Twin Beds";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.suite_twin_beds1;
            this.pictureBox3.Location = new System.Drawing.Point(16, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(207, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(43, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 375);
            this.panel5.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(16, 331);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 27);
            this.button10.TabIndex = 7;
            this.button10.Text = "Amenities";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "BOOK NOW";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "R1,600";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Max 2 Guests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "1 Bed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "1 Bedroom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Standard Room 1 King Bed";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Standard_king_bed;
            this.pictureBox2.Location = new System.Drawing.Point(16, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlViewBookings);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1421, 1027);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VIEW BOOKINGS";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pnlViewBookings
            // 
            this.pnlViewBookings.AutoScroll = true;
            this.pnlViewBookings.Controls.Add(this.button3);
            this.pnlViewBookings.Controls.Add(this.button2);
            this.pnlViewBookings.Controls.Add(this.button1);
            this.pnlViewBookings.Controls.Add(this.panel12);
            this.pnlViewBookings.Controls.Add(this.panel13);
            this.pnlViewBookings.Controls.Add(this.dgvBookings);
            this.pnlViewBookings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlViewBookings.Location = new System.Drawing.Point(32, 34);
            this.pnlViewBookings.Name = "pnlViewBookings";
            this.pnlViewBookings.Size = new System.Drawing.Size(1389, 497);
            this.pnlViewBookings.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cancelled Bookings";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Future Bookings";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Current Bookings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Location = new System.Drawing.Point(21, 31);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(275, 193);
            this.panel12.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.booking_hotel;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel13.Controls.Add(this.lblBookingID);
            this.panel13.Controls.Add(this.txtBookingID);
            this.panel13.Location = new System.Drawing.Point(387, 31);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(368, 64);
            this.panel13.TabIndex = 7;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(12, 21);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(179, 17);
            this.lblBookingID.TabIndex = 2;
            this.lblBookingID.Text = "ENTER CLIENT FIRST NAME:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(197, 18);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(163, 25);
            this.txtBookingID.TabIndex = 1;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoGenerateColumns = false;
            this.dgvBookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.checkinDateDataGridViewTextBoxColumn,
            this.checkoutDateDataGridViewTextBoxColumn,
            this.bookingTotalAmountDataGridViewTextBoxColumn,
            this.bookingStatusDataGridViewTextBoxColumn,
            this.cancellationDateDataGridViewTextBoxColumn,
            this.cancellationReasonDataGridViewTextBoxColumn,
            this.adminNotesDataGridViewTextBoxColumn,
            this.numberAdultsDataGridViewTextBoxColumn,
            this.numberChildrenDataGridViewTextBoxColumn,
            this.bookingTypeDataGridViewTextBoxColumn,
            this.specialRequestDataGridViewTextBoxColumn,
            this.penaltyAmountDataGridViewTextBoxColumn,
            this.creditAmountDataGridViewTextBoxColumn,
            this.staffCreatedByDataGridViewTextBoxColumn});
            this.dgvBookings.DataSource = this.bookingBindingSource;
            this.dgvBookings.Location = new System.Drawing.Point(21, 268);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.Size = new System.Drawing.Size(1342, 168);
            this.dgvBookings.TabIndex = 0;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // checkinDateDataGridViewTextBoxColumn
            // 
            this.checkinDateDataGridViewTextBoxColumn.DataPropertyName = "Checkin_Date";
            this.checkinDateDataGridViewTextBoxColumn.HeaderText = "Checkin_Date";
            this.checkinDateDataGridViewTextBoxColumn.Name = "checkinDateDataGridViewTextBoxColumn";
            // 
            // checkoutDateDataGridViewTextBoxColumn
            // 
            this.checkoutDateDataGridViewTextBoxColumn.DataPropertyName = "Checkout_Date";
            this.checkoutDateDataGridViewTextBoxColumn.HeaderText = "Checkout_Date";
            this.checkoutDateDataGridViewTextBoxColumn.Name = "checkoutDateDataGridViewTextBoxColumn";
            // 
            // bookingTotalAmountDataGridViewTextBoxColumn
            // 
            this.bookingTotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Booking_Total_Amount";
            this.bookingTotalAmountDataGridViewTextBoxColumn.HeaderText = "Booking_Total_Amount";
            this.bookingTotalAmountDataGridViewTextBoxColumn.Name = "bookingTotalAmountDataGridViewTextBoxColumn";
            // 
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            // 
            // cancellationDateDataGridViewTextBoxColumn
            // 
            this.cancellationDateDataGridViewTextBoxColumn.DataPropertyName = "Cancellation_Date";
            this.cancellationDateDataGridViewTextBoxColumn.HeaderText = "Cancellation_Date";
            this.cancellationDateDataGridViewTextBoxColumn.Name = "cancellationDateDataGridViewTextBoxColumn";
            // 
            // cancellationReasonDataGridViewTextBoxColumn
            // 
            this.cancellationReasonDataGridViewTextBoxColumn.DataPropertyName = "Cancellation_Reason";
            this.cancellationReasonDataGridViewTextBoxColumn.HeaderText = "Cancellation_Reason";
            this.cancellationReasonDataGridViewTextBoxColumn.Name = "cancellationReasonDataGridViewTextBoxColumn";
            // 
            // adminNotesDataGridViewTextBoxColumn
            // 
            this.adminNotesDataGridViewTextBoxColumn.DataPropertyName = "Admin_Notes";
            this.adminNotesDataGridViewTextBoxColumn.HeaderText = "Admin_Notes";
            this.adminNotesDataGridViewTextBoxColumn.Name = "adminNotesDataGridViewTextBoxColumn";
            // 
            // numberAdultsDataGridViewTextBoxColumn
            // 
            this.numberAdultsDataGridViewTextBoxColumn.DataPropertyName = "Number_Adults";
            this.numberAdultsDataGridViewTextBoxColumn.HeaderText = "Number_Adults";
            this.numberAdultsDataGridViewTextBoxColumn.Name = "numberAdultsDataGridViewTextBoxColumn";
            // 
            // numberChildrenDataGridViewTextBoxColumn
            // 
            this.numberChildrenDataGridViewTextBoxColumn.DataPropertyName = "Number_Children";
            this.numberChildrenDataGridViewTextBoxColumn.HeaderText = "Number_Children";
            this.numberChildrenDataGridViewTextBoxColumn.Name = "numberChildrenDataGridViewTextBoxColumn";
            // 
            // bookingTypeDataGridViewTextBoxColumn
            // 
            this.bookingTypeDataGridViewTextBoxColumn.DataPropertyName = "Booking_Type";
            this.bookingTypeDataGridViewTextBoxColumn.HeaderText = "Booking_Type";
            this.bookingTypeDataGridViewTextBoxColumn.Name = "bookingTypeDataGridViewTextBoxColumn";
            // 
            // specialRequestDataGridViewTextBoxColumn
            // 
            this.specialRequestDataGridViewTextBoxColumn.DataPropertyName = "Special_Request";
            this.specialRequestDataGridViewTextBoxColumn.HeaderText = "Special_Request";
            this.specialRequestDataGridViewTextBoxColumn.Name = "specialRequestDataGridViewTextBoxColumn";
            // 
            // penaltyAmountDataGridViewTextBoxColumn
            // 
            this.penaltyAmountDataGridViewTextBoxColumn.DataPropertyName = "Penalty_Amount";
            this.penaltyAmountDataGridViewTextBoxColumn.HeaderText = "Penalty_Amount";
            this.penaltyAmountDataGridViewTextBoxColumn.Name = "penaltyAmountDataGridViewTextBoxColumn";
            // 
            // creditAmountDataGridViewTextBoxColumn
            // 
            this.creditAmountDataGridViewTextBoxColumn.DataPropertyName = "Credit_Amount";
            this.creditAmountDataGridViewTextBoxColumn.HeaderText = "Credit_Amount";
            this.creditAmountDataGridViewTextBoxColumn.Name = "creditAmountDataGridViewTextBoxColumn";
            // 
            // staffCreatedByDataGridViewTextBoxColumn
            // 
            this.staffCreatedByDataGridViewTextBoxColumn.DataPropertyName = "Staff_Created_By";
            this.staffCreatedByDataGridViewTextBoxColumn.HeaderText = "Staff_Created_By";
            this.staffCreatedByDataGridViewTextBoxColumn.Name = "staffCreatedByDataGridViewTextBoxColumn";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.codeCraftersDSTWO;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlGuestDetails);
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.panel14);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1421, 1027);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MANAGE BOOKINGS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlGuestDetails
            // 
            this.pnlGuestDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGuestDetails.Controls.Add(this.panel2);
            this.pnlGuestDetails.Controls.Add(this.label7);
            this.pnlGuestDetails.Controls.Add(this.btnClear);
            this.pnlGuestDetails.Controls.Add(this.btnSearch);
            this.pnlGuestDetails.Controls.Add(this.txtSearchQuery);
            this.pnlGuestDetails.Controls.Add(this.cmbSearchBy);
            this.pnlGuestDetails.Controls.Add(this.label5);
            this.pnlGuestDetails.Controls.Add(this.label6);
            this.pnlGuestDetails.ForeColor = System.Drawing.Color.Navy;
            this.pnlGuestDetails.Location = new System.Drawing.Point(63, 45);
            this.pnlGuestDetails.Name = "pnlGuestDetails";
            this.pnlGuestDetails.Size = new System.Drawing.Size(529, 254);
            this.pnlGuestDetails.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(1, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 1);
            this.panel2.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "🔍 SEARCH BOOKINGS";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(213, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 56);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "🧹 CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(30, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 56);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "🔍 SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Location = new System.Drawing.Point(213, 107);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(155, 29);
            this.txtSearchQuery.TabIndex = 25;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(30, 107);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(153, 29);
            this.cmbSearchBy.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(208, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "SEARCH QUERY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "SEARCH BY";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnCancelBooking);
            this.panel8.Controls.Add(this.btnLinkBookings);
            this.panel8.Controls.Add(this.btnReschedule);
            this.panel8.Controls.Add(this.btnViewEdit);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label21);
            this.panel8.ForeColor = System.Drawing.Color.Navy;
            this.panel8.Location = new System.Drawing.Point(627, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(569, 254);
            this.panel8.TabIndex = 55;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.Red;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(325, 154);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(201, 65);
            this.btnCancelBooking.TabIndex = 37;
            this.btnCancelBooking.Text = "❌ CANCEL BOOKING";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            // 
            // btnLinkBookings
            // 
            this.btnLinkBookings.BackColor = System.Drawing.Color.Purple;
            this.btnLinkBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkBookings.ForeColor = System.Drawing.Color.White;
            this.btnLinkBookings.Location = new System.Drawing.Point(42, 154);
            this.btnLinkBookings.Name = "btnLinkBookings";
            this.btnLinkBookings.Size = new System.Drawing.Size(228, 65);
            this.btnLinkBookings.TabIndex = 36;
            this.btnLinkBookings.Text = "🔗 LINK BOOKINGS";
            this.btnLinkBookings.UseVisualStyleBackColor = false;
            // 
            // btnReschedule
            // 
            this.btnReschedule.BackColor = System.Drawing.Color.Orange;
            this.btnReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReschedule.ForeColor = System.Drawing.Color.White;
            this.btnReschedule.Location = new System.Drawing.Point(325, 52);
            this.btnReschedule.Name = "btnReschedule";
            this.btnReschedule.Size = new System.Drawing.Size(201, 65);
            this.btnReschedule.TabIndex = 35;
            this.btnReschedule.Text = "📅 RESCHEDULE";
            this.btnReschedule.UseVisualStyleBackColor = false;
            // 
            // btnViewEdit
            // 
            this.btnViewEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEdit.ForeColor = System.Drawing.Color.White;
            this.btnViewEdit.Location = new System.Drawing.Point(42, 52);
            this.btnViewEdit.Name = "btnViewEdit";
            this.btnViewEdit.Size = new System.Drawing.Size(228, 65);
            this.btnViewEdit.TabIndex = 34;
            this.btnViewEdit.Text = "👁 EDIT BOOKING";
            this.btnViewEdit.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.panel9.Location = new System.Drawing.Point(0, 30);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1062, 1);
            this.panel9.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 21);
            this.label21.TabIndex = 32;
            this.label21.Text = "⚡ ACTIONS";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.dataGridView1);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.label1);
            this.panel14.ForeColor = System.Drawing.Color.Navy;
            this.panel14.Location = new System.Drawing.Point(65, 335);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1131, 242);
            this.panel14.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn1,
            this.clientIDDataGridViewTextBoxColumn1,
            this.branchIDDataGridViewTextBoxColumn1,
            this.bookingDateDataGridViewTextBoxColumn1,
            this.checkinDateDataGridViewTextBoxColumn1,
            this.checkoutDateDataGridViewTextBoxColumn1,
            this.bookingTotalAmountDataGridViewTextBoxColumn1,
            this.bookingStatusDataGridViewTextBoxColumn1,
            this.cancellationDateDataGridViewTextBoxColumn1,
            this.cancellationReasonDataGridViewTextBoxColumn1,
            this.adminNotesDataGridViewTextBoxColumn1,
            this.numberAdultsDataGridViewTextBoxColumn1,
            this.numberChildrenDataGridViewTextBoxColumn1,
            this.bookingTypeDataGridViewTextBoxColumn1,
            this.specialRequestDataGridViewTextBoxColumn1,
            this.penaltyAmountDataGridViewTextBoxColumn1,
            this.creditAmountDataGridViewTextBoxColumn1,
            this.staffCreatedByDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bookingBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(20, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1459, 163);
            this.dataGridView1.TabIndex = 34;
            // 
            // bookingIDDataGridViewTextBoxColumn1
            // 
            this.bookingIDDataGridViewTextBoxColumn1.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn1.HeaderText = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn1.Name = "bookingIDDataGridViewTextBoxColumn1";
            this.bookingIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            // 
            // branchIDDataGridViewTextBoxColumn1
            // 
            this.branchIDDataGridViewTextBoxColumn1.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn1.HeaderText = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn1.Name = "branchIDDataGridViewTextBoxColumn1";
            // 
            // bookingDateDataGridViewTextBoxColumn1
            // 
            this.bookingDateDataGridViewTextBoxColumn1.DataPropertyName = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn1.HeaderText = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn1.Name = "bookingDateDataGridViewTextBoxColumn1";
            // 
            // checkinDateDataGridViewTextBoxColumn1
            // 
            this.checkinDateDataGridViewTextBoxColumn1.DataPropertyName = "Checkin_Date";
            this.checkinDateDataGridViewTextBoxColumn1.HeaderText = "Checkin_Date";
            this.checkinDateDataGridViewTextBoxColumn1.Name = "checkinDateDataGridViewTextBoxColumn1";
            // 
            // checkoutDateDataGridViewTextBoxColumn1
            // 
            this.checkoutDateDataGridViewTextBoxColumn1.DataPropertyName = "Checkout_Date";
            this.checkoutDateDataGridViewTextBoxColumn1.HeaderText = "Checkout_Date";
            this.checkoutDateDataGridViewTextBoxColumn1.Name = "checkoutDateDataGridViewTextBoxColumn1";
            // 
            // bookingTotalAmountDataGridViewTextBoxColumn1
            // 
            this.bookingTotalAmountDataGridViewTextBoxColumn1.DataPropertyName = "Booking_Total_Amount";
            this.bookingTotalAmountDataGridViewTextBoxColumn1.HeaderText = "Booking_Total_Amount";
            this.bookingTotalAmountDataGridViewTextBoxColumn1.Name = "bookingTotalAmountDataGridViewTextBoxColumn1";
            // 
            // bookingStatusDataGridViewTextBoxColumn1
            // 
            this.bookingStatusDataGridViewTextBoxColumn1.DataPropertyName = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn1.HeaderText = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn1.Name = "bookingStatusDataGridViewTextBoxColumn1";
            // 
            // cancellationDateDataGridViewTextBoxColumn1
            // 
            this.cancellationDateDataGridViewTextBoxColumn1.DataPropertyName = "Cancellation_Date";
            this.cancellationDateDataGridViewTextBoxColumn1.HeaderText = "Cancellation_Date";
            this.cancellationDateDataGridViewTextBoxColumn1.Name = "cancellationDateDataGridViewTextBoxColumn1";
            // 
            // cancellationReasonDataGridViewTextBoxColumn1
            // 
            this.cancellationReasonDataGridViewTextBoxColumn1.DataPropertyName = "Cancellation_Reason";
            this.cancellationReasonDataGridViewTextBoxColumn1.HeaderText = "Cancellation_Reason";
            this.cancellationReasonDataGridViewTextBoxColumn1.Name = "cancellationReasonDataGridViewTextBoxColumn1";
            // 
            // adminNotesDataGridViewTextBoxColumn1
            // 
            this.adminNotesDataGridViewTextBoxColumn1.DataPropertyName = "Admin_Notes";
            this.adminNotesDataGridViewTextBoxColumn1.HeaderText = "Admin_Notes";
            this.adminNotesDataGridViewTextBoxColumn1.Name = "adminNotesDataGridViewTextBoxColumn1";
            // 
            // numberAdultsDataGridViewTextBoxColumn1
            // 
            this.numberAdultsDataGridViewTextBoxColumn1.DataPropertyName = "Number_Adults";
            this.numberAdultsDataGridViewTextBoxColumn1.HeaderText = "Number_Adults";
            this.numberAdultsDataGridViewTextBoxColumn1.Name = "numberAdultsDataGridViewTextBoxColumn1";
            // 
            // numberChildrenDataGridViewTextBoxColumn1
            // 
            this.numberChildrenDataGridViewTextBoxColumn1.DataPropertyName = "Number_Children";
            this.numberChildrenDataGridViewTextBoxColumn1.HeaderText = "Number_Children";
            this.numberChildrenDataGridViewTextBoxColumn1.Name = "numberChildrenDataGridViewTextBoxColumn1";
            // 
            // bookingTypeDataGridViewTextBoxColumn1
            // 
            this.bookingTypeDataGridViewTextBoxColumn1.DataPropertyName = "Booking_Type";
            this.bookingTypeDataGridViewTextBoxColumn1.HeaderText = "Booking_Type";
            this.bookingTypeDataGridViewTextBoxColumn1.Name = "bookingTypeDataGridViewTextBoxColumn1";
            // 
            // specialRequestDataGridViewTextBoxColumn1
            // 
            this.specialRequestDataGridViewTextBoxColumn1.DataPropertyName = "Special_Request";
            this.specialRequestDataGridViewTextBoxColumn1.HeaderText = "Special_Request";
            this.specialRequestDataGridViewTextBoxColumn1.Name = "specialRequestDataGridViewTextBoxColumn1";
            // 
            // penaltyAmountDataGridViewTextBoxColumn1
            // 
            this.penaltyAmountDataGridViewTextBoxColumn1.DataPropertyName = "Penalty_Amount";
            this.penaltyAmountDataGridViewTextBoxColumn1.HeaderText = "Penalty_Amount";
            this.penaltyAmountDataGridViewTextBoxColumn1.Name = "penaltyAmountDataGridViewTextBoxColumn1";
            // 
            // creditAmountDataGridViewTextBoxColumn1
            // 
            this.creditAmountDataGridViewTextBoxColumn1.DataPropertyName = "Credit_Amount";
            this.creditAmountDataGridViewTextBoxColumn1.HeaderText = "Credit_Amount";
            this.creditAmountDataGridViewTextBoxColumn1.Name = "creditAmountDataGridViewTextBoxColumn1";
            // 
            // staffCreatedByDataGridViewTextBoxColumn1
            // 
            this.staffCreatedByDataGridViewTextBoxColumn1.DataPropertyName = "Staff_Created_By";
            this.staffCreatedByDataGridViewTextBoxColumn1.HeaderText = "Staff_Created_By";
            this.staffCreatedByDataGridViewTextBoxColumn1.Name = "staffCreatedByDataGridViewTextBoxColumn1";
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "Booking";
            this.bookingBindingSource1.DataSource = this.codeCraftersDSTWO;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Location = new System.Drawing.Point(0, 30);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1485, 1);
            this.panel15.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "📋 BOOKING LIST";
            // 
            // BookingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 1061);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BookingManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGAL INN MAKE BOOKING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.pnlBooking.ResumeLayout(false);
            this.pnlBooking.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.pnlViewBookings.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.pnlGuestDetails.ResumeLayout(false);
            this.pnlGuestDetails.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private codeCraftersDSTWO codeCraftersDSTWO;
        private codeCraftersDSTWOTableAdapters.BookingTableAdapter taBooking;
        private codeCraftersDSTWOTableAdapters.BranchTableAdapter taBranch;
        private codeCraftersDSTWOTableAdapters.ClientBranchTableBookingTableAdapter taClientBranchTableBooking;
        private codeCraftersDSTWOTableAdapters.ClientTableAdapter taClient;
        private codeCraftersDSTWOTableAdapters.FolioTableAdapter taFolio;
        private codeCraftersDSTWOTableAdapters.Hotel_RoomTableAdapter taHotelRoom;
        private codeCraftersDSTWOTableAdapters.Rate_PlanTableAdapter taRatePlan;
        private codeCraftersDSTWOTableAdapters.Restuarant_TableTableAdapter taRestaurantTable;
        private codeCraftersDSTWOTableAdapters.Room_AssignmentTableAdapter taRoomAssignment;
        private codeCraftersDSTWOTableAdapters.StaffTableAdapter taStaff;
        private codeCraftersDSTWOTableAdapters.Table_AllocationTableAdapter taTableAllocation;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingSource restuarantTableBindingSource;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.Label lblRegalBooking;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numNoOfRooms;
        private System.Windows.Forms.DateTimePicker dtpRoomCheckIn;
        private System.Windows.Forms.DateTimePicker dtpRoomCheckOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbBranchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlViewBookings;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnLinkBookings;
        private System.Windows.Forms.Button btnReschedule;
        private System.Windows.Forms.Button btnViewEdit;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTotalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberAdultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberChildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCreatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.Panel pnlGuestDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchQuery;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTotalAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationReasonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminNotesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberAdultsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberChildrenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialRequestDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffCreatedByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
    }
}