using System;

namespace Bai06
{
    class Program
    {
        static int lonnhattrong3so(int a, int b, int c)
        {
            int max = a;// gia su a la max
            if (b > a)//neu b lon hon max thi b la max
            {
                max = b;
            }
            if (c > max)//neu b lon hon max thi b la max
            {
                max = c;
            }
            return max;//tra ve max
        }

        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            int tm = lonnhattrong3so(a, b, c);//goi lai ham

            Console.Write("Gia tri lon nhat la : " + tm);//in ra ket qua
        }
    }
}