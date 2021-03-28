using System;

namespace _14WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            for (; a < 3;)
            {
                Console.WriteLine("Merhaba Dünya" + a);
                a++;
            }
            a = 0;
            while (a < 3)
            {
                Console.WriteLine("Merhaba Dünya" + a);
                a++;
            }
            Console.ReadLine();
        }
    }
}
