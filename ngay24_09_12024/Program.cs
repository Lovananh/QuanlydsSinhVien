using System;
using ngay24_09_12024;

public class Quanlysinhvien
{
    public static void Main(string[] args)
    {
        DanhSachSinhVien ds = new DanhSachSinhVien(); // khoi tao doi tuong

        for(int i=0;i<3;i++)
        {
            Sinhvien sv = new Sinhvien();
            sv.NhapThongTin();
            ds.ThemSinhvien(sv);

        }
        Console.WriteLine("hien thi thong tin ra man hinh:");
        ds.HienThiDanhSach();
        Sinhvien svMax = ds.TinhDiemTrungBinhCaoNhat();
        if (svMax != null)
        {
            Console.WriteLine("Sinh vien co DTB cao nhat:");
            svMax.XuatThongTin();
        }
        else
        {
            Console.WriteLine("Danh sahc sinh vien rong.");
        }

        // Tìm kiếm sinh viên theo MSSV và hiển thị thông tin sinh viên đó
        Console.Write("Nhap MSSV  can tim: ");
        string mssv = Console.ReadLine();
        Sinhvien svTim = ds.TimSinhVienTheoMSSV(mssv);
        if (svTim != null)
        {
            Console.WriteLine("Thong tin sinh vien timm thay:");
            svTim.XuatThongTin();
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien co MSSV: " + mssv);
        }
    }
}