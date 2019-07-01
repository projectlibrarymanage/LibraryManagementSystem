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
    
        public class MuonBUS
        {
            private MuonDAL DgDAL;

            public MuonBUS()
            {
                DgDAL = new MuonDAL();
            }
            public bool Them(MuonDTO dg)
            {
                bool re = DgDAL.Them(dg);
                return re;
            }
            public bool Xoa(MuonDTO kn)
            {
                bool re = DgDAL.Xoa(kn);
                return re;
            }
        
        }
    
}
