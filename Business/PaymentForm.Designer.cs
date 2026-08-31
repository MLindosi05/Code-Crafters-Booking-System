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
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.hotel_RoomTableAdapter1 = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.codeCraftersDSTWO = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWO();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radPayPal = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radCard = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.taFolio = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.FolioTableAdapter();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).BeginInit();
            this.paymentPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
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
            // hotel_RoomTableAdapter1
            // 
            this.hotel_RoomTableAdapter1.ClearBeforeFill = true;
            // 
            // codeCraftersDSTWO
            // 
            this.codeCraftersDSTWO.DataSetName = "codeCraftersDSTWO";
            this.codeCraftersDSTWO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentPanel
            // 
            this.paymentPanel.Controls.Add(this.label1);
            this.paymentPanel.Controls.Add(this.panel5);
            this.paymentPanel.Controls.Add(this.panel3);
            this.paymentPanel.Controls.Add(this.panel2);
            this.paymentPanel.Location = new System.Drawing.Point(152, 125);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(963, 369);
            this.paymentPanel.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECT PAYMENT METHOD";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.radPayPal);
            this.panel5.Location = new System.Drawing.Point(633, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 174);
            this.panel5.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Paypal2;
            this.pictureBox3.Location = new System.Drawing.Point(66, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pay using your PayPal account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "PAYPAL";
            // 
            // radPayPal
            // 
            this.radPayPal.AutoSize = true;
            this.radPayPal.Location = new System.Drawing.Point(27, 21);
            this.radPayPal.Name = "radPayPal";
            this.radPayPal.Size = new System.Drawing.Size(14, 13);
            this.radPayPal.TabIndex = 1;
            this.radPayPal.TabStop = true;
            this.radPayPal.UseVisualStyleBackColor = true;
            this.radPayPal.Click += new System.EventHandler(this.radPayPal_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radCard);
            this.panel3.Location = new System.Drawing.Point(325, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 174);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.debitcredit1;
            this.pictureBox2.Location = new System.Drawing.Point(61, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pay securely using your card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "DEBIT/CREDIT CARD";
            // 
            // radCard
            // 
            this.radCard.AutoSize = true;
            this.radCard.Location = new System.Drawing.Point(19, 21);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(14, 13);
            this.radCard.TabIndex = 1;
            this.radCard.TabStop = true;
            this.radCard.UseVisualStyleBackColor = true;
            this.radCard.Click += new System.EventHandler(this.radCard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radCash);
            this.panel2.Location = new System.Drawing.Point(45, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 174);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Cash1;
            this.pictureBox1.Location = new System.Drawing.Point(63, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pay with cash at the hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CASH";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(20, 21);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(14, 13);
            this.radCash.TabIndex = 0;
            this.radCash.TabStop = true;
            this.radCash.UseVisualStyleBackColor = true;
            this.radCash.CheckedChanged += new System.EventHandler(this.radCash_CheckedChanged);
            this.radCash.Click += new System.EventHandler(this.radCash_Click);
            // 
            // taFolio
            // 
            this.taFolio.ClearBeforeFill = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Controls.Add(this.label18);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1203, 74);
            this.panel12.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(516, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(303, 31);
            this.label18.TabIndex = 2;
            this.label18.Text = "PAYMENT METHODS";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1203, 531);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.paymentPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaymentForm";
            this.Text = "REGAL INN MAKE PAYMENTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).EndInit();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private codeCraftersDS codeCraftersDS;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBooking;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter hotel_RoomTableAdapter1;
        private codeCraftersDSTWO codeCraftersDSTWO;
        private System.Windows.Forms.Panel paymentPanel;
        private System.Windows.Forms.Label label1;
        private codeCraftersDSTWOTableAdapters.FolioTableAdapter taFolio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radPayPal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radCard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label18;
    }
}