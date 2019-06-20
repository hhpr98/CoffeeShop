using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFProject.DAO
{
    class TableDAO
    {
        #region forMainScreen
        public List<BanAn> getAllTable()
        {
            using (var db = new QLCafeEntities())
            {
                return db.BanAns.ToList();
            }
        }

        public List<ChiTietBanAnClass> getTableDetailyByID(int id)
        {
            using (var db = new QLCafeEntities())
            {
                var lt =  db.ChiTietBanAns.Where(t => t.MaBan == id).ToList();
                List<ChiTietBanAnClass> listTable = new List<ChiTietBanAnClass>();
                foreach (var index in lt)
                {
                    listTable.Add(new ChiTietBanAnClass() { MaSanPham = index.MaSanPham, TenSanPham = index.SanPham.TenSanPham, SoLuong = (int)index.SoLuong, DonGia = (double)index.DonGia });
                }
                return listTable;
            }
        }

        public BanAn findTableByID(int id)
        {
            using (var db = new QLCafeEntities())
            {
                return db.BanAns.Find(id);
            }
        }

        public void updateTableStatus(int tableFrom,int tableTo)
        {
            using (var db = new QLCafeEntities())
            {
                var tableSwitch = db.BanAns.Find(tableTo);
                var tableIndex = db.BanAns.Find(tableFrom);
                tableSwitch.TinhTrang = "Có người"; // cập nhật bàn mới có người
                tableIndex.TinhTrang = "Trống"; // cập nhật bàn cũ trống
                foreach (var index in db.ChiTietBanAns) // chuyển món ăn bàn cũ sang bàn mới
                {
                    if (index.MaBan == tableFrom)
                    {
                        index.MaBan = tableTo;
                    }
                }
                db.SaveChanges();
            }
        }
        #endregion
    }
}
