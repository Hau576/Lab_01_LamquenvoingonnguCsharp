namespace Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao n(so luong ho ten can nhap): ");
            int n = int.Parse(Console.ReadLine());

            string[] dshoten = new string[n];

            Console.WriteLine("Nhap danh sach ho ten: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap vao ho ten nguoi thu {i}: ");
                dshoten[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Array.Sort(dshoten); //sap xep mang theo thu tu tang dan

            Console.WriteLine("Danh sach ho ten sao khi duoc sap xep tang dan: ");
            for (int i = 0; i < dshoten.Length; i++)
            {
                Console.WriteLine($"{dshoten[i]}");
            }
        }
    }
}
