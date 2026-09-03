namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    partial class HelpForm
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
            this.btnContactSupport = new System.Windows.Forms.Button();
            this.lstHelpTopics = new System.Windows.Forms.ListBox();
            this.txtSearchHelp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContactSupport
            // 
            this.btnContactSupport.Location = new System.Drawing.Point(332, 481);
            this.btnContactSupport.Margin = new System.Windows.Forms.Padding(2);
            this.btnContactSupport.Name = "btnContactSupport";
            this.btnContactSupport.Size = new System.Drawing.Size(280, 27);
            this.btnContactSupport.TabIndex = 3;
            this.btnContactSupport.Text = "Chat with Support";
            this.btnContactSupport.UseVisualStyleBackColor = true;
            this.btnContactSupport.Click += new System.EventHandler(this.btnContactSupport_Click);
            // 
            // lstHelpTopics
            // 
            this.lstHelpTopics.FormattingEnabled = true;
            this.lstHelpTopics.ItemHeight = 18;
            this.lstHelpTopics.Location = new System.Drawing.Point(49, 121);
            this.lstHelpTopics.Margin = new System.Windows.Forms.Padding(2);
            this.lstHelpTopics.Name = "lstHelpTopics";
            this.lstHelpTopics.Size = new System.Drawing.Size(563, 328);
            this.lstHelpTopics.TabIndex = 2;
            this.lstHelpTopics.SelectedIndexChanged += new System.EventHandler(this.lstHelpTopics_SelectedIndexChanged);
            // 
            // txtSearchHelp
            // 
            this.txtSearchHelp.Location = new System.Drawing.Point(49, 70);
            this.txtSearchHelp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchHelp.Name = "txtSearchHelp";
            this.txtSearchHelp.Size = new System.Drawing.Size(500, 24);
            this.txtSearchHelp.TabIndex = 1;
            this.txtSearchHelp.TextChanged += new System.EventHandler(this.txtSearchHelp_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1580, 862);
            this.panel1.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 802);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1580, 60);
            this.panel5.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1580, 99);
            this.panel4.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Gemini_Generated_Image_ts86ldts86ldts86;
            this.pictureBox3.Location = new System.Drawing.Point(899, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(229, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lstHelpTopics);
            this.panel2.Controls.Add(this.txtSearchHelp);
            this.panel2.Controls.Add(this.btnContactSupport);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(684, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 564);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "How can we help?";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 862);
            this.Controls.Add(this.panel1);
            this.Name = "HelpForm";
            this.Text = " REGAL INN HELP ";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnContactSupport;
        private System.Windows.Forms.ListBox lstHelpTopics;
        private System.Windows.Forms.TextBox txtSearchHelp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
    }
}