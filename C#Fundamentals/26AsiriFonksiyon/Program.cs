using System;

namespace _26AsiriFonksiyon
{
    class Program
    {
        static void Yaz(string yazi)
        {
            Console.WriteLine(yazi);
        }

        static void Yaz(string yazi, int kackere)
        {
            Console.WriteLine(yazi.ToString());
        }

        /// <summary>
        /// Hakiki Tosun Paşa Benim
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Topla(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Ben seferoğullarının tosun paşasıyım
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="toplayayimmi"></param>
        /// <returns></returns>
        static double Topla(int a, int b, bool toplayayimmi)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            string d = "merhaba";
            Yaz("kalem");
            double b = 50;
            //Yaz(b);
            Yaz(d, 10);
            Console.WriteLine(b);
            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
