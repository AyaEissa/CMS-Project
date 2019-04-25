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
    public partial class Employee_Branch : Form
    {
        string ordb = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;

        public Employee_Branch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            OracleCommand cmd = new OracleCommand(ordb);
            cmd.Connection = conn;
            cmd.CommandText = "GetBranchID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", id.Text);
            cmd.Parameters.Add("ID", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["SSN"].ToString());
                listView1.Items.Add(item);
                //listView1.DataSource = dr;
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            dr.Close();
        }

        private void Employee_Branch_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
