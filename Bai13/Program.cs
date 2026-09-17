using System;

namespace Bai13
{
    public class SinhVien
    {
        private string maSV;
        private string hoTen;
        private string diaChi;
        private int namThuMays;

        // phuong thuc nhap thong tin sinh vien
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();

            Console.Write("Nhap ho va ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();

            Console.Write("Nhap sinh vien nam thu may: ");
            namThuMays = int.Parse(Console.ReadLine());
        }

        // phuong thuc xuat thong tin sinh vien
        public void Xuat()
        {
            Console.WriteLine($"Ma sinh vien : {maSV}");
            Console.WriteLine($"Ho va ten    : {hoTen}");
            Console.WriteLine($"Dia chi      : {diaChi}");
            Console.WriteLine($"Sinh vien nam: {namThuMays}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            SinhVien sv = new SinhVien();// khoi tao doi tuong SinhVien

            //goi phuong thuc nhap va xuat thong tin sinh vien
            sv.Nhap();
            sv.Xuat();
        }
    }
}