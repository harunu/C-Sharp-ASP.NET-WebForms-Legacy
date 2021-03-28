using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Fonksiyonlar
{
  class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            int sonuc = (((x * x) + 2) - (2 * (x * x + 2))) / 4 * (x * x + 2);
            sonuc = (f(x) - 2 * f(x)) / 4 * f(x);

            Console.WriteLine(sonuc);

            EkranaSaatiYazdir();
            EkranaSaatiYazdir();
            EkranaSaatiYazdir();
            EkranaSaatiYazdir();
            EkranaSaatiYazdir();
            EkranaSaatiYazdir();
            EkranaSaatiYazdir();

            Console.WriteLine(topla(5, 6));

            int a = 5;
            fonksiyon(a);

            Console.WriteLine(a);

            Console.ReadLine();
        }

        static int f(int x)
        {
            int sonuc = (int)Math.Pow(x, 3) + 8;
            return sonuc;
        }

        static int topla(int a, int b)
        {
            if (a > 5)
            {
                return a + b;
            }
            return a * b;
        }

        static void EkranaSaatiYazdir()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine("Tabi bu saat İstanbul için geçerli");
            return;
        }
        static void fonksiyon(int a)
        {
            a = a * 2;
            return;
        }
    }
}
