using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace BUS
{
    public class SachBUS
    {
        private SachDAL DgDAL;
        public SachBUS()
        {
            DgDAL = new SachDAL();
        }
        public bool Them(SachDTO dg)
        {
            bool re = DgDAL.Them(dg);
            return re;
        }
        public bool Xoa(SachDTO kn)
        {
            bool re = DgDAL.Xoa(kn);
            return re;
        }

        public bool Sua(SachDTO kn)
        {
            bool re = DgDAL.Sua(kn);
            return re;
        }
        public void GetListSach(DataGridView dataGridView)
        {
            DgDAL.GetListSach(dataGridView);
        }
        public int soluongsach()
        {
            int n = DgDAL.soluongsach();
            return n;
        }
        
    }
}
