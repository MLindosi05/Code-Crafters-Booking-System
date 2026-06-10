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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();

            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbBranchID = new System.Windows.Forms.ComboBox();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mclCheckOut = new System.Windows.Forms.MonthCalendar();
            this.mclCheckIn = new System.Windows.Forms.MonthCalendar();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.restuarantTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.taClient = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
            this.taBranch = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter();
            this.taHotelRoom = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.taRatePlan = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Rate_PlanTableAdapter();
            this.taRoomAssignment = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Room_AssignmentTableAdapter();
            this.taTableAllocation = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Table_AllocationTableAdapter();
            this.taRestaurantTable = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Restuarant_TableTableAdapter();

            this.panel1 = new System.Windows.Forms.Panel();
            this.grpClientDetails = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtRestaurantTableAvailable = new System.Windows.Forms.TextBox();
            this.dgvRestaurantTableAvailable = new System.Windows.Forms.DataGridView();
            this.dgvHotelRoomAvailable = new System.Windows.Forms.DataGridView();
            this.lblRestaurantTableAvailable = new System.Windows.Forms.Label();
            this.lblHotelRoomAvailable = new System.Windows.Forms.Label();
            this.txtHotelRoomAvailable = new System.Windows.Forms.TextBox();

            this.hotelRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.restaurantTableIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restuarantMenuTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIsCombinableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableFeaturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restuarantTableNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlBooking.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantTableAvailable)).BeginInit();
            this.SuspendLayout();

            // invoiceBindingSource
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.codeCraftersDS;

            // codeCraftersDS
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // restuarantTableBindingSource
            this.restuarantTableBindingSource.DataMember = "Restuarant_Table";
            this.restuarantTableBindingSource.DataSource = this.codeCraftersDS;

            // hotelRoomBindingSource
            this.hotelRoomBindingSource.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource.DataSource = this.codeCraftersDS;

            // panel1
            this.panel1.Controls.Add(this.pnlBooking);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 950);
            this.panel1.TabIndex = 0;

            // pnlBooking
            this.pnlBooking.Controls.Add(this.groupBox4);
            this.pnlBooking.Controls.Add(this.btnCreateBooking);
            this.pnlBooking.Location = new System.Drawing.Point(0, 0);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(1140, 940);
            this.pnlBooking.TabIndex = 0;

            // btnCreateBooking
            this.btnCreateBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateBooking.Location = new System.Drawing.Point(900, 880);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(200, 45);
            this.btnCreateBooking.TabIndex = 10;
            this.btnCreateBooking.Text = "MAKE A BOOKING";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);

            // groupBox4
            this.groupBox4.Controls.Add(this.cmbBranchID);
            this.groupBox4.Controls.Add(this.lblBranchID);
            this.groupBox4.Controls.Add(this.lblTotalAmount);
            this.groupBox4.Controls.Add(this.txtTotalAmount);
            this.groupBox4.Controls.Add(this.grpBookingDetails);
            this.groupBox4.Controls.Add(this.grpClientDetails);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(10, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1110, 850);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "REGAL INN BOOKING";

            // cmbBranchID
            this.cmbBranchID.FormattingEnabled = true;
            this.cmbBranchID.Items.AddRange(new object[] { "BR01", "BR02", "BR03", "BR04", "BR05" });
            this.cmbBranchID.Location = new System.Drawing.Point(220, 30);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(150, 29);
            this.cmbBranchID.TabIndex = 1;

            // lblBranchID
            this.lblBranchID.Location = new System.Drawing.Point(20, 33);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(190, 25);
            this.lblBranchID.TabIndex = 0;
            this.lblBranchID.Text = "REGAL INN BRANCH ID:";

            // txtTotalAmount
            this.txtTotalAmount.Location = new System.Drawing.Point(900, 30);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(180, 29);
            this.txtTotalAmount.TabIndex = 3;

            // lblTotalAmount
            this.lblTotalAmount.Location = new System.Drawing.Point(750, 33);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(140, 25);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "TOTAL AMOUNT:";

            // grpClientDetails
            this.grpClientDetails.Controls.Add(this.txtPhoneNumber);
            this.grpClientDetails.Controls.Add(this.txtAddress);
            this.grpClientDetails.Controls.Add(this.txtEmailAddress);
            this.grpClientDetails.Controls.Add(this.txtFullName);
            this.grpClientDetails.Controls.Add(this.lblAddress);
            this.grpClientDetails.Controls.Add(this.lblEmailAddress);
            this.grpClientDetails.Controls.Add(this.lblPhoneNumber);
            this.grpClientDetails.Controls.Add(this.lblFullName);
            this.grpClientDetails.Location = new System.Drawing.Point(20, 70);
            this.grpClientDetails.Name = "grpClientDetails";
            this.grpClientDetails.Size = new System.Drawing.Size(1060, 140);
            this.grpClientDetails.TabIndex = 4;
            this.grpClientDetails.TabStop = false;
            this.grpClientDetails.Text = "CLIENT DETAILS";

            // lblFullName
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(20, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "FULL NAME:";

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(20, 55);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(220, 25);
            this.txtFullName.TabIndex = 1;

            // lblPhoneNumber
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 85);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "PHONE NUMBER:";

            // txtPhoneNumber
            this.txtPhoneNumber.Location = new System.Drawing.Point(20, 105);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(220, 25);
            this.txtPhoneNumber.TabIndex = 3;

            // lblEmailAddress
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmailAddress.Location = new System.Drawing.Point(280, 30);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(120, 20);
            this.lblEmailAddress.TabIndex = 4;
            this.lblEmailAddress.Text = "EMAIL ADDRESS:";

            // txtEmailAddress
            this.txtEmailAddress.Location = new System.Drawing.Point(280, 55);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(250, 25);
            this.txtEmailAddress.TabIndex = 5;

            // lblAddress
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(280, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "ADDRESS:";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(280, 105);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 25);
            this.txtAddress.TabIndex = 7;

            // grpBookingDetails
            this.grpBookingDetails.Controls.Add(this.label3);
            this.grpBookingDetails.Controls.Add(this.label2);
            this.grpBookingDetails.Controls.Add(this.mclCheckOut);
            this.grpBookingDetails.Controls.Add(this.mclCheckIn);
            this.grpBookingDetails.Controls.Add(this.dgvInvoice);
            this.grpBookingDetails.Controls.Add(this.label1);
            this.grpBookingDetails.Controls.Add(this.txtRestaurantTableAvailable);
            this.grpBookingDetails.Controls.Add(this.dgvRestaurantTableAvailable);
            this.grpBookingDetails.Controls.Add(this.dgvHotelRoomAvailable);
            this.grpBookingDetails.Controls.Add(this.lblRestaurantTableAvailable);
            this.grpBookingDetails.Controls.Add(this.lblHotelRoomAvailable);
            this.grpBookingDetails.Controls.Add(this.txtHotelRoomAvailable);
            this.grpBookingDetails.Location = new System.Drawing.Point(20, 220);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(1060, 610);
            this.grpBookingDetails.TabIndex = 5;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "BOOKING DETAILS";

            // lblHotelRoomAvailable
            this.lblHotelRoomAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHotelRoomAvailable.Location = new System.Drawing.Point(20, 30);
            this.lblHotelRoomAvailable.Name = "lblHotelRoomAvailable";
            this.lblHotelRoomAvailable.Size = new System.Drawing.Size(160, 20);
            this.lblHotelRoomAvailable.TabIndex = 0;
            this.lblHotelRoomAvailable.Text = "ENTER HOTEL ROOM ID:";

            // txtHotelRoomAvailable
            this.txtHotelRoomAvailable.Location = new System.Drawing.Point(190, 27);
            this.txtHotelRoomAvailable.Name = "txtHotelRoomAvailable";
            this.txtHotelRoomAvailable.Size = new System.Drawing.Size(100, 29);
            this.txtHotelRoomAvailable.TabIndex = 1;
            this.txtHotelRoomAvailable.TextChanged += new System.EventHandler(this.txtHotelRoomAvailable_TextChanged);

            // dgvHotelRoomAvailable
            this.dgvHotelRoomAvailable.AutoGenerateColumns = false;
            this.dgvHotelRoomAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelRoomAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelRoomIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.hotelroomtypeIDDataGridViewTextBoxColumn,
            this.hotelroomnumberDataGridViewTextBoxColumn,
            this.hotelroomstatusDataGridViewTextBoxColumn,
            this.hotelRoomPriceDataGridViewTextBoxColumn});
            this.dgvHotelRoomAvailable.DataSource = this.hotelRoomBindingSource;
            this.dgvHotelRoomAvailable.Location = new System.Drawing.Point(20, 65);
            this.dgvHotelRoomAvailable.Name = "dgvHotelRoomAvailable";
            this.dgvHotelRoomAvailable.Size = new System.Drawing.Size(1020, 110);
            this.dgvHotelRoomAvailable.TabIndex = 2;
            this.dgvHotelRoomAvailable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHotelRoomAvailable_RowHeaderMouseDoubleClick);

            // Column grid alignments styling mapping
            this.hotelRoomIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_ID";
            this.hotelRoomIDDataGridViewTextBoxColumn.HeaderText = "ROOM ID";
            this.hotelRoomIDDataGridViewTextBoxColumn.Name = "hotelRoomIDDataGridViewTextBoxColumn";
            this.hotelRoomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BRANCH ID";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_type_ID";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.HeaderText = "TYPE ID";
            this.hotelroomnumberDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_number";
            this.hotelroomnumberDataGridViewTextBoxColumn.HeaderText = "ROOM NO.";
            this.hotelroomstatusDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_status";
            this.hotelroomstatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.hotelRoomPriceDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_Price";
            this.hotelRoomPriceDataGridViewTextBoxColumn.HeaderText = "PRICE";

            // lblRestaurantTableAvailable
            this.lblRestaurantTableAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRestaurantTableAvailable.Location = new System.Drawing.Point(20, 190);
            this.lblRestaurantTableAvailable.Name = "lblRestaurantTableAvailable";
            this.lblRestaurantTableAvailable.Size = new System.Drawing.Size(200, 20);
            this.lblRestaurantTableAvailable.TabIndex = 3;
            this.lblRestaurantTableAvailable.Text = "ENTER RESTAURANT TABLE ID:";

            // txtRestaurantTableAvailable
            this.txtRestaurantTableAvailable.Location = new System.Drawing.Point(220, 187);
            this.txtRestaurantTableAvailable.Name = "txtRestaurantTableAvailable";
            this.txtRestaurantTableAvailable.Size = new System.Drawing.Size(100, 29);
            this.txtRestaurantTableAvailable.TabIndex = 4;
            this.txtRestaurantTableAvailable.TextChanged += new System.EventHandler(this.txtRestaurantTableAvailable_TextChanged);

            // dgvRestaurantTableAvailable
            this.dgvRestaurantTableAvailable.AutoGenerateColumns = false;
            this.dgvRestaurantTableAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurantTableAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restaurantTableIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn1,
            this.restuarantTableNumDataGridViewTextBoxColumn,
            this.restuarantMenuTypeDataGridViewTextBoxColumn,
            this.tableCapacityDataGridViewTextBoxColumn,
            this.tableStatusDataGridViewTextBoxColumn,
            this.tableIsCombinableDataGridViewTextBoxColumn,
            this.tableFeaturesDataGridViewTextBoxColumn,
            this.tablePriceDataGridViewTextBoxColumn});
            this.dgvRestaurantTableAvailable.DataSource = this.restuarantTableBindingSource;
            this.dgvRestaurantTableAvailable.Location = new System.Drawing.Point(20, 225);
            this.dgvRestaurantTableAvailable.Name = "dgvRestaurantTableAvailable";
            this.dgvRestaurantTableAvailable.Size = new System.Drawing.Size(1020, 110);
            this.dgvRestaurantTableAvailable.TabIndex = 5;
            this.dgvRestaurantTableAvailable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRestaurantTableAvailable_RowHeaderMouseDoubleClick);

            this.restaurantTableIDDataGridViewTextBoxColumn.DataPropertyName = "RestaurantTableID";
            this.restaurantTableIDDataGridViewTextBoxColumn.HeaderText = "TABLE ID";
            this.branchIDDataGridViewTextBoxColumn1.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn1.HeaderText = "BRANCH ID";
            this.restuarantTableNumDataGridViewTextBoxColumn.DataPropertyName = "RestuarantTableNum";
            this.restuarantTableNumDataGridViewTextBoxColumn.HeaderText = "TABLE NO.";
            this.restuarantMenuTypeDataGridViewTextBoxColumn.DataPropertyName = "RestuarantMenuType";
            this.restuarantMenuTypeDataGridViewTextBoxColumn.HeaderText = "MENU";
            this.tableCapacityDataGridViewTextBoxColumn.DataPropertyName = "TableCapacity";
            this.tableCapacityDataGridViewTextBoxColumn.HeaderText = "CAPACITY";
            this.tableStatusDataGridViewTextBoxColumn.DataPropertyName = "TableStatus";
            this.tableStatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.tableIsCombinableDataGridViewTextBoxColumn.DataPropertyName = "TableIsCombinable";
            this.tableIsCombinableDataGridViewTextBoxColumn.HeaderText = "COMBINABLE";
            this.tableFeaturesDataGridViewTextBoxColumn.DataPropertyName = "TableFeatures";
            this.tableFeaturesDataGridViewTextBoxColumn.HeaderText = "FEATURES";
            this.tablePriceDataGridViewTextBoxColumn.DataPropertyName = "TablePrice";
            this.tablePriceDataGridViewTextBoxColumn.HeaderText = "PRICE";

            // Calendars & Invoice placements
            this.mclCheckIn.Location = new System.Drawing.Point(20, 380);
            this.mclCheckIn.Name = "mclCheckIn";
            this.mclCheckIn.TabIndex = 7;
            this.mclCheckOut.Location = new System.Drawing.Point(270, 380);
            this.mclCheckOut.Name = "mclCheckOut";
            this.mclCheckOut.TabIndex = 9;

            this.label2.Text = "CHECK IN DATE";
            this.label2.Location = new System.Drawing.Point(20, 355);
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label3.Text = "CHECK OUT DATE";
            this.label3.Location = new System.Drawing.Point(270, 355);
            this.label3.Size = new System.Drawing.Size(150, 20);

            this.dgvInvoice.Location = new System.Drawing.Point(530, 380);
            this.dgvInvoice.Size = new System.Drawing.Size(510, 162);
            this.dgvInvoice.TabIndex = 11;
            this.label1.Text = "CURRENT BOOKING SELECTIONS (INVOICE)";
            this.label1.Location = new System.Drawing.Point(530, 355);
            this.label1.Size = new System.Drawing.Size(350, 20);

            // BookingForm main layout assignments
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 981);
            this.Controls.Add(this.panel1); // <--- ATTACHES EVERYTHING TO VISUAL FIELD
            this.Name = "BookingForm";
            this.Text = "Booking Management System";

            this.pnlBooking.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpClientDetails.ResumeLayout(false);
            this.grpClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantTableAvailable)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbBranchID;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mclCheckOut;
        private System.Windows.Forms.MonthCalendar mclCheckIn;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private codeCraftersDS codeCraftersDS;
        private System.Windows.Forms.BindingSource restuarantTableBindingSource;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource;

        private codeCraftersDSTableAdapters.BookingTableAdapter taBooking;
        private codeCraftersDSTableAdapters.ClientTableAdapter taClient;
        private codeCraftersDSTableAdapters.BranchTableAdapter taBranch;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter taHotelRoom;
        private codeCraftersDSTableAdapters.Rate_PlanTableAdapter taRatePlan;
        private codeCraftersDSTableAdapters.Room_AssignmentTableAdapter taRoomAssignment;
        private codeCraftersDSTableAdapters.Table_AllocationTableAdapter taTableAllocation;
        private codeCraftersDSTableAdapters.Restuarant_TableTableAdapter taRestaurantTable;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpClientDetails;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtRestaurantTableAvailable;
        private System.Windows.Forms.DataGridView dgvRestaurantTableAvailable;
        private System.Windows.Forms.DataGridView dgvHotelRoomAvailable;
        private System.Windows.Forms.Label lblRestaurantTableAvailable;
        private System.Windows.Forms.Label lblHotelRoomAvailable;
        private System.Windows.Forms.TextBox txtHotelRoomAvailable;

        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantTableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn restuarantMenuTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIsCombinableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableFeaturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restuarantTableNumDataGridViewTextBoxColumn;
    }
}