namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class RoomManagementForm
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
            this.hotelRoomBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDSTWO = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWO();
            this.hotelRoomBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnClearRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.taRoomHotel = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Hotel_RoomTableAdapter();
            this.room_AssignmentTableAdapter = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Room_AssignmentTableAdapter();
            this.hotel_RoomTableAdapter = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.codeCraftersDSTWOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpViewRooms = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHotelRoomType = new System.Windows.Forms.ComboBox();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.cmbBranchName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblRoomsUnderMaintenance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvViewRooms = new System.Windows.Forms.DataGridView();
            this.hotel_view_room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCleanedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOccupiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotel_room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcViewRooms = new System.Windows.Forms.TabControl();
            this.hotelRoomBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.fKRoomAssiHotel1B5E0D89BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelRoomBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWOBindingSource)).BeginInit();
            this.tbpViewRooms.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBooking.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource5)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tbcViewRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomAssiHotel1B5E0D89BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelRoomBindingSource4
            // 
            this.hotelRoomBindingSource4.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource4.DataSource = this.codeCraftersDSTWO;
            // 
            // codeCraftersDSTWO
            // 
            this.codeCraftersDSTWO.DataSetName = "codeCraftersDSTWO";
            this.codeCraftersDSTWO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelRoomBindingSource3
            // 
            this.hotelRoomBindingSource3.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource3.DataSource = this.codeCraftersDSTWO;
            // 
            // hotelRoomBindingSource1
            // 
            this.hotelRoomBindingSource1.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource1.DataSource = this.codeCraftersDSTWO;
            // 
            // hotelRoomBindingSource
            // 
            this.hotelRoomBindingSource.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource.DataSource = this.codeCraftersDSTWO;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRoom.Location = new System.Drawing.Point(234, 573);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(91, 33);
            this.btnUpdateRoom.TabIndex = 11;
            this.btnUpdateRoom.Text = "UPDATE";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            // 
            // btnClearRoom
            // 
            this.btnClearRoom.BackColor = System.Drawing.Color.DarkGray;
            this.btnClearRoom.Location = new System.Drawing.Point(69, 573);
            this.btnClearRoom.Name = "btnClearRoom";
            this.btnClearRoom.Size = new System.Drawing.Size(75, 33);
            this.btnClearRoom.TabIndex = 10;
            this.btnClearRoom.Text = "CLEAR";
            this.btnClearRoom.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRoom.Location = new System.Drawing.Point(409, 573);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteRoom.TabIndex = 9;
            this.btnDeleteRoom.Text = "DELETE";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.Location = new System.Drawing.Point(573, 573);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 33);
            this.btnAddRoom.TabIndex = 8;
            this.btnAddRoom.Text = "ADD";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // taRoomHotel
            // 
            this.taRoomHotel.ClearBeforeFill = true;
            // 
            // room_AssignmentTableAdapter
            // 
            this.room_AssignmentTableAdapter.ClearBeforeFill = true;
            // 
            // hotel_RoomTableAdapter
            // 
            this.hotel_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // codeCraftersDSTWOBindingSource
            // 
            this.codeCraftersDSTWOBindingSource.DataSource = this.codeCraftersDSTWO;
            this.codeCraftersDSTWOBindingSource.Position = 0;
            // 
            // tbpViewRooms
            // 
            this.tbpViewRooms.BackColor = System.Drawing.Color.DarkGray;
            this.tbpViewRooms.Controls.Add(this.panel12);
            this.tbpViewRooms.Controls.Add(this.panel1);
            this.tbpViewRooms.Location = new System.Drawing.Point(4, 26);
            this.tbpViewRooms.Name = "tbpViewRooms";
            this.tbpViewRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tbpViewRooms.Size = new System.Drawing.Size(1422, 908);
            this.tbpViewRooms.TabIndex = 1;
            this.tbpViewRooms.Text = "REGAL INN VIEW ROOMS";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Controls.Add(this.label18);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1416, 74);
            this.panel12.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(204, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1078, 31);
            this.label18.TabIndex = 1;
            this.label18.Text = "MONITOR REGAL INN HOTEL LIVE BRANCHES METRICS && ROOM STATUSES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbHotelRoomType);
            this.panel1.Controls.Add(this.pnlBooking);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.dgvViewRooms);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(213, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 745);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "ROOM TYPE:";
            // 
            // cmbHotelRoomType
            // 
            this.cmbHotelRoomType.FormattingEnabled = true;
            this.cmbHotelRoomType.Items.AddRange(new object[] {
            "All Rooms",
            "Standard Room 1 King Bed",
            "Suite Room Twin Beds",
            "Suite Room 1 King Bed",
            "Executive Room 1 King Bed",
            "Deluxe Room 1 King Bed",
            "Standard Room 2 Double Beds"});
            this.cmbHotelRoomType.Location = new System.Drawing.Point(185, 270);
            this.cmbHotelRoomType.Name = "cmbHotelRoomType";
            this.cmbHotelRoomType.Size = new System.Drawing.Size(223, 25);
            this.cmbHotelRoomType.TabIndex = 50;
            this.cmbHotelRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbHotelRoomType_SelectedIndexChanged);
            // 
            // pnlBooking
            // 
            this.pnlBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBooking.Controls.Add(this.cmbBranchName);
            this.pnlBooking.Controls.Add(this.label9);
            this.pnlBooking.Controls.Add(this.btnRefresh);
            this.pnlBooking.Location = new System.Drawing.Point(87, 25);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(936, 70);
            this.pnlBooking.TabIndex = 49;
            // 
            // cmbBranchName
            // 
            this.cmbBranchName.FormattingEnabled = true;
            this.cmbBranchName.Items.AddRange(new object[] {
            "All Branches",
            "Pietermaritzburg",
            "Durban Umhlanga",
            "Durban North Beach",
            "Durban Ballito",
            "JHB Midrand"});
            this.cmbBranchName.Location = new System.Drawing.Point(160, 24);
            this.cmbBranchName.Name = "cmbBranchName";
            this.cmbBranchName.Size = new System.Drawing.Size(160, 25);
            this.cmbBranchName.TabIndex = 44;
            this.cmbBranchName.SelectedIndexChanged += new System.EventHandler(this.cmbBranchName_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(3, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "🏨 REGAL INN HOTELS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Location = new System.Drawing.Point(703, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(216, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTotalRooms);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(87, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 122);
            this.panel4.TabIndex = 2;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRooms.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRooms.Location = new System.Drawing.Point(71, 40);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(84, 65);
            this.lblTotalRooms.TabIndex = 15;
            this.lblTotalRooms.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "TOTAL ROOMS";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblRoomsUnderMaintenance);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(778, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 122);
            this.panel7.TabIndex = 5;
            // 
            // lblRoomsUnderMaintenance
            // 
            this.lblRoomsUnderMaintenance.AutoSize = true;
            this.lblRoomsUnderMaintenance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsUnderMaintenance.ForeColor = System.Drawing.Color.Black;
            this.lblRoomsUnderMaintenance.Location = new System.Drawing.Point(97, 40);
            this.lblRoomsUnderMaintenance.Name = "lblRoomsUnderMaintenance";
            this.lblRoomsUnderMaintenance.Size = new System.Drawing.Size(56, 65);
            this.lblRoomsUnderMaintenance.TabIndex = 14;
            this.lblRoomsUnderMaintenance.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "MAINTENANCE ROOMS";
            // 
            // dgvViewRooms
            // 
            this.dgvViewRooms.AutoGenerateColumns = false;
            this.dgvViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotel_view_room_number,
            this.hotelroomstatusDataGridViewTextBoxColumn,
            this.hotelRoomPriceDataGridViewTextBoxColumn,
            this.cleaningStatusDataGridViewTextBoxColumn,
            this.lastCleanedDataGridViewTextBoxColumn,
            this.lastOccupiedDataGridViewTextBoxColumn,
            this.hotel_room_type});
            this.dgvViewRooms.DataSource = this.hotelRoomBindingSource5;
            this.dgvViewRooms.Location = new System.Drawing.Point(87, 318);
            this.dgvViewRooms.Name = "dgvViewRooms";
            this.dgvViewRooms.RowHeadersWidth = 51;
            this.dgvViewRooms.Size = new System.Drawing.Size(936, 384);
            this.dgvViewRooms.TabIndex = 7;
            // 
            // hotel_view_room_number
            // 
            this.hotel_view_room_number.DataPropertyName = "hotel_room_number";
            this.hotel_view_room_number.HeaderText = "ROOM NO.";
            this.hotel_view_room_number.MinimumWidth = 6;
            this.hotel_view_room_number.Name = "hotel_view_room_number";
            this.hotel_view_room_number.Width = 125;
            // 
            // hotelroomstatusDataGridViewTextBoxColumn
            // 
            this.hotelroomstatusDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_status";
            this.hotelroomstatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.hotelroomstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelroomstatusDataGridViewTextBoxColumn.Name = "hotelroomstatusDataGridViewTextBoxColumn";
            this.hotelroomstatusDataGridViewTextBoxColumn.Width = 90;
            // 
            // hotelRoomPriceDataGridViewTextBoxColumn
            // 
            this.hotelRoomPriceDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_Price";
            this.hotelRoomPriceDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.hotelRoomPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelRoomPriceDataGridViewTextBoxColumn.Name = "hotelRoomPriceDataGridViewTextBoxColumn";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // cleaningStatusDataGridViewTextBoxColumn
            // 
            this.cleaningStatusDataGridViewTextBoxColumn.DataPropertyName = "Cleaning_Status";
            this.cleaningStatusDataGridViewTextBoxColumn.HeaderText = "CLEANING STATUS";
            this.cleaningStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cleaningStatusDataGridViewTextBoxColumn.Name = "cleaningStatusDataGridViewTextBoxColumn";
            this.cleaningStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastCleanedDataGridViewTextBoxColumn
            // 
            this.lastCleanedDataGridViewTextBoxColumn.DataPropertyName = "Last_Cleaned";
            this.lastCleanedDataGridViewTextBoxColumn.HeaderText = "LAST CLEANED";
            this.lastCleanedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastCleanedDataGridViewTextBoxColumn.Name = "lastCleanedDataGridViewTextBoxColumn";
            this.lastCleanedDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastOccupiedDataGridViewTextBoxColumn
            // 
            this.lastOccupiedDataGridViewTextBoxColumn.DataPropertyName = "Last_Occupied";
            this.lastOccupiedDataGridViewTextBoxColumn.HeaderText = "LAST OCCUPIED";
            this.lastOccupiedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastOccupiedDataGridViewTextBoxColumn.Name = "lastOccupiedDataGridViewTextBoxColumn";
            this.lastOccupiedDataGridViewTextBoxColumn.Width = 130;
            // 
            // hotel_room_type
            // 
            this.hotel_room_type.DataPropertyName = "hotel_room_type";
            this.hotel_room_type.HeaderText = "ROOM TYPE";
            this.hotel_room_type.MinimumWidth = 6;
            this.hotel_room_type.Name = "hotel_room_type";
            this.hotel_room_type.Width = 180;
            // 
            // hotelRoomBindingSource5
            // 
            this.hotelRoomBindingSource5.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource5.DataSource = this.codeCraftersDSTWOBindingSource;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblAvailableRooms);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(315, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 122);
            this.panel5.TabIndex = 3;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.Black;
            this.lblAvailableRooms.Location = new System.Drawing.Point(71, 40);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(84, 65);
            this.lblAvailableRooms.TabIndex = 15;
            this.lblAvailableRooms.Text = "14";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "AVAILABLE ROOMS";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblOccupiedRooms);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(549, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 122);
            this.panel6.TabIndex = 4;
            // 
            // lblOccupiedRooms
            // 
            this.lblOccupiedRooms.AutoSize = true;
            this.lblOccupiedRooms.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupiedRooms.ForeColor = System.Drawing.Color.Black;
            this.lblOccupiedRooms.Location = new System.Drawing.Point(88, 40);
            this.lblOccupiedRooms.Name = "lblOccupiedRooms";
            this.lblOccupiedRooms.Size = new System.Drawing.Size(56, 65);
            this.lblOccupiedRooms.TabIndex = 15;
            this.lblOccupiedRooms.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "OCCUPIED ROOMS";
            // 
            // tbcViewRooms
            // 
            this.tbcViewRooms.Controls.Add(this.tbpViewRooms);
            this.tbcViewRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcViewRooms.Location = new System.Drawing.Point(0, 0);
            this.tbcViewRooms.Name = "tbcViewRooms";
            this.tbcViewRooms.SelectedIndex = 0;
            this.tbcViewRooms.Size = new System.Drawing.Size(1430, 938);
            this.tbcViewRooms.TabIndex = 0;
            // 
            // hotelRoomBindingSource6
            // 
            this.hotelRoomBindingSource6.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource6.DataSource = this.codeCraftersDSTWOBindingSource;
            // 
            // fKRoomAssiHotel1B5E0D89BindingSource
            // 
            this.fKRoomAssiHotel1B5E0D89BindingSource.DataMember = "FK__Room_Assi__Hotel__1B5E0D89";
            this.fKRoomAssiHotel1B5E0D89BindingSource.DataSource = this.hotelRoomBindingSource1;
            // 
            // RoomManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1430, 938);
            this.Controls.Add(this.tbcViewRooms);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManagementForm";
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RoomManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWOBindingSource)).EndInit();
            this.tbpViewRooms.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBooking.ResumeLayout(false);
            this.pnlBooking.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tbcViewRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomAssiHotel1B5E0D89BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnClearRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomtypeIDDataGridViewTextBoxColumn;
        private codeCraftersDSTWO codeCraftersDSTWO;
        private codeCraftersDSTWOTableAdapters.Hotel_RoomTableAdapter taRoomHotel;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource1;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource2;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter hotel_RoomTableAdapter;
        private System.Windows.Forms.BindingSource fKRoomAssiHotel1B5E0D89BindingSource;
        private codeCraftersDSTWOTableAdapters.Room_AssignmentTableAdapter room_AssignmentTableAdapter;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource3;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.BindingSource codeCraftersDSTWOBindingSource;
        private System.Windows.Forms.TabPage tbpViewRooms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblRoomsUnderMaintenance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblOccupiedRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tbcViewRooms;
        private System.Windows.Forms.DataGridView dgvViewRooms;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource5;
        private System.Windows.Forms.ComboBox cmbHotelRoomType;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.ComboBox cmbBranchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel_view_room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleaningStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCleanedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOccupiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel_room_type;
    }
}