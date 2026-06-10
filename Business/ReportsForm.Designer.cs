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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnRevenueReport = new System.Windows.Forms.Button();
            this.btnRoomReport = new System.Windows.Forms.Button();
            this.dgvReportSummary = new System.Windows.Forms.DataGridView();
            this.txtTotalEnterpriseRevenue = new System.Windows.Forms.TextBox();
            this.taBookingReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.taClientReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
            this.taFolioReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.FolioTableAdapter();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewerRegalInn = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.taRoomAssignmentReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Room_AssignmentTableAdapter();
            this.taHotelRoomReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.taBranchReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(211, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REGAL INN BUSINESS INTELLIGENCE REPORTS";
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
            // btnRevenueReport
            // 
            this.btnRevenueReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenueReport.Location = new System.Drawing.Point(216, 46);
            this.btnRevenueReport.Name = "btnRevenueReport";
            this.btnRevenueReport.Size = new System.Drawing.Size(180, 36);
            this.btnRevenueReport.TabIndex = 2;
            this.btnRevenueReport.Text = "REVENUE REPORT";
            this.btnRevenueReport.UseVisualStyleBackColor = true;
            this.btnRevenueReport.Click += new System.EventHandler(this.btnRevenueReport_Click);
            // 
            // btnRoomReport
            // 
            this.btnRoomReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomReport.Location = new System.Drawing.Point(426, 46);
            this.btnRoomReport.Name = "btnRoomReport";
            this.btnRoomReport.Size = new System.Drawing.Size(172, 36);
            this.btnRoomReport.TabIndex = 3;
            this.btnRoomReport.Text = "ROOM OCCUPANCY REPORT";
            this.btnRoomReport.UseVisualStyleBackColor = true;
            this.btnRoomReport.Click += new System.EventHandler(this.btnRoomReport_Click);
            // 
            // dgvReportSummary
            // 
            this.dgvReportSummary.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvReportSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportSummary.Location = new System.Drawing.Point(56, 94);
            this.dgvReportSummary.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtTotalEnterpriseRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalEnterpriseRevenue.Name = "txtTotalEnterpriseRevenue";
            this.txtTotalEnterpriseRevenue.ReadOnly = true;
            this.txtTotalEnterpriseRevenue.Size = new System.Drawing.Size(134, 20);
            this.txtTotalEnterpriseRevenue.TabIndex = 3;
            // 
            // taBookingReport
            // 
            this.taBookingReport.ClearBeforeFill = true;
            // 
            // taClientReport
            // 
            this.taClientReport.ClearBeforeFill = true;
            // 
            // taFolioReport
            // 
            this.taFolioReport.ClearBeforeFill = true;
            // 
            // codeCraftersDS
            // 
            this.codeCraftersDS.DataSetName = "codeCraftersDS";
            this.codeCraftersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlTop
            // 
            this.pnlTop.AutoScroll = true;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnRoomReport);
            this.pnlTop.Controls.Add(this.btnRevenueReport);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(986, 90);
            this.pnlTop.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Generate_Reports;
            this.pictureBox1.Location = new System.Drawing.Point(635, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(216, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 3);
            this.panel1.TabIndex = 4;
            // 
            // crystalReportViewerRegalInn
            // 
            this.crystalReportViewerRegalInn.ActiveViewIndex = -1;
            this.crystalReportViewerRegalInn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerRegalInn.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerRegalInn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerRegalInn.Location = new System.Drawing.Point(0, 90);
            this.crystalReportViewerRegalInn.Name = "crystalReportViewerRegalInn";
            this.crystalReportViewerRegalInn.Size = new System.Drawing.Size(986, 430);
            this.crystalReportViewerRegalInn.TabIndex = 4;
            // 
            // taRoomAssignmentReport
            // 
            this.taRoomAssignmentReport.ClearBeforeFill = true;
            // 
            // taHotelRoomReport
            // 
            this.taHotelRoomReport.ClearBeforeFill = true;
            // 
            // taBranchReport
            // 
            this.taBranchReport.ClearBeforeFill = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(986, 520);
            this.Controls.Add(this.crystalReportViewerRegalInn);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txtTotalEnterpriseRevenue);
            this.Controls.Add(this.dgvReportSummary);
            this.Controls.Add(this.lblReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportsForm";
            this.Text = "REGAL INN REPORTS";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnRevenueReport;
        private System.Windows.Forms.Button btnRoomReport;
        private System.Windows.Forms.DataGridView dgvReportSummary;
        private System.Windows.Forms.TextBox txtTotalEnterpriseRevenue;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBookingReport;
        private codeCraftersDSTableAdapters.ClientTableAdapter taClientReport;
        private codeCraftersDSTableAdapters.FolioTableAdapter taFolioReport;
        private codeCraftersDS codeCraftersDS;
        private System.Windows.Forms.Panel pnlTop;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerRegalInn;
        private codeCraftersDSTableAdapters.Room_AssignmentTableAdapter taRoomAssignmentReport;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter taHotelRoomReport;
        private codeCraftersDSTableAdapters.BranchTableAdapter taBranchReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}