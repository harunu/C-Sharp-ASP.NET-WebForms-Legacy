using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Baklava
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil çizmek için en geniş kısmı girin");
            int cap = int.Parse(Console.ReadLine());
            if (cap % 2 == 0)
            {
                cap++;
            }

            //cap = cap + (cap % 2);

            for (int i = 1; i < (cap * 2) + 1; i = i + 2)
            {
                int sekil;
                if (cap > i)
                {
                    sekil = i;
                }
                else if (cap == i)
                {
                    sekil = i;
                }
                else
                {
                    sekil = Math.Abs(cap * 2 - i);
                }

                //int sekil = Math.Abs(i - cap) + 1;

                int bosluk = (cap - sekil) / 2;

                for (int k = 0; k < bosluk; k++)
                {
                    Console.Write(" ");
                }

                for (int m = 0; m < sekil; m++)
                {
                    Console.Write("*");
                }

                for (int l = 0; l < bosluk; l++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
