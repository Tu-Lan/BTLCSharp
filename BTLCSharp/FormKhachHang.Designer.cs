
namespace BTLCSharp
{
    partial class FormKhachHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbQLKH = new System.Windows.Forms.Label();
            this.dataKH = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnRefesh);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(35, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 44);
            this.panel2.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(836, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 38);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(528, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 38);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(687, 3);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(87, 38);
            this.btnRefesh.TabIndex = 0;
            this.btnRefesh.Text = "Bỏ Qua";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(218, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 38);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(380, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 38);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(56, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.lbDiaChi);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.lbSDT);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.lbMaKH);
            this.panel1.Location = new System.Drawing.Point(35, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 228);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(648, 48);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(182, 28);
            this.txtDiaChi.TabIndex = 1;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(522, 55);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(73, 21);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa Chỉ:";
            this.lbDiaChi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(245, 114);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(182, 28);
            this.txtTenKH.TabIndex = 1;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(86, 124);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(71, 21);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ Tên:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(648, 121);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(182, 28);
            this.txtSDT.TabIndex = 1;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(533, 125);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(50, 21);
            this.lbSDT.TabIndex = 0;
            this.lbSDT.Text = "SĐT:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(245, 44);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(182, 28);
            this.txtMaKH.TabIndex = 1;
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(86, 47);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(135, 21);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã Khách Hàng:";
            // 
            // lbQLKH
            // 
            this.lbQLKH.AutoSize = true;
            this.lbQLKH.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLKH.Location = new System.Drawing.Point(458, 16);
            this.lbQLKH.Name = "lbQLKH";
            this.lbQLKH.Size = new System.Drawing.Size(176, 35);
            this.lbQLKH.TabIndex = 4;
            this.lbQLKH.Text = "Khách Hàng";
            // 
            // dataKH
            // 
            this.dataKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKH.Location = new System.Drawing.Point(35, 421);
            this.dataKH.Name = "dataKH";
            this.dataKH.RowHeadersWidth = 51;
            this.dataKH.RowTemplate.Height = 24;
            this.dataKH.Size = new System.Drawing.Size(986, 261);
            this.dataKH.TabIndex = 3;
            this.dataKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKH_CellClick);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 734);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbQLKH);
            this.Controls.Add(this.dataKH);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKhachHang";
            this.Text = "Khách Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbQLKH;
        private System.Windows.Forms.DataGridView dataKH;
        /*private System.Windows.Forms.ErrorProvider errorProvider;*/
    }
}