﻿using System;
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
    public partial class frm_volunteerno_report : Form
    {
        public frm_volunteerno_report()
        {
            InitializeComponent();
        }

        private void frm_volunteerno_report_Load(object sender, EventArgs e)
        {
            rpt_volunteerno_campaign volunteersRpt = new rpt_volunteerno_campaign();
            crystalReportViewer1.ReportSource = volunteersRpt;
        }
    }
}
