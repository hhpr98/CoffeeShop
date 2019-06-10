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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<TaiKhoan> l;
            using (var db = new QLCafeEntities())
            {
                l = db.TaiKhoans.ToList();
            }

            var username = txtUser.Text;
            var password = txtPassword.Text;

            foreach (var item in l)
            {
                if (item.TenDangNhap==username)
                {
                    if (item.MatKhau==password)
                    {
                        this.Hide();
                        Main frmMain = new Main();
                        frmMain.FormClosed += FrmMain_FormClosed; // nếu không có event này thì khi run lại hoặc build lại thì sẽ lỗi, thì app chưa thoát hoàn toàn
                        frmMain.ShowDialog();
                        return;
                    }
                }
            }
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
