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
    public partial class Employeeform : Form
    {
        string ordb = "Data source = orcl; User id = hr; Password = hr;";
        OracleConnection conn;
        OracleCommand cmd;
        public Employeeform()
        {
            InitializeComponent();
        }

        private void Employeeform_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            OracleCommand cmd = new OracleCommand(ordb);
            cmd.Connection = conn;
            cmd.CommandText = "Select * from EMPLOYEE";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["SSN"].ToString());
                item.SubItems.Add(dr["Fname"].ToString());
                item.SubItems.Add(dr["Lname"].ToString());
                item.SubItems.Add(dr["Email"].ToString());
                item.SubItems.Add(dr["MOBILENUMBER"].ToString());
                item.SubItems.Add(dr["Address"].ToString());
                item.SubItems.Add(dr["BID"].ToString());
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
