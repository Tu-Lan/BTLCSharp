using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormNhaCC : Form
    {
        public FormNhaCC()
        {
            InitializeComponent();
        }

        private void FormNhaCC_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblNHACC", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataNCC.DataSource = dt;
                    }

                    dataNCC.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
                    dataNCC.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
                    dataNCC.Columns[2].HeaderText = "Địa Chỉ";
                    dataNCC.Columns[3].HeaderText = "Số Điện Thoại";
                }
            }
        }

        private void dataNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataNCC.CurrentRow.Index;
            txtMaNCC.Text = dataNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dataNCC.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dataNCC.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dataNCC.Rows[i].Cells[2].Value.ToString();
        }

        private void Reset(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            FormNhaCC_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkCmd =
                    new SqlCommand("SELECT COUNT(*) FROM tblNHACC WHERE iMaNCC = @iMaNCC", connection);
                checkCmd.Parameters.AddWithValue("@iMaNCC", txtMaNCC.Text);
                connection.Open();
                int count = (int)checkCmd.ExecuteScalar();
                connection.Close();

                if (count > 0)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập mã khác.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand insertCmd = new SqlCommand("themNCC", connection);
                    insertCmd.CommandType = CommandType.StoredProcedure;
                    insertCmd.Parameters.AddWithValue("@iMaNCC", txtMaNCC.Text);
                    insertCmd.Parameters.AddWithValue("@sTenNCC", txtTenNCC.Text);
                    insertCmd.Parameters.AddWithValue("@sDiaChi", txtDiaChi.Text);
                    insertCmd.Parameters.AddWithValue("@sSDT", txtSDT.Text);
                    connection.Open();
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        FormNhaCC_Load(sender, e);
                        MessageBox.Show("Thêm nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Reset(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà cung cấp không thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            Reset(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return;
            }

            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("suaNCC", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@iMaNCC", txtMaNCC.Text);
                    command.Parameters.AddWithValue("@sTenNCC", txtTenNCC.Text);
                    command.Parameters.AddWithValue("@sDiaChi", txtDiaChi.Text);
                    command.Parameters.AddWithValue("@sSDT", txtSDT.Text);
                    connection.Open();

                    try
                    {
                        command.ExecuteNonQuery();
                        FormNhaCC_Load(sender, e);
                        MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset(sender, e);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("xoaNCC", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@iMaNCC", txtMaNCC.Text);
                    connection.Open();

                    try
                    {
                        command.ExecuteNonQuery();
                        FormNhaCC_Load(sender, e);
                        MessageBox.Show("Xóa nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Reset(sender, e);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void lbThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormNhaCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                FormNhaCC_Load(sender, e);
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
                SqlDataAdapter adt =
                    new SqlDataAdapter("Select * from tblNHACC where sTenNCC like '%" + txtSearch.Text + "%'",
                        connectionString);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataNCC.DataSource = dt;

            }
        }
    }
}