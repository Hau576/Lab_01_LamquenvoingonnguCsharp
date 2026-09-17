
using System;
using System.Collections.Generic;

namespace Bai15
{
    public class arr
    {
        private int[] mang;
        private int n; //khai bao n boi private de cac phuong thuc khac sdung, tranh lap lai

        public void nhapmang()
        {
            Console.Write("Nhap vao n(so luong phan tu): ");
            n = int.Parse(Console.ReadLine());
            
            mang = new int[n]; //khai bao so luong phan tu toi da trong mang la so luong phan tu nhap vao(n)

            for (int i=0;i<n;i++)
            {
                Console.Write($"Nhap vao phan tu thu {i}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
        }

        public void inmang()
        {
            Console.Write("Cac phan tu trong mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
        }

        public void timlonnhatvanhonhat(out int max, out int min)
        {
            max = mang[0];//gan vi tri ban dau
            min = mang[0];

            for (int i = 1; i < n; i++) //vi da gan gia tri ban dau o tren, neu chay tu 0 se them 1 lan so sanh voi chinh no(du thua)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                }
                if (mang[i] < min)
                {
                    min = mang[i];
                }
            }
        }

        private bool songuyento(int p)
        {
            if (p < 2)
            {
                return false;
            }
            for (int i = 2; i <= p / 2; i++)
            {
                if (p % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int[] songuyentotrave()
        {
            List<int> dssonguyento = new List<int>(); //tim thay snt thi dua vao ds

            for (int i = 0; i < n; i++)
            {
                if (songuyento(mang[i]))
                {
                    dssonguyento.Add(mang[i]);
                }
            }
            return dssonguyento.ToArray();
        }

        static void Main()
        {
            arr m = new arr();

            m.nhapmang();
            Console.WriteLine();
            m.inmang();

            m.timlonnhatvanhonhat(out int max, out int min);
            Console.WriteLine($"\n\nPhan tu lon nhat trong mang: {max}");//in ra phan tu lon nhat trong mang
            Console.WriteLine($"Phan tu nho nhat trong mang: {min}");//in ra phan tu lon nhat trong mang

            int[] snguyento = m.songuyentotrave();
            Console.Write("\nCac so nguyen to trong mang: ");
            if (snguyento.Length > 0)
            {
                for (int i = 0; i < snguyento.Length; i++)
                {
                    Console.Write(snguyento[i] + " ");//in ra cac so nguyen to trong mang
                }
            }
            else
            {
                Console.Write("Khong co");//neu khong co so nguyen to se in ra "Khong co"
            }
        }
    }
}
