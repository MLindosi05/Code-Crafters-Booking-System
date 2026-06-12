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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lblSearchRoomID = new System.Windows.Forms.Label();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.btnRoomClear = new System.Windows.Forms.Button();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvHotelRoomManagement = new System.Windows.Forms.DataGridView();
            this.hotelRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.pnlRoomManagement = new System.Windows.Forms.Panel();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.cmbBranchID = new System.Windows.Forms.ComboBox();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomTypeID = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.cmbRoomStatus = new System.Windows.Forms.ComboBox();
            this.cmbRoomTypeID = new System.Windows.Forms.ComboBox();
            this.lblRoomManagement = new System.Windows.Forms.Label();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnClearRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.taHotelRoom = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.pnlRoomManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblRoomManagement);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 782);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(409, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 3);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRoomID);
            this.panel2.Controls.Add(this.lblSearchRoomID);
            this.panel2.Controls.Add(this.btnRoomAdd);
            this.panel2.Controls.Add(this.btnRoomDelete);
            this.panel2.Controls.Add(this.btnRoomClear);
            this.panel2.Controls.Add(this.btnRoomUpdate);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvHotelRoomManagement);
            this.panel2.Controls.Add(this.pnlRoomManagement);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(34, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 644);
            this.panel2.TabIndex = 1;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(163, 374);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(106, 29);
            this.txtRoomID.TabIndex = 10;
            this.txtRoomID.TextChanged += new System.EventHandler(this.txtRoomID_TextChanged_1);
            // 
            // lblSearchRoomID
            // 
            this.lblSearchRoomID.AutoSize = true;
            this.lblSearchRoomID.Location = new System.Drawing.Point(43, 377);
            this.lblSearchRoomID.Name = "lblSearchRoomID";
            this.lblSearchRoomID.Size = new System.Drawing.Size(148, 23);
            this.lblSearchRoomID.TabIndex = 9;
            this.lblSearchRoomID.Text = "ENTER ROOM ID:";
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Location = new System.Drawing.Point(378, 591);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(64, 36);
            this.btnRoomAdd.TabIndex = 8;
            this.btnRoomAdd.Text = "ADD";
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Location = new System.Drawing.Point(269, 591);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(68, 36);
            this.btnRoomDelete.TabIndex = 7;
            this.btnRoomDelete.Text = "DELETE";
            this.btnRoomDelete.UseVisualStyleBackColor = true;
            this.btnRoomDelete.Click += new System.EventHandler(this.btnRoomDelete_Click);
            // 
            // btnRoomClear
            // 
            this.btnRoomClear.Location = new System.Drawing.Point(38, 591);
            this.btnRoomClear.Name = "btnRoomClear";
            this.btnRoomClear.Size = new System.Drawing.Size(63, 36);
            this.btnRoomClear.TabIndex = 6;
            this.btnRoomClear.Text = "CLEAR";
            this.btnRoomClear.UseVisualStyleBackColor = true;
            this.btnRoomClear.Click += new System.EventHandler(this.btnRoomClear_Click);
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.Location = new System.Drawing.Point(154, 591);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(67, 36);
            this.btnRoomUpdate.TabIndex = 5;
            this.btnRoomUpdate.Text = "UPDATE";
            this.btnRoomUpdate.UseVisualStyleBackColor = true;
            this.btnRoomUpdate.Click += new System.EventHandler(this.btnRoomUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(585, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 337);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Insights_into_hotel_management_salary_and_requirements_1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvHotelRoomManagement
            // 
            this.dgvHotelRoomManagement.AutoGenerateColumns = false;
            this.dgvHotelRoomManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelRoomManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelRoomIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.hotelroomtypeIDDataGridViewTextBoxColumn,
            this.hotelroomnumberDataGridViewTextBoxColumn,
            this.hotelroomstatusDataGridViewTextBoxColumn,
            this.hotelRoomPriceDataGridViewTextBoxColumn});
            this.dgvHotelRoomManagement.DataSource = this.hotelRoomBindingSource;
            this.dgvHotelRoomManagement.Location = new System.Drawing.Point(38, 402);
            this.dgvHotelRoomManagement.Name = "dgvHotelRoomManagement";
            this.dgvHotelRoomManagement.RowHeadersWidth = 51;
            this.dgvHotelRoomManagement.Size = new System.Drawing.Size(873, 175);
            this.dgvHotelRoomManagement.TabIndex = 3;
            this.dgvHotelRoomManagement.SelectionChanged += new System.EventHandler(this.dgvHotelRoomManagement_SelectionChanged);
            // 
            // hotelRoomIDDataGridViewTextBoxColumn
            // 
            this.hotelRoomIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_ID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hotelRoomIDDataGridViewTextBoxColumn.HeaderText = "ROOM ID";
            this.hotelRoomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelRoomIDDataGridViewTextBoxColumn.Name = "hotelRoomIDDataGridViewTextBoxColumn";
            this.hotelRoomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelRoomIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BRANCH ID";
            this.branchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // hotelroomtypeIDDataGridViewTextBoxColumn
            // 
            this.hotelroomtypeIDDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_type_ID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomtypeIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.hotelroomtypeIDDataGridViewTextBoxColumn.HeaderText = "ROOM TYPE ID";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelroomtypeIDDataGridViewTextBoxColumn.Name = "hotelroomtypeIDDataGridViewTextBoxColumn";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelroomnumberDataGridViewTextBoxColumn
            // 
            this.hotelroomnumberDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_number";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.hotelroomnumberDataGridViewTextBoxColumn.HeaderText = "ROOM NO.";
            this.hotelroomnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelroomnumberDataGridViewTextBoxColumn.Name = "hotelroomnumberDataGridViewTextBoxColumn";
            this.hotelroomnumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // hotelroomstatusDataGridViewTextBoxColumn
            // 
            this.hotelroomstatusDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_status";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomstatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.hotelroomstatusDataGridViewTextBoxColumn.HeaderText = "ROOOM STATUS";
            this.hotelroomstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelroomstatusDataGridViewTextBoxColumn.Name = "hotelroomstatusDataGridViewTextBoxColumn";
            this.hotelroomstatusDataGridViewTextBoxColumn.Width = 160;
            // 
            // hotelRoomPriceDataGridViewTextBoxColumn
            // 
            this.hotelRoomPriceDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_Price";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.hotelRoomPriceDataGridViewTextBoxColumn.HeaderText = "ROOM PRICE";
            this.hotelRoomPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelRoomPriceDataGridViewTextBoxColumn.Name = "hotelRoomPriceDataGridViewTextBoxColumn";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelRoomBindingSource
            // 
            this.hotelRoomBindingSource.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource.DataSource = this.codeCraftersDS;
            // 
            // codeCraftersDS
            // 
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlRoomManagement
            // 
            this.pnlRoomManagement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRoomManagement.Controls.Add(this.txtRoomNumber);
            this.pnlRoomManagement.Controls.Add(this.lblRoomNumber);
            this.pnlRoomManagement.Controls.Add(this.cmbBranchID);
            this.pnlRoomManagement.Controls.Add(this.lblBranchID);
            this.pnlRoomManagement.Controls.Add(this.lblRoomStatus);
            this.pnlRoomManagement.Controls.Add(this.lblRoomPrice);
            this.pnlRoomManagement.Controls.Add(this.lblRoomTypeID);
            this.pnlRoomManagement.Controls.Add(this.txtRoomPrice);
            this.pnlRoomManagement.Controls.Add(this.cmbRoomStatus);
            this.pnlRoomManagement.Controls.Add(this.cmbRoomTypeID);
            this.pnlRoomManagement.Location = new System.Drawing.Point(38, 19);
            this.pnlRoomManagement.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoomManagement.Name = "pnlRoomManagement";
            this.pnlRoomManagement.Size = new System.Drawing.Size(540, 337);
            this.pnlRoomManagement.TabIndex = 0;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(222, 131);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(197, 29);
            this.txtRoomNumber.TabIndex = 15;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(28, 134);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(99, 23);
            this.lblRoomNumber.TabIndex = 14;
            this.lblRoomNumber.Text = "ROOM NO:";
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
            this.cmbBranchID.Location = new System.Drawing.Point(222, 31);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(96, 29);
            this.cmbBranchID.TabIndex = 13;
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.ForeColor = System.Drawing.Color.Black;
            this.lblBranchID.Location = new System.Drawing.Point(28, 34);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(109, 23);
            this.lblBranchID.TabIndex = 12;
            this.lblBranchID.Text = "BRANCH ID:";
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new System.Drawing.Point(28, 171);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(135, 23);
            this.lblRoomStatus.TabIndex = 7;
            this.lblRoomStatus.Text = "ROOM STATUS:";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(28, 210);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(119, 23);
            this.lblRoomPrice.TabIndex = 6;
            this.lblRoomPrice.Text = "ROOM PRICE:";
            // 
            // lblRoomTypeID
            // 
            this.lblRoomTypeID.AutoSize = true;
            this.lblRoomTypeID.Location = new System.Drawing.Point(28, 97);
            this.lblRoomTypeID.Name = "lblRoomTypeID";
            this.lblRoomTypeID.Size = new System.Drawing.Size(135, 23);
            this.lblRoomTypeID.TabIndex = 5;
            this.lblRoomTypeID.Text = "ROOM TYPE ID:";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(222, 207);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(197, 29);
            this.txtRoomPrice.TabIndex = 4;
            // 
            // cmbRoomStatus
            // 
            this.cmbRoomStatus.FormattingEnabled = true;
            this.cmbRoomStatus.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Maintenance"});
            this.cmbRoomStatus.Location = new System.Drawing.Point(222, 168);
            this.cmbRoomStatus.Name = "cmbRoomStatus";
            this.cmbRoomStatus.Size = new System.Drawing.Size(139, 29);
            this.cmbRoomStatus.TabIndex = 3;
            // 
            // cmbRoomTypeID
            // 
            this.cmbRoomTypeID.FormattingEnabled = true;
            this.cmbRoomTypeID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRoomTypeID.Location = new System.Drawing.Point(222, 94);
            this.cmbRoomTypeID.Name = "cmbRoomTypeID";
            this.cmbRoomTypeID.Size = new System.Drawing.Size(139, 29);
            this.cmbRoomTypeID.TabIndex = 1;
            // 
            // lblRoomManagement
            // 
            this.lblRoomManagement.AutoSize = true;
            this.lblRoomManagement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRoomManagement.Location = new System.Drawing.Point(367, 29);
            this.lblRoomManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomManagement.Name = "lblRoomManagement";
            this.lblRoomManagement.Size = new System.Drawing.Size(271, 32);
            this.lblRoomManagement.TabIndex = 2;
            this.lblRoomManagement.Text = "ROOM MANAGEMENT";
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
            // taHotelRoom
            // 
            this.taHotelRoom.ClearBeforeFill = true;
            // 
            // RoomManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1318, 944);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManagementForm";
            this.Text = "REGAL INN ROOM MANAGEMENT";
            this.Load += new System.EventHandler(this.RoomManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.pnlRoomManagement.ResumeLayout(false);
            this.pnlRoomManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRoomManagement;
        private System.Windows.Forms.Panel pnlRoomManagement;
        private System.Windows.Forms.DataGridView dgvHotelRoomManagement;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnClearRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoomTypeID;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.ComboBox cmbRoomStatus;
        private System.Windows.Forms.ComboBox cmbRoomTypeID;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource;
        private codeCraftersDS codeCraftersDS;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter taHotelRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbBranchID;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.Button btnRoomClear;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lblSearchRoomID;
    }
}