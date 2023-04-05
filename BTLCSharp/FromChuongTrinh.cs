using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormChuongTrinh : Form
    {
        private string RoleID;
        public bool isThoat = true;
        public FormChuongTrinh(string roleId)
        {
            InitializeComponent();
        }
        
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void FormChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.Show();
                this.Hide();
            }

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormNhanVien formNhanVien = new FormNhanVien(RoleID);
            formNhanVien.Show();            
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham formSanPham = new FormSanPham();
            formSanPham.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.Show();
        }
    }
}
