namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class CardPayment
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtCardholderName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.AliceBlue;
            this.panel9.Controls.Add(this.label18);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.txtCVV);
            this.panel9.Controls.Add(this.txtExpiryDate);
            this.panel9.Controls.Add(this.txtCardholderName);
            this.panel9.Controls.Add(this.txtAccountNumber);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(12, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(637, 208);
            this.panel9.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "ACCOUNT NO.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(459, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "CVV";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(459, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "EXPIRY DATE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "CARDHOLDER NAME";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(463, 157);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(85, 20);
            this.txtCVV.TabIndex = 13;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(462, 92);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(159, 20);
            this.txtExpiryDate.TabIndex = 12;
            // 
            // txtCardholderName
            // 
            this.txtCardholderName.Location = new System.Drawing.Point(20, 93);
            this.txtCardholderName.Name = "txtCardholderName";
            this.txtCardholderName.Size = new System.Drawing.Size(257, 20);
            this.txtCardholderName.TabIndex = 11;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(20, 157);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(257, 20);
            this.txtAccountNumber.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(16, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "PAY WITH DEBIT/CREDIT CARD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "All transactions are secure and encrypted.";
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.Navy;
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(498, 226);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(151, 42);
            this.btnProcessPayment.TabIndex = 61;
            this.btnProcessPayment.Text = "✔ PROCESS PAYMENT";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Navy;
            this.btnCancel.Location = new System.Drawing.Point(12, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 41);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "❌ CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.panel9);
            this.Name = "CardPayment";
            this.Text = "REGAL INN PAY WITH CARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtCardholderName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnCancel;
    }
}