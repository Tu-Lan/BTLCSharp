using System.ComponentModel;

namespace BTLCSharp
{
    partial class FormHoaDonBan
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaHDB = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.txtNgayGiao = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbNgayDat = new System.Windows.Forms.Label();
            this.lbNgayGiao = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(838, 513);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 38);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(838, 434);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 38);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(838, 343);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 38);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(838, 255);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 38);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(838, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 38);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbMaKH
            // 
            this.lbMaKH.Location = new System.Drawing.Point(48, 493);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(140, 17);
            this.lbMaKH.TabIndex = 31;
            this.lbMaKH.Text = "Mã Khách Hàng:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Location = new System.Drawing.Point(48, 436);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(140, 17);
            this.lbMaNV.TabIndex = 28;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "HÓA ĐƠN BÁN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(638, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nhập mã hóa đơn cần tìm:";
            // 
            // lbMaHDB
            // 
            this.lbMaHDB.Location = new System.Drawing.Point(48, 387);
            this.lbMaHDB.Name = "lbMaHDB";
            this.lbMaHDB.Size = new System.Drawing.Size(140, 17);
            this.lbMaHDB.TabIndex = 29;
            this.lbMaHDB.Text = "Mã Hóa Đơn Bán:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(194, 490);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(165, 25);
            this.txtMaKH.TabIndex = 24;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(194, 428);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(165, 25);
            this.txtMaNV.TabIndex = 23;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(638, 424);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 25);
            this.txtSearch.TabIndex = 26;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(194, 379);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(165, 25);
            this.txtMaHDB.TabIndex = 25;
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(460, 379);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(165, 25);
            this.txtNgayDat.TabIndex = 25;
            // 
            // txtNgayGiao
            // 
            this.txtNgayGiao.Location = new System.Drawing.Point(460, 428);
            this.txtNgayGiao.Name = "txtNgayGiao";
            this.txtNgayGiao.Size = new System.Drawing.Size(165, 25);
            this.txtNgayGiao.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(460, 485);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(165, 25);
            this.txtDiaChi.TabIndex = 24;
            // 
            // lbNgayDat
            // 
            this.lbNgayDat.Location = new System.Drawing.Point(368, 387);
            this.lbNgayDat.Name = "lbNgayDat";
            this.lbNgayDat.Size = new System.Drawing.Size(86, 17);
            this.lbNgayDat.TabIndex = 29;
            this.lbNgayDat.Text = "Ngày Đặt:";
            // 
            // lbNgayGiao
            // 
            this.lbNgayGiao.Location = new System.Drawing.Point(368, 434);
            this.lbNgayGiao.Name = "lbNgayGiao";
            this.lbNgayGiao.Size = new System.Drawing.Size(86, 17);
            this.lbNgayGiao.TabIndex = 28;
            this.lbNgayGiao.Text = "Ngày Giao:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Location = new System.Drawing.Point(368, 493);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(86, 17);
            this.lbDiaChi.TabIndex = 31;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // FormHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 578);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.lbNgayGiao);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNgayDat);
            this.Controls.Add(this.lbMaHDB);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtNgayGiao);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtNgayDat);
            this.Controls.Add(this.txtMaHDB);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormHoaDonBan";
            this.Text = "Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.FormHoaDonBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.TextBox txtNgayGiao;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbNgayDat;
        private System.Windows.Forms.Label lbNgayGiao;
        private System.Windows.Forms.Label lbDiaChi;

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaHDB;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtMaHDB;

        #endregion
    }
}