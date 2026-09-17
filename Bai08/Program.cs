using System;

namespace Bai08
{
    class Program
    {
        static void hoanvi(ref double x, ref double y)//ham hoan vi 2 so thuc
        {
            double t = x; //bien tam luu x
            x = y;//gan x vao y
            y = t;//gan lai x ban dau(tam) cho y
        }

        static void Main()
        {
            Console.Write("Nhap vao x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhap vao y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nVi tri ban dau(truoc hoan vi): {x}  {y}");//vi tri ban dau

            hoanvi(ref x, ref y);//goi lai ham hoan vi

            Console.WriteLine($"\nKhi da doi cho (sau hoan vi): {x}  {y}");//in ra vi tri sau khi hoan vi
        }
    }
}

