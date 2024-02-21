using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhungThiNgocHan_01
{
    class NhanVienBC : NhanVien
    {
        private string mucxeploai;

        public NhanVienBC() : base()
        { }

        public NhanVienBC(string maso, string hoten)
        {
            this.mucxeploai = mucxeploai;
        }

        public string MucXeploai
        {
            set { this.mucxeploai = value; }
            get { return mucxeploai; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write(" Nhap xep loai:");
            this.mucxeploai = Console.ReadLine();
        }

        public override double TinhLuong()
        {
            double thuong;
            if  (this.mucxeploai == "A")
            {
                thuong = 1.8 * Luongcung;
            }
            else if (this.mucxeploai == "B")
            {
                thuong = 1.2 * Luongcung;
            }
            else
            {
                thuong = 0.8 * Luongcung;
            }
            return thuong;
        }
    }
}
    