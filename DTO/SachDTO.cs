using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SachDTO
    {
        private int masach;
        private int madausach;
        private string tinhtrang;

        public int Masach { get => masach; set => masach = value; }
        public int Madausach { get => madausach; set => madausach = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
