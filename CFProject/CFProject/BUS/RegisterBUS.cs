using CFProject.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFProject.BUS
{
    class RegisterBUS
    {
        public int checkAccountIsExist(string user)
        {
            var list = new AccountDAO().listAccountSame(user);
            if (list.Count()>0)
            {
                return 1;
            }
            return 0;
        }

        public void registerNewAccount(string user,string pass,int manager)
        {
            new AccountDAO().registerNewAccount(user,pass,manager);
        }
    }
}
