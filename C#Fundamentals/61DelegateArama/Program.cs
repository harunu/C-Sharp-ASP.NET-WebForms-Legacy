using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61DelegateArama
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] dizi = { "ak", "bddd", "aeee", "cqqq", "daaa", "a" };
            DiziAra ara = new DiziAra();
            var sonuc = ara.Ara(dizi, BizimArama);

            foreach (string bulunan in sonuc)
            {
                Console.WriteLine(bulunan);
            }
            Console.ReadLine();
        }
        static bool BizimArama(string metin)
        {
            return metin.IndexOf("a") > -1;
        }
    }
}
