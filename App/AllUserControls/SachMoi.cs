using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace App
{
    public partial class SachMoi : UserControl
    {
        TuaSachBUS tuasach = new TuaSachBUS();
        public SachMoi()
        {
            InitializeComponent();           
        }

        private void SaveAddBt_Click(object sender, EventArgs e)
        {
            //SachDTO sach;
            //DauSachDTO dauSach;
            //TuaSachDTO tuaSach;

            //sach.Masach = ;
            //sach.Madausach =;
            //sach.Tinhtrang = "Con2";

            //dauSach.Madausach =;
            //dauSach.Matuasach =;
            //dauSach.Namxb = namxb_tb.Text;
            //dauSach.Nxb = nxb_tb.Text;
            //dauSach.Trigia = float.Parse(gia_tb.Text);

            //tuaSach.Matacgia =;
            //tuaSach.Matheloai =;
            //tuaSach.Matuasach = MaTuDongTuaSach(Tensach_tb.Text);
            //tuaSach.Tuasach = Tensach_tb.Text;
        }
        public int MaTuDongTuaSach(string ts)
        {
            int maTuDong;
            if (tuasach.kiemtra(ts) == true)
            {
                maTuDong = 1;
            }
            else
            {
                int n = tuasach.soluong();
                maTuDong = n + 1;
            }
            return maTuDong;
        }
        public int MaTuDongDauSach(string ts)
        {
            return 0;
        }
    }
}
