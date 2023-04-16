using System.ComponentModel;

namespace BTLCSharp
{
    partial class FormChiTietCuaMotHDB
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbMaHDB = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.dataHDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(678, 289);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(678, 197);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Trờ về";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(678, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Location = new System.Drawing.Point(48, 427);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(118, 21);
            this.lbMaSP.TabIndex = 12;
            this.lbMaSP.Text = "Mã Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số Lượng:";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(396, 345);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(40, 21);
            this.lbGia.TabIndex = 14;
            this.lbGia.Text = "Giá:";
            // 
            // lbMaHDB
            // 
            this.lbMaHDB.AutoSize = true;
            this.lbMaHDB.Location = new System.Drawing.Point(48, 350);
            this.lbMaHDB.Name = "lbMaHDB";
            this.lbMaHDB.Size = new System.Drawing.Size(142, 21);
            this.lbMaHDB.TabIndex = 11;
            this.lbMaHDB.Text = "Mã Hóa Đơn Bán";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(467, 419);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(153, 29);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(196, 424);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(153, 29);
            this.txtMaSP.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(467, 342);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(153, 29);
            this.txtGia.TabIndex = 10;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(196, 345);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(153, 29);
            this.txtMaHDB.TabIndex = 9;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(147, 29);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(500, 39);
            this.lbTieuDe.TabIndex = 6;
            this.lbTieuDe.Text = "Chi Tiết Hóa Đơn Của Một Hóa Đơn Bán";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataHDB
            // 
            this.dataHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHDB.Location = new System.Drawing.Point(48, 105);
            this.dataHDB.Name = "dataHDB";
            this.dataHDB.RowTemplate.Height = 24;
            this.dataHDB.Size = new System.Drawing.Size(572, 216);
            this.dataHDB.TabIndex = 5;
            this.dataHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHDB_CellClick);
            // 
            // FormChiTietCuaMotHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbMaSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbMaHDB);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMaHDB);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.dataHDB);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormChiTietCuaMotHDB";
            this.Text = "FormChiTietCuaMotHDB";
            this.Load += new System.EventHandler(this.FormChiTietCuaMotHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbMaHDB;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.DataGridView dataHDB;

        #endregion
    }
}