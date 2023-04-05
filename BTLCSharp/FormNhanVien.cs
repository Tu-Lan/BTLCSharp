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
    public partial class FormNhanVien : Form
    {
        private string RoleID;
        public FormNhanVien(string roleID)
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblNhanVien", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataNV.DataSource = dt;
                    }
                    dataNV.Columns[0].HeaderText = "Mã Nhân Viên";
                    dataNV.Columns[1].HeaderText = "Tên Nhân Viên";
                    dataNV.Columns[2].HeaderText = "Ngày Sinh";
                    dataNV.Columns[3].HeaderText = "Giới Tính";
                    dataNV.Columns[4].HeaderText = "Phụ Cấp";
                    dataNV.Columns[5].HeaderText = "Lương Cơ Bản";
                    dataNV.Columns[6].HeaderText = "Số Điện Thoại";
                }
            }

            if (RoleID == "USER1")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }else if (RoleID == "ADMINMP")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
        private bool kiemtra()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return false;
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            if (txtPhuCap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập phụ cấp nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhuCap.Focus();
                return false;
            }
            if (txtLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lương nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLuong.Focus();
                return false;
            }
            if (txtBirth.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBirth.Focus();
                return false;
            }
            return true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                try
                {
                    string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "themNV";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@iMaNV", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@sHoTen", txtTenNV.Text);
                            cmd.Parameters.AddWithValue("@dNgaySinh", txtBirth.Text);
                            cmd.Parameters.AddWithValue("@sGioiTinh", cbGioiTinh.Text);
                            cmd.Parameters.AddWithValue("@fPhuCap", txtPhuCap.Text);
                            cmd.Parameters.AddWithValue("@fLuongCB", txtLuong.Text);
                            cmd.Parameters.AddWithValue("@sDienThoai", txtSDT.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            FormNhanVien_Load(sender, e);
                            MessageBox.Show("Thêm Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataNV.CurrentRow.Index;
            txtMaNV.Text = dataNV.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dataNV.Rows[i].Cells[1].Value.ToString();
            txtBirth.Text = dataNV.Rows[i].Cells[2].Value.ToString();
            cbGioiTinh.Text = dataNV.Rows[i].Cells[3].Value.ToString();
            txtPhuCap.Text = dataNV.Rows[i].Cells[4].Value.ToString();
            txtLuong.Text = dataNV.Rows[i].Cells[5].Value.ToString();
            txtSDT.Text = dataNV.Rows[i].Cells[6].Value.ToString();
        }
        public void reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtLuong.Text = "";
            txtPhuCap.Text = "";
            txtSDT.Text = "";
            txtBirth.Text = "";
            cbGioiTinh.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        if(MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo)== DialogResult.Yes)
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "XoaNhanVien";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            FormNhanVien_Load(sender, e);
                            reset();
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (txtBirth.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBirth.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return;
            }
            if (this.cbGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGioiTinh.Focus();
                return;
            }
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    cmd.Connection = conn;
                    cmd.CommandText = "suaNV";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@iMaNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@sHoTen", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@dNgaySinh", txtBirth.Text);
                    cmd.Parameters.AddWithValue("@sGioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@fPhuCap", txtPhuCap.Text);
                    cmd.Parameters.AddWithValue("@fLuongCB", txtLuong.Text);
                    cmd.Parameters.AddWithValue("@sDienThoai", txtSDT.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    FormNhanVien_Load(sender, e);
                    reset();
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
        public DataTable btnTimKiem(string iMaNV)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("timNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iMaNV", iMaNV);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string iMaNV = txtMaNV.Text;
            DataTable dt = btnTimKiem(iMaNV);
            dataNV.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                FormNhanVien_Load(sender, e);
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
                SqlDataAdapter adt = new SqlDataAdapter("Select * from tblNHANVIEN where sHoTen like '%" + txtSearch.Text + "%'", connectionString);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataNV.DataSource = dt;
            }
            
        }
        
        private void btnRefesh_Click(object sender, EventArgs e)
        {
           reset();
           FormNhanVien_Load(sender,e);
        }

        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
