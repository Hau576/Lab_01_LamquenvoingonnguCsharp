using System;

namespace Bai05
{
    class Program
    {
        static double luythua(double x, double y)//ham tinh luy thua x^y
        {
            return Math.Pow(x, y);//tra ve ket qua 
        }

        static void canbac2(double x, double y)//ham tinh can bac 2 cua x va y
        {
            if (x >= 0)
                Console.WriteLine($"Can bac 2 cua x ({x}) la: {Math.Sqrt(x)}");//in ra ket qua
            else
                Console.WriteLine("Khong the tinh can bac 2 cua so am x!");//sai neu nguoi dung nhap so am

            if (y >= 0)
                Console.WriteLine($"Can bac 2 cua y ({y}) la: {Math.Sqrt(y)}");
            else
                Console.WriteLine("Khong the tinh can bac 2 cua so am y!");
        }

        static void Main(string[] args)
        {
            double x = 0, y = 0;

            while (true) //vong lap vo han de hien thi menu va thuc hien cac chuc nang
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                int luachon = int.Parse(Console.ReadLine());

                if (luachon == 1)
                {
                    Console.Write("Nhap x: ");
                    x = double.Parse(Console.ReadLine()); 

                    Console.Write("Nhap y: ");
                    y = double.Parse(Console.ReadLine());
                }
                else if (luachon == 2)
                {
                    double dapan = luythua(x, y);
                    Console.WriteLine($"Ket qua: {dapan}");
                }
                else if (luachon == 3)
                {
                    canbac2(x, y);
                }
                else if (luachon == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lua chon cua ban khong co trong danh sach, hay chon lai tu 1 den 4");//in ra neu nguoi dung nhap lua chon khong hop le
                }
            }
        }
    }
}