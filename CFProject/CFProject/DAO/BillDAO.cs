using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFProject.DAO
{
    class BillDAO
    {
        public HoaDon findBillByID(int id)
        {
            using (var db = new QLCafeEntities())
            {
                return db.HoaDons.Find(id);
            }
        }

        public List<ChiTietHoaDon> findBillDetailByID(int id)
        {
            using (var db = new QLCafeEntities())
            {
                return db.ChiTietHoaDons.Where(d => d.MaHoaDon == id).ToList();
            }
        }
    }
}
