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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHotelRoomManagement = new System.Windows.Forms.DataGridView();
            this.hotelRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomtypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelroomstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDS1 = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.lblRoomManagement = new System.Windows.Forms.Label();
            this.pnlRoomManagement = new System.Windows.Forms.Panel();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnClearRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomTypeID = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.cmbRoomStatus = new System.Windows.Forms.ComboBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.cmbRoomTypeID = new System.Windows.Forms.ComboBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.taHotelRoom = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS1)).BeginInit();
            this.pnlRoomManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHotelRoomManagement);
            this.panel1.Controls.Add(this.lblRoomManagement);
            this.panel1.Controls.Add(this.pnlRoomManagement);
            this.panel1.Location = new System.Drawing.Point(279, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 758);
            this.panel1.TabIndex = 0;
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
            this.dgvHotelRoomManagement.Location = new System.Drawing.Point(71, 447);
            this.dgvHotelRoomManagement.Name = "dgvHotelRoomManagement";
            this.dgvHotelRoomManagement.Size = new System.Drawing.Size(962, 258);
            this.dgvHotelRoomManagement.TabIndex = 3;
            // 
            // hotelRoomIDDataGridViewTextBoxColumn
            // 
            this.hotelRoomIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_ID";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.hotelRoomIDDataGridViewTextBoxColumn.HeaderText = "ROOM ID";
            this.hotelRoomIDDataGridViewTextBoxColumn.Name = "hotelRoomIDDataGridViewTextBoxColumn";
            this.hotelRoomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelRoomIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BRANCH ID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // hotelroomtypeIDDataGridViewTextBoxColumn
            // 
            this.hotelroomtypeIDDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_type_ID";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomtypeIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.hotelroomtypeIDDataGridViewTextBoxColumn.HeaderText = "ROOM TYPE ID";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.Name = "hotelroomtypeIDDataGridViewTextBoxColumn";
            this.hotelroomtypeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelroomnumberDataGridViewTextBoxColumn
            // 
            this.hotelroomnumberDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_number";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomnumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.hotelroomnumberDataGridViewTextBoxColumn.HeaderText = "ROOM NO.";
            this.hotelroomnumberDataGridViewTextBoxColumn.Name = "hotelroomnumberDataGridViewTextBoxColumn";
            this.hotelroomnumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // hotelroomstatusDataGridViewTextBoxColumn
            // 
            this.hotelroomstatusDataGridViewTextBoxColumn.DataPropertyName = "hotel_room_status";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelroomstatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.hotelroomstatusDataGridViewTextBoxColumn.HeaderText = "ROOOM STATUS";
            this.hotelroomstatusDataGridViewTextBoxColumn.Name = "hotelroomstatusDataGridViewTextBoxColumn";
            this.hotelroomstatusDataGridViewTextBoxColumn.Width = 160;
            // 
            // hotelRoomPriceDataGridViewTextBoxColumn
            // 
            this.hotelRoomPriceDataGridViewTextBoxColumn.DataPropertyName = "Hotel_Room_Price";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.hotelRoomPriceDataGridViewTextBoxColumn.HeaderText = "ROOM PRICE";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Name = "hotelRoomPriceDataGridViewTextBoxColumn";
            this.hotelRoomPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelRoomBindingSource
            // 
            this.hotelRoomBindingSource.DataMember = "Hotel_Room";
            this.hotelRoomBindingSource.DataSource = this.codeCraftersDS1;
            // 
            // codeCraftersDS1
            // 
            this.codeCraftersDS1.DataSetName = "codeCraftersDS";
            this.codeCraftersDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRoomManagement
            // 
            this.lblRoomManagement.AutoSize = true;
            this.lblRoomManagement.Location = new System.Drawing.Point(535, 45);
            this.lblRoomManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomManagement.Name = "lblRoomManagement";
            this.lblRoomManagement.Size = new System.Drawing.Size(163, 16);
            this.lblRoomManagement.TabIndex = 2;
            this.lblRoomManagement.Text = "ROOM MANAGEMENT";
            // 
            // pnlRoomManagement
            // 
            this.pnlRoomManagement.Controls.Add(this.btnUpdateRoom);
            this.pnlRoomManagement.Controls.Add(this.btnClearRoom);
            this.pnlRoomManagement.Controls.Add(this.btnDeleteRoom);
            this.pnlRoomManagement.Controls.Add(this.btnAddRoom);
            this.pnlRoomManagement.Controls.Add(this.lblRoomStatus);
            this.pnlRoomManagement.Controls.Add(this.lblRoomPrice);
            this.pnlRoomManagement.Controls.Add(this.lblRoomTypeID);
            this.pnlRoomManagement.Controls.Add(this.txtRoomPrice);
            this.pnlRoomManagement.Controls.Add(this.cmbRoomStatus);
            this.pnlRoomManagement.Controls.Add(this.txtRoomID);
            this.pnlRoomManagement.Controls.Add(this.cmbRoomTypeID);
            this.pnlRoomManagement.Controls.Add(this.lblRoomID);
            this.pnlRoomManagement.Location = new System.Drawing.Point(71, 90);
            this.pnlRoomManagement.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoomManagement.Name = "pnlRoomManagement";
            this.pnlRoomManagement.Size = new System.Drawing.Size(627, 317);
            this.pnlRoomManagement.TabIndex = 0;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRoom.Location = new System.Drawing.Point(205, 256);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(91, 33);
            this.btnUpdateRoom.TabIndex = 11;
            this.btnUpdateRoom.Text = "UPDATE";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            // 
            // btnClearRoom
            // 
            this.btnClearRoom.BackColor = System.Drawing.Color.DarkGray;
            this.btnClearRoom.Location = new System.Drawing.Point(35, 256);
            this.btnClearRoom.Name = "btnClearRoom";
            this.btnClearRoom.Size = new System.Drawing.Size(75, 33);
            this.btnClearRoom.TabIndex = 10;
            this.btnClearRoom.Text = "CLEAR";
            this.btnClearRoom.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRoom.Location = new System.Drawing.Point(379, 256);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteRoom.TabIndex = 9;
            this.btnDeleteRoom.Text = "DELETE";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.Location = new System.Drawing.Point(523, 256);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 33);
            this.btnAddRoom.TabIndex = 8;
            this.btnAddRoom.Text = "ADD";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new System.Drawing.Point(32, 195);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(68, 16);
            this.lblRoomStatus.TabIndex = 7;
            this.lblRoomStatus.Text = "STATUS";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(32, 149);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(52, 16);
            this.lblRoomPrice.TabIndex = 6;
            this.lblRoomPrice.Text = "PRICE";
            // 
            // lblRoomTypeID
            // 
            this.lblRoomTypeID.AutoSize = true;
            this.lblRoomTypeID.Location = new System.Drawing.Point(32, 93);
            this.lblRoomTypeID.Name = "lblRoomTypeID";
            this.lblRoomTypeID.Size = new System.Drawing.Size(115, 16);
            this.lblRoomTypeID.TabIndex = 5;
            this.lblRoomTypeID.Text = "ROOM TYPE ID";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(250, 146);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(221, 22);
            this.txtRoomPrice.TabIndex = 4;
            // 
            // cmbRoomStatus
            // 
            this.cmbRoomStatus.FormattingEnabled = true;
            this.cmbRoomStatus.Location = new System.Drawing.Point(250, 192);
            this.cmbRoomStatus.Name = "cmbRoomStatus";
            this.cmbRoomStatus.Size = new System.Drawing.Size(156, 24);
            this.cmbRoomStatus.TabIndex = 3;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(250, 30);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(221, 22);
            this.txtRoomID.TabIndex = 2;
            // 
            // cmbRoomTypeID
            // 
            this.cmbRoomTypeID.FormattingEnabled = true;
            this.cmbRoomTypeID.Location = new System.Drawing.Point(250, 90);
            this.cmbRoomTypeID.Name = "cmbRoomTypeID";
            this.cmbRoomTypeID.Size = new System.Drawing.Size(156, 24);
            this.cmbRoomTypeID.TabIndex = 1;
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(32, 33);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(75, 16);
            this.lblRoomID.TabIndex = 0;
            this.lblRoomID.Text = "ROOM ID:";
            // 
            // taHotelRoom
            // 
            this.taHotelRoom.ClearBeforeFill = true;
            // 
            // RoomManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1483, 888);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManagementForm";
            this.Text = "REGAL INN ROOM MANAGEMENT";
            this.Load += new System.EventHandler(this.RoomManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRoomManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS1)).EndInit();
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
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.ComboBox cmbRoomTypeID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource;
        private codeCraftersDS codeCraftersDS1;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter taHotelRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomtypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelroomstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoomPriceDataGridViewTextBoxColumn;
    }
}