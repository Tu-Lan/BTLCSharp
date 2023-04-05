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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
        private void FormSanPham_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblSanPham", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataSP.DataSource = dt;
                    }
                    dataSP.Columns[0].HeaderText = "Mã Sản Phẩm";
                    dataSP.Columns[1].HeaderText = "Mã Loại SP";
                    dataSP.Columns[2].HeaderText = "Tên Sản Phẩm";
                    dataSP.Columns[3].HeaderText = "Mã Nhà CC";
                    dataSP.Columns[4].HeaderText = "Hãng Sản Xuất";
                    dataSP.Columns[5].HeaderText = "Màu sắc";
                    dataSP.Columns[6].HeaderText = "Dung Tích";
                    dataSP.Columns[7].HeaderText = "Số Lượng";
                    dataSP.Columns[8].HeaderText = "Giá Hàng";
                }
            }
        }

        private void btnOpenPic_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "themSP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text);
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
                    cmd.Parameters.AddWithValue("@Mausac", txtMauSac.Text);
                    cmd.Parameters.AddWithValue("@DungTich", txtDungTich.Text);
                    cmd.Parameters.AddWithValue("@Soluong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@Giahang", txtGia.Text);
                    cmd.Parameters.AddWithValue("@HangSX", txtHangSX.Text);

                    using (SqlCommand check = new SqlCommand("select * from tblSanPham where sMaSP=@MaSP", cnn))
                    {
                        check.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                        bool KT = false;
                        cnn.Open();
                        using (SqlDataReader reader = check.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (txtMaSP.Text == reader.GetString(reader.GetOrdinal("sMaSP")))
                                {
                                    MessageBox.Show("Mã sản phẩm này đã tồn tại. Mời nhập mã khác");
                                    KT = true;
                                }
                            }
                            reader.Close();
                        }
                        if (KT == false)
                        {
                            cmd.ExecuteNonQuery();
                            FormSanPham_Load(sender, e);
                        }
                    }
                }
            }
        }
        private void dataSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dataSP.CurrentRow.Index;
            txtMaSP.Text = dataSP.Rows[i].Cells[0].Value.ToString();
            txtMaLoaiSP.Text = dataSP.Rows[i].Cells[1].Value.ToString();
            txtTenSP.Text = dataSP.Rows[i].Cells[2].Value.ToString();
            txtMaNCC.Text = dataSP.Rows[i].Cells[3].Value.ToString();
            txtHangSX.Text = dataSP.Rows[i].Cells[4].Value.ToString();
            txtMauSac.Text = dataSP.Rows[i].Cells[5].Value.ToString();
            txtDungTich.Text = dataSP.Rows[i].Cells[6].Value.ToString();
            txtSoLuong.Text = dataSP.Rows[i].Cells[7].Value.ToString();
            txtGia.Text = dataSP.Rows[i].Cells[8].Value.ToString();
        }

        public void reset()
        {
            txtMauSac.Text = "";
            txtMaSP.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            txtDungTich.Text = "";
            txtHangSX.Text = "";
            txtMaLoaiSP.Text = "";
            txtMaNCC.Text = "";
            txtTenSP.Text = "";
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
                            cmd.CommandText = "xoaSP";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            FormSanPham_Load(sender, e);
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
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SuaSP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text);
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
                    cmd.Parameters.AddWithValue("@Mausac", txtMauSac.Text);
                    cmd.Parameters.AddWithValue("@DungTich", txtDungTich.Text);
                    cmd.Parameters.AddWithValue("@Soluong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@Giahang", txtGia.Text);
                    cmd.Parameters.AddWithValue("@HangSX", txtHangSX.Text);
                    conn.Open();
                    Convert.ToString( cmd.ExecuteNonQuery());
                    FormSanPham_Load(sender, e);
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
        public DataTable TimKiemSanPham(string maSP, string tenSP)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("TimKiemSanPham", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (!string.IsNullOrEmpty(maSP))
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                else
                    cmd.Parameters.AddWithValue("@MaSP", DBNull.Value);

                if (!string.IsNullOrEmpty(tenSP))
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                else
                    cmd.Parameters.AddWithValue("@TenSP", DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();

            DataTable dt = TimKiemSanPham(maSP, tenSP);
            dataSP.DataSource = dt;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không","Cảnh báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                this.Close();
        }
    }
}
