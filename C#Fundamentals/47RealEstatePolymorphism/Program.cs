using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47RealEstatePolymorphism
{
    class Program
    {

        //Çok biçimlilik - polymorfism deniyor.
        static void Main(string[] args)
        {
            DortgenArsa darsa = new DortgenArsa();
            darsa.Boy = 90;
            darsa.En = 80;
            int alan = darsa.AlanHesapla();
            Console.WriteLine(FiyatHesapla(darsa, 10));


            UcgenArsa uarsa = new UcgenArsa();
            uarsa.Boy = 90;
            uarsa.En = 80;
            Console.WriteLine(FiyatHesapla(uarsa, 10));



            Console.ReadLine();

        }


        public static double FiyatHesapla(Arsa a, double fiyat)
        {
            return a.AlanHesapla() * fiyat;
        }
    }
}
