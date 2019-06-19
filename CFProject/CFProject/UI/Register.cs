using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFProject
{
    public partial class Register : Form
    {
        private TaiKhoan tk;
        public Register()
        {
            InitializeComponent();
        }

        public Register(TaiKhoan t)
        {
            InitializeComponent();
            this.tk = t;
        }

        Random r = new Random();
        List<string> authList = new List<string>() { "krk35d", "1jdj34", "ha0z34", "d6m31a", "vk1l2k", "p1o3ra" };
        private string authString = "";
        private void Register_Load(object sender, EventArgs e)
        {
            authString = authList[r.Next(authList.Count())];
            lblAuth.Text = authString;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            authString = authList[r.Next(authList.Count())];
            lblAuth.Text = authString;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRepassword.Text)
            {
                MessageBox.Show("Mật khẩu không khớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAuth.Text != authString)
            {
                MessageBox.Show("Mã xác thực không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                authString = authList[r.Next(authList.Count())];
                lblAuth.Text = authString;
                return;
            }

            using (var db = new QLCafeEntities())
            {
                var checkAcc = db.TaiKhoans.Where(a => a.TenDangNhap.ToLower() == txtUser.Text.ToLower()).ToList();
                if (checkAcc.Count()>0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = txtUser.Text, MatKhau = txtPassword.Text, MaNQL = tk.MaNQL, isDeleted = 0 });
                db.SaveChanges();
                MessageBox.Show("Đăng kí tài khoản thành công ! Bạn có thể sử dụng tài khoản này để đăng nhập lần sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
