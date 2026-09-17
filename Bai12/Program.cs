using System;
namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot chuoi gom nhieu tu: ");
            string chuoi = Console.ReadLine();

            string chuoithuong = chuoi.ToLower();//chuyen chu thuong sang chu hoa

            string chuoihoa = chuoi.ToUpper();//chuyenn chu hoa sang chu thuong

            //dem so tu trong chuoi, cat chuoi dua tren khoang trang va loai bo cac khoang trang thua lien tuc
            string[] dstu = chuoi.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int soluongtu = dstu.Length;

            Console.WriteLine($"Chuoi chu thuong: {chuoithuong}");//in ra chuoi chu thuong
            Console.WriteLine($"Chuoi chu hoa: {chuoihoa}");//in ra chuoi chu hoa
            Console.WriteLine($"So luong tu: {soluongtu}");//in ra so luong tu trong chuoi
        }

    }
}