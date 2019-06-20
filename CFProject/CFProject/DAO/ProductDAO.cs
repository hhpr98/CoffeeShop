using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFProject.DAO
{
    class ProductDAO
    {
        #region forDetailScreen
        public SanPham findProductByID(int id)
        {
            using (var db = new QLCafeEntities())
            {
                return db.SanPhams.Find(id);
            }
        }
        #endregion

        #region forMainScreen
        public List<NhomSanPham> getAllCategory()
        {
            using (var db = new QLCafeEntities())
            {
                return db.NhomSanPhams.Where(c => c.isDeleted == 0).ToList();
            }
        }

        public List<SanPham> getProductByCategoryName(string cname)
        {
            using (var db = new QLCafeEntities())
            {
                var l = db.NhomSanPhams.Where(c => c.isDeleted == 0 && c.TenNhom == cname).ToList();
                var cid = l[0].MaNhom;
                return db.SanPhams.Where(p => p.isDeleted == 0 && p.MaNhom == cid).ToList();
            }
        }

        public SanPham findProductByName(string pname)
        {
            using (var db = new QLCafeEntities())
            {
                var lp = db.SanPhams.Where(p => p.isDeleted == 0 && p.TenSanPham == pname).ToList();
                var product = lp[0];
                return product;
            }
        }

        public void updateProductDetail(int tableId,SanPham product,int numProduct)
        {
            using (var db = new QLCafeEntities())
            {
                db.ChiTietBanAns.Add(new ChiTietBanAn() { MaBan = tableId, MaSanPham = product.MaSanPham, SoLuong = numProduct, DonGia = product.GiaBan });
                db.SaveChanges();
            }
        }
        #endregion
    }
}
