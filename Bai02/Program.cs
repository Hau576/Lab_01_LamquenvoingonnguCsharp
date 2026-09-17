using System;
namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho ten cua ban : ");//nguoi dung nhap vao ho ten
            string hoten = Console.ReadLine();//luu ho ten cua ho nhap vao o dang chuoi(string)
            Console.Write($"Chao ban {hoten}!");//in ra ket qua 
        }
    }
}