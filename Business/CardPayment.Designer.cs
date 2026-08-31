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
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(39, 26);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(559, 187);
            this.panel9.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(16, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 16);
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
            this.btnProcessPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(578, 369);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(151, 42);
            this.btnProcessPayment.TabIndex = 61;
            this.btnProcessPayment.Text = "✔ PROCESS PAYMENT";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(92, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 41);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "❌ CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Controls.Add(this.label18);
            this.panel12.Location = new System.Drawing.Point(92, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(637, 82);
            this.panel12.TabIndex = 63;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(200, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(242, 31);
            this.label18.TabIndex = 2;
            this.label18.Text = "CARD PAYMENT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(92, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 244);
            this.panel1.TabIndex = 64;
            // 
            // CardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(854, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcessPayment);
            this.Name = "CardPayment";
            this.Text = "REGAL INN PAY WITH CARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CardPayment_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
    }
}