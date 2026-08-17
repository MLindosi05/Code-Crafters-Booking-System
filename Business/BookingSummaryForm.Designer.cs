namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class BookingSummaryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTableAreaValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGuestEmailValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblNumOfGuestsValue = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCheckInValue = new System.Windows.Forms.Label();
            this.lblCheckOutValue = new System.Windows.Forms.Label();
            this.lblRoomTypeValue = new System.Windows.Forms.Label();
            this.lblRoomNoValue = new System.Windows.Forms.Label();
            this.lblBookingRefValue = new System.Windows.Forms.Label();
            this.lblGuestNameValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintSummary = new System.Windows.Forms.Button();
            this.btnBackToBooking = new System.Windows.Forms.Button();
            this.btnModifyBooking = new System.Windows.Forms.Button();
            this.btnProceedToPayment = new System.Windows.Forms.Button();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.BookingTableAdapter();
            this.taClient = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.ClientTableAdapter();
            this.taRestaurantTable = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Restuarant_TableTableAdapter();
            this.taTableAllocation = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Table_AllocationTableAdapter();
            this.taHotelRoom = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters.Hotel_RoomTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPrintSummary);
            this.panel1.Controls.Add(this.btnBackToBooking);
            this.panel1.Controls.Add(this.btnModifyBooking);
            this.panel1.Controls.Add(this.btnProceedToPayment);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 546);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTableAreaValue);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblGuestEmailValue);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblTotalAmountValue);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lblNumOfGuestsValue);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblCheckInValue);
            this.panel2.Controls.Add(this.lblCheckOutValue);
            this.panel2.Controls.Add(this.lblRoomTypeValue);
            this.panel2.Controls.Add(this.lblRoomNoValue);
            this.panel2.Controls.Add(this.lblBookingRefValue);
            this.panel2.Controls.Add(this.lblGuestNameValue);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 403);
            this.panel2.TabIndex = 5;
            // 
            // lblTableAreaValue
            // 
            this.lblTableAreaValue.AutoSize = true;
            this.lblTableAreaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableAreaValue.Location = new System.Drawing.Point(522, 278);
            this.lblTableAreaValue.Name = "lblTableAreaValue";
            this.lblTableAreaValue.Size = new System.Drawing.Size(90, 16);
            this.lblTableAreaValue.TabIndex = 46;
            this.lblTableAreaValue.Text = "TABLE AREA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "TABLE AREA";
            // 
            // lblGuestEmailValue
            // 
            this.lblGuestEmailValue.AutoSize = true;
            this.lblGuestEmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestEmailValue.Location = new System.Drawing.Point(521, 113);
            this.lblGuestEmailValue.Name = "lblGuestEmailValue";
            this.lblGuestEmailValue.Size = new System.Drawing.Size(165, 16);
            this.lblGuestEmailValue.TabIndex = 23;
            this.lblGuestEmailValue.Text = "GUEST EMAIL ADDRESS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "GUEST EMAIL ADDRESS";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(522, 350);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(52, 18);
            this.lblTotalAmountValue.TabIndex = 21;
            this.lblTotalAmountValue.Text = "R0.00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(450, 471);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 18);
            this.label21.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(37, 350);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 18);
            this.label20.TabIndex = 19;
            this.label20.Text = "TOTAL AMOUNT";
            // 
            // lblNumOfGuestsValue
            // 
            this.lblNumOfGuestsValue.AutoSize = true;
            this.lblNumOfGuestsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfGuestsValue.Location = new System.Drawing.Point(521, 249);
            this.lblNumOfGuestsValue.Name = "lblNumOfGuestsValue";
            this.lblNumOfGuestsValue.Size = new System.Drawing.Size(110, 16);
            this.lblNumOfGuestsValue.TabIndex = 15;
            this.lblNumOfGuestsValue.Text = "NO. OF GUESTS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "CHECK - OUT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "NO. OF GUESTS";
            // 
            // lblCheckInValue
            // 
            this.lblCheckInValue.AutoSize = true;
            this.lblCheckInValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInValue.Location = new System.Drawing.Point(521, 192);
            this.lblCheckInValue.Name = "lblCheckInValue";
            this.lblCheckInValue.Size = new System.Drawing.Size(78, 16);
            this.lblCheckInValue.TabIndex = 10;
            this.lblCheckInValue.Text = "CHECK - IN ";
            // 
            // lblCheckOutValue
            // 
            this.lblCheckOutValue.AutoSize = true;
            this.lblCheckOutValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutValue.Location = new System.Drawing.Point(521, 220);
            this.lblCheckOutValue.Name = "lblCheckOutValue";
            this.lblCheckOutValue.Size = new System.Drawing.Size(91, 16);
            this.lblCheckOutValue.TabIndex = 9;
            this.lblCheckOutValue.Text = "CHECK - OUT";
            // 
            // lblRoomTypeValue
            // 
            this.lblRoomTypeValue.AutoSize = true;
            this.lblRoomTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomTypeValue.Location = new System.Drawing.Point(521, 142);
            this.lblRoomTypeValue.Name = "lblRoomTypeValue";
            this.lblRoomTypeValue.Size = new System.Drawing.Size(87, 16);
            this.lblRoomTypeValue.TabIndex = 8;
            this.lblRoomTypeValue.Text = "ROOM TYPE";
            // 
            // lblRoomNoValue
            // 
            this.lblRoomNoValue.AutoSize = true;
            this.lblRoomNoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNoValue.Location = new System.Drawing.Point(521, 167);
            this.lblRoomNoValue.Name = "lblRoomNoValue";
            this.lblRoomNoValue.Size = new System.Drawing.Size(74, 16);
            this.lblRoomNoValue.TabIndex = 7;
            this.lblRoomNoValue.Text = "ROOM NO.";
            // 
            // lblBookingRefValue
            // 
            this.lblBookingRefValue.AutoSize = true;
            this.lblBookingRefValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingRefValue.Location = new System.Drawing.Point(521, 45);
            this.lblBookingRefValue.Name = "lblBookingRefValue";
            this.lblBookingRefValue.Size = new System.Drawing.Size(34, 16);
            this.lblBookingRefValue.TabIndex = 6;
            this.lblBookingRefValue.Text = "BKR";
            // 
            // lblGuestNameValue
            // 
            this.lblGuestNameValue.AutoSize = true;
            this.lblGuestNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestNameValue.Location = new System.Drawing.Point(521, 85);
            this.lblGuestNameValue.Name = "lblGuestNameValue";
            this.lblGuestNameValue.Size = new System.Drawing.Size(96, 16);
            this.lblGuestNameValue.TabIndex = 5;
            this.lblGuestNameValue.Text = "GUEST NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "GUEST NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "ROOM TYPE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "ROOM NO.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "CHECK - IN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "BOOKING REFERENCE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "BOOKING SUMMARY";
            // 
            // btnPrintSummary
            // 
            this.btnPrintSummary.Location = new System.Drawing.Point(633, 21);
            this.btnPrintSummary.Name = "btnPrintSummary";
            this.btnPrintSummary.Size = new System.Drawing.Size(164, 31);
            this.btnPrintSummary.TabIndex = 3;
            this.btnPrintSummary.Text = "PRINT SUMMARY";
            this.btnPrintSummary.UseVisualStyleBackColor = true;
            this.btnPrintSummary.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBackToBooking
            // 
            this.btnBackToBooking.Location = new System.Drawing.Point(27, 473);
            this.btnBackToBooking.Name = "btnBackToBooking";
            this.btnBackToBooking.Size = new System.Drawing.Size(152, 31);
            this.btnBackToBooking.TabIndex = 2;
            this.btnBackToBooking.Text = "BACK TO BOOKING";
            this.btnBackToBooking.UseVisualStyleBackColor = true;
            this.btnBackToBooking.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnModifyBooking
            // 
            this.btnModifyBooking.Location = new System.Drawing.Point(314, 473);
            this.btnModifyBooking.Name = "btnModifyBooking";
            this.btnModifyBooking.Size = new System.Drawing.Size(164, 31);
            this.btnModifyBooking.TabIndex = 1;
            this.btnModifyBooking.Text = "MODIFY BOOKING";
            this.btnModifyBooking.UseVisualStyleBackColor = true;
            this.btnModifyBooking.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProceedToPayment
            // 
            this.btnProceedToPayment.BackColor = System.Drawing.Color.Navy;
            this.btnProceedToPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProceedToPayment.Location = new System.Drawing.Point(633, 473);
            this.btnProceedToPayment.Name = "btnProceedToPayment";
            this.btnProceedToPayment.Size = new System.Drawing.Size(164, 31);
            this.btnProceedToPayment.TabIndex = 0;
            this.btnProceedToPayment.Text = "PROCEEED TO PAYMENT";
            this.btnProceedToPayment.UseVisualStyleBackColor = false;
            this.btnProceedToPayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // taClient
            // 
            this.taClient.ClearBeforeFill = true;
            // 
            // taRestaurantTable
            // 
            this.taRestaurantTable.ClearBeforeFill = true;
            // 
            // taTableAllocation
            // 
            this.taTableAllocation.ClearBeforeFill = true;
            // 
            // taHotelRoom
            // 
            this.taHotelRoom.ClearBeforeFill = true;
            // 
            // BookingSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 616);
            this.Controls.Add(this.panel1);
            this.Name = "BookingSummaryForm";
            this.Text = "REGAL INN BOOKING SUMMARY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookingSummaryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrintSummary;
        private System.Windows.Forms.Button btnBackToBooking;
        private System.Windows.Forms.Button btnModifyBooking;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCheckInValue;
        private System.Windows.Forms.Label lblCheckOutValue;
        private System.Windows.Forms.Label lblRoomTypeValue;
        private System.Windows.Forms.Label lblRoomNoValue;
        private System.Windows.Forms.Label lblBookingRefValue;
        private System.Windows.Forms.Label lblGuestNameValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblNumOfGuestsValue;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnProceedToPayment;
        private codeCraftersDSTWOTableAdapters.BookingTableAdapter taBooking;
        private System.Windows.Forms.Label lblGuestEmailValue;
        private System.Windows.Forms.Label label7;
        private codeCraftersDSTWOTableAdapters.ClientTableAdapter taClient;
        private System.Windows.Forms.Label lblTableAreaValue;
        private System.Windows.Forms.Label label9;
        private codeCraftersDSTWOTableAdapters.Restuarant_TableTableAdapter taRestaurantTable;
        private codeCraftersDSTWOTableAdapters.Table_AllocationTableAdapter taTableAllocation;
        private codeCraftersDSTWOTableAdapters.Hotel_RoomTableAdapter taHotelRoom;
    }
}