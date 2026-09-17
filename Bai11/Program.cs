using System;

namespace Bai11
{
    public class Program
    {
        static string chuoidaonguoc(string s)
        {
            char[] mangkitu = s.ToCharArray();//chuyen doi chuoi thanh mang ki tu

            int left = 0;//bien dem tu ben trai sang
            int right = mangkitu.Length - 1;//bien dem tu ben phai sang

            while (left < right)//vong lap dung lai khi trai lon hon hoac bang phai
            {
                char t = mangkitu[left];//tao bien tam de luu gia tri cua ky tu ben trai
                mangkitu[left] = mangkitu[right];//gan gia tri cua ky tu phai cho ky tu trai
                mangkitu[right] = t;//gan gia tri cua bien tam(t) lai cho ky tu phai

                left++;//tang bien dem trai len 1
                right--;//giam bien dem phai di 1
            }
            return new string(mangkitu);//tra ve chuoi sau khi dao nguoc
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot chuoi can dao nguoc: ");
            string chuoigoc  = Console.ReadLine();

            string chuoidao = chuoidaonguoc(chuoigoc);//goi lai ham de dao nguoc chuoi

            Console.WriteLine($"Chuoi sau khi dao nguoc la: {chuoidao}");//in ra chuoi sau khi dao nguoc
        }
    }
}