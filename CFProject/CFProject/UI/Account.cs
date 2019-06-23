using CFProject.BUS;
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
            var acc = new AccountBUS().findAccountByID(tk.MaTaiKhoan);
            var man = new AccountBUS().findManager(tk.MaTaiKhoan);
            txtUsername.Text = acc.TenDangNhap;
            txtPassword.Text = acc.MatKhau;
            txtUsermanagement.Text = man.HoTen;
            txtAddress.Text = man.DiaChi;
            txtCMND.Text = man.CMND;
            txtPhoneNumber.Text = man.SoDienThoai;
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
            // check double password
            if (txtNewpassword.Text!=txtRepassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewpassword.Text = txtOldpassword.Text = txtRepassword.Text = "";
                return;
            }

            // check old password is correct ??
            var acc = new AccountBUS().findAccountByID(tk.MaTaiKhoan);
            if (acc.MatKhau != txtOldpassword.Text)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewpassword.Text = txtOldpassword.Text = txtRepassword.Text = "";
                return;
            }

            // Changed password
            new AccountBUS().changePassword(tk.MaTaiKhoan,txtNewpassword.Text);
            
            // reset data text
            txtNewpassword.Text = txtOldpassword.Text = txtRepassword.Text = "";
            LoadDataAccount();
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
