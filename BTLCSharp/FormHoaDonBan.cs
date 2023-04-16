using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormHoaDonBan : Form
    {
        public FormHoaDonBan()
        {
            InitializeComponent();
        }

        private void FormHoaDonBan_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblHOADONBAN",conn))
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataHDB.DataSource = dt;
                    }

                    dataHDB.Columns[0].HeaderText = "Mã hóa đơn";
                    dataHDB.Columns[1].HeaderText = "Mã nhân viên";
                    dataHDB.Columns[2].HeaderText = "Mã khách hàng";
                    dataHDB.Columns[3].HeaderText = "Ngày đặt";
                    dataHDB.Columns[4].HeaderText = "Ngày giao";
                    dataHDB.Columns[5].HeaderText = "Địa chỉ";
                }
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtDiaChi.Text = "";
            txtNgayDat.Text = "";
            txtNgayGiao.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            txtMaHDB.Text = "";
            FormHoaDonBan_Load(sender,e);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkCmd =
                    new SqlCommand("SELECT COUNT(*) FROM tblHOADONBAN WHERE iMaHDB = @iMaHDB", connection);
                checkCmd.Parameters.AddWithValue("@iMaHDB", txtMaHDB.Text);
                connection.Open();
                int count = (int)checkCmd.ExecuteScalar();
                connection.Close();

                if (count > 0)
                {
                    MessageBox.Show("Mã hóa đơn nhập đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập mã khác.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand insertCmd = new SqlCommand("themHDB", connection);
                    insertCmd.CommandType = CommandType.StoredProcedure;
                    insertCmd.Parameters.AddWithValue("@iMaHDB", txtMaHDB.Text);
                    insertCmd.Parameters.AddWithValue("@iMaNV", txtMaNV.Text);
                    insertCmd.Parameters.AddWithValue("@iMaKH", txtMaKH.Text);
                    insertCmd.Parameters.AddWithValue("@dNgayDat", txtNgayDat.Text);
                    insertCmd.Parameters.AddWithValue("@dNgayGiao", txtNgayGiao.Text);
                    insertCmd.Parameters.AddWithValue("@sDiaChiGiao", txtDiaChi.Text);
                    connection.Open();
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        FormHoaDonBan_Load(sender, e);
                        MessageBox.Show("Thêm hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Reset(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn không thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("suaHDB", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@iMaHDB", txtMaHDB.Text);
                    cmd.Parameters.AddWithValue("@iMaNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@iMaKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@dNgayDat", txtNgayDat.Text);
                    cmd.Parameters.AddWithValue("@dNgayGiao", txtNgayGiao.Text);
                    cmd.Parameters.AddWithValue("@sDiaChiGiao", txtDiaChi.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thông tin hóa đơn bán thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            Reset(sender,e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("xoaHDB",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iMaHDB", txtMaHDB.Text);
                    conn.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Xóa hóa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHoaDonBan_Load(sender, e);
                        Reset(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn nhập để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            FormChiTietCuaMotHDB CTHDB = new FormChiTietCuaMotHDB(txtMaHDB.Text);
            CTHDB.Show();
            this.Hide();
        }

        private void dataHDB_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataHDB.CurrentRow.Index;
            txtMaHDB.Text = dataHDB.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dataHDB.Rows[i].Cells[1].Value.ToString();
            txtMaKH.Text = dataHDB.Rows[i].Cells[2].Value.ToString();
            txtNgayDat.Text = dataHDB.Rows[i].Cells[3].Value.ToString();
            txtNgayGiao.Text = dataHDB.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dataHDB.Rows[i].Cells[5].Value.ToString(); 
        }
    }
}