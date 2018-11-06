using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            //IlkOrnekler();
            Insan insan1 = new Insan();
            Insan ogreteninsan = new Ogretmen();

            ogreteninsan.Yas = 19;

            YasiArtir(ogreteninsan);

            Console.WriteLine(ogreteninsan.Yas);

            Console.ReadLine();

        }



        public static void YasiArtir(Insan kisi)
        {

            kisi.Yas += 1;

        }

        private static void IlkOrnekler()
        {
            Ogretmen ogrt = new Ogretmen();

            ogrt.Adi = "Selami";
            ogrt.AdinNe();

            Console.Read();

            ogrt.Adi = "Ahmet";

            Ogrenci ogrc = new Ogrenci();

            ogrc.Adi = "Mehmet";

            ogrt.AdinNe();
            ogrc.AdinNe();

            Console.ReadLine();

          //  Canli.Kaplan k = new Canli.Kaplan();

         //   k.Turu = "asdfasd";
        }
    }
}
