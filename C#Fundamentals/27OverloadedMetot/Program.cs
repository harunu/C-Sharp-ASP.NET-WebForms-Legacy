using System;

namespace _27OverloadedMetot
{
    class Program
    {
        static void Islem(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        static int Islem(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int toplam = Islem(2, 3);
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
