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
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDSTWO = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWO();
            this.taStaffs = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.StaffTableAdapter();
            this.taClients = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.ClientTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.dgvStaffManagement = new System.Windows.Forms.DataGridView();
            this.staffstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datejoinedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffphonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.txtStaffSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblStaffFullName = new System.Windows.Forms.Label();
            this.cmbStaffRole = new System.Windows.Forms.ComboBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.cmbStaffStatus = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblStaffRole = new System.Windows.Forms.Label();
            this.lblStaffStatus = new System.Windows.Forms.Label();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.cmbBranchID = new System.Windows.Forms.ComboBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblStaffPassword = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStaffClear = new System.Windows.Forms.Button();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.btnStaffUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffManagement)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.codeCraftersDSTWO;
            // 
            // codeCraftersDSTWO
            // 
            this.codeCraftersDSTWO.DataSetName = "codeCraftersDSTWO";
            this.codeCraftersDSTWO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taStaffs
            // 
            this.taStaffs.ClearBeforeFill = true;
            // 
            // taClients
            // 
            this.taClients.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 817);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnStaffUpdate);
            this.panel3.Controls.Add(this.lblStaffID);
            this.panel3.Controls.Add(this.btnStaffClear);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dgvStaffManagement);
            this.panel3.Controls.Add(this.txtStaffID);
            this.panel3.Controls.Add(this.btnStaffDelete);
            this.panel3.Controls.Add(this.btnStaffAdd);
            this.panel3.Location = new System.Drawing.Point(22, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 742);
            this.panel3.TabIndex = 4;
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Location = new System.Drawing.Point(439, 688);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(75, 33);
            this.btnStaffAdd.TabIndex = 8;
            this.btnStaffAdd.Text = "ADD";
            this.btnStaffAdd.UseVisualStyleBackColor = false;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.Location = new System.Drawing.Point(316, 688);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(75, 33);
            this.btnStaffDelete.TabIndex = 9;
            this.btnStaffDelete.Text = "DELETE";
            this.btnStaffDelete.UseVisualStyleBackColor = false;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(199, 409);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(106, 25);
            this.txtStaffID.TabIndex = 21;
            this.txtStaffID.Click += new System.EventHandler(this.txtStaffID_TextChanged);
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
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
            this.dgvStaffManagement.Location = new System.Drawing.Point(71, 440);
            this.dgvStaffManagement.Name = "dgvStaffManagement";
            this.dgvStaffManagement.RowHeadersWidth = 51;
            this.dgvStaffManagement.Size = new System.Drawing.Size(1056, 225);
            this.dgvStaffManagement.TabIndex = 3;
            // 
            // staffstatusDataGridViewTextBoxColumn
            // 
            this.staffstatusDataGridViewTextBoxColumn.DataPropertyName = "staff_status";
            this.staffstatusDataGridViewTextBoxColumn.HeaderText = "STAFF STATUS";
            this.staffstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffstatusDataGridViewTextBoxColumn.Name = "staffstatusDataGridViewTextBoxColumn";
            this.staffstatusDataGridViewTextBoxColumn.Width = 160;
            // 
            // datejoinedDataGridViewTextBoxColumn
            // 
            this.datejoinedDataGridViewTextBoxColumn.DataPropertyName = "date_joined";
            this.datejoinedDataGridViewTextBoxColumn.HeaderText = "DATE JOINED";
            this.datejoinedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datejoinedDataGridViewTextBoxColumn.Name = "datejoinedDataGridViewTextBoxColumn";
            this.datejoinedDataGridViewTextBoxColumn.Width = 160;
            // 
            // staffroleDataGridViewTextBoxColumn
            // 
            this.staffroleDataGridViewTextBoxColumn.DataPropertyName = "staff_role";
            this.staffroleDataGridViewTextBoxColumn.HeaderText = "STAFF ROLE";
            this.staffroleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffroleDataGridViewTextBoxColumn.Name = "staffroleDataGridViewTextBoxColumn";
            this.staffroleDataGridViewTextBoxColumn.Width = 130;
            // 
            // staffemailDataGridViewTextBoxColumn
            // 
            this.staffemailDataGridViewTextBoxColumn.DataPropertyName = "staff_email";
            this.staffemailDataGridViewTextBoxColumn.HeaderText = "EMAIL ADDRESS";
            this.staffemailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffemailDataGridViewTextBoxColumn.Name = "staffemailDataGridViewTextBoxColumn";
            this.staffemailDataGridViewTextBoxColumn.Width = 140;
            // 
            // staffphonenumberDataGridViewTextBoxColumn
            // 
            this.staffphonenumberDataGridViewTextBoxColumn.DataPropertyName = "staff_phone_number";
            this.staffphonenumberDataGridViewTextBoxColumn.HeaderText = "PHONE NO.";
            this.staffphonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffphonenumberDataGridViewTextBoxColumn.Name = "staffphonenumberDataGridViewTextBoxColumn";
            this.staffphonenumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "STAFF ADDRESS";
            this.staffAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            this.staffAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffSurnameDataGridViewTextBoxColumn
            // 
            this.staffSurnameDataGridViewTextBoxColumn.DataPropertyName = "staff_Surname";
            this.staffSurnameDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.staffSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffSurnameDataGridViewTextBoxColumn.Name = "staffSurnameDataGridViewTextBoxColumn";
            this.staffSurnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // staffFirstNameDataGridViewTextBoxColumn
            // 
            this.staffFirstNameDataGridViewTextBoxColumn.DataPropertyName = "staff_First_Name";
            this.staffFirstNameDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.staffFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffFirstNameDataGridViewTextBoxColumn.Name = "staffFirstNameDataGridViewTextBoxColumn";
            this.staffFirstNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BRANCH ID";
            this.branchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.Width = 115;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "STAFF ID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 105;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblStaffPassword);
            this.panel2.Controls.Add(this.lblPhoneNumber);
            this.panel2.Controls.Add(this.lblEmailAddress);
            this.panel2.Controls.Add(this.txtStaffAddress);
            this.panel2.Controls.Add(this.txtEmailAddress);
            this.panel2.Controls.Add(this.cmbBranchID);
            this.panel2.Controls.Add(this.lblStaffAddress);
            this.panel2.Controls.Add(this.lblBranchID);
            this.panel2.Controls.Add(this.lblStaffStatus);
            this.panel2.Controls.Add(this.lblStaffRole);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Controls.Add(this.cmbStaffStatus);
            this.panel2.Controls.Add(this.txtStaffName);
            this.panel2.Controls.Add(this.cmbStaffRole);
            this.panel2.Controls.Add(this.lblStaffFullName);
            this.panel2.Controls.Add(this.lblSurname);
            this.panel2.Controls.Add(this.txtStaffSurname);
            this.panel2.Controls.Add(this.txtStaffPassword);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(71, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 361);
            this.panel2.TabIndex = 0;
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Location = new System.Drawing.Point(245, 233);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(221, 25);
            this.txtStaffPassword.TabIndex = 23;
            this.txtStaffPassword.UseSystemPasswordChar = true;
            // 
            // txtStaffSurname
            // 
            this.txtStaffSurname.Location = new System.Drawing.Point(245, 100);
            this.txtStaffSurname.Name = "txtStaffSurname";
            this.txtStaffSurname.Size = new System.Drawing.Size(221, 25);
            this.txtStaffSurname.TabIndex = 22;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(27, 103);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 17);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "LASTNAME:";
            // 
            // lblStaffFullName
            // 
            this.lblStaffFullName.AutoSize = true;
            this.lblStaffFullName.Location = new System.Drawing.Point(27, 72);
            this.lblStaffFullName.Name = "lblStaffFullName";
            this.lblStaffFullName.Size = new System.Drawing.Size(88, 17);
            this.lblStaffFullName.TabIndex = 0;
            this.lblStaffFullName.Text = "FIRST NAME:";
            // 
            // cmbStaffRole
            // 
            this.cmbStaffRole.FormattingEnabled = true;
            this.cmbStaffRole.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Manager"});
            this.cmbStaffRole.Location = new System.Drawing.Point(245, 276);
            this.cmbStaffRole.Name = "cmbStaffRole";
            this.cmbStaffRole.Size = new System.Drawing.Size(156, 25);
            this.cmbStaffRole.TabIndex = 1;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(245, 69);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(221, 25);
            this.txtStaffName.TabIndex = 2;
            // 
            // cmbStaffStatus
            // 
            this.cmbStaffStatus.FormattingEnabled = true;
            this.cmbStaffStatus.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.cmbStaffStatus.Location = new System.Drawing.Point(245, 317);
            this.cmbStaffStatus.Name = "cmbStaffStatus";
            this.cmbStaffStatus.Size = new System.Drawing.Size(156, 25);
            this.cmbStaffStatus.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(245, 162);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(221, 25);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // lblStaffRole
            // 
            this.lblStaffRole.AutoSize = true;
            this.lblStaffRole.Location = new System.Drawing.Point(27, 284);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(85, 17);
            this.lblStaffRole.TabIndex = 5;
            this.lblStaffRole.Text = "STAFF ROLE:";
            // 
            // lblStaffStatus
            // 
            this.lblStaffStatus.AutoSize = true;
            this.lblStaffStatus.Location = new System.Drawing.Point(27, 320);
            this.lblStaffStatus.Name = "lblStaffStatus";
            this.lblStaffStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStaffStatus.TabIndex = 7;
            this.lblStaffStatus.Text = "STATUS";
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Location = new System.Drawing.Point(27, 20);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(83, 17);
            this.lblBranchID.TabIndex = 12;
            this.lblBranchID.Text = "BRANCH ID:";
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Location = new System.Drawing.Point(27, 134);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(111, 17);
            this.lblStaffAddress.TabIndex = 13;
            this.lblStaffAddress.Text = "STAFF ADDRESS:";
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
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(245, 193);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(221, 25);
            this.txtEmailAddress.TabIndex = 18;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Location = new System.Drawing.Point(245, 131);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(221, 25);
            this.txtStaffAddress.TabIndex = 17;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(27, 196);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(113, 17);
            this.lblEmailAddress.TabIndex = 14;
            this.lblEmailAddress.Text = "EMAIL ADDRESS:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(27, 165);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 17);
            this.lblPhoneNumber.TabIndex = 24;
            this.lblPhoneNumber.Text = "PHONE NO:";
            // 
            // lblStaffPassword
            // 
            this.lblStaffPassword.AutoSize = true;
            this.lblStaffPassword.Location = new System.Drawing.Point(27, 236);
            this.lblStaffPassword.Name = "lblStaffPassword";
            this.lblStaffPassword.Size = new System.Drawing.Size(83, 17);
            this.lblStaffPassword.TabIndex = 25;
            this.lblStaffPassword.Text = "PASSWORD:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(721, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 361);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources._360_F_1071326094_tjUmhPv6z93aSEtnCx7jEXRkPH2XhFh7;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnStaffClear
            // 
            this.btnStaffClear.Location = new System.Drawing.Point(71, 688);
            this.btnStaffClear.Name = "btnStaffClear";
            this.btnStaffClear.Size = new System.Drawing.Size(75, 33);
            this.btnStaffClear.TabIndex = 10;
            this.btnStaffClear.Text = "CLEAR";
            this.btnStaffClear.UseVisualStyleBackColor = false;
            this.btnStaffClear.Click += new System.EventHandler(this.btnStaffClear_Click);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(68, 412);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(125, 17);
            this.lblStaffID.TabIndex = 22;
            this.lblStaffID.Text = "ENTER PHONE NO:";
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.Location = new System.Drawing.Point(185, 688);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(76, 33);
            this.btnStaffUpdate.TabIndex = 23;
            this.btnStaffUpdate.Text = "UPDATE";
            this.btnStaffUpdate.UseVisualStyleBackColor = false;
            this.btnStaffUpdate.Click += new System.EventHandler(this.btnStaffUpdate_Click);
            // 
            // StaffManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 885);
            this.Controls.Add(this.panel1);
            this.Name = "StaffManagementForm";
            this.Text = "REGAL INN STAFF MANAGEMENT";
            this.Load += new System.EventHandler(this.StaffManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffManagement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource staffBindingSource;
        private codeCraftersDSTableAdapters.StaffTableAdapter taStaff;
        private codeCraftersDSTableAdapters.ClientTableAdapter taClient;
        private codeCraftersDSTWO codeCraftersDSTWO;
        private codeCraftersDSTWOTableAdapters.StaffTableAdapter taStaffs;
        private codeCraftersDSTWOTableAdapters.ClientTableAdapter taClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStaffUpdate;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Button btnStaffClear;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStaffPassword;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.ComboBox cmbBranchID;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.Label lblStaffStatus;
        private System.Windows.Forms.Label lblStaffRole;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cmbStaffStatus;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.ComboBox cmbStaffRole;
        private System.Windows.Forms.Label lblStaffFullName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtStaffSurname;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.DataGridView dgvStaffManagement;
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
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnStaffAdd;
    }
}