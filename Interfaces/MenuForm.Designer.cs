namespace Code_Crafters_Interface_Prototype_1
{
    partial class MainMenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTextBox1,
            this.signUpToolStripMenuItem,
            this.LoginToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.msTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1118, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsTextBox1
            // 
            this.tsTextBox1.AutoSize = false;
            this.tsTextBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsTextBox1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.pngtree_house_with_no_background_png_image_9197435;
            this.tsTextBox1.Name = "tsTextBox1";
            this.tsTextBox1.Size = new System.Drawing.Size(122, 24);
            this.tsTextBox1.Text = "Regal Inn Hotel";
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.AutoSize = false;
            this.signUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpToolStripMenuItem1});
            this.signUpToolStripMenuItem.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources._6478_200;
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.signUpToolStripMenuItem.Text = "Sign Up";
            // 
            // signUpToolStripMenuItem1
            // 
            this.signUpToolStripMenuItem1.Name = "signUpToolStripMenuItem1";
            this.signUpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.signUpToolStripMenuItem1.Text = "Sign up ";
            this.signUpToolStripMenuItem1.Click += new System.EventHandler(this.signUpToolStripMenuItem1_Click);
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1});
            this.LoginToolStripMenuItem.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.black_login_icon__0;
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.LoginToolStripMenuItem.Text = "Login";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem1.Text = "Login";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBookingToolStripMenuItem,
            this.viewBookingsToolStripMenuItem});
            this.bookingToolStripMenuItem.Enabled = false;
            this.bookingToolStripMenuItem.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources._1131224_200;
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // makeBookingToolStripMenuItem
            // 
            this.makeBookingToolStripMenuItem.Name = "makeBookingToolStripMenuItem";
            this.makeBookingToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.makeBookingToolStripMenuItem.Text = "New Booking";
            this.makeBookingToolStripMenuItem.Click += new System.EventHandler(this.makeBookingToolStripMenuItem_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.viewBookingsToolStripMenuItem.Text = "View Bookings";
            this.viewBookingsToolStripMenuItem.Click += new System.EventHandler(this.viewBookingsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.logout_11551049168o9cg0mxxib;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.Generate_Reports_png;
            this.reportsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateReportsToolStripMenuItem.Text = "Generate Reports";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.exit_icon_2;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.toolStripMenuItem1.Text = "EXIT";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // msTextBox
            // 
            this.msTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.msTextBox.ForeColor = System.Drawing.Color.Red;
            this.msTextBox.Name = "msTextBox";
            this.msTextBox.Size = new System.Drawing.Size(151, 24);
            this.msTextBox.Text = "LOGGED OUT";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 566);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1118, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.Color.LightSlateGray;
            this.PB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB1.Image = global::Code_Crafters_Interface_Prototype_1.Properties.Resources.lv_0_202604131858311;
            this.PB1.Location = new System.Drawing.Point(0, 28);
            this.PB1.Margin = new System.Windows.Forms.Padding(2);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(1118, 538);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 3;
            this.PB1.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainMenuForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox msTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}