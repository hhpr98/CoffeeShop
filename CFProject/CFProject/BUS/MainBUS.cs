using CFProject.DTO;
using CFProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFProject.BUS
{
    class MainBUS
    {
        public List<BanAn> getAllTable()
        {
            return new TableDAO().getAllTable();
        }

        public List<ChiTietBanAnClass> getTableDetailByID(int id)
        {
            return new TableDAO().getTableDetailyByID(id);
        }

        public int switchTable(int tableFrom, int tableTo)
        {
            var tableSwitch = new TableDAO().findTableByID(tableTo);
            var tableIndex = new TableDAO().findTableByID(tableFrom);
            if (tableSwitch.TinhTrang == "Có người")
            {
                return 1; // fail
            }
            // Ngược lại : update table
            new TableDAO().updateTableStatus(tableFrom, tableTo);
            return 0; // success
        }

        public List<string> loadCategoryName()
        {
            var temp = new ProductDAO().getAllCategory();
            List<string> l = new List<string>();
            foreach (var index in temp)
            {
                l.Add(index.TenNhom);
            }
            return l;
        }

        public List<string> loadProductName(string cname)
        {
            var temp = new ProductDAO().getProductByCategoryName(cname);
            List<string> l = new List<string>();
            foreach (var index in temp)
            {
                l.Add(index.TenSanPham);
            }
            return l;
        }

        public List<int> getAllIdTable()
        {
            var temp = new TableDAO().getAllTable();
            List<int> l = new List<int>();
            foreach (var index in temp)
            {
                l.Add(index.MaBan);
            }
            return l;
        }

        public void updateTable(int tableId,string status)
        {
            new TableDAO().updateTable(tableId, status);
        }

        public void updateTableDetail(int tableId, string nameProduct, int numProduct)
        {
            // update status table
            this.updateTable(tableId, "Có người");
            // find Product with name
            var product = new ProductDAO().findProductByName(nameProduct);
            // add product toTable detail
            new ProductDAO().updateProductDetail(tableId, product, numProduct);
        }

        public int checkTableStatus(int tableId)
        {
            var table = new TableDAO().findTableByID(tableId);
            if (table.TinhTrang == "Trống") return 0;
            return 1;
        }

        public int addBill(HoaDon bill)
        {
            return new BillDAO().addBill(bill);
        }

        public void createBillDetail(int tableId,int billId)
        {
            var tableDetail = new TableDAO().getTableDetailyByID(tableId);
            foreach (var index in tableDetail)
            {
                var billToAdd = new ChiTietHoaDon() { MaSanPham = index.MaSanPham, MaHoaDon = billId, SoLuong = index.SoLuong, DonGia = index.DonGia };
                new TableDAO().addBillDetail(billToAdd);
            }
        }

        public void RemoveTableDetail(int TableId)
        {
            var lt = new TableDAO().getTableDetailyByIDFull(TableId);
            foreach (var index in lt)
            {
                new TableDAO().removeTableDetail(index.MaChiTietBanAn);
            }
        }
    }
}
