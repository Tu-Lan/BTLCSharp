using System.ComponentModel;

namespace BTLCSharp
{
    partial class FormLoaiSP
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
            this.dataLoaiSP = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNgayDat = new System.Windows.Forms.Label();
            this.lbMaLoaiSP = new System.Windows.Forms.Label();
            this.txtTenLSP = new System.Windows.Forms.TextBox();
            this.txtMaLSP = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLoaiSP
            // 
            this.dataLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoaiSP.Location = new System.Drawing.Point(34, 85);
            this.dataLoaiSP.Name = "dataLoaiSP";
            this.dataLoaiSP.RowTemplate.Height = 24;
            this.dataLoaiSP.Size = new System.Drawing.Size(770, 250);
            this.dataLoaiSP.TabIndex = 49;
            this.dataLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLoaiSP_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(824, 252);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 38);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(824, 164);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 38);
            this.btnSua.TabIndex = 48;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(824, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 38);
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 33);
            this.label2.TabIndex = 42;
            this.label2.Text = "LOẠI SẢN PHẨM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(468, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nhập mã hóa đơn cần tìm:";
            // 
            // lbNgayDat
            // 
            this.lbNgayDat.Location = new System.Drawing.Point(243, 374);
            this.lbNgayDat.Name = "lbNgayDat";
            this.lbNgayDat.Size = new System.Drawing.Size(165, 29);
            this.lbNgayDat.TabIndex = 44;
            this.lbNgayDat.Text = "Tên Loại Sản Phẩm:";
            // 
            // lbMaLoaiSP
            // 
            this.lbMaLoaiSP.Location = new System.Drawing.Point(29, 374);
            this.lbMaLoaiSP.Name = "lbMaLoaiSP";
            this.lbMaLoaiSP.Size = new System.Drawing.Size(165, 17);
            this.lbMaLoaiSP.TabIndex = 43;
            this.lbMaLoaiSP.Text = "Mã Loại Sản Phẩm:";
            // 
            // txtTenLSP
            // 
            this.txtTenLSP.Location = new System.Drawing.Point(243, 406);
            this.txtTenLSP.Name = "txtTenLSP";
            this.txtTenLSP.Size = new System.Drawing.Size(165, 28);
            this.txtTenLSP.TabIndex = 41;
            this.txtTenLSP.TextChanged += new System.EventHandler(this.txtNgayDat_TextChanged);
            // 
            // txtMaLSP
            // 
            this.txtMaLSP.Location = new System.Drawing.Point(29, 403);
            this.txtMaLSP.Name = "txtMaLSP";
            this.txtMaLSP.Size = new System.Drawing.Size(165, 28);
            this.txtMaLSP.TabIndex = 40;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(961, 164);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 38);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(961, 85);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 38);
            this.btnReset.TabIndex = 50;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(468, 406);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(306, 28);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtNgayDat_TextChanged);
            // 
            // FormLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 449);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dataLoaiSP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNgayDat);
            this.Controls.Add(this.lbMaLoaiSP);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTenLSP);
            this.Controls.Add(this.txtMaLSP);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLoaiSP";
            this.Text = "Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.FormLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.DataGridView dataLoaiSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNgayDat;
        private System.Windows.Forms.Label lbMaLoaiSP;
        private System.Windows.Forms.TextBox txtTenLSP;
        private System.Windows.Forms.TextBox txtMaLSP;

        #endregion
    }
}