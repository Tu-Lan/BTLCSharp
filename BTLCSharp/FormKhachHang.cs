using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from tblKHACHHANG", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataKH.DataSource = dt;
                    }
                    dataKH.Columns[0].HeaderText = "Mã khách hàng";
                    dataKH.Columns[1].HeaderText = "Tên khách hàng";
                    dataKH.Columns[3].HeaderText = "Địa Chỉ";
                    dataKH.Columns[2].HeaderText = "Số Điện Thoại";
                }
            }
        }

        private void dataKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataKH.CurrentRow.Index;
            txtMaKH.Text = dataKH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataKH.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dataKH.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dataKH.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string db = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(db))
            {
                using (SqlCommand cmd = new SqlCommand("themKH", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    FormKhachHang_Load(sender, e);
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string db = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(db))
            {
                using (SqlCommand cmd = new SqlCommand("xoaKHACHHANG", cnn))
                {
                    if (MessageBox.Show("Bạn có muốn xóa khách hàng này không", "Cảnh Báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        FormKhachHang_Load(sender, e);
                        Reset();
                    }
                }
            }
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return; 
            }
            string db = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(db))
            {
                using (SqlCommand cmd = new SqlCommand("suaKHACHHANG", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    FormKhachHang_Load(sender, e);
                    Reset();
                }
            }
        }

        private void Reset()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string db = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(db))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "timKH";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtTenKH.Text);
                    cnn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataKH.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
           Reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void FormKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}

