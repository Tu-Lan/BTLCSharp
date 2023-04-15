using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormChiTietCuaMotHDN : Form
    {
        public FormChiTietCuaMotHDN(string maHDN)
        {
            InitializeComponent();
            txtMaHDN.Text = maHDN;
        }

        private void FormChiTietCuaMotHDN_Load(object sender, System.EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "select CTHDN.iMaHDN,CTHDN.sMaSP,CTHDN.fGiaNhap,CTHDN.iSoluong from tblCT_HDN CTHDN where CTHDN.iMaHDN ='" + txtMaHDN.Text + "'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                    dataGridView1.Columns[0].HeaderText = "Mã Hóa Đơn Nhập";
                    dataGridView1.Columns[1].HeaderText = "Mã Nhân Viên";
                    dataGridView1.Columns[2].HeaderText = "Giá Nhập";
                    dataGridView1.Columns[3].HeaderText = "Số lượng";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaHDN.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("suaCTHDN", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@iMaHDN", txtMaHDN.Text);
                    cmd.Parameters.AddWithValue("@sMaSP", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@fGiaNhap", float.Parse(txtGia.Text));
                    cmd.Parameters.AddWithValue("@iSoLuong", int.Parse(txtSoLuong.Text));

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa chi tiết hóa đơn nhập thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy chi tiết hóa đơn nhập để sửa.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                FormChiTietCuaMotHDN_Load(sender,e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormHoaDonNhap hoaDonNhap = new FormHoaDonNhap();
            hoaDonNhap.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}