namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class StaffManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStaffManagement = new System.Windows.Forms.DataGridView();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.lblStaffManagement = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStaffUpdate = new System.Windows.Forms.Button();
            this.btnStaffClear = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.lblStaffStatus = new System.Windows.Forms.Label();
            this.lblStaffPhoneNumber = new System.Windows.Forms.Label();
            this.lblStaffRole = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmbStaffStatus = new System.Windows.Forms.ComboBox();
            this.txtStaffFullName = new System.Windows.Forms.TextBox();
            this.cmbStaffRole = new System.Windows.Forms.ComboBox();
            this.lblStaffFullName = new System.Windows.Forms.Label();
            this.taStaff = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffphonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datejoinedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.cmbBranchID = new System.Windows.Forms.ComboBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStaffManagement);
            this.panel1.Controls.Add(this.lblStaffManagement);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(119, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 733);
            this.panel1.TabIndex = 1;
            // 
            // dgvStaffManagement
            // 
            this.dgvStaffManagement.AutoGenerateColumns = false;
            this.dgvStaffManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.branchIDDataGridViewTextBoxColumn,
            this.staffFirstNameDataGridViewTextBoxColumn,
            this.staffSurnameDataGridViewTextBoxColumn,
            this.staffAddressDataGridViewTextBoxColumn,
            this.staffphonenumberDataGridViewTextBoxColumn,
            this.staffemailDataGridViewTextBoxColumn,
            this.staffroleDataGridViewTextBoxColumn,
            this.datejoinedDataGridViewTextBoxColumn,
            this.staffstatusDataGridViewTextBoxColumn});
            this.dgvStaffManagement.DataSource = this.staffBindingSource;
            this.dgvStaffManagement.Location = new System.Drawing.Point(71, 414);
            this.dgvStaffManagement.Name = "dgvStaffManagement";
            this.dgvStaffManagement.Size = new System.Drawing.Size(1046, 240);
            this.dgvStaffManagement.TabIndex = 3;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.codeCraftersDS;
            // 
            // codeCraftersDS
            // 
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStaffManagement
            // 
            this.lblStaffManagement.AutoSize = true;
            this.lblStaffManagement.Location = new System.Drawing.Point(556, 48);
            this.lblStaffManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffManagement.Name = "lblStaffManagement";
            this.lblStaffManagement.Size = new System.Drawing.Size(142, 17);
            this.lblStaffManagement.TabIndex = 2;
            this.lblStaffManagement.Text = "STAFF MANAGEMENT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEmailAddress);
            this.panel2.Controls.Add(this.txtStaffAddress);
            this.panel2.Controls.Add(this.cmbBranchID);
            this.panel2.Controls.Add(this.lblEmailAddress);
            this.panel2.Controls.Add(this.lblStaffAddress);
            this.panel2.Controls.Add(this.lblBranchID);
            this.panel2.Controls.Add(this.btnStaffUpdate);
            this.panel2.Controls.Add(this.btnStaffClear);
            this.panel2.Controls.Add(this.btnStaffDelete);
            this.panel2.Controls.Add(this.btnStaffAdd);
            this.panel2.Controls.Add(this.lblStaffStatus);
            this.panel2.Controls.Add(this.lblStaffPhoneNumber);
            this.panel2.Controls.Add(this.lblStaffRole);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Controls.Add(this.cmbStaffStatus);
            this.panel2.Controls.Add(this.txtStaffFullName);
            this.panel2.Controls.Add(this.cmbStaffRole);
            this.panel2.Controls.Add(this.lblStaffFullName);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(71, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 317);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnStaffUpdate.Location = new System.Drawing.Point(204, 270);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(91, 33);
            this.btnStaffUpdate.TabIndex = 11;
            this.btnStaffUpdate.Text = "UPDATE";
            this.btnStaffUpdate.UseVisualStyleBackColor = false;
            // 
            // btnStaffClear
            // 
            this.btnStaffClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnStaffClear.Location = new System.Drawing.Point(35, 270);
            this.btnStaffClear.Name = "btnStaffClear";
            this.btnStaffClear.Size = new System.Drawing.Size(75, 33);
            this.btnStaffClear.TabIndex = 10;
            this.btnStaffClear.Text = "CLEAR";
            this.btnStaffClear.UseVisualStyleBackColor = false;
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnStaffDelete.Location = new System.Drawing.Point(380, 270);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(75, 33);
            this.btnStaffDelete.TabIndex = 9;
            this.btnStaffDelete.Text = "DELETE";
            this.btnStaffDelete.UseVisualStyleBackColor = false;
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnStaffAdd.Location = new System.Drawing.Point(528, 270);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(75, 33);
            this.btnStaffAdd.TabIndex = 8;
            this.btnStaffAdd.Text = "ADD";
            this.btnStaffAdd.UseVisualStyleBackColor = false;
            // 
            // lblStaffStatus
            // 
            this.lblStaffStatus.AutoSize = true;
            this.lblStaffStatus.Location = new System.Drawing.Point(32, 228);
            this.lblStaffStatus.Name = "lblStaffStatus";
            this.lblStaffStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStaffStatus.TabIndex = 7;
            this.lblStaffStatus.Text = "STATUS";
            // 
            // lblStaffPhoneNumber
            // 
            this.lblStaffPhoneNumber.AutoSize = true;
            this.lblStaffPhoneNumber.Location = new System.Drawing.Point(32, 130);
            this.lblStaffPhoneNumber.Name = "lblStaffPhoneNumber";
            this.lblStaffPhoneNumber.Size = new System.Drawing.Size(111, 17);
            this.lblStaffPhoneNumber.TabIndex = 6;
            this.lblStaffPhoneNumber.Text = "PHONE NUMBER";
            // 
            // lblStaffRole
            // 
            this.lblStaffRole.AutoSize = true;
            this.lblStaffRole.Location = new System.Drawing.Point(32, 194);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(85, 17);
            this.lblStaffRole.TabIndex = 5;
            this.lblStaffRole.Text = "STAFF ROLE:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(250, 127);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(221, 25);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // cmbStaffStatus
            // 
            this.cmbStaffStatus.FormattingEnabled = true;
            this.cmbStaffStatus.Location = new System.Drawing.Point(250, 225);
            this.cmbStaffStatus.Name = "cmbStaffStatus";
            this.cmbStaffStatus.Size = new System.Drawing.Size(156, 25);
            this.cmbStaffStatus.TabIndex = 3;
            // 
            // txtStaffFullName
            // 
            this.txtStaffFullName.Location = new System.Drawing.Point(250, 64);
            this.txtStaffFullName.Name = "txtStaffFullName";
            this.txtStaffFullName.Size = new System.Drawing.Size(221, 25);
            this.txtStaffFullName.TabIndex = 2;
            // 
            // cmbStaffRole
            // 
            this.cmbStaffRole.FormattingEnabled = true;
            this.cmbStaffRole.Location = new System.Drawing.Point(250, 194);
            this.cmbStaffRole.Name = "cmbStaffRole";
            this.cmbStaffRole.Size = new System.Drawing.Size(156, 25);
            this.cmbStaffRole.TabIndex = 1;
            this.cmbStaffRole.SelectedIndexChanged += new System.EventHandler(this.cmbStaffRole_SelectedIndexChanged);
            // 
            // lblStaffFullName
            // 
            this.lblStaffFullName.AutoSize = true;
            this.lblStaffFullName.Location = new System.Drawing.Point(33, 67);
            this.lblStaffFullName.Name = "lblStaffFullName";
            this.lblStaffFullName.Size = new System.Drawing.Size(84, 17);
            this.lblStaffFullName.TabIndex = 0;
            this.lblStaffFullName.Text = "FULL NAME:";
            // 
            // taStaff
            // 
            this.taStaff.ClearBeforeFill = true;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staff_ID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "STAFF ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BRANCH ID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // staffFirstNameDataGridViewTextBoxColumn
            // 
            this.staffFirstNameDataGridViewTextBoxColumn.DataPropertyName = "staff_First_Name";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffFirstNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffFirstNameDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.staffFirstNameDataGridViewTextBoxColumn.Name = "staffFirstNameDataGridViewTextBoxColumn";
            this.staffFirstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffSurnameDataGridViewTextBoxColumn
            // 
            this.staffSurnameDataGridViewTextBoxColumn.DataPropertyName = "staff_Surname";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSurnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.staffSurnameDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.staffSurnameDataGridViewTextBoxColumn.Name = "staffSurnameDataGridViewTextBoxColumn";
            this.staffSurnameDataGridViewTextBoxColumn.Width = 130;
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "staff_Address";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffAddressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "STAFF ADDRESS";
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            this.staffAddressDataGridViewTextBoxColumn.Width = 180;
            // 
            // staffphonenumberDataGridViewTextBoxColumn
            // 
            this.staffphonenumberDataGridViewTextBoxColumn.DataPropertyName = "staff_phone_number";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffphonenumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.staffphonenumberDataGridViewTextBoxColumn.HeaderText = "PHONE NO.";
            this.staffphonenumberDataGridViewTextBoxColumn.Name = "staffphonenumberDataGridViewTextBoxColumn";
            this.staffphonenumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // staffemailDataGridViewTextBoxColumn
            // 
            this.staffemailDataGridViewTextBoxColumn.DataPropertyName = "staff_email";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffemailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.staffemailDataGridViewTextBoxColumn.HeaderText = "EMAIL ADDRESS";
            this.staffemailDataGridViewTextBoxColumn.Name = "staffemailDataGridViewTextBoxColumn";
            this.staffemailDataGridViewTextBoxColumn.Width = 180;
            // 
            // staffroleDataGridViewTextBoxColumn
            // 
            this.staffroleDataGridViewTextBoxColumn.DataPropertyName = "staff_role";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffroleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.staffroleDataGridViewTextBoxColumn.HeaderText = "STAFF ROLE";
            this.staffroleDataGridViewTextBoxColumn.Name = "staffroleDataGridViewTextBoxColumn";
            this.staffroleDataGridViewTextBoxColumn.Width = 130;
            // 
            // datejoinedDataGridViewTextBoxColumn
            // 
            this.datejoinedDataGridViewTextBoxColumn.DataPropertyName = "date_joined";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datejoinedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.datejoinedDataGridViewTextBoxColumn.HeaderText = "DATE JOINED";
            this.datejoinedDataGridViewTextBoxColumn.Name = "datejoinedDataGridViewTextBoxColumn";
            this.datejoinedDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffstatusDataGridViewTextBoxColumn
            // 
            this.staffstatusDataGridViewTextBoxColumn.DataPropertyName = "staff_status";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffstatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.staffstatusDataGridViewTextBoxColumn.HeaderText = "STAFF STATUS";
            this.staffstatusDataGridViewTextBoxColumn.Name = "staffstatusDataGridViewTextBoxColumn";
            this.staffstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBranchID.Location = new System.Drawing.Point(33, 20);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(83, 17);
            this.lblBranchID.TabIndex = 12;
            this.lblBranchID.Text = "BRANCH ID:";
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Location = new System.Drawing.Point(32, 98);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(111, 17);
            this.lblStaffAddress.TabIndex = 13;
            this.lblStaffAddress.Text = "STAFF ADDRESS:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(32, 164);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(109, 17);
            this.lblEmailAddress.TabIndex = 14;
            this.lblEmailAddress.Text = "EMAIL ADDRESS";
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
            this.cmbBranchID.Location = new System.Drawing.Point(250, 20);
            this.cmbBranchID.Name = "cmbBranchID";
            this.cmbBranchID.Size = new System.Drawing.Size(110, 25);
            this.cmbBranchID.TabIndex = 15;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Location = new System.Drawing.Point(250, 95);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(221, 25);
            this.txtStaffAddress.TabIndex = 17;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(250, 161);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(221, 25);
            this.txtEmailAddress.TabIndex = 18;
            // 
            // StaffManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1434, 866);
            this.Controls.Add(this.panel1);
            this.Name = "StaffManagementForm";
            this.Text = "REGAL INN STAFF MANAGEMENT";
            this.Load += new System.EventHandler(this.StaffManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStaffManagement;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private codeCraftersDS codeCraftersDS;
        private System.Windows.Forms.Label lblStaffManagement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStaffUpdate;
        private System.Windows.Forms.Button btnStaffClear;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.Label lblStaffStatus;
        private System.Windows.Forms.Label lblStaffPhoneNumber;
        private System.Windows.Forms.Label lblStaffRole;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cmbStaffStatus;
        private System.Windows.Forms.TextBox txtStaffFullName;
        private System.Windows.Forms.ComboBox cmbStaffRole;
        private System.Windows.Forms.Label lblStaffFullName;
        private codeCraftersDSTableAdapters.StaffTableAdapter taStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffphonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datejoinedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.ComboBox cmbBranchID;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtStaffAddress;
    }
}