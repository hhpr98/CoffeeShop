using CFProject.DAO;
using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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
                var res = ExecuteCommand(command);

                if (res == 0)
                {
                    MessageBox.Show("Cài đặt database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi cài đặt database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int ExecuteCommand(string command)
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
            return ExitCode;
        }

        public int ExecuteCommand2(string command)
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
            return cmd.ExitCode;
        }

        public void doBackupDatabase()
        {
            //SqlCmd -E -S .\SQLEXPRESS –Q "BACKUP DATABASE QLCafe TO DISK='D:\backupCoffee\backup.bak'"

            // Code dưới đây cmd không hiểu tham số "BACKUP DATABASE QLCafe TO DISK='D:\\backup.bak'\" 
            //var command = "SqlCmd -E -S .\\SQLEXPRESS –Q \"BACKUP DATABASE QLCafe TO DISK='D:\\backup.bak'\"";
            //var res = ExecuteCommand2(command);

            //if (res == 0)
            //{
            //    MessageBox.Show("Backup database thành công, vị trí file : D:\\backup.bak", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Đã xảy ra lỗi khi backup database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            System.IO.Directory.CreateDirectory(@"C:\backupCoffee");
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            var query = "BACKUP DATABASE QLCafe TO DISK='C:\\backupCoffee\\backup.bak'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Backup database thành công, vị trí file : C:\\backupCoffee\\backup.bak", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void doRestoreDatabase()
        {
            //SqlCmd -E -S .\SQLEXPRESS –Q "RESTORE DATABASE QLCafe FROM DISK='D:\backup.bak'"
            System.IO.Directory.CreateDirectory(@"C:\backupCoffee");
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\backupCoffee";
            dlg.Filter = "Backup file (*.bak)|*.bak";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                var query = "RESTORE DATABASE QLCafe FROM DISK='" + dlg.FileName + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Restore database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}