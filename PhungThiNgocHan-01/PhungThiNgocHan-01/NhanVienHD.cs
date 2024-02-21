using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhungThiNgocHan_01
{
    class NhanVienHD : NhanVien
    {
        private int doanhthu;

        public NhanVienHD() : base()
        { }

        public NhanVienHD(string maso, string hoten, int luongcung, int doanhthu)
        {
            this.doanhthu = doanhthu;
        }

        public int Doanhthu
        {
            set { this.doanhthu = value; }
            get { return doanhthu; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write(" Nhap doanh thu:");
            this.doanhthu = int.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            double thuong = 0.05 * doanhthu;
            return (int)thuong;
        }
    }
}

    