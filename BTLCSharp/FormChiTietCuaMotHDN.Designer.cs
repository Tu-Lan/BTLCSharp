using System.ComponentModel;

namespace BTLCSharp
{
    partial class FormChiTietCuaMotHDN
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.lbMaHDN = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(158, 26);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(467, 39);
            this.lbTieuDe.TabIndex = 1;
            this.lbTieuDe.Text = "Chi Tiết Hóa Đơn Của Một Hóa Đơn Nhập";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(144, 334);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(153, 25);
            this.txtMaHDN.TabIndex = 2;
            // 
            // lbMaHDN
            // 
            this.lbMaHDN.AutoSize = true;
            this.lbMaHDN.Location = new System.Drawing.Point(12, 342);
            this.lbMaHDN.Name = "lbMaHDN";
            this.lbMaHDN.Size = new System.Drawing.Size(126, 17);
            this.lbMaHDN.TabIndex = 3;
            this.lbMaHDN.Text = "Mã Hóa Đơn Nhập:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(144, 411);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(153, 25);
            this.txtMaNV.TabIndex = 2;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(12, 419);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(98, 17);
            this.lbMaNV.TabIndex = 3;
            this.lbMaNV.Text = "Mã Nhân Viên:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(431, 334);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(153, 25);
            this.txtGia.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(431, 411);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(153, 25);
            this.txtSoLuong.TabIndex = 2;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(360, 337);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(31, 17);
            this.lbGia.TabIndex = 3;
            this.lbGia.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Lượng:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(642, 97);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(642, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Trờ về";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(642, 281);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormChiTietCuaMotHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbMaHDN);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormChiTietCuaMotHDN";
            this.Text = "FormChiTietCuaMotHDN";
            this.Load += new System.EventHandler(this.FormChiTietCuaMotHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.TextBox txtMaHDN;

        private System.Windows.Forms.Label lbTieuDe;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion

        private System.Windows.Forms.Label lbMaHDN;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label label1;
    }
}