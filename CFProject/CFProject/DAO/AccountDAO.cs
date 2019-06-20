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
    }
}
