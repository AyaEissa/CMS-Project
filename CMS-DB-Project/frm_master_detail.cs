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
    public partial class frm_master_detail : Form
    {
        string ordb = "Data source = orcl; User id = hr; Password = hr;";
        OracleDataAdapter adp;
        DataSet ds;

        public frm_master_detail()
        {
            InitializeComponent();
        }

        private void frm_employeesworksforbranch_Load(object sender, EventArgs e)
        {
            cmb_tables.SelectedIndex = 0;
            cmb_tables.Select();
        }

        private void cmb_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tables.SelectedIndex == 0)
            {
                grp_type.Text = "Employees work for Branch";

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
            else if (cmb_tables.SelectedIndex == 1)
            {
                grp_type.Text = "Branch Mobile Phones";

                ds = new DataSet();
                string cmd = "SELECT * " +
                    "FROM Branch";
                adp = new OracleDataAdapter(cmd, ordb);
                adp.Fill(ds, "branch");

                cmd = "SELECT * " +
                    "FROM Branchphones";
                adp = new OracleDataAdapter(cmd, ordb);
                adp.Fill(ds, "phones");

                DataRelation dr = new DataRelation("fk", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(dr);

                BindingSource master = new BindingSource(ds, "branch");
                BindingSource child = new BindingSource(master, "fk");

                branchDataGridView.DataSource = master;
                employeeDataGridView.DataSource = child;
            }
            else if (cmb_tables.SelectedIndex == 2)
            {
                grp_type.Text = "Branch Manges Campaign";

                ds = new DataSet();
                string cmd = "SELECT * " +
                    "FROM Branch";
                adp = new OracleDataAdapter(cmd, ordb);
                adp.Fill(ds, "branch");

                cmd = "SELECT * " +
                    "FROM Manages";
                adp = new OracleDataAdapter(cmd, ordb);
                adp.Fill(ds, "manage");

                DataRelation dr = new DataRelation("fk", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
                ds.Relations.Add(dr);

                BindingSource master = new BindingSource(ds, "branch");
                BindingSource child = new BindingSource(master, "fk");

                branchDataGridView.DataSource = master;
                employeeDataGridView.DataSource = child;
            }
            else if (cmb_tables.SelectedIndex == 3)
            {
                grp_type.Text = "Campaign Activites";

                ds = new DataSet();
                string cmd = "SELECT * " +
                    "FROM Campaign";
                adp = new OracleDataAdapter(cmd, ordb);
                adp.Fill(ds, "campaign");

                cmd = "SELECT * " +
                    "FROM Activity";
                adp = new OracleDataAdapter(cmd, ordb);
                adp.Fill(ds, "activity");

                DataColumn[] pks = { ds.Tables[0].Columns[0], ds.Tables[0].Columns[1] };
                DataColumn[] fks = { ds.Tables[1].Columns[1], ds.Tables[1].Columns[2] };
                DataRelation dr = new DataRelation("fk", pks, fks);
                ds.Relations.Add(dr);

                BindingSource master = new BindingSource(ds, "campaign");
                BindingSource child = new BindingSource(master, "fk");

                branchDataGridView.DataSource = master;
                employeeDataGridView.DataSource = child;
            }
        }
    }
}
