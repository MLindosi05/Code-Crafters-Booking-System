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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taBookingReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BookingTableAdapter();
            this.taClientReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.ClientTableAdapter();
            this.taFolioReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.FolioTableAdapter();
            this.codeCraftersDS = new Code_Crafters_Interface_Prototype_1.codeCraftersDS();
            this.taRoomAssignmentReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Room_AssignmentTableAdapter();
            this.taHotelRoomReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Hotel_RoomTableAdapter();
            this.taBranchReport = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.BranchTableAdapter();
            this.taTable = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Restuarant_TableTableAdapter();
            this.taTableAllocation = new Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters.Table_AllocationTableAdapter();
            this.wbReports = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
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
            // pnlTop
            // 
            this.pnlTop.AutoScroll = true;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1252, 90);
            this.pnlTop.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Generate_Reports;
            this.pictureBox1.Location = new System.Drawing.Point(1084, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // taTable
            // 
            this.taTable.ClearBeforeFill = true;
            // 
            // taTableAllocation
            // 
            this.taTableAllocation.ClearBeforeFill = true;
            // 
            // wbReports
            // 
            this.wbReports.AllowExternalDrop = true;
            this.wbReports.CreationProperties = null;
            this.wbReports.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbReports.Location = new System.Drawing.Point(0, 90);
            this.wbReports.Name = "wbReports";
            this.wbReports.Size = new System.Drawing.Size(1252, 577);
            this.wbReports.TabIndex = 6;
            this.wbReports.ZoomFactor = 1D;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1252, 667);
            this.Controls.Add(this.wbReports);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportsForm";
            this.Text = "REGAL INN REPORTS";
            //this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeCraftersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReport;
        private codeCraftersDSTableAdapters.BookingTableAdapter taBookingReport;
        private codeCraftersDSTableAdapters.ClientTableAdapter taClientReport;
        private codeCraftersDSTableAdapters.FolioTableAdapter taFolioReport;
        private codeCraftersDS codeCraftersDS;
        private System.Windows.Forms.Panel pnlTop;
        private codeCraftersDSTableAdapters.Room_AssignmentTableAdapter taRoomAssignmentReport;
        private codeCraftersDSTableAdapters.Hotel_RoomTableAdapter taHotelRoomReport;
        private codeCraftersDSTableAdapters.BranchTableAdapter taBranchReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private codeCraftersDSTableAdapters.Restuarant_TableTableAdapter taTable;
        private codeCraftersDSTableAdapters.Table_AllocationTableAdapter taTableAllocation;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbReports;
    }
}