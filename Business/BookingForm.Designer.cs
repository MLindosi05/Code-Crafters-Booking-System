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
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.chkRestaurant = new System.Windows.Forms.CheckBox();
            this.grpRestaurantDetails = new System.Windows.Forms.GroupBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtTablePrice = new System.Windows.Forms.TextBox();
            this.cmbRestaurantTable = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblTablePrice = new System.Windows.Forms.Label();
            this.lblRestaurantTable = new System.Windows.Forms.Label();
            this.grpRoomDetails = new System.Windows.Forms.GroupBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.chkRoom = new System.Windows.Forms.CheckBox();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.grpClientDetails = new System.Windows.Forms.GroupBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
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
            this.grpRestaurantDetails.SuspendLayout();
            this.grpRoomDetails.SuspendLayout();
            this.grpBookingDetails.SuspendLayout();
            this.grpClientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCreateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBooking.Location = new System.Drawing.Point(1291, 1166);
            this.btnCreateBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(189, 38);
            this.btnCreateBooking.TabIndex = 20;
            this.btnCreateBooking.Text = "Make a Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // pnlBooking
            // 
            this.pnlBooking.Controls.Add(this.groupBox4);
            this.pnlBooking.Controls.Add(this.btnCreateBooking);
            this.pnlBooking.Location = new System.Drawing.Point(16, 15);
            this.pnlBooking.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(1511, 1250);
            this.pnlBooking.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox4.Controls.Add(this.lblTotalAmount);
            this.groupBox4.Controls.Add(this.txtTotalAmount);
            this.groupBox4.Controls.Add(this.chkRestaurant);
            this.groupBox4.Controls.Add(this.grpRestaurantDetails);
            this.groupBox4.Controls.Add(this.grpRoomDetails);
            this.groupBox4.Controls.Add(this.chkRoom);
            this.groupBox4.Controls.Add(this.grpBookingDetails);
            this.groupBox4.Controls.Add(this.grpClientDetails);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1464, 1130);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Make Booking";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(1020, 1089);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(140, 22);
            this.lblTotalAmount.TabIndex = 29;
            this.lblTotalAmount.Text = "Booking Price:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(1187, 1086);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(171, 28);
            this.txtTotalAmount.TabIndex = 28;
            // 
            // chkRestaurant
            // 
            this.chkRestaurant.AutoSize = true;
            this.chkRestaurant.Location = new System.Drawing.Point(109, 732);
            this.chkRestaurant.Margin = new System.Windows.Forms.Padding(4);
            this.chkRestaurant.Name = "chkRestaurant";
            this.chkRestaurant.Size = new System.Drawing.Size(208, 26);
            this.chkRestaurant.TabIndex = 27;
            this.chkRestaurant.Text = "Restaurant Booking";
            this.chkRestaurant.UseVisualStyleBackColor = true;
            this.chkRestaurant.CheckedChanged += new System.EventHandler(this.chkRestaurant_CheckedChanged_1);
            // 
            // grpRestaurantDetails
            // 
            this.grpRestaurantDetails.Controls.Add(this.dtpEndTime);
            this.grpRestaurantDetails.Controls.Add(this.dtpStartTime);
            this.grpRestaurantDetails.Controls.Add(this.txtTablePrice);
            this.grpRestaurantDetails.Controls.Add(this.cmbRestaurantTable);
            this.grpRestaurantDetails.Controls.Add(this.lblEndTime);
            this.grpRestaurantDetails.Controls.Add(this.lblStartTime);
            this.grpRestaurantDetails.Controls.Add(this.lblTablePrice);
            this.grpRestaurantDetails.Controls.Add(this.lblRestaurantTable);
            this.grpRestaurantDetails.Location = new System.Drawing.Point(109, 785);
            this.grpRestaurantDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpRestaurantDetails.Name = "grpRestaurantDetails";
            this.grpRestaurantDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpRestaurantDetails.Size = new System.Drawing.Size(1249, 282);
            this.grpRestaurantDetails.TabIndex = 25;
            this.grpRestaurantDetails.TabStop = false;
            this.grpRestaurantDetails.Text = "Restaurant Details";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Location = new System.Drawing.Point(247, 214);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(359, 28);
            this.dtpEndTime.TabIndex = 28;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Location = new System.Drawing.Point(247, 160);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(359, 28);
            this.dtpStartTime.TabIndex = 27;
            // 
            // txtTablePrice
            // 
            this.txtTablePrice.Location = new System.Drawing.Point(247, 116);
            this.txtTablePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtTablePrice.Name = "txtTablePrice";
            this.txtTablePrice.Size = new System.Drawing.Size(160, 28);
            this.txtTablePrice.TabIndex = 5;
            // 
            // cmbRestaurantTable
            // 
            this.cmbRestaurantTable.FormattingEnabled = true;
            this.cmbRestaurantTable.Location = new System.Drawing.Point(247, 63);
            this.cmbRestaurantTable.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRestaurantTable.Name = "cmbRestaurantTable";
            this.cmbRestaurantTable.Size = new System.Drawing.Size(160, 30);
            this.cmbRestaurantTable.TabIndex = 4;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(51, 214);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(101, 22);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "End Time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(51, 160);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(109, 22);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblTablePrice
            // 
            this.lblTablePrice.AutoSize = true;
            this.lblTablePrice.Location = new System.Drawing.Point(51, 119);
            this.lblTablePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTablePrice.Name = "lblTablePrice";
            this.lblTablePrice.Size = new System.Drawing.Size(119, 22);
            this.lblTablePrice.TabIndex = 1;
            this.lblTablePrice.Text = "Table Price:";
            // 
            // lblRestaurantTable
            // 
            this.lblRestaurantTable.AutoSize = true;
            this.lblRestaurantTable.Location = new System.Drawing.Point(51, 66);
            this.lblRestaurantTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestaurantTable.Name = "lblRestaurantTable";
            this.lblRestaurantTable.Size = new System.Drawing.Size(171, 22);
            this.lblRestaurantTable.TabIndex = 0;
            this.lblRestaurantTable.Text = "Restaurant Table:";
            // 
            // grpRoomDetails
            // 
            this.grpRoomDetails.Controls.Add(this.txtRoomPrice);
            this.grpRoomDetails.Controls.Add(this.cmbRoom);
            this.grpRoomDetails.Controls.Add(this.lblRoomPrice);
            this.grpRoomDetails.Controls.Add(this.lblRoom);
            this.grpRoomDetails.Location = new System.Drawing.Point(109, 537);
            this.grpRoomDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpRoomDetails.Name = "grpRoomDetails";
            this.grpRoomDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpRoomDetails.Size = new System.Drawing.Size(1249, 165);
            this.grpRoomDetails.TabIndex = 24;
            this.grpRoomDetails.TabStop = false;
            this.grpRoomDetails.Text = "Room Details";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(192, 101);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(160, 28);
            this.txtRoomPrice.TabIndex = 3;
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(192, 48);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(160, 30);
            this.cmbRoom.TabIndex = 2;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(43, 101);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(119, 22);
            this.lblRoomPrice.TabIndex = 1;
            this.lblRoomPrice.Text = "Room Price:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(43, 52);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(67, 22);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Room:";
            // 
            // chkRoom
            // 
            this.chkRoom.AutoSize = true;
            this.chkRoom.Location = new System.Drawing.Point(109, 484);
            this.chkRoom.Margin = new System.Windows.Forms.Padding(4);
            this.chkRoom.Name = "chkRoom";
            this.chkRoom.Size = new System.Drawing.Size(161, 26);
            this.chkRoom.TabIndex = 26;
            this.chkRoom.Text = "Room Booking";
            this.chkRoom.UseVisualStyleBackColor = true;
            this.chkRoom.CheckedChanged += new System.EventHandler(this.chkRoom_CheckedChanged_1);
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.dtpCheckInDate);
            this.grpBookingDetails.Controls.Add(this.dtpCheckOutDate);
            this.grpBookingDetails.Controls.Add(this.lblCheckOutDate);
            this.grpBookingDetails.Controls.Add(this.lblCheckInDate);
            this.grpBookingDetails.Controls.Add(this.lblBookingDate);
            this.grpBookingDetails.Controls.Add(this.dtpBookingDate);
            this.grpBookingDetails.Location = new System.Drawing.Point(109, 218);
            this.grpBookingDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpBookingDetails.Size = new System.Drawing.Size(1249, 231);
            this.grpBookingDetails.TabIndex = 23;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Details";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Location = new System.Drawing.Point(224, 112);
            this.dtpCheckInDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(359, 28);
            this.dtpCheckInDate.TabIndex = 26;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Location = new System.Drawing.Point(224, 164);
            this.dtpCheckOutDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(359, 28);
            this.dtpCheckOutDate.TabIndex = 25;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(39, 164);
            this.lblCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(159, 22);
            this.lblCheckOutDate.TabIndex = 24;
            this.lblCheckOutDate.Text = "Check-Out Date:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(39, 112);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(143, 22);
            this.lblCheckInDate.TabIndex = 23;
            this.lblCheckInDate.Text = "Check-In Date:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(39, 54);
            this.lblBookingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(136, 22);
            this.lblBookingDate.TabIndex = 22;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(224, 54);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(359, 28);
            this.dtpBookingDate.TabIndex = 21;
            // 
            // grpClientDetails
            // 
            this.grpClientDetails.Controls.Add(this.cmbBranch);
            this.grpClientDetails.Controls.Add(this.cmbClient);
            this.grpClientDetails.Controls.Add(this.lblBranch);
            this.grpClientDetails.Controls.Add(this.lblClient);
            this.grpClientDetails.Location = new System.Drawing.Point(113, 47);
            this.grpClientDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpClientDetails.Name = "grpClientDetails";
            this.grpClientDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpClientDetails.Size = new System.Drawing.Size(1245, 150);
            this.grpClientDetails.TabIndex = 22;
            this.grpClientDetails.TabStop = false;
            this.grpClientDetails.Text = "Client Details";
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(141, 91);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(160, 30);
            this.cmbBranch.TabIndex = 3;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(141, 42);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(160, 30);
            this.cmbClient.TabIndex = 2;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(31, 95);
            this.lblBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(79, 22);
            this.lblBranch.TabIndex = 1;
            this.lblBranch.Text = "Branch:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(31, 46);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(68, 22);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client:";
            // 
            // codeCraftersDS
            // 
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1543, 1055);
            this.Controls.Add(this.pnlBooking);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookingForm";
            this.Text = "MakeBookingForm";
            this.pnlBooking.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpRestaurantDetails.ResumeLayout(false);
            this.grpRestaurantDetails.PerformLayout();
            this.grpRoomDetails.ResumeLayout(false);
            this.grpRoomDetails.PerformLayout();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            this.grpClientDetails.ResumeLayout(false);
            this.grpClientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
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
        private System.Windows.Forms.CheckBox chkRestaurant;
        private System.Windows.Forms.GroupBox grpRestaurantDetails;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.TextBox txtTablePrice;
        private System.Windows.Forms.ComboBox cmbRestaurantTable;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblTablePrice;
        private System.Windows.Forms.Label lblRestaurantTable;
        private System.Windows.Forms.GroupBox grpRoomDetails;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.CheckBox chkRoom;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.GroupBox grpClientDetails;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblClient;
        private codeCraftersDSTableAdapters.Room_AssignmentTableAdapter taRoomAssignment;
        private codeCraftersDSTableAdapters.Table_AllocationTableAdapter taTableAllocation;
        private codeCraftersDSTableAdapters.Restuarant_TableTableAdapter taRestaurantTable;
    }
}