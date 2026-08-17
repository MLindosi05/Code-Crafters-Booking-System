namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class CashPayment
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(690, 136);
            this.panel6.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(16, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "PAY WITH CASH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Please pay the total amount at the hotel reception.";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(20, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(656, 36);
            this.panel7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(355, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Your booking will be confirmed once payment is received";
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.Navy;
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(552, 154);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(151, 42);
            this.btnProcessPayment.TabIndex = 60;
            this.btnProcessPayment.Text = "✔ PROCESS PAYMENT";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Navy;
            this.btnCancel.Location = new System.Drawing.Point(12, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 41);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "❌ CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 213);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.panel6);
            this.Name = "CashPayment";
            this.Text = "REGAL INN PAY WITH CASH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnCancel;
    }
}