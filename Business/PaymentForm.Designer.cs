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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPaymentMethods = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPayPrice = new System.Windows.Forms.Label();
            this.txtPayPrice = new System.Windows.Forms.TextBox();
            this.txtPayBookingID = new System.Windows.Forms.TextBox();
            this.taFolio = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.FolioTableAdapter();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.lblPayBookingID = new System.Windows.Forms.Label();
            this.grbPayments.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPayments
            // 
            this.grbPayments.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.grbPayments.Controls.Add(this.button1);
            this.grbPayments.Controls.Add(this.button2);
            this.grbPayments.Controls.Add(this.groupBox4);
            this.grbPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPayments.Location = new System.Drawing.Point(39, 39);
            this.grbPayments.Margin = new System.Windows.Forms.Padding(2);
            this.grbPayments.Name = "grbPayments";
            this.grbPayments.Padding = new System.Windows.Forms.Padding(2);
            this.grbPayments.Size = new System.Drawing.Size(775, 528);
            this.grbPayments.TabIndex = 0;
            this.grbPayments.TabStop = false;
            this.grbPayments.Text = "Make Payment";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(652, 447);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(396, 447);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbPaymentMethods);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblPayPrice);
            this.groupBox4.Controls.Add(this.lblPayBookingID);
            this.groupBox4.Controls.Add(this.txtPayPrice);
            this.groupBox4.Controls.Add(this.txtPayBookingID);
            this.groupBox4.Location = new System.Drawing.Point(29, 41);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(314, 441);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Payment Method:";
            // 
            // cmbPaymentMethods
            // 
            this.cmbPaymentMethods.FormattingEnabled = true;
            this.cmbPaymentMethods.Items.AddRange(new object[] {
            "CASH",
            "CARD"});
            this.cmbPaymentMethods.Location = new System.Drawing.Point(173, 145);
            this.cmbPaymentMethods.Name = "cmbPaymentMethods";
            this.cmbPaymentMethods.Size = new System.Drawing.Size(121, 25);
            this.cmbPaymentMethods.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 9;
            // 
            // lblPayPrice
            // 
            this.lblPayPrice.AutoSize = true;
            this.lblPayPrice.Location = new System.Drawing.Point(26, 95);
            this.lblPayPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayPrice.Name = "lblPayPrice";
            this.lblPayPrice.Size = new System.Drawing.Size(100, 18);
            this.lblPayPrice.TabIndex = 7;
            this.lblPayPrice.Text = "Total Price: ";
            // 
            // txtPayPrice
            // 
            this.txtPayPrice.Location = new System.Drawing.Point(173, 93);
            this.txtPayPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayPrice.Name = "txtPayPrice";
            this.txtPayPrice.Size = new System.Drawing.Size(122, 24);
            this.txtPayPrice.TabIndex = 1;
            // 
            // txtPayBookingID
            // 
            this.txtPayBookingID.Location = new System.Drawing.Point(173, 47);
            this.txtPayBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayBookingID.Name = "txtPayBookingID";
            this.txtPayBookingID.Size = new System.Drawing.Size(122, 24);
            this.txtPayBookingID.TabIndex = 0;
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
            // lblPayBookingID
            // 
            this.lblPayBookingID.AutoSize = true;
            this.lblPayBookingID.Location = new System.Drawing.Point(26, 50);
            this.lblPayBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayBookingID.Name = "lblPayBookingID";
            this.lblPayBookingID.Size = new System.Drawing.Size(96, 18);
            this.lblPayBookingID.TabIndex = 6;
            this.lblPayBookingID.Text = "Booking ID:";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1147, 630);
            this.Controls.Add(this.grbPayments);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaymentForm";
            this.Text = "REGAL INN MAKE PAYMENTS";
            this.grbPayments.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPayments;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPayPrice;
        private System.Windows.Forms.TextBox txtPayBookingID;
        private System.Windows.Forms.Label lblPayPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPaymentMethods;
        private codeCraftersDSTableAdapters.FolioTableAdapter taFolio;
        private codeCraftersDS codeCraftersDS;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBooking;
        private System.Windows.Forms.Label lblPayBookingID;
    }
}