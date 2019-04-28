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
    public partial class Search_mode : Form
    {
        public Search_mode()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_search_volunteer_disconnected fd = new frm_search_volunteer_disconnected();
            fd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_search_volunteer_connected x = new frm_search_volunteer_connected();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_manage_volunteer a = new frm_manage_volunteer();
            a.Show();
        }
    }
}
