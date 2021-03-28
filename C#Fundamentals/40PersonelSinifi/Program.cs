using System;

namespace _40PersonelSinifi
{
    class Program
    {
        static void Main(string[] args)
        {

            Personel p = new Personel("Ahmet", "Soyalan", 45);
            Console.WriteLine(p.VergiVer());
            Math.Abs(12);
            double hesaplanan = Personel.VergiHesapla(5000);
            Console.WriteLine(hesaplanan);
            Console.Read();
        }
    }
}
