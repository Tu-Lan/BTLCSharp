
namespace BTLCSharp
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.lbQLNV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.lbLuong = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbPhuCap = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNV
            // 
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Location = new System.Drawing.Point(12, 414);
            this.dataNV.Name = "dataNV";
            this.dataNV.RowHeadersWidth = 51;
            this.dataNV.RowTemplate.Height = 24;
            this.dataNV.Size = new System.Drawing.Size(986, 261);
            this.dataNV.TabIndex = 0;
            this.dataNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNV_CellClick);
            // 
            // lbQLNV
            // 
            this.lbQLNV.AutoSize = true;
            this.lbQLNV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLNV.Location = new System.Drawing.Point(435, 9);
            this.lbQLNV.Name = "lbQLNV";
            this.lbQLNV.Size = new System.Drawing.Size(148, 35);
            this.lbQLNV.TabIndex = 1;
            this.lbQLNV.Text = "Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGioiTinh);
            this.panel1.Controls.Add(this.txtLuong);
            this.panel1.Controls.Add(this.txtBirth);
            this.panel1.Controls.Add(this.lbLuong);
            this.panel1.Controls.Add(this.lbBirth);
            this.panel1.Controls.Add(this.txtPhuCap);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.lbPhuCap);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbSDT);
            this.panel1.Controls.Add(this.lbGioiTinh);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.lbMaSV);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 228);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cbGioiTinh.Location = new System.Drawing.Point(471, 14);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(182, 28);
            this.cbGioiTinh.TabIndex = 2;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(471, 160);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(182, 28);
            this.txtLuong.TabIndex = 1;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(140, 160);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(182, 28);
            this.txtBirth.TabIndex = 1;
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Location = new System.Drawing.Point(345, 167);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(63, 21);
            this.lbLuong.TabIndex = 0;
            this.lbLuong.Text = "Lương:";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(14, 167);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(91, 21);
            this.lbBirth.TabIndex = 0;
            this.lbBirth.Text = "Ngày Sinh:";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(471, 84);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(182, 28);
            this.txtPhuCap.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(140, 84);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(182, 28);
            this.txtTenNV.TabIndex = 1;
            // 
            // lbPhuCap
            // 
            this.lbPhuCap.AutoSize = true;
            this.lbPhuCap.Location = new System.Drawing.Point(345, 91);
            this.lbPhuCap.Name = "lbPhuCap";
            this.lbPhuCap.Size = new System.Drawing.Size(79, 21);
            this.lbPhuCap.TabIndex = 0;
            this.lbPhuCap.Text = "Phụ Cấp:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(14, 91);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(71, 21);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ Tên:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(741, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 28);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(741, 14);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(182, 28);
            this.txtSDT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên nhân viên cần tìm:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(685, 21);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(50, 21);
            this.lbSDT.TabIndex = 0;
            this.lbSDT.Text = "SĐT:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(345, 21);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(87, 21);
            this.lbGioiTinh.TabIndex = 0;
            this.lbGioiTinh.Text = "Giới Tính:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(140, 14);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(182, 28);
            this.txtMaNV.TabIndex = 1;
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(14, 21);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(120, 21);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "Mã Nhân Viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnRefesh);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(12, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 44);
            this.panel2.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(741, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 38);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(566, 0);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(87, 38);
            this.btnRefesh.TabIndex = 0;
            this.btnRefesh.Text = "Bỏ Qua";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(247, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 38);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(406, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 38);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(85, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbQLNV);
            this.Controls.Add(this.dataNV);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhanVien";
            this.Text = "Nhân Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNhanVien_FormClosed);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtSearch;

        #endregion

        private System.Windows.Forms.DataGridView dataNV;
        private System.Windows.Forms.Label lbQLNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label lbLuong;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbPhuCap;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}