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
        #region forDetailScreen
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
        #endregion

        #region forMainScreen
        public int addBill(HoaDon bill)
        {
            using (var db = new QLCafeEntities())
            {
                db.HoaDons.Add(bill);
                db.SaveChanges();
                //MessageBox.Show(bill.MaHoaDon.ToString());
                return bill.MaHoaDon;
            }
        }
        #endregion
    }
}
