using System;
namespace Bai09
{
    class Program
    {
        static void lonnhatvanhonhattrong3so(double x, double y, double z, out double max, out double min)
        {
            max = x; //dung x lam gia tri ban dau(ca nho nhat va lon nhat) roi lay di so sanh
            min = x;

            //tim gia tri lon nhat
            if (y > max)
            {
                max = y;
            }
            if (z > max)
            {
                max = z;
            }

            //tim gia tri nho nhat
            if (y < min)
            {
                min = y;
            }
            if (z < min)
            {
                min = z;
            }
        }

        static void Main()
        {
            double max, min;

            Console.Write("Nhap vao x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhap vao y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Nhap vao z: ");
            double z = double.Parse(Console.ReadLine());

            lonnhatvanhonhattrong3so(x, y, z, out max, out min);

            Console.WriteLine($"\nSo co gia tri lon nhat cua ba so thuc la: {max}");//in ra ket qua
            Console.WriteLine($"So co gia tri nho nhat cua ba so thuc la: {min}");
        }
    }
}
