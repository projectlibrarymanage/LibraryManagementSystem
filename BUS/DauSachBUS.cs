using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    class DauSachBUS
    {
        private DauSachDAL DauSach;
        public DauSachBUS()
        {
            DauSach = new DauSachDAL();
        }
        public bool add(DauSachDTO ds)
        {
            bool re = DauSach.ADD(ds);
            return re;
        }
        public bool delete(DauSachDTO ds)
        {
            bool re = DauSach.DELETE(ds);
            return re;
        }
        public bool alter(DauSachDTO ds)
        {
            bool re = DauSach.ALTER(ds);
            return re;
        }
    }
}
