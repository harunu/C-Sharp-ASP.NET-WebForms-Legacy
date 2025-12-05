using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61DelegateSearch
{
    class ArraySearch
    {
        public string[] Search(string[] ArrayToSearch, string searchTerm)
        {
            string[] result = new string[ArrayToSearch.Length];

            int foundCount = 0;
            foreach (string text in ArrayToSearch)
            {
                if (text == searchTerm)
                {
                    result[foundCount] = searchTerm;
                    foundCount++;
                }
            }

            return result;
        }


        public delegate bool ArraySearchFunction(string searchTerm);

        public string[] Search(string[] ArrayToSearch, ArraySearchFunction SearchFunc)
        {
            string[] result = new string[ArrayToSearch.Length];

            int foundCount = 0;
            foreach (string text in ArrayToSearch)
            {
                if (SearchFunc(text))
                {
                    result[foundCount] = text;
                    foundCount++;
                }
            }
            return result;
        }

    }
}
