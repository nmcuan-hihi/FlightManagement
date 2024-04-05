namespace VnAirLines
{
    partial class MainFrm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.searchForLightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amenitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amenitiesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForLightsToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.amenitiesToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(800, 42);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // searchForLightsToolStripMenuItem
            // 
            this.searchForLightsToolStripMenuItem.Name = "searchForLightsToolStripMenuItem";
            this.searchForLightsToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.searchForLightsToolStripMenuItem.Text = "Search For Lights";
            this.searchForLightsToolStripMenuItem.Click += new System.EventHandler(this.searchForLightsToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(122, 38);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // amenitiesToolStripMenuItem
            // 
            this.amenitiesToolStripMenuItem.Name = "amenitiesToolStripMenuItem";
            this.amenitiesToolStripMenuItem.Size = new System.Drawing.Size(140, 38);
            this.amenitiesToolStripMenuItem.Text = "Amenities";
            this.amenitiesToolStripMenuItem.Click += new System.EventHandler(this.amenitiesToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingReportToolStripMenuItem,
            this.amenitiesReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(104, 38);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // bookingReportToolStripMenuItem
            // 
            this.bookingReportToolStripMenuItem.Name = "bookingReportToolStripMenuItem";
            this.bookingReportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.bookingReportToolStripMenuItem.Text = "Booking Report";
            this.bookingReportToolStripMenuItem.Click += new System.EventHandler(this.bookingReportToolStripMenuItem_Click);
            // 
            // amenitiesReportToolStripMenuItem
            // 
            this.amenitiesReportToolStripMenuItem.Name = "amenitiesReportToolStripMenuItem";
            this.amenitiesReportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.amenitiesReportToolStripMenuItem.Text = "Amenities Report";
            this.amenitiesReportToolStripMenuItem.Click += new System.EventHandler(this.amenitiesReportToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainFrm";
            this.Text = "Vn Air Lines";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchForLightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amenitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amenitiesReportToolStripMenuItem;
    }
}

