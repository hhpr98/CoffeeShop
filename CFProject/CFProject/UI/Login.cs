using CFProject.BUS;
using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Bitmap avt = new Bitmap(Application.StartupPath + "\\Resources\\avatar.jpg");
            pbAvatar.Image = avt;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnInstallDB, "Cài đặt CSDL");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUser.Text;
            var password = txtPassword.Text;
            var res = new LoginBUS().checkLogin(username, password);
            if (res.TenDangNhap != "")
            {
                Main frmMain = new Main(res);
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
                txtUser.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
               txtPassword.UseSystemPasswordChar = false;
               //txtPassword.PasswordChar = '\0';
            }
            else
            {
                //char c = '•';
                //char c = (char)0x2022;// or 0x25cf depending on the one you choose
                //char c = '\u2022';// or "\u25cf"
                //txtPassword.PasswordChar = c;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnInstallDB_Click(object sender, EventArgs e)
        {
            new LoginBUS().doInstallDatabase();
        }
    }
}
