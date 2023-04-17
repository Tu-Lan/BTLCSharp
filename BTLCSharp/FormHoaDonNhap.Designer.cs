using System.ComponentModel;

namespace BTLCSharp
{
    partial class FormHoaDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataHDN = new System.Windows.Forms.DataGridView();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(159, 368);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(165, 29);
            this.txtMaHDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Hóa Đơn Nhập:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(159, 417);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(165, 29);
            this.txtMaNV.TabIndex = 1;
            // 
            // lbMaNV
            // 
            this.lbMaNV.Location = new System.Drawing.Point(13, 425);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(140, 17);
            this.lbMaNV.TabIndex = 3;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.Location = new System.Drawing.Point(13, 482);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(140, 17);
            this.lbNgayNhap.TabIndex = 3;
            this.lbNgayNhap.Text = "Ngày Nhập";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "HÓA ĐƠN NHẬP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(593, 78);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(161, 40);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem Chi Tiết Hóa Đơn";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(610, 156);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 38);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(610, 235);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 38);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(610, 323);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 38);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(610, 414);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 38);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(610, 493);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(348, 476);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(348, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập mã hóa đơn cần tìm:";
            // 
            // dataHDN
            // 
            this.dataHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHDN.Location = new System.Drawing.Point(15, 87);
            this.dataHDN.Name = "dataHDN";
            this.dataHDN.RowTemplate.Height = 24;
            this.dataHDN.Size = new System.Drawing.Size(572, 250);
            this.dataHDN.TabIndex = 6;
            this.dataHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHDN_CellClick_1);
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(159, 479);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(165, 29);
            this.txtNgayNhap.TabIndex = 1;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            this.cbTrangThai.Location = new System.Drawing.Point(348, 395);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(156, 29);
            this.cbTrangThai.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(348, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Trạng Thái";
            // 
            // FormHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 543);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataHDN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lbNgayNhap);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgayNhap);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtMaHDN);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormHoaDonNhap";
            this.Text = "Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.FormHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtNgayNhap;

        private System.Windows.Forms.DataGridView dataHDN;

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}