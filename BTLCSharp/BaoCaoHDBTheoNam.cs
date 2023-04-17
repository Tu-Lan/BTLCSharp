using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace BTLCSharp
{
    public partial class BaoCaoHDBTheoNam : Form
    {
        public BaoCaoHDBTheoNam()
        {
            InitializeComponent();
        }

        private void BaoCaoHDBTheoNam_Load(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            document.Load(@"C:\Users\luuph\RiderProjects\BTLCSharp\BTLCSharp\BaocaoHDBNam.rpt");
            ReportViewHDB.ReportSource = document;
            ReportViewHDB.Refresh();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            document.Load(@"C:\Users\luuph\RiderProjects\BTLCSharp\BTLCSharp\BaocaoHDBNam.rpt");
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("timHDBtheoNamThang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@thang", txtThang.Text);
                    cmd.Parameters.AddWithValue("@nam", txtNam.Text);
                    cmd.Parameters.AddWithValue("imaKH", txtMaKH.Text);
                    using(SqlDataAdapter adt = new SqlDataAdapter())
                    {
                        adt.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        BaoCaoHDB baoCao = new BaoCaoHDB();
                        baoCao.SetDataSource(dt);
                        ReportViewHDB.ReportSource = baoCao;
                        ReportViewHDB.Refresh();
                    }
                }
            }
        }
    }
}
