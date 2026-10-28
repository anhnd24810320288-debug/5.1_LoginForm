
using System;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace LoginForm41
{
    public partial class Form1 : Form
    {
        private readonly string duongDanCSDL =
            Path.Combine(Application.StartupPath, "ql_dangnhap.db");

        private string ChuoiKetNoi =>
            $"Data Source={duongDanCSDL}";

        public Form1()
        {
            InitializeComponent();

            AcceptButton = btnLogin;
            CancelButton = btnExit;

            try
            {
                KhoiTaoCSDL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể khởi tạo cơ sở dữ liệu:\n" + ex.Message,
                    "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            chkShowPassword.CheckedChanged +=
                chkShowPassword_CheckedChanged;

            btnLogin.Click += btnLogin_Click;
            btnExit.Click += btnExit_Click;

            txtUsername.TextChanged += txtUsername_TextChanged;
            txtPassword.TextChanged += txtPassword_TextChanged;
        }

        private void KhoiTaoCSDL()
        {
            using var ketNoi = new SqliteConnection(ChuoiKetNoi);
            ketNoi.Open();

            string taoBang = @"
                CREATE TABLE IF NOT EXISTS TaiKhoan
                (
                    TenDangNhap TEXT PRIMARY KEY,
                    MatKhau TEXT NOT NULL
                );";

            using var lenhTaoBang =
                new SqliteCommand(taoBang, ketNoi);

            lenhTaoBang.ExecuteNonQuery();

            string themTaiKhoan = @"
                INSERT OR IGNORE INTO TaiKhoan
                (TenDangNhap, MatKhau)
                VALUES
                ('admin', '123456'),
                ('user', '123456');";

            using var lenhThemTaiKhoan =
                new SqliteCommand(themTaiKhoan, ketNoi);

            lenhThemTaiKhoan.ExecuteNonQuery();
        }

        private bool KiemTraDuLieu()
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(
                    txtUsername,
                    "Vui lòng nhập tên đăng nhập.");

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(
                    txtPassword,
                    "Vui lòng nhập mật khẩu.");

                hopLe = false;
            }

            return hopLe;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            try
            {
                using var ketNoi =
                    new SqliteConnection(ChuoiKetNoi);

                ketNoi.Open();

                string sql = @"
                    SELECT COUNT(*)
                    FROM TaiKhoan
                    WHERE TenDangNhap = @ten
                    AND MatKhau = @matKhau;";

                using var lenh =
                    new SqliteCommand(sql, ketNoi);

                lenh.Parameters.AddWithValue(
                    "@ten", txtUsername.Text.Trim());

                lenh.Parameters.AddWithValue(
                    "@matKhau", txtPassword.Text);

                long soLuong = (long)lenh.ExecuteScalar();

                if (soLuong > 0)
                {
                    MessageBox.Show(
                        "Đăng nhập thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Tên đăng nhập hoặc mật khẩu không đúng!",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi đăng nhập:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        private void txtUsername_TextChanged(
            object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsername, "");
        }

        private void txtPassword_TextChanged(
            object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassword, "");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
