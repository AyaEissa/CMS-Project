using System;
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
    public partial class frm_search_volunteer_disconnected : Form
    {
        string ordb = "Data source = orcl; User id = hr; Password = hr;";
        OracleDataAdapter adp;
        DataSet ds;

        public frm_search_volunteer_disconnected()
        {
            InitializeComponent();
        }

        private void frm_search_volunteer_Load(object sender, EventArgs e)
        {
            cmp_search.SelectedIndex = 0;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
                return;

            string cmd = "SELECT * " +
                "FROM Volunteer ";
            if (cmp_search.Text == "Email")
                cmd += "WHERE lower(Email) like :search";
            else if (cmp_search.Text == "First Name")
                cmd += "WHERE lower(Fname) like :search";
            else if (cmp_search.Text == "Last Name")
                cmd += "WHERE lower(Lname) like :search";
            else if (cmp_search.Text == "Mobile Number")
                cmd += "WHERE Mobilenumber like :search";
            else if (cmp_search.Text == "Address")
                cmd += "WHERE lower(Address) like :search";

            adp = new OracleDataAdapter(cmd, ordb);
            adp.SelectCommand.Parameters.Add("search", '%' + txt_search.Text.ToLower() + '%');

            ds = new DataSet();
            adp.Fill(ds);
            volunteerDataGridView.DataSource = ds.Tables[0];
        }

        private void cmp_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_search.Focus();
        }
    }
}
