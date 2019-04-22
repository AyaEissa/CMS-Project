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
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeEmployeeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volunteerToolStripMenuItem,
            this.branchToolStripMenuItem,
            this.donorToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.changeEmployeeInfoToolStripMenuItem,
            this.employeeReportToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(807, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Menu Strip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // volunteerToolStripMenuItem
            // 
            this.volunteerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVolunteerToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.volunteerToolStripMenuItem.Name = "volunteerToolStripMenuItem";
            this.volunteerToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
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
            this.branchToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.branchToolStripMenuItem.Text = "Branch";
            // 
            // employeesWorksForBranchToolStripMenuItem
            // 
            this.employeesWorksForBranchToolStripMenuItem.Name = "employeesWorksForBranchToolStripMenuItem";
            this.employeesWorksForBranchToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.employeesWorksForBranchToolStripMenuItem.Text = "Employees works for branch (Master-Detail)";
            this.employeesWorksForBranchToolStripMenuItem.Click += new System.EventHandler(this.employeesWorksForBranchToolStripMenuItem_Click);
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.donorToolStripMenuItem.Text = "Donor";
            this.donorToolStripMenuItem.Click += new System.EventHandler(this.donorToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donationsReportToolStripMenuItem,
            this.employeeReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // donationsReportToolStripMenuItem
            // 
            this.donationsReportToolStripMenuItem.Name = "donationsReportToolStripMenuItem";
            this.donationsReportToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.donationsReportToolStripMenuItem.Text = "Donations Report";
            this.donationsReportToolStripMenuItem.Click += new System.EventHandler(this.donationsReportToolStripMenuItem_Click);
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.employeeReportToolStripMenuItem.Text = "Employee_Report";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.employeeReportToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // changeEmployeeInfoToolStripMenuItem
            // 
            this.changeEmployeeInfoToolStripMenuItem.Name = "changeEmployeeInfoToolStripMenuItem";
            this.changeEmployeeInfoToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.changeEmployeeInfoToolStripMenuItem.Text = "Change Employee Info";
            this.changeEmployeeInfoToolStripMenuItem.Click += new System.EventHandler(this.changeEmployeeInfoToolStripMenuItem_Click);
            // 
            // employeeReportToolStripMenuItem1
            // 
            this.employeeReportToolStripMenuItem1.Name = "employeeReportToolStripMenuItem1";
            this.employeeReportToolStripMenuItem1.Size = new System.Drawing.Size(136, 24);
            this.employeeReportToolStripMenuItem1.Text = "Employee Branch";
            this.employeeReportToolStripMenuItem1.Click += new System.EventHandler(this.employeeReportToolStripMenuItem1_Click);
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 474);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeEmployeeInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}