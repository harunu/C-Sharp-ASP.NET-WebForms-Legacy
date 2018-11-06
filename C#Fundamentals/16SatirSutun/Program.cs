using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16SatirSutun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Satir ve Sutun sayısını giriniz");
            int satir = int.Parse(Console.ReadLine());
            int sutun = int.Parse(Console.ReadLine());

            for (int i = 0; i < satir; i++)
            {

                for (int k = 0; k < sutun; k++)
                {

                    for (int m = 0; m < 3; m++)
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
