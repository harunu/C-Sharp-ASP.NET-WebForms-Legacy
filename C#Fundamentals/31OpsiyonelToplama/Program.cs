using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31OpsiyonelToplama
{
    /*
         İki tane int türünden parametre alan bir fonksiyon olsun, yalnız üçüncü olarak bool 
         * tipinden mutlak değere dönüşsüm mü şeklinde bir parametre alsın. 
         * Eğer üçüncü parametre true ise mutlak değere dönüştürerek toplamlarını döndürsün, 
         * eğer değer girilmezse veya false denirse doğrudan toplamı döndürsün. 
         *
         */
    class Program
    {
        static int Topla(int a, int b, bool MulakDegeriniAl = true)
        {
            int toplam = a + b;
            if (MulakDegeriniAl)
            {
                return Math.Abs(toplam);
            }

            return toplam;
        }

        static void Main(string[] args)
        {
            int s = Topla(-5, -6, true);
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
