using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormChiTietCuaMotHDB : Form
    {
        public FormChiTietCuaMotHDB(string maHDB)
        {
            InitializeComponent();
            txtMaHDB.Text = maHDB;
        }

        private void FormChiTietCuaMotHDB_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string query = "select CTHDB.iMaHDB,CTHDB.sMaSP,CTHDB.fGiaBan,CTHDB.iSoLuong from tblCT_HDB CTHDB where CTHDB.iMaHDB ='" + txtMaHDB.Text + "'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataHDB.DataSource = dt;
                    }
                    dataHDB.Columns[0].HeaderText = "Mã Hóa Đơn Nhập";
                    dataHDB.Columns[1].HeaderText = "Mã Nhân Viên";
                    dataHDB.Columns[2].HeaderText = "Giá Bán";
                    dataHDB.Columns[3].HeaderText = "Số lượng";
                }
            }
        }

        private void dataHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataHDB.CurrentRow.Index;
            txtMaHDB.Text = dataHDB.Rows[i].Cells[0].Value.ToString();
            txtMaSP.Text = dataHDB.Rows[i].Cells[1].Value.ToString();
            txtGia.Text = dataHDB.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dataHDB.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("suaCTHDB", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@iMaHDB", txtMaHDB.Text);
                    cmd.Parameters.AddWithValue("@sMaSP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@fGiaBan", float.Parse(txtGia.Text));
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
                FormChiTietCuaMotHDB_Load(sender,e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormHoaDonBan HDB = new FormHoaDonBan();
            HDB.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("themCTHDB", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@iMaHDB", txtMaHDB.Text);
                        cmd.Parameters.AddWithValue("sMaSP", txtMaSP.Text);
                        cmd.Parameters.AddWithValue("fGiaBan", float.Parse(txtGia.Text));
                        cmd.Parameters.AddWithValue("iSoLuong", int.Parse(txtSoLuong.Text));
                    }
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
            }
           
        }
    }
}