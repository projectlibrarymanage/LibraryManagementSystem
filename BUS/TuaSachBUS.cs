using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    class TuaSachBUS
    {
        private TuaSachDAL TsDAL;
        public TuaSachBUS()
        {
            TsDAL = new TuaSachDAL();
        }
        public bool Them(TuaSachDTO dg)
        {
            bool re = TsDAL.Them(dg);
            return re;
        }
        public bool Xoa(TuaSachDTO kn)
        {
            bool re = TsDAL.Xoa(kn);
            return re;
        }

        public bool Sua(TuaSachDTO kn)
        {
            bool re = TsDAL.Sua(kn);
            return re;
        }
    }
}
