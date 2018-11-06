using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62DelegateSiralama
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] dizi = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            DiziSirala ds = new DiziSirala();
            var sonuc = ds.DiziSiralama(dizi, BizimSiralama);

            foreach (string item in sonuc)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }

        public static bool BizimSiralama(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return true;
            }
            else
                return false;
        }
    }
}
