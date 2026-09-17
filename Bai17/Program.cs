using System;
using System.Collections.Generic;

namespace Bai17
{
    public class Program
    {
        //phuong thuc nhap mang 2 chieu voi cac gia tri ngau nhien tu 10_100
        public static void Input(int[,] arr)
        {
            Random random = new Random();//tao random de sinh so ngau nhien

            for (int i=0;i<arr.GetLength(0); i++)//duyet tung dong
            {
                for (int j=0; j<arr.GetLength(1); j++)//duyet tung cot
                {
                    arr[i,j]=random.Next(10, 101);
                }
            }
        }

        // phuong thuc in ra mang 2 chieu vua sinh
        public static void Output(int[,] arr)
        {
            Console.WriteLine("Mang vua sinh la:");//duyet tung dong va cot de in ra mang
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //duyet tung cot
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");//in ra tung phan tu
                }
                Console.WriteLine();
            }
        }
        

        // phuong thuc tra ve mang chan va mang le
        public static void GetEvenOdd(int[,] arr, out int[] even, out int[] odd)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            for (int i=0;i<arr.GetLength(0);i++)//duyet tung dong
            {
                for (int j=0;j<arr.GetLength(1);j++)//duyet tung cot
                {
                    if (arr[i, j]%2==0)//kiem tra so chan
                    {
                        evenList.Add(arr[i, j]);
                    }
                    else
                    {
                        oddList.Add(arr[i, j]);//con lai la so le
                    }
                }
            }

            even = evenList.ToArray();
            odd = oddList.ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap vao so dong n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so cot m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];//khoi tao mang 2 chieu voi n dong va m cot

            //goi cac ham de nhap, xuat va tach mang chan le
            Input(matrix);
            Output(matrix);

            GetEvenOdd(matrix, out int[] evenArr, out int[] oddArr);

            Console.WriteLine($"\nMang cac so chan ({evenArr.Length} phan tu):");//in ra mang chan va so phan tu
            Console.WriteLine(string.Join(" ", evenArr));

            Console.WriteLine($"\nMang cac so le ({oddArr.Length} phan tu):");//in ra mang le va so phan tu
            Console.WriteLine(string.Join(" ", oddArr));
        }
    }
}