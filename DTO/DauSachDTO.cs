using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DauSachDTO
    {
        private int madausach;
        private int matuasach;
        private char nxb;
        private char namxb;
        private float trigia;

        public int Madausach { get => madausach; set => madausach = value; }
        public int Matuasach { get => matuasach; set => matuasach = value; }
        public char Nxb { get => nxb; set => nxb = value; }
        public char Namxb { get => namxb; set => namxb = value; }
        public float Trigia { get => trigia; set => trigia = value; }
    }
}
