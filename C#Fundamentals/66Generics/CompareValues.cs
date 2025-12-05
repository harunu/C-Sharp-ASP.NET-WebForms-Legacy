using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66Generics
{
    class CompareValues<T> where T : IComparable
    {
        public string Compare(T first, T second)
        {
            if (first.CompareTo(second) == -1)
            {
                return "First is smaller";
            }
            else if (first.CompareTo(second) == 1)
            {
                return "First is larger";
            }
            else
            {
                return "These two are equal";
            }
        }
    }
}
