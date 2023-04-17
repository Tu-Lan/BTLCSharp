using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormLoaiSP : Form
    {
        public FormLoaiSP()
        {
            InitializeComponent();
        }

        private void txtNgayDat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormLoaiSP_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select*from tblLOAISP", conn))
                {
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataLoaiSP.DataSource = dt;
                    }

                    dataLoaiSP.Columns[0].HeaderText = "Mã loại sản phẩm";
                    dataLoaiSP.Columns[1].HeaderText = "Tên loại sản phẩm";
                }
            }
        }

        private void dataLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataLoaiSP.CurrentRow.Index;
            txtMaLSP.Text = dataLoaiSP.Rows[i].Cells[0].Value.ToString();
            txtTenLSP.Text = dataLoaiSP.Rows[i].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("themLSP", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaLoaiSP", txtMaLSP.Text);
                    cmd.Parameters.AddWithValue("@sTenLoaiSP", txtTenLSP.Text);
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    FormLoaiSP_Load(sender,e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataLoaiSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaLSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (txtMaLSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại sản phẩm", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMaLSP.Focus();
                return;
            }

            if (txtTenLSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại sản phẩm", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMaLSP.Focus();
                return;
            }

            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Tạo đối tượng SqlCommand để thực thi stored procedure
                SqlCommand command = new SqlCommand("suaLSP", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho stored procedure
                command.Parameters.AddWithValue("@sMaLoaiSP", txtMaLSP.Text);
                command.Parameters.AddWithValue("@sTenLoaiSP", txtTenLSP.Text);

                // Thực thi stored procedure
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật loại sản phẩm thành công.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật loại sản phẩm: " + ex.Message);
                }

                // Đóng kết nối
                connection.Close();
            }
            FormLoaiSP_Load(sender,e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa loại sản phẩm này không", "Cảnh báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;

                // Kết nối đến cơ sở dữ liệu
                SqlConnection connection = new SqlConnection(constr);
                connection.Open();

                // Tạo đối tượng SqlCommand để thực thi stored procedure
                SqlCommand command = new SqlCommand("xoaLSP", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm tham số cho stored procedure
                command.Parameters.AddWithValue("@sMaLoaiSP", txtMaLSP.Text);

                // Thực thi stored procedure
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa loại sản phẩm thành công.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi xóa loại sản phẩm: " + ex.Message);
                }

                // Đóng kết nối
                connection.Close();
                FormLoaiSP_Load(sender, e);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           FormLoaiSP_Load(sender,e);
        }
    }
}