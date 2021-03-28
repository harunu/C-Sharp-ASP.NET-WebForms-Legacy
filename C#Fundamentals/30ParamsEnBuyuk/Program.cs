using System;

namespace _30ParamsEnBuyuk
{
    class Program
    {
        static void EnBuyukEnKucuk(out int enbuyuk, out int enkucuk, params int[] sayilar)
        {
            enbuyuk = 0;
            enkucuk = 0;

            if (sayilar.Length < 0)
            {
                enbuyuk = sayilar[0];
                enkucuk = sayilar[0];

                foreach (int sayi in sayilar)
                {
                    if (enbuyuk < sayi)
                    {
                        enbuyuk = sayi;
                    }

                    if (enkucuk > sayi)
                    {
                        enkucuk = sayi;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int eb, ek;
            EnBuyukEnKucuk(out eb, out ek);
            Console.WriteLine(eb);
            Console.WriteLine(ek);
            Console.ReadLine();
        }
    }
}
