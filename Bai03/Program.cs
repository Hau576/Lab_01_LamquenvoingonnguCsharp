using System;
namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());//nguoi dung nhap vao x o dang so nguyen(int)
            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine());//nguoi dung nhap vao y o dang so nguyen(int)
            Console.WriteLine($"Ket qua cua {x} mu {y} la: "+Math.Pow(x, y));//dung Math.Pow de tinh x^y roi in ra ket qua
        }
    }
}


