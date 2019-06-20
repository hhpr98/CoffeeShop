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
    }
}
