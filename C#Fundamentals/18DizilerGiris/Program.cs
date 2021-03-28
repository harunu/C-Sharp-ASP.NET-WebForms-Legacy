using System;

namespace _18DizilerGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            string ogrenci = "";
            string[] ogrenciler = new string[5];
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            Console.WriteLine("Günün numarasını girin");
            int gunnumarasi = int.Parse(Console.ReadLine());
            Console.WriteLine(gunler[gunnumarasi - 1]);

            string[] aylar = new string[12];

            aylar[0] = "Ocak";
            aylar[1] = "Şubat";
            aylar[2] = "Mart";
            aylar[11] = "Aralık";

            Console.WriteLine("Ayın numarasını girin");
            int aynumarasi = int.Parse(Console.ReadLine());
            Console.WriteLine(aylar[aynumarasi - 1]);

            Console.ReadLine();
        }
    }
}
