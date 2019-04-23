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

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Employee_Info change = new Change_Employee_Info();
            change.MdiParent = this;
            change.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employeeform Employee = new Employeeform();
            Employee.MdiParent = this;
            Employee.Show();
        }

        private void masterDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_master_detail masterDetailForm = new frm_master_detail();
            masterDetailForm.MdiParent = this;
            masterDetailForm.Show();
        }

        private void noOfVolunteersPerCampaignReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_volunteerno_report noOfVolunteersForm = new frm_volunteerno_report();
            noOfVolunteersForm.MdiParent = this;
            noOfVolunteersForm.Show();
        }
    }
}
