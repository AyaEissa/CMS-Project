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
    public partial class frm_search_volunteer : Form
    {
        string ordb = "Data source = orcl; User id = hr; Password = hr;";
        OracleConnection con;
        OracleCommand cmd;
        public frm_search_volunteer()
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
            if (!chk_usingProcedure.Checked)
            {
                volunteerListView.Items.Clear();

                if (txt_search.Text == "")
                    return;

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * " +
                    "FROM Volunteer ";
                if (cmp_search.Text == "Email")
                {
                    cmd.CommandText += "WHERE lower(Email) like :search";
                    cmd.Parameters.Add("sarch", '%' + txt_search.Text.ToLower() + '%');
                }
                else if (cmp_search.Text == "First Name")
                {
                    cmd.CommandText += "WHERE lower(Fname) like :search";
                    cmd.Parameters.Add("search", '%' + txt_search.Text.ToLower() + '%');
                }
                else if (cmp_search.Text == "Last Name")
                {
                    cmd.CommandText += "WHERE lower(Lname) like :search";
                    cmd.Parameters.Add("search", '%' + txt_search.Text.ToLower() + '%');
                }
                else if (cmp_search.Text == "Mobile Number")
                {
                    cmd.CommandText += "WHERE Mobilenumber like :search";
                    cmd.Parameters.Add("search", '%' + txt_search.Text + '%');
                }
                else if (cmp_search.Text == "Address")
                {
                    cmd.CommandText += "WHERE lower(Address) like :search";
                    cmd.Parameters.Add("search", '%' + txt_search.Text.ToLower() + '%');
                }
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
        }

        private void cmp_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_search.Text = "";
            volunteerListView.Items.Clear();
            txt_search.Focus();
        }

        private void chk_usingProcedure_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_usingProcedure.Checked == true)
            {
                cmp_search.Enabled = false;

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "Get_Volunteer_Count";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("count", OracleDbType.Int32, ParameterDirection.Output);

                cmd.ExecuteNonQuery();

                txt_search.Text = "Number of Volunteer: " + cmd.Parameters["count"].Value.ToString();
            }
            else
            {
                cmp_search.Enabled = true;
                txt_search.Text = "";
            }
            volunteerListView.Items.Clear();
            txt_search.Focus();
        }
    }
}
