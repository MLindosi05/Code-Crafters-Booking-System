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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnContinueToPayment = new System.Windows.Forms.Button();
            this.taTableAllocation = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Table_AllocationTableAdapter();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.BookingTableAdapter();
            this.taRestuarant_Table = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Restuarant_TableTableAdapter();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbTableArea);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label19);
            this.panel4.ForeColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(81, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 101);
            this.panel4.TabIndex = 13;
            // 
            // cmbTableArea
            // 
            this.cmbTableArea.FormattingEnabled = true;
            this.cmbTableArea.Location = new System.Drawing.Point(96, 46);
            this.cmbTableArea.Name = "cmbTableArea";
            this.cmbTableArea.Size = new System.Drawing.Size(231, 21);
            this.cmbTableArea.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(17, 49);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "TABLE AREA";
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
            // btnContinueToPayment
            // 
            this.btnContinueToPayment.BackColor = System.Drawing.Color.Navy;
            this.btnContinueToPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinueToPayment.Location = new System.Drawing.Point(335, 189);
            this.btnContinueToPayment.Name = "btnContinueToPayment";
            this.btnContinueToPayment.Size = new System.Drawing.Size(164, 31);
            this.btnContinueToPayment.TabIndex = 14;
            this.btnContinueToPayment.Text = "CONTINUE TO PAYMENT";
            this.btnContinueToPayment.UseVisualStyleBackColor = false;
            this.btnContinueToPayment.Click += new System.EventHandler(this.btnContinueToPayment_Click_1);
            // 
            // taTableAllocation
            // 
            this.taTableAllocation.ClearBeforeFill = true;
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // taRestuarant_Table
            // 
            this.taRestuarant_Table.ClearBeforeFill = true;
            // 
            // RestaurentBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 239);
            this.Controls.Add(this.btnContinueToPayment);
            this.Controls.Add(this.panel4);
            this.Name = "RestaurentBookingForm";
            this.Text = "REGAL INN RESTAURANT BOOKING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RestaurentBookingForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbTableArea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnContinueToPayment;
        private codeCraftersDSTWOTableAdapters.Table_AllocationTableAdapter taTableAllocation;
        private codeCraftersDSTWOTableAdapters.BookingTableAdapter taBooking;
        private codeCraftersDSTWOTableAdapters.Restuarant_TableTableAdapter taRestuarant_Table;
    }
}