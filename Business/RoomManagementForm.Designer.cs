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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomManagementForm));
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblRoomsUnderMaintenance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcViewRooms = new System.Windows.Forms.TabControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tbcViewRooms.SuspendLayout();
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
            this.tbpViewRooms.Controls.Add(this.panel1);
            this.tbpViewRooms.Location = new System.Drawing.Point(4, 26);
            this.tbpViewRooms.Name = "tbpViewRooms";
            this.tbpViewRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tbpViewRooms.Size = new System.Drawing.Size(1264, 830);
            this.tbpViewRooms.TabIndex = 1;
            this.tbpViewRooms.Text = "VIEW ROOMS";
            this.tbpViewRooms.UseVisualStyleBackColor = true;
            this.tbpViewRooms.Click += new System.EventHandler(this.tbpViewRooms_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(84, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 656);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(25, 170);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(936, 435);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(25, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 134);
            this.panel3.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 100);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.lblRoomsUnderMaintenance);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(690, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 93);
            this.panel7.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 94);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // lblRoomsUnderMaintenance
            // 
            this.lblRoomsUnderMaintenance.AutoSize = true;
            this.lblRoomsUnderMaintenance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsUnderMaintenance.ForeColor = System.Drawing.Color.Black;
            this.lblRoomsUnderMaintenance.Location = new System.Drawing.Point(106, 28);
            this.lblRoomsUnderMaintenance.Name = "lblRoomsUnderMaintenance";
            this.lblRoomsUnderMaintenance.Size = new System.Drawing.Size(56, 65);
            this.lblRoomsUnderMaintenance.TabIndex = 14;
            this.lblRoomsUnderMaintenance.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(70, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "MAINTENANCE ROOMS";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lblTotalRooms);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 93);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRooms.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRooms.Location = new System.Drawing.Point(81, 28);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(84, 65);
            this.lblTotalRooms.TabIndex = 15;
            this.lblTotalRooms.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "TOTAL ROOMS";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.lblOccupiedRooms);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(461, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 93);
            this.panel6.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // lblOccupiedRooms
            // 
            this.lblOccupiedRooms.AutoSize = true;
            this.lblOccupiedRooms.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupiedRooms.ForeColor = System.Drawing.Color.Black;
            this.lblOccupiedRooms.Location = new System.Drawing.Point(106, 28);
            this.lblOccupiedRooms.Name = "lblOccupiedRooms";
            this.lblOccupiedRooms.Size = new System.Drawing.Size(56, 65);
            this.lblOccupiedRooms.TabIndex = 15;
            this.lblOccupiedRooms.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(83, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "OCCUPIED ROOMS";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.lblAvailableRooms);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(232, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 93);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.Black;
            this.lblAvailableRooms.Location = new System.Drawing.Point(87, 28);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(84, 65);
            this.lblAvailableRooms.TabIndex = 15;
            this.lblAvailableRooms.Text = "14";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "AVAILABLE ROOMS";
            // 
            // tbcViewRooms
            // 
            this.tbcViewRooms.Controls.Add(this.tbpViewRooms);
            this.tbcViewRooms.Location = new System.Drawing.Point(3, 2);
            this.tbcViewRooms.Name = "tbcViewRooms";
            this.tbcViewRooms.SelectedIndex = 0;
            this.tbcViewRooms.Size = new System.Drawing.Size(1272, 860);
            this.tbcViewRooms.TabIndex = 0;
            // 
            // RoomManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1289, 874);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tbcViewRooms.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblRoomsUnderMaintenance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblOccupiedRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tbcViewRooms;
    }
}