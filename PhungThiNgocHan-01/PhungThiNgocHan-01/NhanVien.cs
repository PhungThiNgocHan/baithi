using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhungThiNgocHan_01
{
    class NhanVien
    {
        private string maso;
        private string hoten;
        private int luongcung;
        private double luongthuclanh;

        public NhanVien()
        {
        }

        public NhanVien(string maso, string hoten, int luongcung)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongcung = luongcung;
        }

        public string Maso
        {
            set { this.maso = value; }
            get { return maso; }
        }

        public string Hoten
        {
            set { this.hoten = value; }
            get { return hoten; }
        }

        public int Luongcung
        {
            set { this.luongcung = value; }
            get { return luongcung; }
        }

        public virtual void Nhap()
        {
            Console.Write(" Nhap ma so:");
            this.maso = Console.ReadLine();
            Console.Write(" Nhap ho ten:");
            this.hoten = Console.ReadLine();
            Console.Write(" Nhap luong cung:");
            this.luongcung = int.Parse(Console.ReadLine());
        }

        public virtual double TinhLuong()
        {
            return 0;
        }
    }
}
    
