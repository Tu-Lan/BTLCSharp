
namespace BTLCSharp
{
    partial class BaoCaoHDBTheoNam
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
            this.ReportViewHDB = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lbThang = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbMakH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReportViewHDB
            // 
            this.ReportViewHDB.ActiveViewIndex = -1;
            this.ReportViewHDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewHDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewHDB.Location = new System.Drawing.Point(0, 149);
            this.ReportViewHDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportViewHDB.Name = "ReportViewHDB";
            this.ReportViewHDB.Size = new System.Drawing.Size(1290, 413);
            this.ReportViewHDB.TabIndex = 0;
            this.ReportViewHDB.ToolPanelWidth = 250;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(115, 12);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(171, 28);
            this.txtThang.TabIndex = 1;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(115, 64);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(171, 28);
            this.txtNam.TabIndex = 1;
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(32, 19);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(57, 21);
            this.lbThang.TabIndex = 2;
            this.lbThang.Text = "Tháng";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(32, 71);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(45, 21);
            this.lbNam.TabIndex = 2;
            this.lbNam.Text = "Năm";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(310, 14);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(80, 35);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(115, 114);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(171, 28);
            this.txtMaKH.TabIndex = 1;
            // 
            // lbMakH
            // 
            this.lbMakH.AutoSize = true;
            this.lbMakH.Location = new System.Drawing.Point(32, 121);
            this.lbMakH.Name = "lbMakH";
            this.lbMakH.Size = new System.Drawing.Size(69, 21);
            this.lbMakH.TabIndex = 2;
            this.lbMakH.Text = "Mã KH:";
            // 
            // BaoCaoHDBTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 562);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lbMakH);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.ReportViewHDB);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaoCaoHDBTheoNam";
            this.Text = "BaoCaoHDBTheoNam";
            this.Load += new System.EventHandler(this.BaoCaoHDBTheoNam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewHDB;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lbMakH;
    }
}