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

        

        private void button1_Click(object sender, EventArgs e)
        {
            Search_mode x = new Search_mode();
            x.Show();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_manage_donor b = new frm_manage_donor();
            b.Show();

               }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_master_detail c = new frm_master_detail();
            c.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports d = new Reports();
            d.Show();
        }
    }
}
