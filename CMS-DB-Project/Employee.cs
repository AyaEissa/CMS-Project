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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employeeform Employee = new Employeeform();
            Employee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Branch cm = new Employee_Branch();
            cm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change_Employee_Info change = new Change_Employee_Info();
            change.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
