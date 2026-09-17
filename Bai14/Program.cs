using System;
using System.Security.Cryptography.X509Certificates;
namespace Bai14
{
    struct nhanvien
    {
        public string hoten;
        public int mucluong, songayvang;

    static void Main()
        {
            nhanvien nv;

            Console.Write("Nhap vao ho ten cua nhan vien: ");
            nv.hoten = Console.ReadLine();

            Console.Write("Nhap vao muc luong cua nhan vien: ");
            nv.mucluong = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so ngay vang cua nhan vien: ");
            nv.songayvang = int.Parse(Console.ReadLine());

            int tinhluong = nv.mucluong - 100000 * nv.songayvang; //phep toan tinh luong sau khi tru di so ngay vang

            Console.WriteLine($"\nMuc luong sau khi vang {nv.songayvang} ngay cua nhan vien {nv.hoten}: " + tinhluong);//in ra ket qua tinh luong
        }
    }
}
