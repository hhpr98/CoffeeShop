using CFProject.DAO;
using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFProject.BUS
{
    class DetailBUS
    {
        public HoaDon findBillByID(int id)
        {
            return new BillDAO().findBillByID(id);
        }

        public List<ChiTietHoaDon> findBillDetailByID(int id)
        {
            return new BillDAO().findBillDetailByID(id);
        }

        public SanPham findProductByID(int id)
        {
            return new ProductDAO().findProductByID(id);
        }
    }
}
