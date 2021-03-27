using System;

namespace ChipperSample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ichipher cipRef;
            //BitCipper bit = new BitCipper(27);
            //SimpleCipher sc = new SimpleCipher();

            //string plain;
            //string coded;

            //cipRef = sc;
            //plain = "Fatih";
            //coded = cipRef.encode(plain);
            //Console.WriteLine(coded);

            //coded = cipRef.decode(coded);
            //Console.WriteLine(coded);

            //cipRef = bit;
            //coded = cipRef.encode(plain);
            //Console.WriteLine(coded);

            //coded = cipRef.decode(coded);
            //Console.WriteLine(coded);

            UnlistedPhone ugurun_numarasi = new UnlistedPhone("ugur", "32948234294", new SimpleCipher());
            UnlistedPhone harunun_numarasi = new UnlistedPhone("harun", "3576897294", new BitCipper(37));
            Console.WriteLine("1.Kayıt" + ugurun_numarasi.Name + ":" + ugurun_numarasi.Number + "sifre" + ugurun_numarasi._name + ugurun_numarasi._number);
            Console.WriteLine("1.Kayıt" + harunun_numarasi.Name + ":" + harunun_numarasi.Number);
            Console.ReadLine();
        }
    }
}
