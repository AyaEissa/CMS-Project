using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_DB_Project
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void manageVolunteerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manage_volunteer volunteerForm = new frm_manage_volunteer();
            volunteerForm.MdiParent = this;
            volunteerForm.Show();
        }

        private void employeesWorksForBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_employeesworksforbranch empForBranch = new frm_employeesworksforbranch();
            empForBranch.MdiParent = this;
            empForBranch.Show();
        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manage_donor donorForm = new frm_manage_donor();
            donorForm.MdiParent = this;
            donorForm.Show();
        }

        private void donationsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_donations_report donationsReport = new frm_donations_report();
            donationsReport.MdiParent = this;
            donationsReport.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employeeform Employee = new Employeeform();
            Employee.MdiParent = this;
            Employee.Show();
        }

        private void changeEmployeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Employee_Info change = new Change_Employee_Info();
            change.MdiParent = this;
            change.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CampainReport cm = new CampainReport();
            cm.MdiParent = this;
            cm.Show();

        }

        private void employeeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee_Bramch cm = new Employee_Bramch();
            cm.MdiParent = this;
            cm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_search_volunteer_connected searchVolForm = new frm_search_volunteer_connected();
            searchVolForm.MdiParent = this;
            searchVolForm.Show();
        }

        private void searchDisconnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_search_volunteer_disconnected searchVolForm = new frm_search_volunteer_disconnected();
            searchVolForm.MdiParent = this;
            searchVolForm.Show();
        }

        private void campaginReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CampaginRep_form camp = new CampaginRep_form();
            camp.MdiParent = this;
            camp.Show();
        }
    }
}
