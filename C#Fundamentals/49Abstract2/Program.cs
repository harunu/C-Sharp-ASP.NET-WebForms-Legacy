using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49Abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat tabby = new Cat();
            MakeSpeak(tabby);
            Dog k9 = new Dog();
            MakeSpeak(k9);
            Console.ReadLine();
        }

        public static void MakeSpeak(Living x)
        {
            Console.WriteLine(x.Speak());
        }
    }
}
