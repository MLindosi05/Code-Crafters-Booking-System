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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPaymentMethods = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPayPrice = new System.Windows.Forms.Label();
            this.lblPayBookingID = new System.Windows.Forms.Label();
            this.txtPayPrice = new System.Windows.Forms.TextBox();
            this.txtPayBookingID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.taFolio = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.FolioTableAdapter();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(775, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make Payment";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(396, 327);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(396, 50);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(332, 255);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Details";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(189, 206);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 24);
            this.textBox6.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(189, 158);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(76, 24);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "CVV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expiry date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cardholder Name:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(189, 105);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 24);
            this.textBox5.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 47);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 24);
            this.textBox3.TabIndex = 1;
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
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1147, 630);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPayPrice;
        private System.Windows.Forms.TextBox txtPayBookingID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPayPrice;
        private System.Windows.Forms.Label lblPayBookingID;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPaymentMethods;
        private codeCraftersDSTableAdapters.FolioTableAdapter taFolio;
        private codeCraftersDS codeCraftersDS;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBooking;
    }
}