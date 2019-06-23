using CFProject.DAO;
using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void doInstallDatabase()
        {
            //sqlcmd -S .\SQLEXPRESS -i C:\git\CoffeeShop\db23062019.sql

            var command = @"sqlcmd -S .\SQLEXPRESS -i ";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\git\CoffeeShop";
            dlg.Filter = "Database file (*.sql)|*.sql";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                command = command + dlg.FileName;
                ExecuteCommand(command);
            }
        }


        public void ExecuteCommand(string command)
        {
            int ExitCode;
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = false;

            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();

            ExitCode = Process.ExitCode;
            Process.Close();

            //MessageBox.Show("ExitCode: " + ExitCode.ToString(), "ExecuteCommand");
            if (ExitCode == 0)
            {
                MessageBox.Show("Cài đặt database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi cài đặt database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExecuteCommand2(string command) // cách này cũng ok nhưng không trả về exitcode
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            /* execute "commandline" */

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
    }
}
