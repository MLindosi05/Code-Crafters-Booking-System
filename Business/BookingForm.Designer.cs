namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class BookingForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mclCheckOut = new System.Windows.Forms.MonthCalendar();
            this.mclCheckIn = new System.Windows.Forms.MonthCalendar();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRestaurantTableAvailable = new System.Windows.Forms.TextBox();
            this.dgvRestaurantTableAvailable = new System.Windows.Forms.DataGridView();
            this.restaurantTableIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restuarantTableNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restuarantMenuTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIsCombinableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableFeaturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restuarantTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.dgvHotelRoomAvailable = new System.Windows.Forms.DataGridView();
            this.hotelRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRestaurantTableAvailable = new System.Windows.Forms.Label();
            this.lblHotelRoomAvailable = new System.Windows.Forms.Label();
            this.txtHotelRoomAvailable = new System.Windows.Forms.TextBox();
            this.grpClientDetails = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.taClient = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
            this.taBranch = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter();
            this.taHotelRoom = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.taRatePlan = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Rate_PlanTableAdapter();
            this.taRoomAssignment = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Room_AssignmentTableAdapter();
            this.taTableAllocation = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Table_AllocationTableAdapter();
            this.taRestaurantTable = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Restuarant_TableTableAdapter();
            this.pnlBooking.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantTableAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            this.grpClientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCreateBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBooking.Location = new System.Drawing.Point(949, 992);
            this.btnCreateBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(161, 31);
            this.btnCreateBooking.TabIndex = 20;
            this.btnCreateBooking.Text = "MAKE A BOOKING";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // pnlBooking
            // 
            this.pnlBooking.Controls.Add(this.groupBox4);
            this.pnlBooking.Controls.Add(this.btnCreateBooking);
            this.pnlBooking.Location = new System.Drawing.Point(12, 12);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(1133, 1037);
            this.pnlBooking.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox4.Controls.Add(this.lblTotalAmount);
            this.groupBox4.Controls.Add(this.txtTotalAmount);
            this.groupBox4.Controls.Add(this.grpBookingDetails);
            this.groupBox4.Controls.Add(this.grpClientDetails);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(1098, 975);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "REGAL INN BOOKING";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(773, 939);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(185, 21);
            this.lblTotalAmount.TabIndex = 29;
            this.lblTotalAmount.Text = "BOOKING TOTAL PRICE:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(964, 936);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(129, 29);
            this.txtTotalAmount.TabIndex = 28;
            // 
            // grpBookingDetails
            // 
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
            this.grpBookingDetails.Location = new System.Drawing.Point(82, 214);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(1011, 716);
            this.grpBookingDetails.TabIndex = 23;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "BOOKING DETAILS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "CHECK-OUT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "CHECK-IN:";
            // 
            // mclCheckOut
            // 
            this.mclCheckOut.Location = new System.Drawing.Point(289, 384);
            this.mclCheckOut.Name = "mclCheckOut";
            this.mclCheckOut.TabIndex = 10;
            // 
            // mclCheckIn
            // 
            this.mclCheckIn.Location = new System.Drawing.Point(32, 384);
            this.mclCheckIn.Name = "mclCheckIn";
            this.mclCheckIn.TabIndex = 9;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(32, 575);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(957, 124);
            this.dgvInvoice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "REGAL INN INVOICE";
            // 
            // txtRestaurantTableAvailable
            // 
            this.txtRestaurantTableAvailable.Location = new System.Drawing.Point(224, 201);
            this.txtRestaurantTableAvailable.Name = "txtRestaurantTableAvailable";
            this.txtRestaurantTableAvailable.Size = new System.Drawing.Size(98, 29);
            this.txtRestaurantTableAvailable.TabIndex = 6;
            this.txtRestaurantTableAvailable.TextChanged += new System.EventHandler(this.txtRestaurantTableAvailable_TextChanged);
            // 
            // dgvRestaurantTableAvailable
            // 
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
            this.tableFeaturesDataGridViewTextBoxColumn});
            this.dgvRestaurantTableAvailable.DataSource = this.restuarantTableBindingSource;
            this.dgvRestaurantTableAvailable.Location = new System.Drawing.Point(32, 236);
            this.dgvRestaurantTableAvailable.Name = "dgvRestaurantTableAvailable";
            this.dgvRestaurantTableAvailable.Size = new System.Drawing.Size(957, 124);
            this.dgvRestaurantTableAvailable.TabIndex = 5;
            this.dgvRestaurantTableAvailable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRestaurantTableAvailable_RowHeaderMouseDoubleClick);
            // 
            // restaurantTableIDDataGridViewTextBoxColumn
            // 
            this.restaurantTableIDDataGridViewTextBoxColumn.DataPropertyName = "RestaurantTableID";
            this.restaurantTableIDDataGridViewTextBoxColumn.HeaderText = "TABLE ID";
            this.restaurantTableIDDataGridViewTextBoxColumn.Name = "restaurantTableIDDataGridViewTextBoxColumn";
            this.restaurantTableIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.restaurantTableIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // branchIDDataGridViewTextBoxColumn1
            // 
            this.branchIDDataGridViewTextBoxColumn1.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn1.HeaderText = "BRANCH ID";
            this.branchIDDataGridViewTextBoxColumn1.Name = "branchIDDataGridViewTextBoxColumn1";
            this.branchIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // restuarantTableNumDataGridViewTextBoxColumn
            // 
            this.restuarantTableNumDataGridViewTextBoxColumn.DataPropertyName = "RestuarantTableNum";
            this.restuarantTableNumDataGridViewTextBoxColumn.HeaderText = "TABLE NO.";
            this.restuarantTableNumDataGridViewTextBoxColumn.Name = "restuarantTableNumDataGridViewTextBoxColumn";
            this.restuarantTableNumDataGridViewTextBoxColumn.Width = 120;
            // 
            // restuarantMenuTypeDataGridViewTextBoxColumn
            // 
            this.restuarantMenuTypeDataGridViewTextBoxColumn.DataPropertyName = "RestuarantMenuType";
            this.restuarantMenuTypeDataGridViewTextBoxColumn.HeaderText = "TABLE MENU";
            this.restuarantMenuTypeDataGridViewTextBoxColumn.Name = "restuarantMenuTypeDataGridViewTextBoxColumn";
            this.restuarantMenuTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // tableCapacityDataGridViewTextBoxColumn
            // 
            this.tableCapacityDataGridViewTextBoxColumn.DataPropertyName = "TableCapacity";
            this.tableCapacityDataGridViewTextBoxColumn.HeaderText = "TABLE CAPACITY";
            this.tableCapacityDataGridViewTextBoxColumn.Name = "tableCapacityDataGridViewTextBoxColumn";
            this.tableCapacityDataGridViewTextBoxColumn.Width = 170;
            // 
            // tableStatusDataGridViewTextBoxColumn
            // 
            this.tableStatusDataGridViewTextBoxColumn.DataPropertyName = "TableStatus";
            this.tableStatusDataGridViewTextBoxColumn.HeaderText = "TABLE STATUS";
            this.tableStatusDataGridViewTextBoxColumn.Name = "tableStatusDataGridViewTextBoxColumn";
            this.tableStatusDataGridViewTextBoxColumn.Width = 160;
            // 
            // tableIsCombinableDataGridViewTextBoxColumn
            // 
            this.tableIsCombinableDataGridViewTextBoxColumn.DataPropertyName = "TableIsCombinable";
            this.tableIsCombinableDataGridViewTextBoxColumn.HeaderText = "TABLE COMBINED";
            this.tableIsCombinableDataGridViewTextBoxColumn.Name = "tableIsCombinableDataGridViewTextBoxColumn";
            this.tableIsCombinableDataGridViewTextBoxColumn.Width = 180;
            // 
            // tableFeaturesDataGridViewTextBoxColumn
            // 
            this.tableFeaturesDataGridViewTextBoxColumn.DataPropertyName = "TableFeatures";
            this.tableFeaturesDataGridViewTextBoxColumn.HeaderText = "TABLE FEATURES";
            this.tableFeaturesDataGridViewTextBoxColumn.Name = "tableFeaturesDataGridViewTextBoxColumn";
            this.tableFeaturesDataGridViewTextBoxColumn.Width = 170;
            // 
            // restuarantTableBindingSource
            // 
            this.restuarantTableBindingSource.DataMember = "Restuarant_Table";
            this.restuarantTableBindingSource.DataSource = this.codeCraftersDS;
            // 
            // codeCraftersDS
            // 
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvHotelRoomAvailable
            // 
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
            this.dgvHotelRoomAvailable.Location = new System.Drawing.Point(32, 69);
            this.dgvHotelRoomAvailable.Name = "dgvHotelRoomAvailable";
            this.dgvHotelRoomAvailable.Size = new System.Drawing.Size(957, 126);
            this.dgvHotelRoomAvailable.TabIndex = 4;
            this.dgvHotelRoomAvailable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHotelRoomAvailable_RowHeaderMouseDoubleClick);
            // 
            // hotelRoomIDDataGridViewTextBoxColumn
            // 
            this.hotelRoomIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_ID";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.hotelRoomIDDataGridViewTextBoxColumn.HeaderText = "ROOM ID";
            this.hotelRoomIDDataGridViewTextBoxColumn.Name = "hotelRoomIDDataGridViewTextBoxColumn";
            this.hotelRoomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelRoomIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BRANCH ID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // hotelroomtypeIDDataGridViewTextBoxColumn
            // 
            this.hotelroomtypeIDDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_type_ID";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.HeaderText = "ROOM TYPE ID";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.Name = "hotelroomtypeIDDataGridViewTextBoxColumn";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.Width = 180;
            // 
            // hotelroomnumberDataGridViewTextBoxColumn
            // 
            this.hotelroomnumberDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_number";
            this.hotelroomnumberDataGridViewTextBoxColumn.HeaderText = "ROOM NO.";
            this.hotelroomnumberDataGridViewTextBoxColumn.Name = "hotelroomnumberDataGridViewTextBoxColumn";
            this.hotelroomnumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // hotelroomstatusDataGridViewTextBoxColumn
            // 
            this.hotelroomstatusDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_status";
            this.hotelroomstatusDataGridViewTextBoxColumn.HeaderText = "ROOM STATUS";
            this.hotelroomstatusDataGridViewTextBoxColumn.Name = "hotelroomstatusDataGridViewTextBoxColumn";
            this.hotelroomstatusDataGridViewTextBoxColumn.Width = 180;
            // 
            // hotelRoomPriceDataGridViewTextBoxColumn
            // 
            this.hotelRoomPriceDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_Price";
            this.hotelRoomPriceDataGridViewTextBoxColumn.HeaderText = "ROOM PRICE";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Name = "hotelRoomPriceDataGridViewTextBoxColumn";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelRoomBindingSource
            // 
            this.hotelRoomBindingSource.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource.DataSource = this.codeCraftersDS;
            // 
            // lblRestaurantTableAvailable
            // 
            this.lblRestaurantTableAvailable.AutoSize = true;
            this.lblRestaurantTableAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantTableAvailable.Location = new System.Drawing.Point(29, 207);
            this.lblRestaurantTableAvailable.Name = "lblRestaurantTableAvailable";
            this.lblRestaurantTableAvailable.Size = new System.Drawing.Size(198, 17);
            this.lblRestaurantTableAvailable.TabIndex = 3;
            this.lblRestaurantTableAvailable.Text = "ENTER RESTAURANT TABLE ID:";
            // 
            // lblHotelRoomAvailable
            // 
            this.lblHotelRoomAvailable.AutoSize = true;
            this.lblHotelRoomAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelRoomAvailable.Location = new System.Drawing.Point(29, 42);
            this.lblHotelRoomAvailable.Name = "lblHotelRoomAvailable";
            this.lblHotelRoomAvailable.Size = new System.Drawing.Size(159, 17);
            this.lblHotelRoomAvailable.TabIndex = 2;
            this.lblHotelRoomAvailable.Text = "ENTER HOTEL ROOM ID:";
            // 
            // txtHotelRoomAvailable
            // 
            this.txtHotelRoomAvailable.Location = new System.Drawing.Point(194, 34);
            this.txtHotelRoomAvailable.Name = "txtHotelRoomAvailable";
            this.txtHotelRoomAvailable.Size = new System.Drawing.Size(94, 29);
            this.txtHotelRoomAvailable.TabIndex = 0;
            this.txtHotelRoomAvailable.TextChanged += new System.EventHandler(this.txtHotelRoomAvailable_TextChanged);
            // 
            // grpClientDetails
            // 
            this.grpClientDetails.Controls.Add(this.txtPhoneNumber);
            this.grpClientDetails.Controls.Add(this.txtAddress);
            this.grpClientDetails.Controls.Add(this.txtEmailAddress);
            this.grpClientDetails.Controls.Add(this.txtFullName);
            this.grpClientDetails.Controls.Add(this.lblAddress);
            this.grpClientDetails.Controls.Add(this.lblEmailAddress);
            this.grpClientDetails.Controls.Add(this.lblPhoneNumber);
            this.grpClientDetails.Controls.Add(this.lblFullName);
            this.grpClientDetails.Location = new System.Drawing.Point(85, 38);
            this.grpClientDetails.Name = "grpClientDetails";
            this.grpClientDetails.Size = new System.Drawing.Size(1008, 170);
            this.grpClientDetails.TabIndex = 22;
            this.grpClientDetails.TabStop = false;
            this.grpClientDetails.Text = "CLIENT DETAILS";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(29, 120);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(168, 29);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(367, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 29);
            this.txtAddress.TabIndex = 6;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(367, 62);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(251, 29);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(29, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(196, 29);
            this.txtFullName.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(364, 100);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "ADDRESS:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(364, 39);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(113, 17);
            this.lblEmailAddress.TabIndex = 2;
            this.lblEmailAddress.Text = "EMAIL ADDRESS:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(26, 100);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(115, 17);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "PHONE NUMBER:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(26, 39);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(84, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "FULL NAME:";
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // taClient
            // 
            this.taClient.ClearBeforeFill = true;
            // 
            // taBranch
            // 
            this.taBranch.ClearBeforeFill = true;
            // 
            // taHotelRoom
            // 
            this.taHotelRoom.ClearBeforeFill = true;
            // 
            // taRatePlan
            // 
            this.taRatePlan.ClearBeforeFill = true;
            // 
            // taRoomAssignment
            // 
            this.taRoomAssignment.ClearBeforeFill = true;
            // 
            // taTableAllocation
            // 
            this.taTableAllocation.ClearBeforeFill = true;
            // 
            // taRestaurantTable
            // 
            this.taRestaurantTable.ClearBeforeFill = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 1061);
            this.Controls.Add(this.pnlBooking);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingForm";
            this.Text = "REGAL INN MAKE BOOKINGS";
            this.pnlBooking.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantTableAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            this.grpClientDetails.ResumeLayout(false);
            this.grpClientDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateBooking;
        private codeCraftersDS codeCraftersDS;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBooking;
        private codeCraftersDSTableAdapters.ClientTableAdapter taClient;
        private codeCraftersDSTableAdapters.BranchTableAdapter taBranch;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter taHotelRoom;
        private codeCraftersDSTableAdapters.Rate_PlanTableAdapter taRatePlan;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.GroupBox grpClientDetails;
        private codeCraftersDSTableAdapters.Room_AssignmentTableAdapter taRoomAssignment;
        private codeCraftersDSTableAdapters.Table_AllocationTableAdapter taTableAllocation;
        private codeCraftersDSTableAdapters.Restuarant_TableTableAdapter taRestaurantTable;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.DataGridView dgvRestaurantTableAvailable;
        private System.Windows.Forms.DataGridView dgvHotelRoomAvailable;
        private System.Windows.Forms.Label lblRestaurantTableAvailable;
        private System.Windows.Forms.Label lblHotelRoomAvailable;
        private System.Windows.Forms.TextBox txtHotelRoomAvailable;
        private System.Windows.Forms.TextBox txtRestaurantTableAvailable;
        private System.Windows.Forms.BindingSource restuarantTableBindingSource;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantTableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn restuarantTableNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restuarantMenuTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIsCombinableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableFeaturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mclCheckOut;
        private System.Windows.Forms.MonthCalendar mclCheckIn;
    }
}