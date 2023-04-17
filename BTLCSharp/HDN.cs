using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class HDN : Form
    {
        public HDN()
        {
            InitializeComponent();
        }

        private void HDN_Load(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            document.Load(@"C:\Users\luuph\RiderProjects\BTLCSharp\BTLCSharp\BaocaoHDN.rpt");
            crystalReportViewer1.ReportSource = document;
            crystalReportViewer1.Refresh();
        }
    }
}
