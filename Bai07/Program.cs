namespace Bai07
{
    class Program
    {
        static bool kiemtrasonguyento(int n)
        {
            if (n < 2)//2 la so nguyen to nho nhat
            {
                return false;//tra ve false neu n nho hon 2
            }
            for (int i=2;i<=n/2;i++)//bat dau tu 2 va chi kiem tra den 0.5*n va tang bien dem i
            {
                if (n%i==0)//neu n chia het cho i thi no khong phai so nguyen to
                {
                    return false;//tra ve false
                }
            }
            return true;//con lai tra ve true
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());

            bool rs = kiemtrasonguyento(n);//goi lai ham bool

            if (rs) { Console.Write($"{n} la so nguyen to"); }//in ra ket qua
            else { Console.Write($"{n} khong phai so nguyen to"); }//in ra ket qua
        }
    }
}
