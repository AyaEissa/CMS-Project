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
            this.branchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesWorksForBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donationsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volunteerToolStripMenuItem,
            this.branchToolStripMenuItem,
            this.donorToolStripMenuItem,
            this.reportsToolStripMenuItem});
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
            this.searchToolStripMenuItem});
            this.volunteerToolStripMenuItem.Name = "volunteerToolStripMenuItem";
            this.volunteerToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.volunteerToolStripMenuItem.Text = "Volunteer";
            // 
            // manageVolunteerToolStripMenuItem
            // 
            this.manageVolunteerToolStripMenuItem.Name = "manageVolunteerToolStripMenuItem";
            this.manageVolunteerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageVolunteerToolStripMenuItem.Text = "Manage";
            this.manageVolunteerToolStripMenuItem.Click += new System.EventHandler(this.manageVolunteerToolStripMenuItem_Click);
            // 
            // branchToolStripMenuItem
            // 
            this.branchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesWorksForBranchToolStripMenuItem});
            this.branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            this.branchToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.branchToolStripMenuItem.Text = "Branch";
            // 
            // employeesWorksForBranchToolStripMenuItem
            // 
            this.employeesWorksForBranchToolStripMenuItem.Name = "employeesWorksForBranchToolStripMenuItem";
            this.employeesWorksForBranchToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.employeesWorksForBranchToolStripMenuItem.Text = "Employees works for branch (Master-Detail)";
            this.employeesWorksForBranchToolStripMenuItem.Click += new System.EventHandler(this.employeesWorksForBranchToolStripMenuItem_Click);
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.donorToolStripMenuItem.Text = "Donor";
            this.donorToolStripMenuItem.Click += new System.EventHandler(this.donorToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donationsReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // donationsReportToolStripMenuItem
            // 
            this.donationsReportToolStripMenuItem.Name = "donationsReportToolStripMenuItem";
            this.donationsReportToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.donationsReportToolStripMenuItem.Text = "Donations Report";
            this.donationsReportToolStripMenuItem.Click += new System.EventHandler(this.donationsReportToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem branchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesWorksForBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donationsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}