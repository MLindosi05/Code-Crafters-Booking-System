namespace Code_Crafters_Booking_System
{
    partial class GuestManagementForm
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
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taClient = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
            this.taStaff = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter();
            this.taBranch = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhysicalAddress = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDSTWO1 = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWO();
            this.btnArchived = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.btnBlacklisted = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManageEmailAddress = new System.Windows.Forms.TextBox();
            this.dgvManageClients = new System.Windows.Forms.DataGridView();
            this.Client_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBlackList = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.clientTableAdapter1 = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
            this.clientTableAdapter = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel9.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageClients)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeCraftersDS
            // 
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taClient
            // 
            this.taClient.ClearBeforeFill = true;
            // 
            // taStaff
            // 
            this.taStaff.ClearBeforeFill = true;
            // 
            // taBranch
            // 
            this.taBranch.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1359, 835);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1351, 806);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GUEST REGISTRATION";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(180, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 499);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtContactNumber);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnSignUp);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPhysicalAddress);
            this.panel2.Controls.Add(this.txtEmailAddress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSurname);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(78, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 400);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "PHONE NO:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(186, 290);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(165, 22);
            this.txtContactNumber.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources._6478_200;
            this.pictureBox2.Location = new System.Drawing.Point(447, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(447, 285);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(145, 32);
            this.btnSignUp.TabIndex = 26;
            this.btnSignUp.Text = "Register";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "FIRST NAME:";
            // 
            // txtPhysicalAddress
            // 
            this.txtPhysicalAddress.Location = new System.Drawing.Point(186, 226);
            this.txtPhysicalAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhysicalAddress.Name = "txtPhysicalAddress";
            this.txtPhysicalAddress.Size = new System.Drawing.Size(166, 22);
            this.txtPhysicalAddress.TabIndex = 28;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(186, 164);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(166, 22);
            this.txtEmailAddress.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "PHYSICAL ADDRESS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "EMAIL ADDRESS:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(186, 45);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "LAST NAME:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(186, 105);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(166, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1345, 61);
            this.panel9.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(415, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "GUEST REGISTRATION";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1351, 806);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VIEW GUESTS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1345, 61);
            this.panel5.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(454, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "VIEW GUESTS";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.dgvBookings);
            this.panel8.Controls.Add(this.btnArchived);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.btnBlacklisted);
            this.panel8.Location = new System.Drawing.Point(142, 70);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(895, 632);
            this.panel8.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(79, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 193);
            this.panel4.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.booking_hotel;
            this.pictureBox3.Location = new System.Drawing.Point(18, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 168);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoGenerateColumns = false;
            this.dgvBookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.clientStatusDataGridViewTextBoxColumn,
            this.dateRegisteredDataGridViewTextBoxColumn});
            this.dgvBookings.DataSource = this.clientBindingSource;
            this.dgvBookings.Location = new System.Drawing.Point(79, 260);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.Size = new System.Drawing.Size(637, 328);
            this.dgvBookings.TabIndex = 13;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "CLIENT ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LAST NAME";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email_Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EMAIL ADDRESS";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 140;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PHONE NO.";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // clientStatusDataGridViewTextBoxColumn
            // 
            this.clientStatusDataGridViewTextBoxColumn.DataPropertyName = "Client_Status";
            this.clientStatusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.clientStatusDataGridViewTextBoxColumn.Name = "clientStatusDataGridViewTextBoxColumn";
            // 
            // dateRegisteredDataGridViewTextBoxColumn
            // 
            this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "Date_Registered";
            this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DATE REGISTERED";
            this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
            this.dateRegisteredDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.codeCraftersDSTWO1;
            // 
            // codeCraftersDSTWO1
            // 
            this.codeCraftersDSTWO1.DataSetName = "codeCraftersDSTWO";
            this.codeCraftersDSTWO1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnArchived
            // 
            this.btnArchived.Location = new System.Drawing.Point(596, 200);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(120, 30);
            this.btnArchived.TabIndex = 19;
            this.btnArchived.Text = "ARCHIVED";
            this.btnArchived.UseVisualStyleBackColor = true;
            this.btnArchived.Click += new System.EventHandler(this.btnArchived_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblBookingID);
            this.panel1.Controls.Add(this.txtSearchEmail);
            this.panel1.Location = new System.Drawing.Point(368, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 72);
            this.panel1.TabIndex = 14;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(3, 21);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(200, 17);
            this.lblBookingID.TabIndex = 2;
            this.lblBookingID.Text = "ENTER GUEST EMAIL ADDRESS:";
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(204, 19);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(144, 22);
            this.txtSearchEmail.TabIndex = 1;
            // 
            // btnBlacklisted
            // 
            this.btnBlacklisted.Location = new System.Drawing.Point(374, 200);
            this.btnBlacklisted.Name = "btnBlacklisted";
            this.btnBlacklisted.Size = new System.Drawing.Size(129, 30);
            this.btnBlacklisted.TabIndex = 17;
            this.btnBlacklisted.Text = "BLACKLISTED";
            this.btnBlacklisted.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.panel10);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1351, 806);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MANAGE GUESTS";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.dgvManageClients);
            this.panel10.Controls.Add(this.btnBlackList);
            this.panel10.Controls.Add(this.btnArchive);
            this.panel10.Location = new System.Drawing.Point(150, 70);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(787, 648);
            this.panel10.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtManageEmailAddress);
            this.panel6.Location = new System.Drawing.Point(79, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 64);
            this.panel6.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ENTER GUEST EMAIL ADDRESS:";
            // 
            // txtManageEmailAddress
            // 
            this.txtManageEmailAddress.Location = new System.Drawing.Point(168, 19);
            this.txtManageEmailAddress.Name = "txtManageEmailAddress";
            this.txtManageEmailAddress.Size = new System.Drawing.Size(175, 22);
            this.txtManageEmailAddress.TabIndex = 1;
            this.txtManageEmailAddress.TextChanged += new System.EventHandler(this.txtManageEmailAddress_TextChanged);
            // 
            // dgvManageClients
            // 
            this.dgvManageClients.AutoGenerateColumns = false;
            this.dgvManageClients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvManageClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client_ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Email_Address,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvManageClients.DataSource = this.clientBindingSource;
            this.dgvManageClients.Location = new System.Drawing.Point(79, 223);
            this.dgvManageClients.Name = "dgvManageClients";
            this.dgvManageClients.RowHeadersWidth = 51;
            this.dgvManageClients.Size = new System.Drawing.Size(622, 396);
            this.dgvManageClients.TabIndex = 14;
            // 
            // Client_ID
            // 
            this.Client_ID.DataPropertyName = "Client_ID";
            this.Client_ID.HeaderText = "CLIENT ID";
            this.Client_ID.Name = "Client_ID";
            this.Client_ID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "FIRST NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "LAST NAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // Email_Address
            // 
            this.Email_Address.DataPropertyName = "Email_Address";
            this.Email_Address.HeaderText = "EMAIL ADDRESS";
            this.Email_Address.Name = "Email_Address";
            this.Email_Address.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Phone_Number";
            this.dataGridViewTextBoxColumn7.HeaderText = "PHONE NO.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Client_Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date_Registered";
            this.dataGridViewTextBoxColumn9.HeaderText = "DATE REGISTERED";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // btnBlackList
            // 
            this.btnBlackList.Location = new System.Drawing.Point(79, 166);
            this.btnBlackList.Name = "btnBlackList";
            this.btnBlackList.Size = new System.Drawing.Size(158, 30);
            this.btnBlackList.TabIndex = 18;
            this.btnBlackList.Text = "BLACKLIST GUEST";
            this.btnBlackList.UseVisualStyleBackColor = true;
            this.btnBlackList.Click += new System.EventHandler(this.btnBlackList_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(278, 166);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(170, 30);
            this.btnArchive.TabIndex = 17;
            this.btnArchive.Text = "ARCHIVE GUEST";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1345, 61);
            this.panel7.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(419, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "MANAGE GUESTS";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // GuestManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 835);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GuestManagementForm";
            this.Text = "REGAL INN SIGN UP ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GuestManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageClients)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Code_Crafters_Interface_Prototype_1.codeCraftersDS codeCraftersDS;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter taClient;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter taStaff;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter taBranch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTWO codeCraftersDSTWO1;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button btnArchived;
        private System.Windows.Forms.Button btnBlacklisted;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.Button btnBlackList;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.DataGridView dgvManageClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManageEmailAddress;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhysicalAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
    }
}