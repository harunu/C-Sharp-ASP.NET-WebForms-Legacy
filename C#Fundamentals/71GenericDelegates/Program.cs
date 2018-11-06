using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71GenericDelegates
{
    class Program
    {
        public delegate void OzelDegelegate<T>(T a, T b);

        static void Main(string[] args)
        {
            Action<int, int> k = new Action<int, int>(ToplaYazdir);
            k(5, 6);


        }

        static void ToplaYazdir(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.ReadLine();
        }


    }
}
