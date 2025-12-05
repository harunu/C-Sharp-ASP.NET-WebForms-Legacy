using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
            }

            //for (int i = 0; i < dizi.Length - 1; i++)
            //{
            //    if (dizi[i] > dizi[i + 1])
            //    {
            //        int temp = dizi[i];
            //        dizi[i] = dizi[i + 1];
            //        dizi[i + 1] = temp;
            //        i = 0;
            //    }
            //}

            System.Array.Sort(dizi);
            Console.WriteLine("****************");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
                //item = item * 5;
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            Console.ReadLine();
        }
    }
}
