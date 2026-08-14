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
            this.taFolio = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.FolioTableAdapter();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taBooking = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtBookingReference = new System.Windows.Forms.TextBox();
            this.txtNoOfNights = new System.Windows.Forms.TextBox();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtNoOfGuests = new System.Windows.Forms.TextBox();
            this.txtCategoryArea = new System.Windows.Forms.TextBox();
            this.txtRoomTable = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.numAmountPaid = new System.Windows.Forms.NumericUpDown();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.txtPaymentNotes = new System.Windows.Forms.TextBox();
            this.txtReceiptReference = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEFT = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.hotel_RoomTableAdapter1 = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.codeCraftersDSTWO = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTWO();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountPaid)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).BeginInit();
            this.SuspendLayout();
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
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txtBookingReference);
            this.panel8.Controls.Add(this.txtNoOfNights);
            this.panel8.Controls.Add(this.txtCheckOut);
            this.panel8.Controls.Add(this.txtCheckIn);
            this.panel8.Controls.Add(this.txtPhoneNo);
            this.panel8.Controls.Add(this.txtEmailAddress);
            this.panel8.Controls.Add(this.txtGuestName);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label21);
            this.panel8.ForeColor = System.Drawing.Color.Navy;
            this.panel8.Location = new System.Drawing.Point(14, 14);
            this.panel8.Margin = new System.Windows.Forms.Padding(5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1015, 176);
            this.panel8.TabIndex = 53;
            // 
            // txtBookingReference
            // 
            this.txtBookingReference.Location = new System.Drawing.Point(817, 34);
            this.txtBookingReference.Name = "txtBookingReference";
            this.txtBookingReference.ReadOnly = true;
            this.txtBookingReference.Size = new System.Drawing.Size(192, 29);
            this.txtBookingReference.TabIndex = 47;
            // 
            // txtNoOfNights
            // 
            this.txtNoOfNights.Location = new System.Drawing.Point(822, 120);
            this.txtNoOfNights.Name = "txtNoOfNights";
            this.txtNoOfNights.ReadOnly = true;
            this.txtNoOfNights.Size = new System.Drawing.Size(148, 29);
            this.txtNoOfNights.TabIndex = 46;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(680, 120);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.ReadOnly = true;
            this.txtCheckOut.Size = new System.Drawing.Size(122, 29);
            this.txtCheckOut.TabIndex = 45;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(535, 120);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ReadOnly = true;
            this.txtCheckIn.Size = new System.Drawing.Size(122, 29);
            this.txtCheckIn.TabIndex = 44;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(381, 120);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.ReadOnly = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(132, 29);
            this.txtPhoneNo.TabIndex = 43;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(199, 120);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(162, 29);
            this.txtEmailAddress.TabIndex = 42;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(32, 120);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.Size = new System.Drawing.Size(147, 29);
            this.txtGuestName.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(818, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "🌙 NO. OF NIGHTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "📅 CHECK-OUT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "📅 CHECK-IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "☎ PHONE NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "✉ EMAIL ADDRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "👤 GUEST NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "🆔 BOOKING REFERENCE";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.panel9.Location = new System.Drawing.Point(5, 71);
            this.panel9.Margin = new System.Windows.Forms.Padding(5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1004, 1);
            this.panel9.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 10);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(196, 21);
            this.label21.TabIndex = 32;
            this.label21.Text = "📋 BOOKING SUMMARY";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.txtNoOfGuests);
            this.panel1.Controls.Add(this.txtCategoryArea);
            this.panel1.Controls.Add(this.txtRoomTable);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(14, 200);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 84);
            this.panel1.TabIndex = 54;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(822, 36);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(148, 29);
            this.txtTotalPrice.TabIndex = 7;
            // 
            // txtNoOfGuests
            // 
            this.txtNoOfGuests.Location = new System.Drawing.Point(550, 36);
            this.txtNoOfGuests.Name = "txtNoOfGuests";
            this.txtNoOfGuests.ReadOnly = true;
            this.txtNoOfGuests.Size = new System.Drawing.Size(121, 29);
            this.txtNoOfGuests.TabIndex = 6;
            // 
            // txtCategoryArea
            // 
            this.txtCategoryArea.Location = new System.Drawing.Point(271, 36);
            this.txtCategoryArea.Name = "txtCategoryArea";
            this.txtCategoryArea.ReadOnly = true;
            this.txtCategoryArea.Size = new System.Drawing.Size(143, 29);
            this.txtCategoryArea.TabIndex = 5;
            // 
            // txtRoomTable
            // 
            this.txtRoomTable.Location = new System.Drawing.Point(32, 36);
            this.txtRoomTable.Name = "txtRoomTable";
            this.txtRoomTable.ReadOnly = true;
            this.txtRoomTable.Size = new System.Drawing.Size(108, 29);
            this.txtRoomTable.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(818, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "💰 TOTAL PRICE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(546, 11);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(152, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "👥 NO. OF GUESTS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "🏷 CATEGORY / AREA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "🛏 ROOM / TABLE";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpPaymentDate);
            this.panel2.Controls.Add(this.txtTotalAmount);
            this.panel2.Controls.Add(this.numAmountPaid);
            this.panel2.Controls.Add(this.txtBalanceDue);
            this.panel2.Controls.Add(this.txtPaymentNotes);
            this.panel2.Controls.Add(this.txtReceiptReference);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnEFT);
            this.panel2.Controls.Add(this.btnCard);
            this.panel2.Controls.Add(this.btnCash);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(14, 294);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 375);
            this.panel2.TabIndex = 55;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(515, 252);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.ShowUpDown = true;
            this.dtpPaymentDate.Size = new System.Drawing.Size(455, 29);
            this.dtpPaymentDate.TabIndex = 52;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(673, 71);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(297, 29);
            this.txtTotalAmount.TabIndex = 51;
            // 
            // numAmountPaid
            // 
            this.numAmountPaid.DecimalPlaces = 2;
            this.numAmountPaid.Location = new System.Drawing.Point(674, 120);
            this.numAmountPaid.Name = "numAmountPaid";
            this.numAmountPaid.Size = new System.Drawing.Size(296, 29);
            this.numAmountPaid.TabIndex = 50;
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.Location = new System.Drawing.Point(674, 173);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(296, 29);
            this.txtBalanceDue.TabIndex = 49;
            // 
            // txtPaymentNotes
            // 
            this.txtPaymentNotes.Location = new System.Drawing.Point(32, 308);
            this.txtPaymentNotes.Multiline = true;
            this.txtPaymentNotes.Name = "txtPaymentNotes";
            this.txtPaymentNotes.Size = new System.Drawing.Size(430, 56);
            this.txtPaymentNotes.TabIndex = 47;
            // 
            // txtReceiptReference
            // 
            this.txtReceiptReference.Location = new System.Drawing.Point(32, 252);
            this.txtReceiptReference.Name = "txtReceiptReference";
            this.txtReceiptReference.Size = new System.Drawing.Size(389, 29);
            this.txtReceiptReference.TabIndex = 46;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(250, 21);
            this.label19.TabIndex = 45;
            this.label19.Text = "📝 PAYMENT NOTES (Optional)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(313, 21);
            this.label18.TabIndex = 44;
            this.label18.Text = "🧾 RECEIPT / REFERENCE NO (Optional)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(511, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 21);
            this.label17.TabIndex = 43;
            this.label17.Text = "📅 PAYMENT DATE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(511, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 21);
            this.label16.TabIndex = 42;
            this.label16.Text = "⚠ BALANCE DUE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(511, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 21);
            this.label15.TabIndex = 41;
            this.label15.Text = "💲 AMOUNT PAID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(511, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 21);
            this.label14.TabIndex = 40;
            this.label14.Text = "💵 TOTAL AMOUNT";
            // 
            // btnEFT
            // 
            this.btnEFT.Location = new System.Drawing.Point(328, 107);
            this.btnEFT.Name = "btnEFT";
            this.btnEFT.Size = new System.Drawing.Size(112, 50);
            this.btnEFT.TabIndex = 39;
            this.btnEFT.Text = "🏦 EFT";
            this.btnEFT.UseVisualStyleBackColor = true;
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(180, 107);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(113, 50);
            this.btnCard.TabIndex = 38;
            this.btnCard.Text = "💳 CARD";
            this.btnCard.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(32, 107);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(116, 50);
            this.btnCash.TabIndex = 37;
            this.btnCash.Text = "💵 CASH";
            this.btnCash.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "💳 PAYMENT METHOD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 21);
            this.label12.TabIndex = 35;
            this.label12.Text = "💳 PAYMENT DETAILS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(10, 38);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 1);
            this.panel3.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.label20);
            this.panel4.Location = new System.Drawing.Point(14, 681);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 39);
            this.panel4.TabIndex = 56;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(29, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(493, 21);
            this.label20.TabIndex = 46;
            this.label20.Text = "ℹ Please confirm payment details before processing payment.";
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Navy;
            this.btnReset.Location = new System.Drawing.Point(12, 736);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 40);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "🔄 RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Navy;
            this.btnCancel.Location = new System.Drawing.Point(554, 735);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 41);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "❌ CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.Navy;
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(767, 734);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(261, 42);
            this.btnProcessPayment.TabIndex = 59;
            this.btnProcessPayment.Text = "✔ PROCESS PAYMENT";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click_1);
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
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 801);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaymentForm";
            this.Text = "REGAL INN MAKE PAYMENTS";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountPaid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDSTWO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private codeCraftersDSTableAdapters.FolioTableAdapter taFolio;
        private codeCraftersDS codeCraftersDS;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBooking;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingReference;
        private System.Windows.Forms.TextBox txtNoOfNights;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtNoOfGuests;
        private System.Windows.Forms.TextBox txtCategoryArea;
        private System.Windows.Forms.TextBox txtRoomTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEFT;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPaymentNotes;
        private System.Windows.Forms.TextBox txtReceiptReference;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProcessPayment;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter hotel_RoomTableAdapter1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.NumericUpDown numAmountPaid;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private codeCraftersDSTWO codeCraftersDSTWO;
        private System.Windows.Forms.TextBox txtBalanceDue;
        private System.Windows.Forms.Label label16;
    }
}