using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61DelegateSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "ak", "bddd", "aeee", "cqqq", "daaa", "a" };
            ArraySearch searcher = new ArraySearch();
            var result = searcher.Search(array, OurSearch);

            foreach (string found in result)
            {
                Console.WriteLine(found);
            }
            Console.ReadLine();
        }
        static bool OurSearch(string text)
        {
            return text.IndexOf("a") > -1;
        }
    }
}
