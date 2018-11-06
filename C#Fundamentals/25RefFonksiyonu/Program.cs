using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25RefFonksiyonu
{
    class Program
    {
        static void fonksiyon(ref int a)
        {
            a = a + 5;
        }

        static void SesliHarfler(ref string metin)
        {
            //metin = metin.Replace("a", "");
            //metin = metin.Replace("e", "");
            //metin = metin.Replace("u", "");
            //metin = metin.Replace("ü", "");
            //metin = metin.Replace("ö", "");
            //metin = metin.Replace("o", "");
            //metin = metin.Replace("ı", "");
            //metin = metin.Replace("i", "");

            string[] sesliharfler = { "a", "e", "u", "ü", "ı", "i", "ö", "o" };

            foreach (var harf in sesliharfler)
            {
                metin = metin.Replace(harf, "");
                metin = metin.Replace(harf.ToUpper(), "");
            }

        }


        static void Main(string[] args)
        {
            string strDeg = "Ali İhsan";

            strDeg = strDeg.Replace("Ali", "Hacı");
            Console.WriteLine(strDeg);

            string denememetni = "Merhaba Dünya, Hoşgeldin GÜle GÜle";

            SesliHarfler(ref denememetni);

            Console.WriteLine(denememetni);


            int baska = 9;
            fonksiyon(ref baska);
            Console.WriteLine(baska);
            Console.ReadLine();

        }
    }
}
