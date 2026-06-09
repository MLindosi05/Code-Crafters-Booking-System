namespace Code_Crafters_Interface_Prototype_1.Business
{
    partial class ReportsForm
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
            this.lblReport = new System.Windows.Forms.Label();
            this.dgvReportSummary = new System.Windows.Forms.DataGridView();
            this.txtTotalEnterpriseRevenue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(205, 57);
            this.lblReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(470, 26);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "Regal Inn Management Insights Dashboard";
            // 
            // dgvReportSummary
            // 
            this.dgvReportSummary.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvReportSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportSummary.Location = new System.Drawing.Point(56, 94);
            this.dgvReportSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReportSummary.Name = "dgvReportSummary";
            this.dgvReportSummary.RowHeadersWidth = 51;
            this.dgvReportSummary.RowTemplate.Height = 24;
            this.dgvReportSummary.Size = new System.Drawing.Size(776, 181);
            this.dgvReportSummary.TabIndex = 1;
            // 
            // txtTotalEnterpriseRevenue
            // 
            this.txtTotalEnterpriseRevenue.BackColor = System.Drawing.Color.Gray;
            this.txtTotalEnterpriseRevenue.Location = new System.Drawing.Point(56, 291);
            this.txtTotalEnterpriseRevenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalEnterpriseRevenue.Name = "txtTotalEnterpriseRevenue";
            this.txtTotalEnterpriseRevenue.ReadOnly = true;
            this.txtTotalEnterpriseRevenue.Size = new System.Drawing.Size(134, 20);
            this.txtTotalEnterpriseRevenue.TabIndex = 3;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(863, 459);
            this.Controls.Add(this.txtTotalEnterpriseRevenue);
            this.Controls.Add(this.dgvReportSummary);
            this.Controls.Add(this.lblReport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.DataGridView dgvReportSummary;
        private System.Windows.Forms.TextBox txtTotalEnterpriseRevenue;
    }
}