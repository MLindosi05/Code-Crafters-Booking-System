namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class BookingForm
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
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.lblRegalBooking = new System.Windows.Forms.Label();
            this.pnlGuestDetails = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchQuery = new System.Windows.Forms.TextBox();
            this.cmbFilterBookingStatus = new System.Windows.Forms.ComboBox();
            this.cmbFilterBookingType = new System.Windows.Forms.ComboBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numNoOfRooms = new System.Windows.Forms.NumericUpDown();
            this.dtpRoomCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpRoomCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDSTWO = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWO();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbTableArea = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpTableCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpTableCheckIn = new System.Windows.Forms.DateTimePicker();
            this.numTableGuests = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numInfants = new System.Windows.Forms.NumericUpDown();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.cmbRoomCategory = new System.Windows.Forms.ComboBox();
            this.txtIdPassportNo = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cmbBookingType = new System.Windows.Forms.ComboBox();
            this.lblRoomCategory = new System.Windows.Forms.Label();
            this.lblInfants = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblIDORPASS = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblBookingTypes = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnLinkBookings = new System.Windows.Forms.Button();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.btnViewEdit = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvBookingList = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
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
            this.numNoOfNights = new System.Windows.Forms.TextBox();
            this.pnlBooking.SuspendLayout();
            this.pnlGuestDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTableGuests)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInfants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBooking
            // 
            this.pnlBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBooking.Controls.Add(this.cmbBranchName);
            this.pnlBooking.Controls.Add(this.label9);
            this.pnlBooking.Controls.Add(this.btnRefresh);
            this.pnlBooking.Controls.Add(this.btnNewBooking);
            this.pnlBooking.Controls.Add(this.lblRegalBooking);
            this.pnlBooking.Location = new System.Drawing.Point(12, 22);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(1486, 100);
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
            this.cmbBranchName.Size = new System.Drawing.Size(168, 36);
            this.cmbBranchName.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(12, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "🏨 REGAL INN HOTELS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Location = new System.Drawing.Point(1320, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.Navy;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnNewBooking.Location = new System.Drawing.Point(1121, 23);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(170, 45);
            this.btnNewBooking.TabIndex = 2;
            this.btnNewBooking.Text = "➕ NEW BOOKING";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click_1);
            // 
            // lblRegalBooking
            // 
            this.lblRegalBooking.AutoSize = true;
            this.lblRegalBooking.ForeColor = System.Drawing.Color.Navy;
            this.lblRegalBooking.Location = new System.Drawing.Point(16, 13);
            this.lblRegalBooking.Name = "lblRegalBooking";
            this.lblRegalBooking.Size = new System.Drawing.Size(216, 28);
            this.lblRegalBooking.TabIndex = 1;
            this.lblRegalBooking.Text = "REGAL INN BOOKING";
            // 
            // pnlGuestDetails
            // 
            this.pnlGuestDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGuestDetails.Controls.Add(this.panel2);
            this.pnlGuestDetails.Controls.Add(this.label7);
            this.pnlGuestDetails.Controls.Add(this.btnClear);
            this.pnlGuestDetails.Controls.Add(this.btnSearch);
            this.pnlGuestDetails.Controls.Add(this.dtpToDate);
            this.pnlGuestDetails.Controls.Add(this.dtpFromDate);
            this.pnlGuestDetails.Controls.Add(this.label1);
            this.pnlGuestDetails.Controls.Add(this.label2);
            this.pnlGuestDetails.Controls.Add(this.txtSearchQuery);
            this.pnlGuestDetails.Controls.Add(this.cmbFilterBookingStatus);
            this.pnlGuestDetails.Controls.Add(this.cmbFilterBookingType);
            this.pnlGuestDetails.Controls.Add(this.cmbSearchBy);
            this.pnlGuestDetails.Controls.Add(this.label3);
            this.pnlGuestDetails.Controls.Add(this.label4);
            this.pnlGuestDetails.Controls.Add(this.label5);
            this.pnlGuestDetails.Controls.Add(this.label6);
            this.pnlGuestDetails.ForeColor = System.Drawing.Color.Navy;
            this.pnlGuestDetails.Location = new System.Drawing.Point(13, 418);
            this.pnlGuestDetails.Name = "pnlGuestDetails";
            this.pnlGuestDetails.Size = new System.Drawing.Size(659, 250);
            this.pnlGuestDetails.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(1, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 1);
            this.panel2.TabIndex = 33;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "🔍 SEARCH AND FILTER BOOKINGS";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(497, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 45);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "🧹 CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(375, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 45);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "🔍 SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy/MM/dd ";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(200, 187);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(143, 34);
            this.dtpToDate.TabIndex = 29;
            this.dtpToDate.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy/MM/dd";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(30, 187);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(134, 34);
            this.dtpFromDate.TabIndex = 28;
            this.dtpFromDate.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "FROM DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(196, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "TO DATE";
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Location = new System.Drawing.Point(146, 107);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(133, 34);
            this.txtSearchQuery.TabIndex = 25;
            // 
            // cmbFilterBookingStatus
            // 
            this.cmbFilterBookingStatus.FormattingEnabled = true;
            this.cmbFilterBookingStatus.Location = new System.Drawing.Point(445, 107);
            this.cmbFilterBookingStatus.Name = "cmbFilterBookingStatus";
            this.cmbFilterBookingStatus.Size = new System.Drawing.Size(147, 36);
            this.cmbFilterBookingStatus.TabIndex = 24;
            // 
            // cmbFilterBookingType
            // 
            this.cmbFilterBookingType.FormattingEnabled = true;
            this.cmbFilterBookingType.Location = new System.Drawing.Point(293, 107);
            this.cmbFilterBookingType.Name = "cmbFilterBookingType";
            this.cmbFilterBookingType.Size = new System.Drawing.Size(121, 36);
            this.cmbFilterBookingType.TabIndex = 23;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(30, 107);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(95, 36);
            this.cmbSearchBy.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(441, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "BOOKING STATUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(289, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "BOOKING TYPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(142, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "SEARCH QUERY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "SEARCH BY";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numNoOfNights);
            this.panel1.Controls.Add(this.numNoOfRooms);
            this.panel1.Controls.Add(this.dtpRoomCheckIn);
            this.panel1.Controls.Add(this.dtpRoomCheckOut);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(694, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 250);
            this.panel1.TabIndex = 11;
            // 
            // numNoOfRooms
            // 
            this.numNoOfRooms.Location = new System.Drawing.Point(152, 166);
            this.numNoOfRooms.Name = "numNoOfRooms";
            this.numNoOfRooms.Size = new System.Drawing.Size(85, 34);
            this.numNoOfRooms.TabIndex = 41;
            // 
            // dtpRoomCheckIn
            // 
            this.dtpRoomCheckIn.CustomFormat = "yyyy/MM/dd";
            this.dtpRoomCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRoomCheckIn.Location = new System.Drawing.Point(152, 55);
            this.dtpRoomCheckIn.Name = "dtpRoomCheckIn";
            this.dtpRoomCheckIn.Size = new System.Drawing.Size(129, 34);
            this.dtpRoomCheckIn.TabIndex = 40;
            this.dtpRoomCheckIn.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // dtpRoomCheckOut
            // 
            this.dtpRoomCheckOut.CustomFormat = "yyyy/MM/dd ";
            this.dtpRoomCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRoomCheckOut.Location = new System.Drawing.Point(152, 92);
            this.dtpRoomCheckOut.Name = "dtpRoomCheckOut";
            this.dtpRoomCheckOut.Size = new System.Drawing.Size(129, 34);
            this.dtpRoomCheckOut.TabIndex = 39;
            this.dtpRoomCheckOut.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 28);
            this.label10.TabIndex = 37;
            this.label10.Text = "NO. OF ROOMS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(18, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 28);
            this.label11.TabIndex = 36;
            this.label11.Text = "NO. OF NIGHTS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(18, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 28);
            this.label12.TabIndex = 35;
            this.label12.Text = "CHECK-OUT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(18, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 28);
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
            this.label8.Size = new System.Drawing.Size(206, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "🛏 ROOM BOOKING";
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbTableArea);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dtpTableCheckOut);
            this.panel4.Controls.Add(this.dtpTableCheckIn);
            this.panel4.Controls.Add(this.numTableGuests);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label19);
            this.panel4.ForeColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(1086, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 250);
            this.panel4.TabIndex = 12;
            // 
            // cmbTableArea
            // 
            this.cmbTableArea.FormattingEnabled = true;
            this.cmbTableArea.Location = new System.Drawing.Point(159, 171);
            this.cmbTableArea.Name = "cmbTableArea";
            this.cmbTableArea.Size = new System.Drawing.Size(170, 36);
            this.cmbTableArea.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(28, 174);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(129, 28);
            this.label14.TabIndex = 42;
            this.label14.Text = "TABLE AREA";
            // 
            // dtpTableCheckOut
            // 
            this.dtpTableCheckOut.CustomFormat = "yyyy/MM/dd";
            this.dtpTableCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTableCheckOut.Location = new System.Drawing.Point(159, 92);
            this.dtpTableCheckOut.Name = "dtpTableCheckOut";
            this.dtpTableCheckOut.Size = new System.Drawing.Size(131, 34);
            this.dtpTableCheckOut.TabIndex = 41;
            this.dtpTableCheckOut.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // dtpTableCheckIn
            // 
            this.dtpTableCheckIn.CustomFormat = "yyyy/MM/dd";
            this.dtpTableCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTableCheckIn.Location = new System.Drawing.Point(159, 57);
            this.dtpTableCheckIn.Name = "dtpTableCheckIn";
            this.dtpTableCheckIn.Size = new System.Drawing.Size(131, 34);
            this.dtpTableCheckIn.TabIndex = 40;
            this.dtpTableCheckIn.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // numTableGuests
            // 
            this.numTableGuests.Location = new System.Drawing.Point(159, 130);
            this.numTableGuests.Name = "numTableGuests";
            this.numTableGuests.Size = new System.Drawing.Size(85, 34);
            this.numTableGuests.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(28, 135);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(157, 28);
            this.label15.TabIndex = 37;
            this.label15.Text = "NO. OF GUESTS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(28, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 28);
            this.label17.TabIndex = 35;
            this.label17.Text = "CHECK-OUT";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(28, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 28);
            this.label18.TabIndex = 34;
            this.label18.Text = "CHECK-IN";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(3, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 1);
            this.panel5.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(203, 28);
            this.label19.TabIndex = 32;
            this.label19.Text = "🍽 TABLE BOOKING";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.numInfants);
            this.panel6.Controls.Add(this.numChildren);
            this.panel6.Controls.Add(this.numAdults);
            this.panel6.Controls.Add(this.cmbRoomCategory);
            this.panel6.Controls.Add(this.txtIdPassportNo);
            this.panel6.Controls.Add(this.txtEmailAddress);
            this.panel6.Controls.Add(this.txtPhoneNo);
            this.panel6.Controls.Add(this.txtFullName);
            this.panel6.Controls.Add(this.cmbBookingType);
            this.panel6.Controls.Add(this.lblRoomCategory);
            this.panel6.Controls.Add(this.lblInfants);
            this.panel6.Controls.Add(this.lblChildren);
            this.panel6.Controls.Add(this.lblAdults);
            this.panel6.Controls.Add(this.lblIDORPASS);
            this.panel6.Controls.Add(this.lblEmailAddress);
            this.panel6.Controls.Add(this.lblPhoneNo);
            this.panel6.Controls.Add(this.lblFullName);
            this.panel6.Controls.Add(this.lblBookingTypes);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label20);
            this.panel6.ForeColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(13, 147);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(659, 250);
            this.panel6.TabIndex = 44;
            // 
            // numInfants
            // 
            this.numInfants.Location = new System.Drawing.Point(533, 131);
            this.numInfants.Name = "numInfants";
            this.numInfants.Size = new System.Drawing.Size(85, 34);
            this.numInfants.TabIndex = 51;
            // 
            // numChildren
            // 
            this.numChildren.Location = new System.Drawing.Point(533, 94);
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(85, 34);
            this.numChildren.TabIndex = 50;
            // 
            // numAdults
            // 
            this.numAdults.Location = new System.Drawing.Point(533, 59);
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(85, 34);
            this.numAdults.TabIndex = 49;
            // 
            // cmbRoomCategory
            // 
            this.cmbRoomCategory.FormattingEnabled = true;
            this.cmbRoomCategory.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Executive",
            "Suite"});
            this.cmbRoomCategory.Location = new System.Drawing.Point(532, 167);
            this.cmbRoomCategory.Name = "cmbRoomCategory";
            this.cmbRoomCategory.Size = new System.Drawing.Size(86, 36);
            this.cmbRoomCategory.TabIndex = 48;
            // 
            // txtIdPassportNo
            // 
            this.txtIdPassportNo.Location = new System.Drawing.Point(191, 203);
            this.txtIdPassportNo.Name = "txtIdPassportNo";
            this.txtIdPassportNo.Size = new System.Drawing.Size(168, 34);
            this.txtIdPassportNo.TabIndex = 47;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(191, 168);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(168, 34);
            this.txtEmailAddress.TabIndex = 46;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(191, 132);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(168, 34);
            this.txtPhoneNo.TabIndex = 45;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(191, 95);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(168, 34);
            this.txtFullName.TabIndex = 44;
            // 
            // cmbBookingType
            // 
            this.cmbBookingType.FormattingEnabled = true;
            this.cmbBookingType.Location = new System.Drawing.Point(191, 59);
            this.cmbBookingType.Name = "cmbBookingType";
            this.cmbBookingType.Size = new System.Drawing.Size(168, 36);
            this.cmbBookingType.TabIndex = 43;
            // 
            // lblRoomCategory
            // 
            this.lblRoomCategory.AutoSize = true;
            this.lblRoomCategory.ForeColor = System.Drawing.Color.Black;
            this.lblRoomCategory.Location = new System.Drawing.Point(380, 170);
            this.lblRoomCategory.Name = "lblRoomCategory";
            this.lblRoomCategory.Size = new System.Drawing.Size(182, 28);
            this.lblRoomCategory.TabIndex = 42;
            this.lblRoomCategory.Text = "ROOM CATEGORY";
            // 
            // lblInfants
            // 
            this.lblInfants.AutoSize = true;
            this.lblInfants.ForeColor = System.Drawing.Color.Black;
            this.lblInfants.Location = new System.Drawing.Point(381, 131);
            this.lblInfants.Name = "lblInfants";
            this.lblInfants.Size = new System.Drawing.Size(96, 28);
            this.lblInfants.TabIndex = 41;
            this.lblInfants.Text = "INFANTS";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.ForeColor = System.Drawing.Color.Black;
            this.lblChildren.Location = new System.Drawing.Point(381, 94);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(110, 28);
            this.lblChildren.TabIndex = 40;
            this.lblChildren.Text = "CHILDREN";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.ForeColor = System.Drawing.Color.Black;
            this.lblAdults.Location = new System.Drawing.Point(381, 59);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(87, 28);
            this.lblAdults.TabIndex = 39;
            this.lblAdults.Text = "ADULTS";
            // 
            // lblIDORPASS
            // 
            this.lblIDORPASS.AutoSize = true;
            this.lblIDORPASS.ForeColor = System.Drawing.Color.Black;
            this.lblIDORPASS.Location = new System.Drawing.Point(26, 203);
            this.lblIDORPASS.Name = "lblIDORPASS";
            this.lblIDORPASS.Size = new System.Drawing.Size(178, 28);
            this.lblIDORPASS.TabIndex = 38;
            this.lblIDORPASS.Text = "ID/PASSPORT NO";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.lblEmailAddress.Location = new System.Drawing.Point(26, 168);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(168, 28);
            this.lblEmailAddress.TabIndex = 37;
            this.lblEmailAddress.Text = "EMAIL ADDRESS";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNo.Location = new System.Drawing.Point(26, 132);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(118, 28);
            this.lblPhoneNo.TabIndex = 36;
            this.lblPhoneNo.Text = "PHONE NO";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(26, 95);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(122, 28);
            this.lblFullName.TabIndex = 35;
            this.lblFullName.Text = "FULL NAME";
            // 
            // lblBookingTypes
            // 
            this.lblBookingTypes.AutoSize = true;
            this.lblBookingTypes.ForeColor = System.Drawing.Color.Black;
            this.lblBookingTypes.Location = new System.Drawing.Point(26, 60);
            this.lblBookingTypes.Name = "lblBookingTypes";
            this.lblBookingTypes.Size = new System.Drawing.Size(157, 28);
            this.lblBookingTypes.TabIndex = 34;
            this.lblBookingTypes.Text = "BOOKING TYPE";
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
            this.label20.Size = new System.Drawing.Size(192, 28);
            this.label20.TabIndex = 32;
            this.label20.Text = "👤 GUEST DETAILS";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnPrint);
            this.panel8.Controls.Add(this.btnCancelBooking);
            this.panel8.Controls.Add(this.btnLinkBookings);
            this.panel8.Controls.Add(this.btnReschedule);
            this.panel8.Controls.Add(this.btnViewEdit);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label21);
            this.panel8.ForeColor = System.Drawing.Color.Navy;
            this.panel8.Location = new System.Drawing.Point(694, 418);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(807, 250);
            this.panel8.TabIndex = 52;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(701, 61);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 45);
            this.btnPrint.TabIndex = 38;
            this.btnPrint.Text = "🖨 PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.Purple;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(326, 61);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(189, 45);
            this.btnCancelBooking.TabIndex = 37;
            this.btnCancelBooking.Text = "❌ CANCEL BOOKING";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            // 
            // btnLinkBookings
            // 
            this.btnLinkBookings.BackColor = System.Drawing.Color.Red;
            this.btnLinkBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkBookings.ForeColor = System.Drawing.Color.White;
            this.btnLinkBookings.Location = new System.Drawing.Point(521, 61);
            this.btnLinkBookings.Name = "btnLinkBookings";
            this.btnLinkBookings.Size = new System.Drawing.Size(174, 45);
            this.btnLinkBookings.TabIndex = 36;
            this.btnLinkBookings.Text = "🔗 LINK BOOKINGS";
            this.btnLinkBookings.UseVisualStyleBackColor = false;
            // 
            // btnReschedule
            // 
            this.btnReschedule.BackColor = System.Drawing.Color.Orange;
            this.btnReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReschedule.ForeColor = System.Drawing.Color.White;
            this.btnReschedule.Location = new System.Drawing.Point(159, 61);
            this.btnReschedule.Name = "btnReschedule";
            this.btnReschedule.Size = new System.Drawing.Size(161, 45);
            this.btnReschedule.TabIndex = 35;
            this.btnReschedule.Text = "📅 RESCHEDULE";
            this.btnReschedule.UseVisualStyleBackColor = false;
            // 
            // btnViewEdit
            // 
            this.btnViewEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEdit.ForeColor = System.Drawing.Color.White;
            this.btnViewEdit.Location = new System.Drawing.Point(21, 61);
            this.btnViewEdit.Name = "btnViewEdit";
            this.btnViewEdit.Size = new System.Drawing.Size(132, 45);
            this.btnViewEdit.TabIndex = 34;
            this.btnViewEdit.Text = "👁 VIEW/EDIT";
            this.btnViewEdit.UseVisualStyleBackColor = false;
            this.btnViewEdit.Click += new System.EventHandler(this.btnViewEdit_Click_1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.panel9.Location = new System.Drawing.Point(0, 30);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(803, 1);
            this.panel9.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 28);
            this.label21.TabIndex = 32;
            this.label21.Text = "⚡ ACTIONS";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.dgvBookingList);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label22);
            this.panel10.ForeColor = System.Drawing.Color.Navy;
            this.panel10.Location = new System.Drawing.Point(12, 693);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1489, 227);
            this.panel10.TabIndex = 53;
            // 
            // dgvBookingList
            // 
            this.dgvBookingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingList.Location = new System.Drawing.Point(20, 46);
            this.dgvBookingList.Name = "dgvBookingList";
            this.dgvBookingList.RowHeadersWidth = 51;
            this.dgvBookingList.Size = new System.Drawing.Size(1459, 163);
            this.dgvBookingList.TabIndex = 34;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gainsboro;
            this.panel11.Location = new System.Drawing.Point(0, 30);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1485, 1);
            this.panel11.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 28);
            this.label22.TabIndex = 32;
            this.label22.Text = "📋 BOOKING LIST";
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
            // numNoOfNights
            // 
            this.numNoOfNights.Location = new System.Drawing.Point(152, 129);
            this.numNoOfNights.Name = "numNoOfNights";
            this.numNoOfNights.ReadOnly = true;
            this.numNoOfNights.Size = new System.Drawing.Size(85, 34);
            this.numNoOfNights.TabIndex = 42;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1596, 942);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGuestDetails);
            this.Controls.Add(this.pnlBooking);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGAL INN MAKE BOOKING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.pnlBooking.ResumeLayout(false);
            this.pnlBooking.PerformLayout();
            this.pnlGuestDetails.ResumeLayout(false);
            this.pnlGuestDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTableGuests)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInfants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Panel pnlGuestDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchQuery;
        private System.Windows.Forms.ComboBox cmbFilterBookingStatus;
        private System.Windows.Forms.ComboBox cmbFilterBookingType;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numNoOfRooms;
        private System.Windows.Forms.DateTimePicker dtpRoomCheckIn;
        private System.Windows.Forms.DateTimePicker dtpRoomCheckOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbTableArea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpTableCheckOut;
        private System.Windows.Forms.DateTimePicker dtpTableCheckIn;
        private System.Windows.Forms.NumericUpDown numTableGuests;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numInfants;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.ComboBox cmbRoomCategory;
        private System.Windows.Forms.TextBox txtIdPassportNo;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cmbBookingType;
        private System.Windows.Forms.Label lblRoomCategory;
        private System.Windows.Forms.Label lblInfants;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblIDORPASS;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBookingTypes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnLinkBookings;
        private System.Windows.Forms.Button btnReschedule;
        private System.Windows.Forms.Button btnViewEdit;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgvBookingList;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbBranchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox numNoOfNights;
    }
}