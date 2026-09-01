namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class PayPalPayment
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnPaypalRedirect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.AliceBlue;
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.btnPaypalRedirect);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.label24);
            this.panel10.Controls.Add(this.label25);
            this.panel10.Location = new System.Drawing.Point(12, 91);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(695, 208);
            this.panel10.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(252, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(188, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "Secure payment powered by PayPal";
            // 
            // btnPaypalRedirect
            // 
            this.btnPaypalRedirect.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPaypalRedirect.ForeColor = System.Drawing.Color.White;
            this.btnPaypalRedirect.Location = new System.Drawing.Point(20, 137);
            this.btnPaypalRedirect.Name = "btnPaypalRedirect";
            this.btnPaypalRedirect.Size = new System.Drawing.Size(649, 42);
            this.btnPaypalRedirect.TabIndex = 60;
            this.btnPaypalRedirect.Text = "✔ Pay with PayPal";
            this.btnPaypalRedirect.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(19, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 33);
            this.panel4.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(527, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "After successful payment, you will be directed back to our system and your bookin" +
    "g will be confirmed.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Navy;
            this.label24.Location = new System.Drawing.Point(16, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 16);
            this.label24.TabIndex = 9;
            this.label24.Text = "Pay With PayPal";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(17, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(358, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "You will be redirected to PayPal to securely complete your paymnent.";
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.Navy;
            this.btnProcessPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(556, 328);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(151, 42);
            this.btnProcessPayment.TabIndex = 62;
            this.btnProcessPayment.Text = "✔ PROCESS PAYMENT";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 41);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "❌ CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Controls.Add(this.label18);
            this.panel12.Location = new System.Drawing.Point(22, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(685, 82);
            this.panel12.TabIndex = 64;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(200, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(271, 31);
            this.label18.TabIndex = 2;
            this.label18.Text = "PAYPAL PAYMENT";
            // 
            // PayPalPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 460);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.panel10);
            this.Name = "PayPalPayment";
            this.Text = "REGAL INN PAY WITH PAYPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PayPalPayment_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnPaypalRedirect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label18;
    }
}