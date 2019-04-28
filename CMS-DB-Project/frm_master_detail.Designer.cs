namespace CMS_DB_Project
{
    partial class frm_master_detail
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
            this.cmb_tables = new System.Windows.Forms.ComboBox();
            this.grp_type = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.branchDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_type.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmb_tables, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grp_type, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmb_tables
            // 
            this.cmb_tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_tables.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tables.FormattingEnabled = true;
            this.cmb_tables.Items.AddRange(new object[] {
            "Branch & Employee",
            "Branch & Mobile Phones",
            "Branch & Campaign",
            "Campaign & Activity"});
            this.cmb_tables.Location = new System.Drawing.Point(4, 4);
            this.cmb_tables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_tables.Name = "cmb_tables";
            this.cmb_tables.Size = new System.Drawing.Size(868, 27);
            this.cmb_tables.TabIndex = 1;
            this.cmb_tables.SelectedIndexChanged += new System.EventHandler(this.cmb_tables_SelectedIndexChanged);
            // 
            // grp_type
            // 
            this.grp_type.Controls.Add(this.tableLayoutPanel2);
            this.grp_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_type.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_type.Location = new System.Drawing.Point(4, 41);
            this.grp_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_type.Name = "grp_type";
            this.grp_type.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_type.Size = new System.Drawing.Size(868, 515);
            this.grp_type.TabIndex = 2;
            this.grp_type.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.branchDataGridView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.employeeDataGridView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(860, 484);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.branchDataGridView.Location = new System.Drawing.Point(4, 4);
            this.branchDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.branchDataGridView.MultiSelect = false;
            this.branchDataGridView.Name = "branchDataGridView";
            this.branchDataGridView.ReadOnly = true;
            this.branchDataGridView.RowHeadersVisible = false;
            this.branchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.branchDataGridView.Size = new System.Drawing.Size(852, 234);
            this.branchDataGridView.TabIndex = 0;
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
            this.employeeDataGridView.Location = new System.Drawing.Point(4, 246);
            this.employeeDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeDataGridView.MultiSelect = false;
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersVisible = false;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(852, 234);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // frm_master_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_master_detail";
            this.Text = "Master-Detail";
            this.Load += new System.EventHandler(this.frm_employeesworksforbranch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grp_type.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView branchDataGridView;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.ComboBox cmb_tables;
        private System.Windows.Forms.GroupBox grp_type;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}