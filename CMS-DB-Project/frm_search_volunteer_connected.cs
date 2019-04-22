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
    public partial class frm_search_volunteer_connected : Form
    {
        string ordb = "Data source = orcl; User id = hr; Password = hr;";
        OracleConnection con;
        OracleCommand cmd;
        public frm_search_volunteer_connected()
        {
            InitializeComponent();
        }

        private void frm_search_volunteer_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            cmp_search.SelectedIndex = 0;
        }

        private void frm_search_volunteer_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Dispose();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            volunteerListView.Items.Clear();

            if (txt_search.Text == "")
                return;

            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * " +
                "FROM Volunteer ";
            if (cmp_search.Text == "Email")
                cmd.CommandText += "WHERE lower(Email) like :search";
            else if (cmp_search.Text == "First Name")
                cmd.CommandText += "WHERE lower(Fname) like :search";
            else if (cmp_search.Text == "Last Name")
                cmd.CommandText += "WHERE lower(Lname) like :search";
            else if (cmp_search.Text == "Mobile Number")
                cmd.CommandText += "WHERE Mobilenumber like :search";
            else if (cmp_search.Text == "Address")
                cmd.CommandText += "WHERE lower(Address) like :search";
            cmd.Parameters.Add("search", '%' + txt_search.Text.ToLower() + '%');

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
        }

        private void cmp_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_search.Text = "";
            volunteerListView.Items.Clear();
            txt_search.Focus();
        }
    }
}
