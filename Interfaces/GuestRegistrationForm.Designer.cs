namespace Code_Crafters_Booking_System
{
    partial class GuestRegistrationForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtPhysicalAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taClient = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
            this.taStaff = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter();
            this.taBranch = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.pnlSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(490, 38);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(706, 352);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personal Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnSignUp);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtContactNumber);
            this.panel2.Controls.Add(this.txtPhysicalAddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEmailAddress);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSurname);
            this.panel2.Location = new System.Drawing.Point(20, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 300);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources._6478_200;
            this.pictureBox2.Location = new System.Drawing.Point(508, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(508, 183);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(129, 28);
            this.btnSignUp.TabIndex = 26;
            this.btnSignUp.Text = "Register";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(171, 183);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(122, 24);
            this.txtContactNumber.TabIndex = 14;
            // 
            // txtPhysicalAddress
            // 
            this.txtPhysicalAddress.Location = new System.Drawing.Point(171, 139);
            this.txtPhysicalAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhysicalAddress.Name = "txtPhysicalAddress";
            this.txtPhysicalAddress.Size = new System.Drawing.Size(122, 24);
            this.txtPhysicalAddress.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(345, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Confirm password:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(171, 96);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(122, 24);
            this.txtEmailAddress.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(345, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(25, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phone Number:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(508, 58);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(122, 24);
            this.txtConfirmPassword.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(508, 10);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(122, 24);
            this.txtPassword.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Physical Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(25, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 24);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(171, 54);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(122, 24);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.AutoScroll = true;
            this.pnlSignUp.Controls.Add(this.pictureBox1);
            this.pnlSignUp.Controls.Add(this.button1);
            this.pnlSignUp.Controls.Add(this.groupBox4);
            this.pnlSignUp.Location = new System.Drawing.Point(12, 91);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(1211, 426);
            this.pnlSignUp.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.IMG_20260413_185513;
            this.pictureBox1.Location = new System.Drawing.Point(40, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GuestRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1439, 703);
            this.Controls.Add(this.pnlSignUp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GuestRegistrationForm";
            this.Text = "REGAL INN SIGN UP ";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.pnlSignUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPhysicalAddress;
        private System.Windows.Forms.Label label4;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDS codeCraftersDS;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter taClient;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.StaffTableAdapter taStaff;
        private Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter taBranch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}