using CFProject.DAO;
using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFProject.BUS
{
    class LoginBUS
    {
        public TaiKhoan checkLogin(string user,string pass)
        {
            var l = new AccountDAO().getListAccount();

            foreach (var item in l)
            {
                if (item.TenDangNhap == user)
                {
                    if (item.MatKhau == pass)
                    {
                        return item; // trả về tài khoản
                    }
                }
            }
            return new TaiKhoan() { TenDangNhap = "" }; // trả về tài khoản rỗng => tức là đăng nhập thất bại
        }

        //Main frmMain = new Main(item);
        //this.Hide();
        ////frmMain.FormClosed += FrmMain_FormClosed; // nếu không có event này thì khi run lại hoặc build lại thì sẽ lỗi, thì app chưa thoát hoàn toàn
        //frmMain.ShowDialog();
        //this.Show();

        //private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
