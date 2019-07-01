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
    class TheLoaiBUS
    {
        private TheLoaiDAL TheloaiDAL;
        public TheLoaiBUS()
        {
            TheloaiDAL = new TheLoaiDAL();
        }
        public bool Them(TheLoaiDTO tg)
        {
            bool re = TheloaiDAL.Them(tg);
            return re;
        }
        public bool Xoa(TheLoaiDTO tl)
        {
            bool re = TheloaiDAL.Xoa(tl);
            return re;
        }
        public bool Sua(TheLoaiDTO tl)
        {
            bool re = TheloaiDAL.Sua(tl);
            return re;
        }
    }
}
