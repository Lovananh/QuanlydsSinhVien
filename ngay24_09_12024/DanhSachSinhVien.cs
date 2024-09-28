using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ngay24_09_12024
{
    internal class DanhSachSinhVien 
    {
        private List<Sinhvien> danhsach;
        public DanhSachSinhVien()
        {
            danhsach = new List<Sinhvien>();
        }
        public void ThemSinhvien(Sinhvien sv)
        {
            danhsach.Add(sv);
        }
        public void HienThiDanhSach()
        {
            foreach(var sv in danhsach)
            {
                sv.XuatThongTin();
                Console.WriteLine("---------------------");
            }
        }
        public Sinhvien TimSinhVienTheoMSSV(string mssv)
        {
           foreach(var sv in danhsach)
            {
                if(sv.MSSV == mssv)
                {
                    return sv;
                }
            }
            return null;
        }
        //tim sinh vien co dtb cao nhat
        public Sinhvien TinhDiemTrungBinhCaoNhat()
        {
            if(danhsach.Count ==0)
            {
                return null;
            }
            Sinhvien svMax = danhsach[0];

            foreach(var sv in danhsach)
            {
                if(sv.DTB > svMax.DTB)
                {
                    svMax = sv;
                }
            }
            return svMax;
        }
    }
}
