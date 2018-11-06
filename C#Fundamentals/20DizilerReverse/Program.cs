using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20DizilerReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 2, 5, 7, 3 };

            for (int i = 0; i < dizi.Length / 2; i++)
            {
                int gecici = dizi[i];
                dizi[i] = dizi[dizi.Length - i - 1];
                dizi[dizi.Length - i - 1] = gecici;
            }

            System.Array.Reverse(dizi);

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
