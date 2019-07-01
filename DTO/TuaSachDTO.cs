using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class TuaSachDTO
    {
        private string matuasach;
        private string tuasach;
        private string matheloai;
        private string matacgia;

        public string Matuasach { get => matuasach; set => matuasach = value; }
        public string Tuasach { get => tuasach; set => tuasach = value; }
        public string Matheloai { get => matheloai; set => matheloai = value; }
        public string Matacgia { get => matacgia; set => matacgia = value; }
    }
}
