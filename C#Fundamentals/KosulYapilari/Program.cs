using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;

            if (a < 10)
                Console.WriteLine("A sayısı 10 dan küçüktür");//1           
            else if (a < 20)
            {
                Console.WriteLine("A sayısı 10 ile 20 arasındadır."); //2
            }
            else if (a < 30)
            {
                Console.WriteLine("A sayısı 20 ile 30 arasındadır.");//3
            }
            else
            {
                Console.WriteLine("A sayısı 30a eşit ya da büyüktür.");//4
            }

            Console.ReadLine();
        }
    }
}
