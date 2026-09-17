using System;

namespace Bai04
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen x: "); 
            string x = Console.ReadLine();//nguoi dung nhap vao x dang so nguyen(int)
            Console.Write("Nhap so nguyen y: ");
            string y = Console.ReadLine();//nguoi dung nhap vao y dang so nguyen(int)

            if (!int.TryParse(x, out int numberx) || !int.TryParse(y, out int numbery))//kiem tra x, y
            {
                Console.Write("Loi! Co x hoac y khong phai la so nguyen");//thong bao loi
                return;//thoat chuong trinh
            }
            double ketqua = Math.Pow(numberx, numbery);//tinh x mu y voi Math.Pow neu kiem tra khong loi
            Console.Write($"Ket qua {numberx} mu {numbery} la: {ketqua}");
        }
    }
}
