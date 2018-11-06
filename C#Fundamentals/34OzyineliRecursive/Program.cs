using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34OzyineliRecursive
{
    class Program
    {
        static int faktoriyel(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * faktoriyel(x - 1);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(faktoriyel(3));
            Console.ReadLine();
        }
    }
}
