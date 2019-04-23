namespace CMS_DB_Project
{
    partial class frm_main
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
            this.volunteerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVolunteerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDisconnectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donationsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campaginReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noOfVolunteersPerCampaignReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volunteerToolStripMenuItem,
            this.donorToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.masterDetailToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.employeeReportToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(605, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Menu Strip";
            // 
            // volunteerToolStripMenuItem
            // 
            this.volunteerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVolunteerToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.searchDisconnectedToolStripMenuItem});
            this.volunteerToolStripMenuItem.Name = "volunteerToolStripMenuItem";
            this.volunteerToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.volunteerToolStripMenuItem.Text = "Volunteer";
            // 
            // manageVolunteerToolStripMenuItem
            // 
            this.manageVolunteerToolStripMenuItem.Name = "manageVolunteerToolStripMenuItem";
            this.manageVolunteerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.manageVolunteerToolStripMenuItem.Text = "Manage";
            this.manageVolunteerToolStripMenuItem.Click += new System.EventHandler(this.manageVolunteerToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.searchToolStripMenuItem.Text = "Search (Connected)";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // searchDisconnectedToolStripMenuItem
            // 
            this.searchDisconnectedToolStripMenuItem.Name = "searchDisconnectedToolStripMenuItem";
            this.searchDisconnectedToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.searchDisconnectedToolStripMenuItem.Text = "Search (Disconnected)";
            this.searchDisconnectedToolStripMenuItem.Click += new System.EventHandler(this.searchDisconnectedToolStripMenuItem_Click);
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.donorToolStripMenuItem.Text = "Donor";
            this.donorToolStripMenuItem.Click += new System.EventHandler(this.donorToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.viewAllToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.viewAllToolStripMenuItem.Text = "View All";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
            // 
            // masterDetailToolStripMenuItem
            // 
            this.masterDetailToolStripMenuItem.Name = "masterDetailToolStripMenuItem";
            this.masterDetailToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.masterDetailToolStripMenuItem.Text = "Master-Detail";
            this.masterDetailToolStripMenuItem.Click += new System.EventHandler(this.masterDetailToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donationsReportToolStripMenuItem,
            this.campaginReportToolStripMenuItem,
            this.noOfVolunteersPerCampaignReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // donationsReportToolStripMenuItem
            // 
            this.donationsReportToolStripMenuItem.Name = "donationsReportToolStripMenuItem";
            this.donationsReportToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.donationsReportToolStripMenuItem.Text = "Donations Report";
            this.donationsReportToolStripMenuItem.Click += new System.EventHandler(this.donationsReportToolStripMenuItem_Click);
            // 
            // campaginReportToolStripMenuItem
            // 
            this.campaginReportToolStripMenuItem.Name = "campaginReportToolStripMenuItem";
            this.campaginReportToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.campaginReportToolStripMenuItem.Text = "Volunteers per Campagin Report";
            this.campaginReportToolStripMenuItem.Click += new System.EventHandler(this.campaginReportToolStripMenuItem_Click);
            // 
            // employeeReportToolStripMenuItem1
            // 
            this.employeeReportToolStripMenuItem1.Name = "employeeReportToolStripMenuItem1";
            this.employeeReportToolStripMenuItem1.Size = new System.Drawing.Size(111, 20);
            this.employeeReportToolStripMenuItem1.Text = "Employee Branch";
            this.employeeReportToolStripMenuItem1.Click += new System.EventHandler(this.employeeReportToolStripMenuItem1_Click);
            // 
            // noOfVolunteersPerCampaignReportToolStripMenuItem
            // 
            this.noOfVolunteersPerCampaignReportToolStripMenuItem.Name = "noOfVolunteersPerCampaignReportToolStripMenuItem";
            this.noOfVolunteersPerCampaignReportToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.noOfVolunteersPerCampaignReportToolStripMenuItem.Text = "No of Volunteers per Campaign Report";
            this.noOfVolunteersPerCampaignReportToolStripMenuItem.Click += new System.EventHandler(this.noOfVolunteersPerCampaignReportToolStripMenuItem_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 385);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem volunteerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVolunteerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donationsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDisconnectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campaginReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noOfVolunteersPerCampaignReportToolStripMenuItem;
    }
}