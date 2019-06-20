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
    }
}
