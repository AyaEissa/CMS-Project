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
    public partial class frm_employeesworksforbranch : Form
    {
        string ordb = "Data source = orcl; User id = hr; Password = hr;";
        OracleDataAdapter adp;
        DataSet ds;

        public frm_employeesworksforbranch()
        {
            InitializeComponent();
        }

        private void frm_employeesworksforbranch_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            string cmd = "SELECT * " +
                "FROM Branch";
            adp = new OracleDataAdapter(cmd, ordb);
            adp.Fill(ds, "branch");

            cmd = "SELECT * " +
                "FROM Employee";
            adp = new OracleDataAdapter(cmd, ordb);
            adp.Fill(ds, "employee");

            DataRelation dr = new DataRelation("fk", ds.Tables[0].Columns[0], ds.Tables[1].Columns[6]);
            ds.Relations.Add(dr);

            BindingSource master = new BindingSource(ds, "branch");
            BindingSource child = new BindingSource(master, "fk");

            branchDataGridView.DataSource = master;
            employeeDataGridView.DataSource = child;
        }
    }
}
