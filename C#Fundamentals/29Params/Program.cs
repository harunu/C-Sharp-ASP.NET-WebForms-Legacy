using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Params
{
    class Program
    {

        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }

            return toplam;
        }


        static void Main(string[] args)
        {
            int t = Topla(1, 2, 3, 4, 5, 6);
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
