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
    public partial class Account : Form
    {
        private TaiKhoan tk;
        public Account()
        {
            InitializeComponent();
        }

        public Account(TaiKhoan t)
        {
            InitializeComponent();
            this.tk = t;
            LoadDataAccount();
        }

        private void LoadDataAccount()
        {
            using (var db = new QLCafeEntities())
            {
                var acc = db.TaiKhoans.Find(tk.MaTaiKhoan);
                txtUsername.Text = acc.TenDangNhap;
                txtPassword.Text = acc.MatKhau;
                txtUsermanagement.Text = acc.NguoiQuanLi.HoTen;
                txtAddress.Text = acc.NguoiQuanLi.DiaChi;
                txtCMND.Text = acc.NguoiQuanLi.CMND;
                txtPhoneNumber.Text = acc.NguoiQuanLi.SoDienThoai;
            }
        }

        int statusPassword = 0;
        private void btnShowHidePass_Click(object sender, EventArgs e)
        {
            if (statusPassword == 0)
            {
                statusPassword = 1;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                statusPassword = 0;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnChangedPassword_Click(object sender, EventArgs e)
        {
            if (txtNewpassword.Text!=txtRepassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewpassword.Text = txtOldpassword.Text = txtRepassword.Text = "";
                return;
            }

            using (var db = new QLCafeEntities())
            {
                var acc = db.TaiKhoans.Find(tk.MaTaiKhoan);
                if (acc.MatKhau!=txtOldpassword.Text)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewpassword.Text = txtOldpassword.Text = txtRepassword.Text = "";
                    return;
                }
                acc.MatKhau = txtNewpassword.Text;
                db.SaveChanges();
            }
            txtNewpassword.Text = txtOldpassword.Text = txtRepassword.Text = "";
            LoadDataAccount();
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
