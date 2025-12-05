using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62DelegateSorting
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            ArraySort sorter = new ArraySort();
            var result = sorter.SortArray(array, OurSorting);

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }

        public static bool OurSorting(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return true;
            }
            else
                return false;
        }
    }
}
