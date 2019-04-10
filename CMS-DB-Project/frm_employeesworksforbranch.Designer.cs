namespace CMS_DB_Project
{
    partial class frm_employeesworksforbranch
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.BranchGroupBox = new System.Windows.Forms.GroupBox();
            this.branchDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.EmployeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.BranchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.EmployeeGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BranchGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.employeeDataGridView);
            this.EmployeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGroupBox.Location = new System.Drawing.Point(3, 230);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(651, 222);
            this.EmployeeGroupBox.TabIndex = 1;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "Employee Information";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.AllowUserToOrderColumns = true;
            this.employeeDataGridView.AllowUserToResizeColumns = false;
            this.employeeDataGridView.AllowUserToResizeRows = false;
            this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGridView.Location = new System.Drawing.Point(3, 16);
            this.employeeDataGridView.MultiSelect = false;
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersVisible = false;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(645, 203);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // BranchGroupBox
            // 
            this.BranchGroupBox.Controls.Add(this.branchDataGridView);
            this.BranchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BranchGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BranchGroupBox.Name = "BranchGroupBox";
            this.BranchGroupBox.Size = new System.Drawing.Size(651, 221);
            this.BranchGroupBox.TabIndex = 0;
            this.BranchGroupBox.TabStop = false;
            this.BranchGroupBox.Text = "Branch Information";
            // 
            // branchDataGridView
            // 
            this.branchDataGridView.AllowUserToAddRows = false;
            this.branchDataGridView.AllowUserToDeleteRows = false;
            this.branchDataGridView.AllowUserToOrderColumns = true;
            this.branchDataGridView.AllowUserToResizeColumns = false;
            this.branchDataGridView.AllowUserToResizeRows = false;
            this.branchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.branchDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.branchDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.branchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.branchDataGridView.Location = new System.Drawing.Point(3, 16);
            this.branchDataGridView.MultiSelect = false;
            this.branchDataGridView.Name = "branchDataGridView";
            this.branchDataGridView.ReadOnly = true;
            this.branchDataGridView.RowHeadersVisible = false;
            this.branchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.branchDataGridView.Size = new System.Drawing.Size(645, 202);
            this.branchDataGridView.TabIndex = 0;
            // 
            // frm_employeesworksforbranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_employeesworksforbranch";
            this.Text = "Employess works for Branch";
            this.Load += new System.EventHandler(this.frm_employeesworksforbranch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EmployeeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.BranchGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.GroupBox BranchGroupBox;
        private System.Windows.Forms.DataGridView branchDataGridView;
        private System.Windows.Forms.DataGridView employeeDataGridView;
    }
}