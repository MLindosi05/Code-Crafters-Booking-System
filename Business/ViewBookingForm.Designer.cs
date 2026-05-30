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
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taClientBranchBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientBranchBookingTableAdapter();
            this.clientBranchBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBranchBookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBookingID);
            this.groupBox1.Controls.Add(this.txtBookingID);
            this.groupBox1.Controls.Add(this.dgvBookings);
            this.groupBox1.Location = new System.Drawing.Point(55, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Bookings";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(24, 39);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(88, 13);
            this.lblBookingID.TabIndex = 2;
            this.lblBookingID.Text = "Enter Booking ID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(24, 58);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(255, 20);
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
            this.dgvBookings.Location = new System.Drawing.Point(24, 93);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.Size = new System.Drawing.Size(970, 359);
            this.dgvBookings.TabIndex = 0;
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
            // clientBranchBookingBindingSource
            // 
            this.clientBranchBookingBindingSource.DataMember = "ClientBranchBooking";
            this.clientBranchBookingBindingSource.DataSource = this.codeCraftersDS;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "Branch ID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // checkinDateDataGridViewTextBoxColumn
            // 
            this.checkinDateDataGridViewTextBoxColumn.DataPropertyName = "Checkin_Date";
            this.checkinDateDataGridViewTextBoxColumn.HeaderText = "Checkin Date";
            this.checkinDateDataGridViewTextBoxColumn.Name = "checkinDateDataGridViewTextBoxColumn";
            // 
            // checkoutDateDataGridViewTextBoxColumn
            // 
            this.checkoutDateDataGridViewTextBoxColumn.DataPropertyName = "Checkout_Date";
            this.checkoutDateDataGridViewTextBoxColumn.HeaderText = "Checkout Date";
            this.checkoutDateDataGridViewTextBoxColumn.Name = "checkoutDateDataGridViewTextBoxColumn";
            this.checkoutDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookingTotalAmountDataGridViewTextBoxColumn
            // 
            this.bookingTotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Booking_Total_Amount";
            this.bookingTotalAmountDataGridViewTextBoxColumn.HeaderText = "Price";
            this.bookingTotalAmountDataGridViewTextBoxColumn.Name = "bookingTotalAmountDataGridViewTextBoxColumn";
            // 
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientAddressDataGridViewTextBoxColumn
            // 
            this.clientAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Address";
            this.clientAddressDataGridViewTextBoxColumn.HeaderText = "Client Address";
            this.clientAddressDataGridViewTextBoxColumn.Name = "clientAddressDataGridViewTextBoxColumn";
            this.clientAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // branchNameDataGridViewTextBoxColumn
            // 
            this.branchNameDataGridViewTextBoxColumn.DataPropertyName = "Branch_Name";
            this.branchNameDataGridViewTextBoxColumn.HeaderText = "Branch Name";
            this.branchNameDataGridViewTextBoxColumn.Name = "branchNameDataGridViewTextBoxColumn";
            this.branchNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchAddressDataGridViewTextBoxColumn
            // 
            this.branchAddressDataGridViewTextBoxColumn.DataPropertyName = "Branch_Address";
            this.branchAddressDataGridViewTextBoxColumn.HeaderText = "Branch Address";
            this.branchAddressDataGridViewTextBoxColumn.Name = "branchAddressDataGridViewTextBoxColumn";
            this.branchAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // branchPhoneDataGridViewTextBoxColumn
            // 
            this.branchPhoneDataGridViewTextBoxColumn.DataPropertyName = "Branch_Phone";
            this.branchPhoneDataGridViewTextBoxColumn.HeaderText = "Branch Phone Number";
            this.branchPhoneDataGridViewTextBoxColumn.Name = "branchPhoneDataGridViewTextBoxColumn";
            this.branchPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // branchEmailDataGridViewTextBoxColumn
            // 
            this.branchEmailDataGridViewTextBoxColumn.DataPropertyName = "Branch_Email";
            this.branchEmailDataGridViewTextBoxColumn.HeaderText = "Branch Email Address";
            this.branchEmailDataGridViewTextBoxColumn.Name = "branchEmailDataGridViewTextBoxColumn";
            this.branchEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // branchStatusDataGridViewTextBoxColumn
            // 
            this.branchStatusDataGridViewTextBoxColumn.DataPropertyName = "Branch_Status";
            this.branchStatusDataGridViewTextBoxColumn.HeaderText = "Branch Status";
            this.branchStatusDataGridViewTextBoxColumn.Name = "branchStatusDataGridViewTextBoxColumn";
            this.branchStatusDataGridViewTextBoxColumn.Width = 120;
            // 
            // ViewBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1118, 536);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewBookingForm";
            this.Text = "ViewBookingForm";
            this.Load += new System.EventHandler(this.ViewBookingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBranchBookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private codeCraftersDS codeCraftersDS;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
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
    }
}