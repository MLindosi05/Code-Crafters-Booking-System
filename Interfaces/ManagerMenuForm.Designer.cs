namespace Code_Crafters_Interface_Prototype_1.Interfaces
{
    partial class ManagerMenuForm
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
            this.msManager = new System.Windows.Forms.MenuStrip();
            this.regalinnhotelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWREPORTSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGGEDINASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.msManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // msManager
            // 
            this.msManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regalinnhotelsToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.lOGGEDINASToolStripMenuItem});
            this.msManager.Location = new System.Drawing.Point(0, 0);
            this.msManager.Name = "msManager";
            this.msManager.Size = new System.Drawing.Size(1070, 24);
            this.msManager.TabIndex = 0;
            this.msManager.Text = "menuStrip1";
            // 
            // regalinnhotelsToolStripMenuItem
            // 
            this.regalinnhotelsToolStripMenuItem.BackgroundImage = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.regal_inn_hotels;
            this.regalinnhotelsToolStripMenuItem.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.pngtree_house_with_no_background_png_image_9197435;
            this.regalinnhotelsToolStripMenuItem.Name = "regalinnhotelsToolStripMenuItem";
            this.regalinnhotelsToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.regalinnhotelsToolStripMenuItem.Text = "REGAL INN HOTELS";
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWREPORTSToolStripMenuItem1});
            this.rEPORTSToolStripMenuItem.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Generate_Reports_png;
            this.rEPORTSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // vIEWREPORTSToolStripMenuItem1
            // 
            this.vIEWREPORTSToolStripMenuItem1.Name = "vIEWREPORTSToolStripMenuItem1";
            this.vIEWREPORTSToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.vIEWREPORTSToolStripMenuItem1.Text = "VIEW REPORTS";
            // 
            // lOGGEDINASToolStripMenuItem
            // 
            this.lOGGEDINASToolStripMenuItem.Name = "lOGGEDINASToolStripMenuItem";
            this.lOGGEDINASToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.lOGGEDINASToolStripMenuItem.Text = "LOGGED IN AS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(902, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGOUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManagerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msManager);
            this.MainMenuStrip = this.msManager;
            this.Name = "ManagerMenuForm";
            this.Text = "ManagerMenuForm";
            this.msManager.ResumeLayout(false);
            this.msManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msManager;
        private System.Windows.Forms.ToolStripMenuItem regalinnhotelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWREPORTSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lOGGEDINASToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}