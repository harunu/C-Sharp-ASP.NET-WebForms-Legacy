using System;

namespace _21DizilerEnBuyukEnKucuk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                dizi[i] = rnd.Next(1, 100);
            }

            int enbuyuk = dizi[0];
            int enkucuk = dizi[0];
            int ortalama = 0;

            foreach (var eleman in dizi)
            {
                if (eleman < enkucuk)
                {
                    enkucuk = eleman;
                }
                if (eleman > enbuyuk)
                {
                    enbuyuk = eleman;
                }
                ortalama += eleman;
            }

            Console.WriteLine(enkucuk);
            Console.WriteLine(enbuyuk);
            Console.WriteLine(ortalama / 20.0);
            Console.ReadLine();
        }
    }
}
