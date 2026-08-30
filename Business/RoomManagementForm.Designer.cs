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
            this.fKRoomAssiHotel1B5E0D89BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_AssignmentTableAdapter = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Room_AssignmentTableAdapter();
            this.hotelRoomBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_RoomTableAdapter = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.codeCraftersDSTWOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpViewRooms = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblRoomsUnderMaintenance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcViewRooms = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelRoomBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAdultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxChildrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCleanedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOccupiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.cmbBranchName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hotelRoomBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelRoomIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomstatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAdultsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxChildrenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCleanedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOccupiedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomtypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomAssiHotel1B5E0D89BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWOBindingSource)).BeginInit();
            this.tbpViewRooms.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tbcViewRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource5)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.pnlBooking.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource6)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
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
            // fKRoomAssiHotel1B5E0D89BindingSource
            // 
            this.fKRoomAssiHotel1B5E0D89BindingSource.DataMember = "FK__Room_Assi__Hotel__1B5E0D89";
            this.fKRoomAssiHotel1B5E0D89BindingSource.DataSource = this.hotelRoomBindingSource1;
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
            this.tbpViewRooms.Text = "VIEW ROOMS";
            this.tbpViewRooms.Click += new System.EventHandler(this.tbpViewRooms_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pnlBooking);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(213, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 745);
            this.panel1.TabIndex = 2;
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
            // tbcViewRooms
            // 
            this.tbcViewRooms.Controls.Add(this.tbpViewRooms);
            this.tbcViewRooms.Controls.Add(this.tabPage1);
            this.tbcViewRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcViewRooms.Location = new System.Drawing.Point(0, 0);
            this.tbcViewRooms.Name = "tbcViewRooms";
            this.tbcViewRooms.SelectedIndex = 0;
            this.tbcViewRooms.Size = new System.Drawing.Size(1430, 938);
            this.tbcViewRooms.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelRoomIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.hotelroomnumberDataGridViewTextBoxColumn,
            this.hotelroomstatusDataGridViewTextBoxColumn,
            this.hotelRoomPriceDataGridViewTextBoxColumn,
            this.maxAdultsDataGridViewTextBoxColumn,
            this.maxChildrenDataGridViewTextBoxColumn,
            this.cleaningStatusDataGridViewTextBoxColumn,
            this.lastCleanedDataGridViewTextBoxColumn,
            this.lastOccupiedDataGridViewTextBoxColumn,
            this.hotelroomtypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hotelRoomBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(87, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(936, 384);
            this.dataGridView1.TabIndex = 7;
            // 
            // hotelRoomBindingSource5
            // 
            this.hotelRoomBindingSource5.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource5.DataSource = this.codeCraftersDSTWOBindingSource;
            // 
            // hotelRoomIDDataGridViewTextBoxColumn
            // 
            this.hotelRoomIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_ID";
            this.hotelRoomIDDataGridViewTextBoxColumn.HeaderText = "Hotel_Room_ID";
            this.hotelRoomIDDataGridViewTextBoxColumn.Name = "hotelRoomIDDataGridViewTextBoxColumn";
            this.hotelRoomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            // 
            // hotelroomnumberDataGridViewTextBoxColumn
            // 
            this.hotelroomnumberDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_number";
            this.hotelroomnumberDataGridViewTextBoxColumn.HeaderText = "hotel_room_number";
            this.hotelroomnumberDataGridViewTextBoxColumn.Name = "hotelroomnumberDataGridViewTextBoxColumn";
            // 
            // hotelroomstatusDataGridViewTextBoxColumn
            // 
            this.hotelroomstatusDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_status";
            this.hotelroomstatusDataGridViewTextBoxColumn.HeaderText = "hotel_room_status";
            this.hotelroomstatusDataGridViewTextBoxColumn.Name = "hotelroomstatusDataGridViewTextBoxColumn";
            // 
            // hotelRoomPriceDataGridViewTextBoxColumn
            // 
            this.hotelRoomPriceDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_Price";
            this.hotelRoomPriceDataGridViewTextBoxColumn.HeaderText = "Hotel_Room_Price";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Name = "hotelRoomPriceDataGridViewTextBoxColumn";
            // 
            // maxAdultsDataGridViewTextBoxColumn
            // 
            this.maxAdultsDataGridViewTextBoxColumn.DataPropertyName = "Max_Adults";
            this.maxAdultsDataGridViewTextBoxColumn.HeaderText = "Max_Adults";
            this.maxAdultsDataGridViewTextBoxColumn.Name = "maxAdultsDataGridViewTextBoxColumn";
            // 
            // maxChildrenDataGridViewTextBoxColumn
            // 
            this.maxChildrenDataGridViewTextBoxColumn.DataPropertyName = "Max_Children";
            this.maxChildrenDataGridViewTextBoxColumn.HeaderText = "Max_Children";
            this.maxChildrenDataGridViewTextBoxColumn.Name = "maxChildrenDataGridViewTextBoxColumn";
            // 
            // cleaningStatusDataGridViewTextBoxColumn
            // 
            this.cleaningStatusDataGridViewTextBoxColumn.DataPropertyName = "Cleaning_Status";
            this.cleaningStatusDataGridViewTextBoxColumn.HeaderText = "Cleaning_Status";
            this.cleaningStatusDataGridViewTextBoxColumn.Name = "cleaningStatusDataGridViewTextBoxColumn";
            // 
            // lastCleanedDataGridViewTextBoxColumn
            // 
            this.lastCleanedDataGridViewTextBoxColumn.DataPropertyName = "Last_Cleaned";
            this.lastCleanedDataGridViewTextBoxColumn.HeaderText = "Last_Cleaned";
            this.lastCleanedDataGridViewTextBoxColumn.Name = "lastCleanedDataGridViewTextBoxColumn";
            // 
            // lastOccupiedDataGridViewTextBoxColumn
            // 
            this.lastOccupiedDataGridViewTextBoxColumn.DataPropertyName = "Last_Occupied";
            this.lastOccupiedDataGridViewTextBoxColumn.HeaderText = "Last_Occupied";
            this.lastOccupiedDataGridViewTextBoxColumn.Name = "lastOccupiedDataGridViewTextBoxColumn";
            // 
            // hotelroomtypeDataGridViewTextBoxColumn
            // 
            this.hotelroomtypeDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_type";
            this.hotelroomtypeDataGridViewTextBoxColumn.HeaderText = "hotel_room_type";
            this.hotelroomtypeDataGridViewTextBoxColumn.Name = "hotelroomtypeDataGridViewTextBoxColumn";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel11);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ForeColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1422, 908);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "MANAGE ROOMS";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            "Pietermaritzburg",
            "Durban Umhlanga",
            "Durban North Beach",
            "Durban Ballito",
            "JHB Midrand"});
            this.cmbBranchName.Location = new System.Drawing.Point(160, 19);
            this.cmbBranchName.Name = "cmbBranchName";
            this.cmbBranchName.Size = new System.Drawing.Size(160, 25);
            this.cmbBranchName.TabIndex = 44;
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
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Rooms",
            "Standard Rooms",
            "Deluxe Rooms",
            "Executive Rooms",
            "Suite Rooms"});
            this.comboBox1.Location = new System.Drawing.Point(185, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 25);
            this.comboBox1.TabIndex = 50;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(194, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 794);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelRoomIDDataGridViewTextBoxColumn1,
            this.branchIDDataGridViewTextBoxColumn1,
            this.hotelroomnumberDataGridViewTextBoxColumn1,
            this.hotelroomstatusDataGridViewTextBoxColumn1,
            this.hotelRoomPriceDataGridViewTextBoxColumn1,
            this.maxAdultsDataGridViewTextBoxColumn1,
            this.maxChildrenDataGridViewTextBoxColumn1,
            this.cleaningStatusDataGridViewTextBoxColumn1,
            this.lastCleanedDataGridViewTextBoxColumn1,
            this.lastOccupiedDataGridViewTextBoxColumn1,
            this.hotelroomtypeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.hotelRoomBindingSource6;
            this.dataGridView2.Location = new System.Drawing.Point(43, 463);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1026, 312);
            this.dataGridView2.TabIndex = 0;
            // 
            // hotelRoomBindingSource6
            // 
            this.hotelRoomBindingSource6.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource6.DataSource = this.codeCraftersDSTWOBindingSource;
            // 
            // hotelRoomIDDataGridViewTextBoxColumn1
            // 
            this.hotelRoomIDDataGridViewTextBoxColumn1.DataPropertyName = "Hotel_Room_ID";
            this.hotelRoomIDDataGridViewTextBoxColumn1.HeaderText = "Hotel_Room_ID";
            this.hotelRoomIDDataGridViewTextBoxColumn1.Name = "hotelRoomIDDataGridViewTextBoxColumn1";
            this.hotelRoomIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // branchIDDataGridViewTextBoxColumn1
            // 
            this.branchIDDataGridViewTextBoxColumn1.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn1.HeaderText = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn1.Name = "branchIDDataGridViewTextBoxColumn1";
            // 
            // hotelroomnumberDataGridViewTextBoxColumn1
            // 
            this.hotelroomnumberDataGridViewTextBoxColumn1.DataPropertyName = "hotel_room_number";
            this.hotelroomnumberDataGridViewTextBoxColumn1.HeaderText = "hotel_room_number";
            this.hotelroomnumberDataGridViewTextBoxColumn1.Name = "hotelroomnumberDataGridViewTextBoxColumn1";
            // 
            // hotelroomstatusDataGridViewTextBoxColumn1
            // 
            this.hotelroomstatusDataGridViewTextBoxColumn1.DataPropertyName = "hotel_room_status";
            this.hotelroomstatusDataGridViewTextBoxColumn1.HeaderText = "hotel_room_status";
            this.hotelroomstatusDataGridViewTextBoxColumn1.Name = "hotelroomstatusDataGridViewTextBoxColumn1";
            // 
            // hotelRoomPriceDataGridViewTextBoxColumn1
            // 
            this.hotelRoomPriceDataGridViewTextBoxColumn1.DataPropertyName = "Hotel_Room_Price";
            this.hotelRoomPriceDataGridViewTextBoxColumn1.HeaderText = "Hotel_Room_Price";
            this.hotelRoomPriceDataGridViewTextBoxColumn1.Name = "hotelRoomPriceDataGridViewTextBoxColumn1";
            // 
            // maxAdultsDataGridViewTextBoxColumn1
            // 
            this.maxAdultsDataGridViewTextBoxColumn1.DataPropertyName = "Max_Adults";
            this.maxAdultsDataGridViewTextBoxColumn1.HeaderText = "Max_Adults";
            this.maxAdultsDataGridViewTextBoxColumn1.Name = "maxAdultsDataGridViewTextBoxColumn1";
            // 
            // maxChildrenDataGridViewTextBoxColumn1
            // 
            this.maxChildrenDataGridViewTextBoxColumn1.DataPropertyName = "Max_Children";
            this.maxChildrenDataGridViewTextBoxColumn1.HeaderText = "Max_Children";
            this.maxChildrenDataGridViewTextBoxColumn1.Name = "maxChildrenDataGridViewTextBoxColumn1";
            // 
            // cleaningStatusDataGridViewTextBoxColumn1
            // 
            this.cleaningStatusDataGridViewTextBoxColumn1.DataPropertyName = "Cleaning_Status";
            this.cleaningStatusDataGridViewTextBoxColumn1.HeaderText = "Cleaning_Status";
            this.cleaningStatusDataGridViewTextBoxColumn1.Name = "cleaningStatusDataGridViewTextBoxColumn1";
            // 
            // lastCleanedDataGridViewTextBoxColumn1
            // 
            this.lastCleanedDataGridViewTextBoxColumn1.DataPropertyName = "Last_Cleaned";
            this.lastCleanedDataGridViewTextBoxColumn1.HeaderText = "Last_Cleaned";
            this.lastCleanedDataGridViewTextBoxColumn1.Name = "lastCleanedDataGridViewTextBoxColumn1";
            // 
            // lastOccupiedDataGridViewTextBoxColumn1
            // 
            this.lastOccupiedDataGridViewTextBoxColumn1.DataPropertyName = "Last_Occupied";
            this.lastOccupiedDataGridViewTextBoxColumn1.HeaderText = "Last_Occupied";
            this.lastOccupiedDataGridViewTextBoxColumn1.Name = "lastOccupiedDataGridViewTextBoxColumn1";
            // 
            // hotelroomtypeDataGridViewTextBoxColumn1
            // 
            this.hotelroomtypeDataGridViewTextBoxColumn1.DataPropertyName = "hotel_room_type";
            this.hotelroomtypeDataGridViewTextBoxColumn1.HeaderText = "hotel_room_type";
            this.hotelroomtypeDataGridViewTextBoxColumn1.Name = "hotelroomtypeDataGridViewTextBoxColumn1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.comboBox7);
            this.panel3.Controls.Add(this.comboBox6);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(43, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 341);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(16, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(995, 51);
            this.panel8.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(218, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(389, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "UPDATE ROOM DETAILS";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "King Bed ",
            "Queen Bed",
            "Twin Beds",
            "Double Bed",
            "2 Double Beds",
            "Single Bed"});
            this.comboBox2.Location = new System.Drawing.Point(16, 299);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 25);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Standard",
            "Executive",
            "Suite",
            "Deluxe"});
            this.comboBox3.Location = new System.Drawing.Point(16, 218);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 25);
            this.comboBox3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Room Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Room Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(214, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Price Per Night:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Bed Type:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 25);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 25);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Under Maintenance"});
            this.comboBox4.Location = new System.Drawing.Point(218, 223);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(168, 25);
            this.comboBox4.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(214, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "Room Status:";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.comboBox5);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.button2);
            this.panel9.Location = new System.Drawing.Point(43, 21);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1026, 70);
            this.panel9.TabIndex = 50;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Pietermaritzburg",
            "Durban Umhlanga",
            "Durban North Beach",
            "Durban Ballito",
            "JHB Midrand"});
            this.comboBox5.Location = new System.Drawing.Point(160, 19);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(160, 25);
            this.comboBox5.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label14.Location = new System.Drawing.Point(3, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "🏨 REGAL INN HOTELS";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(794, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "🔄 REFRESH";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(437, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 21);
            this.label15.TabIndex = 13;
            this.label15.Text = "Max Adults:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(437, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 21);
            this.label16.TabIndex = 14;
            this.label16.Text = "Max Children:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox6.Location = new System.Drawing.Point(441, 129);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 25);
            this.comboBox6.TabIndex = 15;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox7.Location = new System.Drawing.Point(441, 218);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 25);
            this.comboBox7.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(12, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 21);
            this.label17.TabIndex = 17;
            this.label17.Text = "Amenities:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.listBox1);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Location = new System.Drawing.Point(596, 81);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(415, 242);
            this.panel10.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "Wi-Fi",
            "Coffee and Tea Maker",
            "Mini Fridge",
            "Air Conditioning and Heating",
            "Flat-Screen Television",
            "Toiletries",
            "Work Desk and Chair",
            "Daily Housekeeping",
            "Closet and Hangers",
            "Iron and Ironing Board",
            "Telephone"});
            this.listBox1.Location = new System.Drawing.Point(16, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 174);
            this.listBox1.TabIndex = 18;
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
            this.label18.Location = new System.Drawing.Point(638, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(202, 31);
            this.label18.TabIndex = 1;
            this.label18.Text = "VIEW ROOMS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(604, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "MANAGE ROOMS";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.Controls.Add(this.label11);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1416, 74);
            this.panel11.TabIndex = 6;
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
            this.Text = "REGAL INN ROOM MANAGEMENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RoomManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRoomAssiHotel1B5E0D89BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWOBindingSource)).EndInit();
            this.tbpViewRooms.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tbcViewRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource5)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.pnlBooking.ResumeLayout(false);
            this.pnlBooking.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAdultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxChildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleaningStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCleanedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOccupiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.ComboBox cmbBranchName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomstatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAdultsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxChildrenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleaningStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCleanedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOccupiedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomtypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
    }
}