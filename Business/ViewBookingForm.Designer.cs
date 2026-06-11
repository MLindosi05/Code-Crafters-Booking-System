namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class ViewBookingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.cmbStatusActions = new System.Windows.Forms.ComboBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTotalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBranchBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taClientBranchBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientBranchBookingTableAdapter();
            this.pnlViewBookings = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBranchBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.pnlViewBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateStatus);
            this.groupBox1.Controls.Add(this.cmbStatusActions);
            this.groupBox1.Controls.Add(this.lblBookingID);
            this.groupBox1.Controls.Add(this.txtBookingID);
            this.groupBox1.Controls.Add(this.dgvBookings);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(30, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1749, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Bookings";
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStatus.Location = new System.Drawing.Point(504, 58);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(114, 20);
            this.btnUpdateStatus.TabIndex = 4;
            this.btnUpdateStatus.Text = "UPDATE Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // cmbStatusActions
            // 
            this.cmbStatusActions.FormattingEnabled = true;
            this.cmbStatusActions.Items.AddRange(new object[] {
            "Confirmed",
            "Checked In",
            "Checked Out",
            "No Show",
            "Cancelled"});
            this.cmbStatusActions.Location = new System.Drawing.Point(327, 57);
            this.cmbStatusActions.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatusActions.Name = "cmbStatusActions";
            this.cmbStatusActions.Size = new System.Drawing.Size(144, 21);
            this.cmbStatusActions.TabIndex = 3;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBookingID.Location = new System.Drawing.Point(24, 39);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(95, 13);
            this.lblBookingID.TabIndex = 2;
            this.lblBookingID.Text = "Enter Booking ID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(24, 58);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(255, 22);
            this.txtBookingID.TabIndex = 1;
            this.txtBookingID.TextChanged += new System.EventHandler(this.txtBookingID_TextChanged);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoGenerateColumns = false;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.checkinDateDataGridViewTextBoxColumn,
            this.checkoutDateDataGridViewTextBoxColumn,
            this.bookingTotalAmountDataGridViewTextBoxColumn,
            this.bookingStatusDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.clientAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.branchNameDataGridViewTextBoxColumn,
            this.branchAddressDataGridViewTextBoxColumn,
            this.branchPhoneDataGridViewTextBoxColumn,
            this.branchEmailDataGridViewTextBoxColumn,
            this.branchStatusDataGridViewTextBoxColumn});
            this.dgvBookings.DataSource = this.clientBranchBookingBindingSource;
            this.dgvBookings.Location = new System.Drawing.Point(24, 87);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.Size = new System.Drawing.Size(1696, 482);
            this.dgvBookings.TabIndex = 0;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking ID";
            this.bookingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client ID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "Branch ID";
            this.branchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkinDateDataGridViewTextBoxColumn
            // 
            this.checkinDateDataGridViewTextBoxColumn.DataPropertyName = "Checkin_Date";
            this.checkinDateDataGridViewTextBoxColumn.HeaderText = "Checkin Date";
            this.checkinDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkinDateDataGridViewTextBoxColumn.Name = "checkinDateDataGridViewTextBoxColumn";
            this.checkinDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkoutDateDataGridViewTextBoxColumn
            // 
            this.checkoutDateDataGridViewTextBoxColumn.DataPropertyName = "Checkout_Date";
            this.checkoutDateDataGridViewTextBoxColumn.HeaderText = "Checkout Date";
            this.checkoutDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkoutDateDataGridViewTextBoxColumn.Name = "checkoutDateDataGridViewTextBoxColumn";
            this.checkoutDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookingTotalAmountDataGridViewTextBoxColumn
            // 
            this.bookingTotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Booking_Total_Amount";
            this.bookingTotalAmountDataGridViewTextBoxColumn.HeaderText = "Price";
            this.bookingTotalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingTotalAmountDataGridViewTextBoxColumn.Name = "bookingTotalAmountDataGridViewTextBoxColumn";
            this.bookingTotalAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.bookingStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            this.bookingStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientAddressDataGridViewTextBoxColumn
            // 
            this.clientAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Address";
            this.clientAddressDataGridViewTextBoxColumn.HeaderText = "Client Address";
            this.clientAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientAddressDataGridViewTextBoxColumn.Name = "clientAddressDataGridViewTextBoxColumn";
            this.clientAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // branchNameDataGridViewTextBoxColumn
            // 
            this.branchNameDataGridViewTextBoxColumn.DataPropertyName = "Branch_Name";
            this.branchNameDataGridViewTextBoxColumn.HeaderText = "Branch Name";
            this.branchNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchNameDataGridViewTextBoxColumn.Name = "branchNameDataGridViewTextBoxColumn";
            this.branchNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchAddressDataGridViewTextBoxColumn
            // 
            this.branchAddressDataGridViewTextBoxColumn.DataPropertyName = "Branch_Address";
            this.branchAddressDataGridViewTextBoxColumn.HeaderText = "Branch Address";
            this.branchAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchAddressDataGridViewTextBoxColumn.Name = "branchAddressDataGridViewTextBoxColumn";
            this.branchAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // branchPhoneDataGridViewTextBoxColumn
            // 
            this.branchPhoneDataGridViewTextBoxColumn.DataPropertyName = "Branch_Phone";
            this.branchPhoneDataGridViewTextBoxColumn.HeaderText = "Branch Phone Number";
            this.branchPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchPhoneDataGridViewTextBoxColumn.Name = "branchPhoneDataGridViewTextBoxColumn";
            this.branchPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchEmailDataGridViewTextBoxColumn
            // 
            this.branchEmailDataGridViewTextBoxColumn.DataPropertyName = "Branch_Email";
            this.branchEmailDataGridViewTextBoxColumn.HeaderText = "Branch Email Address";
            this.branchEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchEmailDataGridViewTextBoxColumn.Name = "branchEmailDataGridViewTextBoxColumn";
            this.branchEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // branchStatusDataGridViewTextBoxColumn
            // 
            this.branchStatusDataGridViewTextBoxColumn.DataPropertyName = "Branch_Status";
            this.branchStatusDataGridViewTextBoxColumn.HeaderText = "Branch Status";
            this.branchStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchStatusDataGridViewTextBoxColumn.Name = "branchStatusDataGridViewTextBoxColumn";
            this.branchStatusDataGridViewTextBoxColumn.Width = 120;
            // 
            // clientBranchBookingBindingSource
            // 
            this.clientBranchBookingBindingSource.DataMember = "ClientBranchBooking";
            this.clientBranchBookingBindingSource.DataSource = this.codeCraftersDS;
            // 
            // codeCraftersDS
            // 
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taClientBranchBooking
            // 
            this.taClientBranchBooking.ClearBeforeFill = true;
            // 
            // pnlViewBookings
            // 
            this.pnlViewBookings.AutoScroll = true;
            this.pnlViewBookings.Controls.Add(this.groupBox1);
            this.pnlViewBookings.Location = new System.Drawing.Point(21, 85);
            this.pnlViewBookings.Name = "pnlViewBookings";
            this.pnlViewBookings.Size = new System.Drawing.Size(1833, 634);
            this.pnlViewBookings.TabIndex = 1;
            // 
            // ViewBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1843, 688);
            this.Controls.Add(this.pnlViewBookings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewBookingForm";
            this.Text = "REGAL INN VIEW BOOKINGS";
            this.Load += new System.EventHandler(this.ViewBookingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBranchBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.pnlViewBookings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private codeCraftersDS codeCraftersDS;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private codeCraftersDSTableAdapters.ClientBranchBookingTableAdapter taClientBranchBooking;
        private System.Windows.Forms.BindingSource clientBranchBookingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingTotalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.ComboBox cmbStatusActions;
        private System.Windows.Forms.Panel pnlViewBookings;
    }
}