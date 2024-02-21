using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhungThiNgocHan_01
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }

        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("Chon loai nhan vien [1:Bien Che, 2:Hop Dong]:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                   case 1:
                        nv = new NhanVienBC(); 
                        nv.Nhap(); 
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD(); 
                        nv.Nhap(); 
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Ban chon sai. Vui long chon 1 hoac 2.");
                        break;
                }

                Console.Write("Ban co muon tiep tuc khong? Y/N:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }

        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10}  {"Ho Ten",20} {"Luong Thuc Lanh",10}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.Maso,-10}  {x.Hoten,20}  {x.Luongcung,10} {x.TinhLuong(),20:0 vnd}");
            }
        }

        public double tinhTongLuong()
        {
            double sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
            }

            return sum;
        }
        public double tinhLuongTrungBinh()
        {
            double avg = 0;
            foreach (NhanVien nv in dsNV)
            {
                avg += nv.TinhLuong();
            }

            return avg;
        }
    }
}