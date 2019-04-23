using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace CMS_DB_Project
{
    public partial class CampaginRep_form : Form
    {
        CampaginReport CR;

        public CampaginRep_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = CR;
        }

        private void CampaginRep_form_Load(object sender, EventArgs e)
        {
            CR = new CampaginReport();
            foreach (ParameterDiscreteValue item in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(item.Value.ToString());
        }
    }
}
