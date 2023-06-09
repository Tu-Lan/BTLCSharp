﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string constr = ConfigurationManager.ConnectionStrings["QLMP"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();
                string query = "SELECT u.ID, u.RoleID, r.Name FROM tblUsers u INNER JOIN tblRoles r ON u.RoleID = r.ID WHERE Username = @Username AND Passwords = @Passwords";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Passwords", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string userID = reader.GetString(0);
                    string roleID = reader.GetString(1);
                    string roleName = reader.GetString(2);

                    // Phân quyền
                    if (roleName == "ADMINMP")
                    {
                        // Hiển thị giao diện quản trị
                        TrangChu adminForm = new TrangChu(roleID);
                        adminForm.Show();
                        this.Hide();
                        MessageBox.Show("Bạn đang đăng nhập với tài khoản admin","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else if (roleName == "USER1")
                    {
                        // Hiển thị giao diện khách hàng
                        TrangChu adminForm = new TrangChu(roleID);
                        adminForm.Show();
                        this.Hide();
                        MessageBox.Show("Bạn đang đăng nhập với tài khoản nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Hiển thị thông báo lỗi
                        MessageBox.Show("Không có chức vụ này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi tài khoản và mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.No)
            {
                
            }
        }
    }
}
