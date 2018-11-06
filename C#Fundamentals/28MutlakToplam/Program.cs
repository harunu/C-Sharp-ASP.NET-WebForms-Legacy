using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28MutlakToplam
{
    class Program
    {

        static int MutlakToplam(int a)
        {
            return Math.Abs(a);
        }


        static double MutlakToplam(int a, int b)
        {
            return Math.Abs(a) + Math.Abs(b);
        }

        static void Main(string[] args)
        {
            var a = new int[10];
            var sayi = MutlakToplam(1);

            sayi = sayi + 1;
            Console.WriteLine(sayi);
            Console.ReadLine();

        }
    }
}
