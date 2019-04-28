﻿namespace CMS_DB_Project
{
    partial class frm_manage_volunteer
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
            this.volunteerGroupBox = new System.Windows.Forms.GroupBox();
            this.txt_birthdate = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.volunteerListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.volunteerGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // volunteerGroupBox
            // 
            this.volunteerGroupBox.Controls.Add(this.button2);
            this.volunteerGroupBox.Controls.Add(this.button1);
            this.volunteerGroupBox.Controls.Add(this.txt_birthdate);
            this.volunteerGroupBox.Controls.Add(this.txt_age);
            this.volunteerGroupBox.Controls.Add(this.txt_address);
            this.volunteerGroupBox.Controls.Add(this.txt_mobile);
            this.volunteerGroupBox.Controls.Add(this.txt_lname);
            this.volunteerGroupBox.Controls.Add(this.txt_fname);
            this.volunteerGroupBox.Controls.Add(this.txt_email);
            this.volunteerGroupBox.Controls.Add(this.lbl_age);
            this.volunteerGroupBox.Controls.Add(this.lbl_address);
            this.volunteerGroupBox.Controls.Add(this.lbl_mobile);
            this.volunteerGroupBox.Controls.Add(this.lbl_birthdate);
            this.volunteerGroupBox.Controls.Add(this.lbl_lname);
            this.volunteerGroupBox.Controls.Add(this.lbl_fname);
            this.volunteerGroupBox.Controls.Add(this.lbl_email);
            this.volunteerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volunteerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volunteerGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.volunteerGroupBox.Location = new System.Drawing.Point(4, 4);
            this.volunteerGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volunteerGroupBox.Name = "volunteerGroupBox";
            this.volunteerGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volunteerGroupBox.Size = new System.Drawing.Size(780, 212);
            this.volunteerGroupBox.TabIndex = 0;
            this.volunteerGroupBox.TabStop = false;
            this.volunteerGroupBox.Text = "Volunteer Information";
            this.volunteerGroupBox.Enter += new System.EventHandler(this.volunteerGroupBox_Enter);
            // 
            // txt_birthdate
            // 
            this.txt_birthdate.BackColor = System.Drawing.SystemColors.Control;
            this.txt_birthdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_birthdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthdate.Location = new System.Drawing.Point(172, 96);
            this.txt_birthdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_birthdate.Name = "txt_birthdate";
            this.txt_birthdate.ReadOnly = true;
            this.txt_birthdate.Size = new System.Drawing.Size(184, 20);
            this.txt_birthdate.TabIndex = 13;
            // 
            // txt_age
            // 
            this.txt_age.BackColor = System.Drawing.SystemColors.Control;
            this.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_age.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(608, 96);
            this.txt_age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_age.Name = "txt_age";
            this.txt_age.ReadOnly = true;
            this.txt_age.Size = new System.Drawing.Size(164, 20);
            this.txt_age.TabIndex = 16;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.Control;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(172, 158);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.ReadOnly = true;
            this.txt_address.Size = new System.Drawing.Size(600, 20);
            this.txt_address.TabIndex = 15;
            // 
            // txt_mobile
            // 
            this.txt_mobile.BackColor = System.Drawing.SystemColors.Control;
            this.txt_mobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mobile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile.Location = new System.Drawing.Point(172, 127);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.ReadOnly = true;
            this.txt_mobile.Size = new System.Drawing.Size(184, 20);
            this.txt_mobile.TabIndex = 14;
            // 
            // txt_lname
            // 
            this.txt_lname.BackColor = System.Drawing.SystemColors.Control;
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(608, 65);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.ReadOnly = true;
            this.txt_lname.Size = new System.Drawing.Size(164, 20);
            this.txt_lname.TabIndex = 12;
            // 
            // txt_fname
            // 
            this.txt_fname.BackColor = System.Drawing.SystemColors.Control;
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(172, 65);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.ReadOnly = true;
            this.txt_fname.Size = new System.Drawing.Size(184, 20);
            this.txt_fname.TabIndex = 11;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Control;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(172, 34);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(600, 20);
            this.txt_email.TabIndex = 10;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.lbl_age.Location = new System.Drawing.Point(452, 96);
            this.lbl_age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(49, 19);
            this.lbl_age.TabIndex = 9;
            this.lbl_age.Text = "Age:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.lbl_address.Location = new System.Drawing.Point(16, 158);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(81, 19);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.lbl_mobile.Location = new System.Drawing.Point(16, 127);
            this.lbl_mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(141, 19);
            this.lbl_mobile.TabIndex = 7;
            this.lbl_mobile.Text = "Mobile Number:";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.lbl_birthdate.Location = new System.Drawing.Point(16, 96);
            this.lbl_birthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(84, 19);
            this.lbl_birthdate.TabIndex = 6;
            this.lbl_birthdate.Text = "Birthdate:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.lbl_lname.Location = new System.Drawing.Point(452, 65);
            this.lbl_lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(100, 19);
            this.lbl_lname.TabIndex = 5;
            this.lbl_lname.Text = "Last Name:";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.lbl_fname.Location = new System.Drawing.Point(16, 65);
            this.lbl_fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(99, 19);
            this.lbl_fname.TabIndex = 4;
            this.lbl_fname.Text = "First Name:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.lbl_email.Location = new System.Drawing.Point(16, 34);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 19);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(598, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 39);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(691, 4);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(85, 39);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(190, 4);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 39);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(97, 4);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(85, 39);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(4, 4);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 39);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // volunteerListView
            // 
            this.volunteerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.volunteerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volunteerListView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volunteerListView.FullRowSelect = true;
            this.volunteerListView.Location = new System.Drawing.Point(4, 279);
            this.volunteerListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volunteerListView.MultiSelect = false;
            this.volunteerListView.Name = "volunteerListView";
            this.volunteerListView.Size = new System.Drawing.Size(780, 239);
            this.volunteerListView.TabIndex = 0;
            this.volunteerListView.UseCompatibleStateImageBehavior = false;
            this.volunteerListView.View = System.Windows.Forms.View.Details;
            this.volunteerListView.SelectedIndexChanged += new System.EventHandler(this.volunteerListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Email";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bithdate";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mobile Number";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            this.columnHeader6.Width = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.volunteerListView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.volunteerGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_status, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 551);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 224);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(4, 531);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(780, 20);
            this.lbl_status.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(739, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(702, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_manage_volunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_manage_volunteer";
            this.Text = "Volunteers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_manage_volunteer_FormClosed);
            this.Load += new System.EventHandler(this.frm_manage_volunteer_Load);
            this.volunteerGroupBox.ResumeLayout(false);
            this.volunteerGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox volunteerGroupBox;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ListView volunteerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txt_birthdate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}