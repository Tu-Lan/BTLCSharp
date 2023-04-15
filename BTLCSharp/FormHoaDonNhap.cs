using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormHoaDonNhap : Form
    {
        public FormHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FormHoaDonNhap_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblHOADONNHAP", conn))
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataHDN.DataSource = dt;
                    }

                    dataHDN.Columns[0].HeaderText = "Mã hóa đơn nhập";
                    dataHDN.Columns[1].HeaderText = "Mã nhân viên";
                    dataHDN.Columns[2].HeaderText = "Ngày Nhập";
                }
            }
        }
/*
        private void dataHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataHDN.CurrentRow.Index;
            txtMaHDN.Text = dataHDN.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dataHDN.Rows[i].Cells[1].Value.ToString();
            txtNgayNhap.Text = dataHDN.Rows[i].Cells[3].Value.ToString();
        }*/

        private void Reset(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtMaHDN.Text = "";
            txtNgayNhap.Text = "";
            FormHoaDonNhap_Load(sender, e);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkCmd =
                    new SqlCommand("SELECT COUNT(*) FROM tblHOADONNHAP WHERE iMaHDN = @iMaHDN", connection);
                checkCmd.Parameters.AddWithValue("@iMaHDN", txtMaHDN.Text);
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
                    SqlCommand insertCmd = new SqlCommand("themHDN", connection);
                    insertCmd.CommandType = CommandType.StoredProcedure;
                    insertCmd.Parameters.AddWithValue("@iMaHDN", txtMaHDN.Text);
                    insertCmd.Parameters.AddWithValue("@iMaNV", txtMaNV.Text);
                    insertCmd.Parameters.AddWithValue("@dNgayNhap", txtNgayNhap.Text);
                    connection.Open();
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        FormHoaDonNhap_Load(sender, e);
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

        private void dataHDN_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataHDN.CurrentRow.Index;
            txtMaHDN.Text = dataHDN.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dataHDN.Rows[i].Cells[1].Value.ToString();
            txtNgayNhap.Text = dataHDN.Rows[i].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaHDN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }

            if (txtNgayNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNgayNhap.Focus();
                return;
            }

            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("suaHDN", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iMaHDN", txtMaHDN.Text);
                    cmd.Parameters.AddWithValue("@iMaNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@dNgayNhap", txtNgayNhap.Text);
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        FormHoaDonNhap_Load(sender,e);
                        MessageBox.Show("Cập nhật thành công hóa đơn nhập", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Reset(sender,e);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string db = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(db))
            {
                using (SqlCommand cmd = new SqlCommand("xoaHDN", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iMaHDN", txtMaHDN.Text);
                    cnn.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    cnn.Close();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Xóa hóa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHoaDonNhap_Load(sender, e);
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
            Reset(sender,e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                FormHoaDonNhap_Load(sender,e);
            }
            else
            {
                string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
                SqlDataAdapter adt =
                    new SqlDataAdapter("Select *from tblHOADONNHAP where iMaHDN like '%" + txtSearch.Text + "%'",constr);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataHDN.DataSource = dt;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            FormChiTietCuaMotHDN chiTietHdn = new FormChiTietCuaMotHDN(txtMaHDN.Text);
            chiTietHdn.Show();
            this.Hide();
        }
    } 
}