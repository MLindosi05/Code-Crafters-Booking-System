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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeCraftersDS1 = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taStaff = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(119, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 758);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1051, 279);
            this.dataGridView1.TabIndex = 3;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "Branch_ID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            // 
            // staffFirstNameDataGridViewTextBoxColumn
            // 
            this.staffFirstNameDataGridViewTextBoxColumn.DataPropertyName = "staff_First_Name";
            this.staffFirstNameDataGridViewTextBoxColumn.HeaderText = "staff_First_Name";
            this.staffFirstNameDataGridViewTextBoxColumn.Name = "staffFirstNameDataGridViewTextBoxColumn";
            // 
            // staffSurnameDataGridViewTextBoxColumn
            // 
            this.staffSurnameDataGridViewTextBoxColumn.DataPropertyName = "staff_Surname";
            this.staffSurnameDataGridViewTextBoxColumn.HeaderText = "staff_Surname";
            this.staffSurnameDataGridViewTextBoxColumn.Name = "staffSurnameDataGridViewTextBoxColumn";
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            // 
            // staffphonenumberDataGridViewTextBoxColumn
            // 
            this.staffphonenumberDataGridViewTextBoxColumn.DataPropertyName = "staff_phone_number";
            this.staffphonenumberDataGridViewTextBoxColumn.HeaderText = "staff_phone_number";
            this.staffphonenumberDataGridViewTextBoxColumn.Name = "staffphonenumberDataGridViewTextBoxColumn";
            // 
            // staffemailDataGridViewTextBoxColumn
            // 
            this.staffemailDataGridViewTextBoxColumn.DataPropertyName = "staff_email";
            this.staffemailDataGridViewTextBoxColumn.HeaderText = "staff_email";
            this.staffemailDataGridViewTextBoxColumn.Name = "staffemailDataGridViewTextBoxColumn";
            // 
            // staffroleDataGridViewTextBoxColumn
            // 
            this.staffroleDataGridViewTextBoxColumn.DataPropertyName = "staff_role";
            this.staffroleDataGridViewTextBoxColumn.HeaderText = "staff_role";
            this.staffroleDataGridViewTextBoxColumn.Name = "staffroleDataGridViewTextBoxColumn";
            // 
            // datejoinedDataGridViewTextBoxColumn
            // 
            this.datejoinedDataGridViewTextBoxColumn.DataPropertyName = "date_joined";
            this.datejoinedDataGridViewTextBoxColumn.HeaderText = "date_joined";
            this.datejoinedDataGridViewTextBoxColumn.Name = "datejoinedDataGridViewTextBoxColumn";
            // 
            // staffstatusDataGridViewTextBoxColumn
            // 
            this.staffstatusDataGridViewTextBoxColumn.DataPropertyName = "staff_status";
            this.staffstatusDataGridViewTextBoxColumn.HeaderText = "staff_status";
            this.staffstatusDataGridViewTextBoxColumn.Name = "staffstatusDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.codeCraftersDS1;
            // 
            // codeCraftersDS1
            // 
            this.codeCraftersDS1.DataSetName = "codeCraftersDS";
            this.codeCraftersDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(510, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "STAFF MANAGEMENT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 317);
            this.panel2.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.Location = new System.Drawing.Point(205, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 33);
            this.button4.TabIndex = 11;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(35, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(379, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(523, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "STATUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PHONE NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ROLE";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(250, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NAME:";
            // 
            // taStaff
            // 
            this.taStaff.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(50, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 666);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(508, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 3);
            this.panel4.TabIndex = 5;
            // 
            // StaffManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 866);
            this.Controls.Add(this.panel1);
            this.Name = "StaffManagementForm";
            this.Text = "StaffManagementForm";
            this.Load += new System.EventHandler(this.StaffManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource staffBindingSource;
        private codeCraftersDS codeCraftersDS1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private codeCraftersDSTableAdapters.StaffTableAdapter taStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}