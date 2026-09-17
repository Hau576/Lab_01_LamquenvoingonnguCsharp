using System;

class Bai10
{
    static bool chuoidoixung(string s)
    {
        int left = 0;//con tro bat dau tu ben trai
        int right = s.Length - 1;//con tro bat dau tu ben phai

        while (left < right)//vong lap dung lai khi con tro ben trai lon hon hoac bang con tro ben phai
        {
            if (s[left] != s[right]) //neu 2 ky tu khac nhau thi tra ve false
            {
                return false;
            }
            left++;//tang con tro ben trai len 1
            right--;//giam con tro ben phai xuong 1
        }
        return true; //tra ve true neu da la chuoi doi xung
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap vao mot chuoi can kiem tra: ");
        string chuoi = Console.ReadLine();

        if (chuoidoixung(chuoi))
        {
            Console.WriteLine($"Chuoi  \"{chuoi}\" la chuoi doi xung");//in ra neu la chuoi doi xung
        }
        else
        {
            Console.WriteLine($"Chuoi \"{chuoi}\" khong phai la chuoi doi xung");//in ra neu khong phai la chuoi doi xung
        }
    }
}