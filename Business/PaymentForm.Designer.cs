namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class PaymentForm
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
            this.grbPayments = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtPhysicalAddress = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblPhysicalAddress = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblBookingReference = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.taFolio = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.FolioTableAdapter();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbPayments.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPayments
            // 
            this.grbPayments.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.grbPayments.Controls.Add(this.btnReset);
            this.grbPayments.Controls.Add(this.btnDone);
            this.grbPayments.Controls.Add(this.grpSummary);
            this.grbPayments.Controls.Add(this.btnCancel);
            this.grbPayments.Controls.Add(this.grpPayment);
            this.grbPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPayments.Location = new System.Drawing.Point(56, 33);
            this.grbPayments.Margin = new System.Windows.Forms.Padding(2);
            this.grbPayments.Name = "grbPayments";
            this.grbPayments.Padding = new System.Windows.Forms.Padding(2);
            this.grbPayments.Size = new System.Drawing.Size(942, 496);
            this.grbPayments.TabIndex = 0;
            this.grbPayments.TabStop = false;
            this.grbPayments.Text = "MAKE PAYMENT";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(29, 395);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 35);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(656, 395);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(89, 35);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpSummary.Controls.Add(this.txtTotalPrice);
            this.grpSummary.Controls.Add(this.lblTotalPrice);
            this.grpSummary.Controls.Add(this.txtPhysicalAddress);
            this.grpSummary.Controls.Add(this.txtEmailAddress);
            this.grpSummary.Controls.Add(this.txtGuestName);
            this.grpSummary.Controls.Add(this.txtBookingID);
            this.grpSummary.Controls.Add(this.lblPhysicalAddress);
            this.grpSummary.Controls.Add(this.lblEmailAddress);
            this.grpSummary.Controls.Add(this.lblGuestName);
            this.grpSummary.Controls.Add(this.lblBookingReference);
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummary.Location = new System.Drawing.Point(29, 39);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(2);
            this.grpSummary.Size = new System.Drawing.Size(716, 243);
            this.grpSummary.TabIndex = 1;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "BOOKING SUMMARY";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(214, 199);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(271, 29);
            this.txtTotalPrice.TabIndex = 20;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(30, 198);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(108, 21);
            this.lblTotalPrice.TabIndex = 19;
            this.lblTotalPrice.Text = "TOTAL PRICE:";
            // 
            // txtPhysicalAddress
            // 
            this.txtPhysicalAddress.Location = new System.Drawing.Point(214, 156);
            this.txtPhysicalAddress.Name = "txtPhysicalAddress";
            this.txtPhysicalAddress.ReadOnly = true;
            this.txtPhysicalAddress.Size = new System.Drawing.Size(271, 29);
            this.txtPhysicalAddress.TabIndex = 18;
            this.txtPhysicalAddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(214, 116);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(271, 29);
            this.txtEmailAddress.TabIndex = 17;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(214, 76);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.Size = new System.Drawing.Size(271, 29);
            this.txtGuestName.TabIndex = 16;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(214, 38);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(271, 29);
            this.txtBookingID.TabIndex = 15;
            this.txtBookingID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPhysicalAddress
            // 
            this.lblPhysicalAddress.AutoSize = true;
            this.lblPhysicalAddress.Location = new System.Drawing.Point(30, 164);
            this.lblPhysicalAddress.Name = "lblPhysicalAddress";
            this.lblPhysicalAddress.Size = new System.Drawing.Size(165, 21);
            this.lblPhysicalAddress.TabIndex = 13;
            this.lblPhysicalAddress.Text = "PHYSICAL ADDRESS:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(30, 124);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(138, 21);
            this.lblEmailAddress.TabIndex = 12;
            this.lblEmailAddress.Text = "EMAIL ADDRESS:";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(30, 84);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(116, 21);
            this.lblGuestName.TabIndex = 11;
            this.lblGuestName.Text = "GUEST NAME:";
            // 
            // lblBookingReference
            // 
            this.lblBookingReference.AutoSize = true;
            this.lblBookingReference.Location = new System.Drawing.Point(30, 41);
            this.lblBookingReference.Name = "lblBookingReference";
            this.lblBookingReference.Size = new System.Drawing.Size(178, 21);
            this.lblBookingReference.TabIndex = 10;
            this.lblBookingReference.Text = "BOOKING REFERENCE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(543, 395);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpPayment.Controls.Add(this.cmbPaymentMethod);
            this.grpPayment.Controls.Add(this.label6);
            this.grpPayment.Location = new System.Drawing.Point(29, 301);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(716, 89);
            this.grpPayment.TabIndex = 14;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "PAYMENT";
            this.grpPayment.Enter += new System.EventHandler(this.grpPayment_Enter);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "CASH ",
            "CREDIT/DEBIT CARD"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(214, 33);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(216, 29);
            this.cmbPaymentMethod.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "PAYMENT METHOD:";
            // 
            // taFolio
            // 
            this.taFolio.ClearBeforeFill = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.grbPayments);
            this.panel1.Location = new System.Drawing.Point(277, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 555);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1531, 683);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaymentForm";
            this.Text = "REGAL INN MAKE PAYMENTS";
            this.Load += new System.EventHandler(this.PaymentForm_Load_1);
            this.grbPayments.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPayments;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private codeCraftersDSTableAdapters.FolioTableAdapter taFolio;
        private codeCraftersDS codeCraftersDS;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBooking;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblPhysicalAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblBookingReference;
        private System.Windows.Forms.TextBox txtPhysicalAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Panel panel1;
    }
}