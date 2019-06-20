using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFProject.DAO
{
    class AccountDAO
    {
        #region forAccountScreen
        public TaiKhoan findAccountByID(int id)
        {
            using (var db = new QLCafeEntities())
            {
                return db.TaiKhoans.Find(id);
            }
        }

        public NguoiQuanLi findManager(int id)
        {
            using (var db = new QLCafeEntities())
            {
                return db.TaiKhoans.Find(id).NguoiQuanLi;
            }
        }

        public void changePassword(int id,string pass)
        {
            using (var db = new QLCafeEntities())
            {
                var acc = db.TaiKhoans.Find(id);
                acc.MatKhau = pass;
                db.SaveChanges();
            }
        }
        #endregion

        #region forLoginScreen
        public List<TaiKhoan> getListAccount()
        {
            using (var db = new QLCafeEntities())
            {
                return db.TaiKhoans.ToList();
            }
        }
        #endregion

        #region forRegisterScreen
        public List<TaiKhoan> listAccountSame(string user)
        {
            using (var db = new QLCafeEntities())
            {
                return db.TaiKhoans.Where(a => a.TenDangNhap.ToLower() == user.ToLower()).ToList();
            }
        }

        public void registerNewAccount(string user,string pass,int manager)
        {
            using (var db = new QLCafeEntities())
            {
                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = user, MatKhau = pass, MaNQL = manager, isDeleted = 0 });
                db.SaveChanges();
            }
        }
        #endregion
    }
}
