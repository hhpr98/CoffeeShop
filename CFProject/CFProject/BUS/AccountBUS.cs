using CFProject.DAO;
using CFProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFProject.BUS
{
    class AccountBUS
    {
        public TaiKhoan findAccountByID(int id)
        {
            return new AccountDAO().findAccountByID(id);
        }

        public NguoiQuanLi findManager(int id)
        {
            return new AccountDAO().findManager(id);
        }

        public void changePassword(int id,string pass)
        {
            new AccountDAO().changePassword(id, pass);
        }
    }
}
