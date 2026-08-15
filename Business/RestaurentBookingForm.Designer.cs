namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class RestaurentBookingForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbTableArea = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpTableCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpTableCheckIn = new System.Windows.Forms.DateTimePicker();
            this.numTableGuests = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTableGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbTableArea);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dtpTableCheckOut);
            this.panel4.Controls.Add(this.dtpTableCheckIn);
            this.panel4.Controls.Add(this.numTableGuests);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label19);
            this.panel4.ForeColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(81, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 247);
            this.panel4.TabIndex = 13;
            // 
            // cmbTableArea
            // 
            this.cmbTableArea.FormattingEnabled = true;
            this.cmbTableArea.Location = new System.Drawing.Point(159, 171);
            this.cmbTableArea.Name = "cmbTableArea";
            this.cmbTableArea.Size = new System.Drawing.Size(170, 21);
            this.cmbTableArea.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(28, 174);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "TABLE AREA";
            // 
            // dtpTableCheckOut
            // 
            this.dtpTableCheckOut.CustomFormat = "yyyy/MM/dd";
            this.dtpTableCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTableCheckOut.Location = new System.Drawing.Point(159, 92);
            this.dtpTableCheckOut.Name = "dtpTableCheckOut";
            this.dtpTableCheckOut.Size = new System.Drawing.Size(131, 20);
            this.dtpTableCheckOut.TabIndex = 41;
            this.dtpTableCheckOut.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // dtpTableCheckIn
            // 
            this.dtpTableCheckIn.CustomFormat = "yyyy/MM/dd";
            this.dtpTableCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTableCheckIn.Location = new System.Drawing.Point(159, 57);
            this.dtpTableCheckIn.Name = "dtpTableCheckIn";
            this.dtpTableCheckIn.Size = new System.Drawing.Size(131, 20);
            this.dtpTableCheckIn.TabIndex = 40;
            this.dtpTableCheckIn.Value = new System.DateTime(2026, 8, 5, 0, 0, 0, 0);
            // 
            // numTableGuests
            // 
            this.numTableGuests.Location = new System.Drawing.Point(159, 130);
            this.numTableGuests.Name = "numTableGuests";
            this.numTableGuests.Size = new System.Drawing.Size(85, 20);
            this.numTableGuests.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(28, 135);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "NO. OF GUESTS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(28, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "CHECK-OUT";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(28, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "CHECK-IN";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(3, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 1);
            this.panel5.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "🍽 TABLE BOOKING";
            // 
            // RestaurentBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 635);
            this.Controls.Add(this.panel4);
            this.Name = "RestaurentBookingForm";
            this.Text = "RestaurentBookingForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTableGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbTableArea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpTableCheckOut;
        private System.Windows.Forms.DateTimePicker dtpTableCheckIn;
        private System.Windows.Forms.NumericUpDown numTableGuests;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
    }
}