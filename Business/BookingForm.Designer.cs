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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            this.restuarantTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.taClient = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
            this.taBranch = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter();
            this.taHotelRoom = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.taRatePlan = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Rate_PlanTableAdapter();
            this.taRoomAssignment = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Room_AssignmentTableAdapter();
            this.taTableAllocation = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Table_AllocationTableAdapter();
            this.taRestaurantTable = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Restuarant_TableTableAdapter();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.grpRegalInnBooking = new System.Windows.Forms.GroupBox();
            this.cmbBranchID = new System.Windows.Forms.ComboBox();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.hotelRoomIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantTableIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantTableNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantTablePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mclCheckOut = new System.Windows.Forms.MonthCalendar();
            this.mclCheckIn = new System.Windows.Forms.MonthCalendar();
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
            this.tablePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHotelRoomAvailable = new System.Windows.Forms.DataGridView();
            this.hotelRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnCreateBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.pnlBooking.SuspendLayout();
            this.grpRegalInnBooking.SuspendLayout();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantTableAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomAvailable)).BeginInit();
            this.grpClientDetails.SuspendLayout();
            this.SuspendLayout();
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
            // hotelRoomBindingSource
            // 
            this.hotelRoomBindingSource.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource.DataSource = this.codeCraftersDS;
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
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.codeCraftersDS;
            // 
            // pnlBooking
            // 
            this.pnlBooking.BackColor = System.Drawing.Color.White;
            this.pnlBooking.Controls.Add(this.grpRegalInnBooking);
            this.pnlBooking.Location = new System.Drawing.Point(12, 2);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(1204, 1006);
            this.pnlBooking.TabIndex = 3;
            // 
            // grpRegalInnBooking
            // 
            this.grpRegalInnBooking.Controls.Add(this.cmbBranchID);
            this.grpRegalInnBooking.Controls.Add(this.lblBranchID);
            this.grpRegalInnBooking.Controls.Add(this.grpBookingDetails);
            this.grpRegalInnBooking.Controls.Add(this.grpClientDetails);
            this.grpRegalInnBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpRegalInnBooking.Location = new System.Drawing.Point(20, 40);
            this.grpRegalInnBooking.Name = "grpRegalInnBooking";
            this.grpRegalInnBooking.Size = new System.Drawing.Size(1130, 988);
            this.grpRegalInnBooking.TabIndex = 4;
            this.grpRegalInnBooking.TabStop = false;
            this.grpRegalInnBooking.Text = "REGAL INN BOOKING";
            // 
            // cmbBranchID
            // 
            this.cmbBranchID.FormattingEnabled = true;
            this.cmbBranchID.Items.AddRange(new object[] {
            "BR01",
            "BR02",
            "BR03",
            "BR04",
            "BR05"});
            this.cmbBranchID.Location = new System.Drawing.Point(220, 30);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(131, 29);
            this.cmbBranchID.TabIndex = 1;
            // 
            // lblBranchID
            // 
            this.lblBranchID.ForeColor = System.Drawing.Color.Black;
            this.lblBranchID.Location = new System.Drawing.Point(20, 33);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(190, 25);
            this.lblBranchID.TabIndex = 0;
            this.lblBranchID.Text = "REGAL INN BRANCH ID:";
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpBookingDetails.Controls.Add(this.txtTotalAmount);
            this.grpBookingDetails.Controls.Add(this.lblTotalAmount);
            this.grpBookingDetails.Controls.Add(this.dgvInvoice);
            this.grpBookingDetails.Controls.Add(this.label3);
            this.grpBookingDetails.Controls.Add(this.label2);
            this.grpBookingDetails.Controls.Add(this.mclCheckOut);
            this.grpBookingDetails.Controls.Add(this.mclCheckIn);
            this.grpBookingDetails.Controls.Add(this.label1);
            this.grpBookingDetails.Controls.Add(this.txtRestaurantTableAvailable);
            this.grpBookingDetails.Controls.Add(this.dgvRestaurantTableAvailable);
            this.grpBookingDetails.Controls.Add(this.dgvHotelRoomAvailable);
            this.grpBookingDetails.Controls.Add(this.lblRestaurantTableAvailable);
            this.grpBookingDetails.Controls.Add(this.lblHotelRoomAvailable);
            this.grpBookingDetails.Controls.Add(this.txtHotelRoomAvailable);
            this.grpBookingDetails.Location = new System.Drawing.Point(20, 220);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(1084, 746);
            this.grpBookingDetails.TabIndex = 5;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "BOOKING DETAILS";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(860, 703);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(180, 29);
            this.txtTotalAmount.TabIndex = 12;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(723, 706);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(140, 25);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "TOTAL AMOUNT:";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AutoGenerateColumns = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelRoomIDDataGridViewTextBoxColumn1,
            this.hotelroomnumberDataGridViewTextBoxColumn1,
            this.hotelRoomPriceDataGridViewTextBoxColumn1,
            this.restaurantTableIDDataGridViewTextBoxColumn1,
            this.restaurantTableNumDataGridViewTextBoxColumn,
            this.restaurantTablePriceDataGridViewTextBoxColumn});
            this.dgvInvoice.DataSource = this.invoiceBindingSource;
            this.dgvInvoice.Location = new System.Drawing.Point(20, 583);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(1020, 110);
            this.dgvInvoice.TabIndex = 13;
            // 
            // hotelRoomIDDataGridViewTextBoxColumn1
            // 
            this.hotelRoomIDDataGridViewTextBoxColumn1.DataPropertyName = "Hotel_Room_ID";
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomIDDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle43;
            this.hotelRoomIDDataGridViewTextBoxColumn1.HeaderText = "ROOM ID";
            this.hotelRoomIDDataGridViewTextBoxColumn1.Name = "hotelRoomIDDataGridViewTextBoxColumn1";
            this.hotelRoomIDDataGridViewTextBoxColumn1.Width = 110;
            // 
            // hotelroomnumberDataGridViewTextBoxColumn1
            // 
            this.hotelroomnumberDataGridViewTextBoxColumn1.DataPropertyName = "Hotel_room_number";
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomnumberDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle44;
            this.hotelroomnumberDataGridViewTextBoxColumn1.HeaderText = "ROOM NO.";
            this.hotelroomnumberDataGridViewTextBoxColumn1.Name = "hotelroomnumberDataGridViewTextBoxColumn1";
            this.hotelroomnumberDataGridViewTextBoxColumn1.Width = 130;
            // 
            // hotelRoomPriceDataGridViewTextBoxColumn1
            // 
            this.hotelRoomPriceDataGridViewTextBoxColumn1.DataPropertyName = "Hotel_Room_Price";
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomPriceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle45;
            this.hotelRoomPriceDataGridViewTextBoxColumn1.HeaderText = "ROOM PRICE";
            this.hotelRoomPriceDataGridViewTextBoxColumn1.Name = "hotelRoomPriceDataGridViewTextBoxColumn1";
            this.hotelRoomPriceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // restaurantTableIDDataGridViewTextBoxColumn1
            // 
            this.restaurantTableIDDataGridViewTextBoxColumn1.DataPropertyName = "RestaurantTable_ID";
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantTableIDDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle46;
            this.restaurantTableIDDataGridViewTextBoxColumn1.HeaderText = "TABLE ID";
            this.restaurantTableIDDataGridViewTextBoxColumn1.Name = "restaurantTableIDDataGridViewTextBoxColumn1";
            this.restaurantTableIDDataGridViewTextBoxColumn1.Width = 110;
            // 
            // restaurantTableNumDataGridViewTextBoxColumn
            // 
            this.restaurantTableNumDataGridViewTextBoxColumn.DataPropertyName = "RestaurantTableNum";
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantTableNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle47;
            this.restaurantTableNumDataGridViewTextBoxColumn.HeaderText = "TABLE NO.";
            this.restaurantTableNumDataGridViewTextBoxColumn.Name = "restaurantTableNumDataGridViewTextBoxColumn";
            this.restaurantTableNumDataGridViewTextBoxColumn.Width = 130;
            // 
            // restaurantTablePriceDataGridViewTextBoxColumn
            // 
            this.restaurantTablePriceDataGridViewTextBoxColumn.DataPropertyName = "RestaurantTablePrice";
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantTablePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle48;
            this.restaurantTablePriceDataGridViewTextBoxColumn.HeaderText = "TABLE PRICE";
            this.restaurantTablePriceDataGridViewTextBoxColumn.Name = "restaurantTablePriceDataGridViewTextBoxColumn";
            this.restaurantTablePriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(270, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CHECK OUT DATE";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHECK IN DATE";
            // 
            // mclCheckOut
            // 
            this.mclCheckOut.Location = new System.Drawing.Point(274, 380);
            this.mclCheckOut.Name = "mclCheckOut";
            this.mclCheckOut.TabIndex = 9;
            // 
            // mclCheckIn
            // 
            this.mclCheckIn.Location = new System.Drawing.Point(20, 380);
            this.mclCheckIn.Name = "mclCheckIn";
            this.mclCheckIn.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "CURRENT BOOKING SELECTIONS (INVOICE)";
            // 
            // txtRestaurantTableAvailable
            // 
            this.txtRestaurantTableAvailable.Location = new System.Drawing.Point(216, 184);
            this.txtRestaurantTableAvailable.Name = "txtRestaurantTableAvailable";
            this.txtRestaurantTableAvailable.Size = new System.Drawing.Size(100, 29);
            this.txtRestaurantTableAvailable.TabIndex = 4;
            this.txtRestaurantTableAvailable.TextChanged += new System.EventHandler(this.txtRestaurantTableAvailable_TextChanged_1);
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
            this.tableFeaturesDataGridViewTextBoxColumn,
            this.tablePriceDataGridViewTextBoxColumn});
            this.dgvRestaurantTableAvailable.DataSource = this.restuarantTableBindingSource;
            this.dgvRestaurantTableAvailable.Location = new System.Drawing.Point(20, 222);
            this.dgvRestaurantTableAvailable.Name = "dgvRestaurantTableAvailable";
            this.dgvRestaurantTableAvailable.Size = new System.Drawing.Size(1020, 118);
            this.dgvRestaurantTableAvailable.TabIndex = 5;
            this.dgvRestaurantTableAvailable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRestaurantTableAvailable_RowHeaderMouseDoubleClick);
            // 
            // restaurantTableIDDataGridViewTextBoxColumn
            // 
            this.restaurantTableIDDataGridViewTextBoxColumn.DataPropertyName = "RestaurantTableID";
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantTableIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle49;
            this.restaurantTableIDDataGridViewTextBoxColumn.HeaderText = "TABLE ID";
            this.restaurantTableIDDataGridViewTextBoxColumn.Name = "restaurantTableIDDataGridViewTextBoxColumn";
            this.restaurantTableIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.restaurantTableIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // branchIDDataGridViewTextBoxColumn1
            // 
            this.branchIDDataGridViewTextBoxColumn1.DataPropertyName = "Branch_ID";
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle50;
            this.branchIDDataGridViewTextBoxColumn1.HeaderText = "BRANCH ID";
            this.branchIDDataGridViewTextBoxColumn1.Name = "branchIDDataGridViewTextBoxColumn1";
            this.branchIDDataGridViewTextBoxColumn1.Width = 130;
            // 
            // restuarantTableNumDataGridViewTextBoxColumn
            // 
            this.restuarantTableNumDataGridViewTextBoxColumn.DataPropertyName = "RestuarantTableNum";
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restuarantTableNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle51;
            this.restuarantTableNumDataGridViewTextBoxColumn.HeaderText = "TABLE NO.";
            this.restuarantTableNumDataGridViewTextBoxColumn.Name = "restuarantTableNumDataGridViewTextBoxColumn";
            this.restuarantTableNumDataGridViewTextBoxColumn.Width = 120;
            // 
            // restuarantMenuTypeDataGridViewTextBoxColumn
            // 
            this.restuarantMenuTypeDataGridViewTextBoxColumn.DataPropertyName = "RestuarantMenuType";
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restuarantMenuTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle52;
            this.restuarantMenuTypeDataGridViewTextBoxColumn.HeaderText = "TABLE MENU";
            this.restuarantMenuTypeDataGridViewTextBoxColumn.Name = "restuarantMenuTypeDataGridViewTextBoxColumn";
            this.restuarantMenuTypeDataGridViewTextBoxColumn.Width = 130;
            // 
            // tableCapacityDataGridViewTextBoxColumn
            // 
            this.tableCapacityDataGridViewTextBoxColumn.DataPropertyName = "TableCapacity";
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableCapacityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle53;
            this.tableCapacityDataGridViewTextBoxColumn.HeaderText = "TABLE CAPACITY";
            this.tableCapacityDataGridViewTextBoxColumn.Name = "tableCapacityDataGridViewTextBoxColumn";
            this.tableCapacityDataGridViewTextBoxColumn.Width = 160;
            // 
            // tableStatusDataGridViewTextBoxColumn
            // 
            this.tableStatusDataGridViewTextBoxColumn.DataPropertyName = "TableStatus";
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle54;
            this.tableStatusDataGridViewTextBoxColumn.HeaderText = "TABLE STATUS";
            this.tableStatusDataGridViewTextBoxColumn.Name = "tableStatusDataGridViewTextBoxColumn";
            this.tableStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // tableIsCombinableDataGridViewTextBoxColumn
            // 
            this.tableIsCombinableDataGridViewTextBoxColumn.DataPropertyName = "TableIsCombinable";
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIsCombinableDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle55;
            this.tableIsCombinableDataGridViewTextBoxColumn.HeaderText = "TABLE COMBINED";
            this.tableIsCombinableDataGridViewTextBoxColumn.Name = "tableIsCombinableDataGridViewTextBoxColumn";
            this.tableIsCombinableDataGridViewTextBoxColumn.Width = 180;
            // 
            // tableFeaturesDataGridViewTextBoxColumn
            // 
            this.tableFeaturesDataGridViewTextBoxColumn.DataPropertyName = "TableFeatures";
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableFeaturesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle56;
            this.tableFeaturesDataGridViewTextBoxColumn.HeaderText = "TABLE FEATURES";
            this.tableFeaturesDataGridViewTextBoxColumn.Name = "tableFeaturesDataGridViewTextBoxColumn";
            this.tableFeaturesDataGridViewTextBoxColumn.Width = 170;
            // 
            // tablePriceDataGridViewTextBoxColumn
            // 
            this.tablePriceDataGridViewTextBoxColumn.DataPropertyName = "TablePrice";
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle57;
            this.tablePriceDataGridViewTextBoxColumn.HeaderText = "TABLE PRICE";
            this.tablePriceDataGridViewTextBoxColumn.Name = "tablePriceDataGridViewTextBoxColumn";
            this.tablePriceDataGridViewTextBoxColumn.Width = 140;
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
            this.dgvHotelRoomAvailable.Location = new System.Drawing.Point(20, 65);
            this.dgvHotelRoomAvailable.Name = "dgvHotelRoomAvailable";
            this.dgvHotelRoomAvailable.Size = new System.Drawing.Size(1020, 110);
            this.dgvHotelRoomAvailable.TabIndex = 2;
            this.dgvHotelRoomAvailable.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHotelRoomAvailable_RowHeaderMouseDoubleClick);
            // 
            // hotelRoomIDDataGridViewTextBoxColumn
            // 
            this.hotelRoomIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_ID";
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle58;
            this.hotelRoomIDDataGridViewTextBoxColumn.HeaderText = "ROOM ID";
            this.hotelRoomIDDataGridViewTextBoxColumn.Name = "hotelRoomIDDataGridViewTextBoxColumn";
            this.hotelRoomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelRoomIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle59;
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BRANCH ID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // hotelroomtypeIDDataGridViewTextBoxColumn
            // 
            this.hotelroomtypeIDDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_type_ID";
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomtypeIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle60;
            this.hotelroomtypeIDDataGridViewTextBoxColumn.HeaderText = "ROOM TYPE ID";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.Name = "hotelroomtypeIDDataGridViewTextBoxColumn";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelroomnumberDataGridViewTextBoxColumn
            // 
            this.hotelroomnumberDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_number";
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle61;
            this.hotelroomnumberDataGridViewTextBoxColumn.HeaderText = "ROOM NO.";
            this.hotelroomnumberDataGridViewTextBoxColumn.Name = "hotelroomnumberDataGridViewTextBoxColumn";
            this.hotelroomnumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // hotelroomstatusDataGridViewTextBoxColumn
            // 
            this.hotelroomstatusDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_status";
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomstatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle62;
            this.hotelroomstatusDataGridViewTextBoxColumn.HeaderText = "ROOM STATUS";
            this.hotelroomstatusDataGridViewTextBoxColumn.Name = "hotelroomstatusDataGridViewTextBoxColumn";
            this.hotelroomstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelRoomPriceDataGridViewTextBoxColumn
            // 
            this.hotelRoomPriceDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_Price";
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle63;
            this.hotelRoomPriceDataGridViewTextBoxColumn.HeaderText = "ROOM PRICE";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Name = "hotelRoomPriceDataGridViewTextBoxColumn";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // lblRestaurantTableAvailable
            // 
            this.lblRestaurantTableAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRestaurantTableAvailable.Location = new System.Drawing.Point(20, 190);
            this.lblRestaurantTableAvailable.Name = "lblRestaurantTableAvailable";
            this.lblRestaurantTableAvailable.Size = new System.Drawing.Size(200, 20);
            this.lblRestaurantTableAvailable.TabIndex = 3;
            this.lblRestaurantTableAvailable.Text = "ENTER RESTAURANT TABLE ID:";
            // 
            // lblHotelRoomAvailable
            // 
            this.lblHotelRoomAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHotelRoomAvailable.Location = new System.Drawing.Point(20, 33);
            this.lblHotelRoomAvailable.Name = "lblHotelRoomAvailable";
            this.lblHotelRoomAvailable.Size = new System.Drawing.Size(160, 20);
            this.lblHotelRoomAvailable.TabIndex = 0;
            this.lblHotelRoomAvailable.Text = "ENTER HOTEL ROOM ID:";
            // 
            // txtHotelRoomAvailable
            // 
            this.txtHotelRoomAvailable.Location = new System.Drawing.Point(190, 27);
            this.txtHotelRoomAvailable.Name = "txtHotelRoomAvailable";
            this.txtHotelRoomAvailable.Size = new System.Drawing.Size(126, 29);
            this.txtHotelRoomAvailable.TabIndex = 1;
            this.txtHotelRoomAvailable.TextChanged += new System.EventHandler(this.txtHotelRoomAvailable_TextChanged_1);
            // 
            // grpClientDetails
            // 
            this.grpClientDetails.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.grpClientDetails.Size = new System.Drawing.Size(1073, 144);
            this.grpClientDetails.TabIndex = 4;
            this.grpClientDetails.TabStop = false;
            this.grpClientDetails.Text = "CLIENT DETAILS";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(20, 105);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(220, 29);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(280, 105);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 29);
            this.txtAddress.TabIndex = 7;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(280, 55);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(250, 29);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(20, 55);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(220, 29);
            this.txtFullName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(280, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "ADDRESS:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmailAddress.Location = new System.Drawing.Point(280, 30);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(120, 20);
            this.lblEmailAddress.TabIndex = 4;
            this.lblEmailAddress.Text = "EMAIL ADDRESS:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 85);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "PHONE NUMBER:";
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(20, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "FULL NAME:";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreateBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateBooking.Location = new System.Drawing.Point(892, 1014);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(200, 33);
            this.btnCreateBooking.TabIndex = 11;
            this.btnCreateBooking.Text = "MAKE A BOOKING";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click_1);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1237, 1061);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.pnlBooking);
            this.Name = "BookingForm";
            this.Text = "Booking Management System";
            this.Load += new System.EventHandler(this.BookingForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.restuarantTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.pnlBooking.ResumeLayout(false);
            this.grpRegalInnBooking.ResumeLayout(false);
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantTableAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomAvailable)).EndInit();
            this.grpClientDetails.ResumeLayout(false);
            this.grpClientDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.GroupBox grpRegalInnBooking;
        private System.Windows.Forms.ComboBox cmbBranchID;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantTableIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantTableNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantTablePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mclCheckOut;
        private System.Windows.Forms.MonthCalendar mclCheckIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRestaurantTableAvailable;
        private System.Windows.Forms.DataGridView dgvRestaurantTableAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantTableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn restuarantTableNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restuarantMenuTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIsCombinableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableFeaturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvHotelRoomAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblRestaurantTableAvailable;
        private System.Windows.Forms.Label lblHotelRoomAvailable;
        private System.Windows.Forms.TextBox txtHotelRoomAvailable;
        private System.Windows.Forms.GroupBox grpClientDetails;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnCreateBooking;
    }
}