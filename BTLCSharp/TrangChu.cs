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
    public partial class TrangChu : Form
    {
        private string RoleID;
        public bool isThoat = true;
        public TrangChu(string roleId)
        {
            InitializeComponent();
        }
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham sanPham = new FormSanPham();
            sanPham.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang khachHang = new FormKhachHang();
            khachHang.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien nhanVien = new FormNhanVien(RoleID);
            nhanVien.Show();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình","Cảnh báo", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
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

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDonNhap HDN = new FormHoaDonNhap();
            HDN.Show();
            this.Hide();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDonBan HDB = new FormHoaDonBan();
            HDB.Show();
            this.Hide();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiSP formLoaiSp = new FormLoaiSP();
            formLoaiSp.Show();
            this.Hide(); 
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HDN hdn = new HDN();
            hdn.Show();
            this.Hide();
        }

        private void hóaĐơnBánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HDB hdb = new HDB();
            hdb.Show();
            this.Hide();
        }

        private void báoCáoTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoHDBTheoNam bcn = new BaoCaoHDBTheoNam();
            bcn.Show();
            this.Hide();
        }
    }
}
