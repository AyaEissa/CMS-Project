﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace CMS_DB_Project
{
    public partial class frm_manage_volunteer : Form
    {
        string ordb = "Data source = orcl; User id = hr; Password = hr;";
        OracleConnection con;
        OracleCommand cmd;
        int chooseFlag = -1; //Indicates user choose Add or Edit
        int lastItemSelected = 0; //Last item selected in list view

        public frm_manage_volunteer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Make volunteer information test boxes editable.
        /// </summary>
        /// <param name="isAdd">Indicates show text boxes in Add or Edit mode</param>
        public void showTextboxes(bool isAdd)
        {
            if (isAdd)
                txt_email.BackColor = Color.White;
            txt_fname.BackColor = Color.White;
            txt_lname.BackColor = Color.White;
            txt_birthdate.BackColor = Color.White;
            txt_mobile.BackColor = Color.White;
            txt_address.BackColor = Color.White;
            if (isAdd)
                txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_fname.BorderStyle = BorderStyle.FixedSingle;
            txt_lname.BorderStyle = BorderStyle.FixedSingle;
            txt_birthdate.BorderStyle = BorderStyle.FixedSingle;
            txt_mobile.BorderStyle = BorderStyle.FixedSingle;
            txt_address.BorderStyle = BorderStyle.FixedSingle;
            if (isAdd)
                txt_email.ReadOnly = false;
            txt_fname.ReadOnly = false;
            txt_lname.ReadOnly = false;
            txt_birthdate.ReadOnly = false;
            txt_mobile.ReadOnly = false;
            txt_address.ReadOnly = false;
        }

        /// <summary>
        /// Make volunteer information test boxes read-only.
        /// </summary>
        public void hideTextboxes()
        {
            txt_email.BackColor = SystemColors.Control;
            txt_fname.BackColor = SystemColors.Control;
            txt_lname.BackColor = SystemColors.Control;
            txt_birthdate.BackColor = SystemColors.Control;
            txt_mobile.BackColor = SystemColors.Control;
            txt_address.BackColor = SystemColors.Control;
            txt_email.BorderStyle = BorderStyle.None;
            txt_fname.BorderStyle = BorderStyle.None;
            txt_lname.BorderStyle = BorderStyle.None;
            txt_birthdate.BorderStyle = BorderStyle.None;
            txt_mobile.BorderStyle = BorderStyle.None;
            txt_address.BorderStyle = BorderStyle.None;
            txt_email.ReadOnly = true;
            txt_fname.ReadOnly = true;
            txt_lname.ReadOnly = true;
            txt_birthdate.ReadOnly = true;
            txt_mobile.ReadOnly = true;
            txt_address.ReadOnly = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            chooseFlag = 1;
            showTextboxes(true);
            txt_email.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_birthdate.Text = "";
            txt_mobile.Text = "";
            txt_address.Text = "";
            txt_age.Text = "";
            txt_email.Focus();

            btn_add.Visible = false;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            btn_save.Visible = true;
            btn_cancel.Visible = true;

            volunteerListView.Enabled = false;

            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Volunteer " +
                "VALUES (:email, :fname, :lname, :birthdare, :mobile, :address)";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            chooseFlag = 2;
            showTextboxes(false);
            txt_fname.Focus();

            btn_add.Visible = false;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            btn_save.Visible = true;
            btn_cancel.Visible = true;

            volunteerListView.Enabled = false;
            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Volunteer " +
                "SET Fname = :fname, Lname = :lname, Birthdate = :birthdate, " +
                "Mobilenumber = :mobile, Address = :address " +
                "WHERE Email = :email";
        }

        private void frm_manage_volunteer_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            if (!checkTableExist(con))
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = @"CREATE TABLE Volunteer 
                                    (EMAIL VARCHAR2(40) PRIMARY KEY,
                                    FNAME VARCHAR2(10) NOT NULL,
                                    LNAME VARCHAR2(10) NOT NULL,
                                    BIRTHDATE DATE NOT NULL,
                                    MOBILENUMBER VARCHAR2(13) NOT NULL,
                                    ADDRESS VARCHAR2(50))";
                cmd.ExecuteNonQuery();
            }

            updateListView();

            if (volunteerListView.Items.Count > 0)
            {
                volunteerListView.Items[0].Selected = true;
                volunteerListView.Select();
            }
        }

        private void volunteerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTextBoxes();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (chooseFlag == 1)
            {
                cmd.Parameters.Add("email", txt_email.Text);
                cmd.Parameters.Add("fname", txt_fname.Text);
                cmd.Parameters.Add("lname", txt_lname.Text);
                cmd.Parameters.Add("birthdate", Convert.ToDateTime(txt_birthdate.Text).Date);
                cmd.Parameters.Add("mobile", txt_mobile.Text);
                cmd.Parameters.Add("address", txt_address.Text);
            }
            else if (chooseFlag == 2)
            {
                cmd.Parameters.Add("fname", txt_fname.Text);
                cmd.Parameters.Add("lname", txt_lname.Text);
                cmd.Parameters.Add("birthdate", Convert.ToDateTime(txt_birthdate.Text).Date);
                cmd.Parameters.Add("mobile", txt_mobile.Text);
                cmd.Parameters.Add("address", txt_address.Text);
                cmd.Parameters.Add("email", txt_email.Text);
            }
            cmd.ExecuteNonQuery();

            updateListView();

            btn_add.Visible = true;
            btn_edit.Visible = true;
            btn_delete.Visible = true;
            btn_save.Visible = false;
            btn_cancel.Visible = false;

            volunteerListView.Enabled = true;

            hideTextboxes();
            if (volunteerListView.Items.Count > 0)
            {
                volunteerListView.Items[lastItemSelected].Selected = true;
                volunteerListView.Select();
            }
        }

        /// <summary>
        /// Open connection with Oracle and fill the list view.
        /// </summary>
        public void updateListView()
        {
            volunteerListView.Items.Clear();

            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * " +
                "FROM Volunteer ";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["Email"].ToString();
                item.SubItems.Add(dr["Fname"].ToString());
                item.SubItems.Add(dr["Lname"].ToString());
                item.SubItems.Add(Convert.ToDateTime(dr["Birthdate"].ToString()).Date.ToShortDateString());
                item.SubItems.Add(dr["Mobilenumber"].ToString());
                item.SubItems.Add(dr["Address"].ToString());
                volunteerListView.Items.Add(item);
            }
            volunteerListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            dr.Dispose();

            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "Get_Volunteer_Count";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("count", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            lbl_status.Text = "Number of Volunteer: " + cmd.Parameters["count"].Value.ToString();
        }

        /// <summary>
        /// Fill volunteer text boxes with selected item in list view.
        /// </summary>
        public void fillTextBoxes()
        {
            if (volunteerListView.SelectedItems.Count != 0)
            {
                txt_email.Text = volunteerListView.SelectedItems[0].SubItems[0].Text;
                txt_fname.Text = volunteerListView.SelectedItems[0].SubItems[1].Text;
                txt_lname.Text = volunteerListView.SelectedItems[0].SubItems[2].Text;
                txt_birthdate.Text = volunteerListView.SelectedItems[0].SubItems[3].Text;
                txt_mobile.Text = volunteerListView.SelectedItems[0].SubItems[4].Text;
                txt_address.Text = volunteerListView.SelectedItems[0].SubItems[5].Text;
                txt_age.Text = (DateTime.Now.Year - Convert.ToDateTime(txt_birthdate.Text).Year).ToString() + " Years";
                lastItemSelected = volunteerListView.SelectedItems[0].Index;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            updateListView();

            btn_add.Visible = true;
            btn_edit.Visible = true;
            btn_delete.Visible = true;
            btn_save.Visible = false;
            btn_cancel.Visible = false;

            volunteerListView.Enabled = true;

            hideTextboxes();
            if (volunteerListView.Items.Count > 0)
            {
                volunteerListView.Items[lastItemSelected].Selected = true;
                volunteerListView.Select();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (volunteerListView.SelectedItems.Count != 0)
            {
                DialogResult res = MessageBox.Show("Delete this record?", "Delete Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM Volunteer " +
                        "WHERE Email = :email";
                    cmd.Parameters.Add("email", txt_email.Text);
                    cmd.ExecuteNonQuery();

                    updateListView();
                    if (volunteerListView.Items.Count > 0)
                    {
                        volunteerListView.Items[0].Selected = true;
                        volunteerListView.Select();
                    }
                }
            }
            else
                MessageBox.Show("Please select the record you want to delete from list.", "Select Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frm_manage_volunteer_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Dispose();
        }

        private bool checkTableExist(OracleConnection connection)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Volunteer";
            try
            {
                cmd.ExecuteReader();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nConnection: " + connection.ConnectionString + "\nTable will be created for you."
                    , "SQL Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void volunteerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
