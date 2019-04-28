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

        private void btn_volunteer_Click(object sender, EventArgs e)
        {
            frm_manage_volunteer volunteerForm = new frm_manage_volunteer();
            volunteerForm.Show();
        }

        private void btn_donor_Click(object sender, EventArgs e)
        {
            frm_manage_donor donorForm = new frm_manage_donor();
            donorForm.Show();
        }

        private void btn_masterDetail_Click(object sender, EventArgs e)
        {
            frm_master_detail masterDetailForm = new frm_master_detail();
            masterDetailForm.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Change_Employee_Info change = new Change_Employee_Info();
            change.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_searchConnected_Click(object sender, EventArgs e)
        {
            frm_search_volunteer_connected searchVolForm = new frm_search_volunteer_connected();
            searchVolForm.Show();
        }

        private void btn_searchDisconnected_Click(object sender, EventArgs e)
        {
            frm_search_volunteer_disconnected searchVolForm = new frm_search_volunteer_disconnected();
            searchVolForm.Show();
        }

        private void btn_empViewAll_Click(object sender, EventArgs e)
        {
            Employeeform Employee = new Employeeform();
            Employee.Show();
        }

        private void btn_empBranch_Click(object sender, EventArgs e)
        {
            Employee_Branch cm = new Employee_Branch();
            cm.Show();
        }

        private void btn_rptDonations_Click(object sender, EventArgs e)
        {
            frm_donations_report donationsReport = new frm_donations_report();
            donationsReport.Show();
        }

        private void btn_rptVolPerCamp_Click(object sender, EventArgs e)
        {
            CampaginRep_form camp = new CampaginRep_form();
            camp.Show();
        }

        private void btn_rptNoOfVolPerCamp_Click(object sender, EventArgs e)
        {
            frm_volunteerno_report noOfVolunteersForm = new frm_volunteerno_report();
            noOfVolunteersForm.Show();
        }

        private void changeButtonMoveColor(ref Button btn)
        {
            btn.ForeColor = Color.Firebrick;
        }

        private void changeButtonLeaveColor(ref Button btn)
        {
            btn.ForeColor = Color.Silver;
        }

        private void btn_volunteer_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_volunteer);
            changeButtonMoveColor(ref btn_searchConnected);
            changeButtonMoveColor(ref btn_searchDisconnected);
        }

        private void btn_volunteer_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_volunteer);
            changeButtonLeaveColor(ref btn_searchConnected);
            changeButtonLeaveColor(ref btn_searchDisconnected);
        }

        private void btn_searchConnected_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_searchConnected);
        }

        private void btn_searchConnected_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_searchConnected);
        }

        private void btn_searchDisconnected_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_searchDisconnected);
        }

        private void btn_searchDisconnected_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_searchDisconnected);
        }

        private void btn_donor_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_donor);
        }

        private void btn_donor_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_donor);
        }

        private void btn_employee_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_employee);
            changeButtonMoveColor(ref btn_empViewAll);
            changeButtonMoveColor(ref btn_empBranch);
        }

        private void btn_employee_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_employee);
            changeButtonLeaveColor(ref btn_empViewAll);
            changeButtonLeaveColor(ref btn_empBranch);
        }

        private void btn_empViewAll_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_empViewAll);
        }

        private void btn_empViewAll_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_empViewAll);
        }

        private void btn_empBranch_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_empBranch);
        }

        private void btn_empBranch_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_empBranch);
        }

        private void btn_masterDetail_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_masterDetail);
        }

        private void btn_masterDetail_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_masterDetail);
        }

        private void btn_report_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_report);
            changeButtonMoveColor(ref btn_rptDonations);
            changeButtonMoveColor(ref btn_rptVolPerCamp);
            changeButtonMoveColor(ref btn_rptNoOfVolPerCamp);
        }

        private void btn_report_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_report);
            changeButtonLeaveColor(ref btn_rptDonations);
            changeButtonLeaveColor(ref btn_rptVolPerCamp);
            changeButtonLeaveColor(ref btn_rptNoOfVolPerCamp);
        }

        private void btn_rptDonations_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_rptDonations);
        }

        private void btn_rptDonations_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_rptDonations);
        }

        private void btn_rptVolPerCamp_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_rptVolPerCamp);
        }

        private void btn_rptVolPerCamp_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_rptVolPerCamp);
        }

        private void btn_rptNoOfVolPerCamp_MouseHover(object sender, EventArgs e)
        {
            changeButtonMoveColor(ref btn_rptNoOfVolPerCamp);
        }

        private void btn_rptNoOfVolPerCamp_MouseLeave(object sender, EventArgs e)
        {
            changeButtonLeaveColor(ref btn_rptNoOfVolPerCamp);
        }
    }
}
