using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngay24_09_12024
{
    internal class Sinhvien
    { 
        public string Hoten {  get; set; }
        public string MSSV { get; set; }
        public double DTB { get; set; }
        public Sinhvien(string Hoten, string MSSV, double DTB)
        {
            this.Hoten = Hoten;
            this.MSSV = MSSV;
            this.DTB = DTB;
        }
        public Sinhvien()
        {

        }
        public void NhapThongTin()
        {
            Console.WriteLine("nhap ho ten:");
            Hoten = Console.ReadLine();
            Console.WriteLine("nhap massv:");
            MSSV = Console.ReadLine();
            Console.WriteLine("nhap diem TB:");
            DTB = Convert.ToDouble(Console.ReadLine());
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"ho ten:{Hoten}");
            Console.WriteLine($"massv:{MSSV}");
            Console.WriteLine($"dtb:{DTB}");
        }
    }
}
