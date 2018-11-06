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
                return "Birincisi küçük";

            }
            else if (first.CompareTo(second) == 1)
            {
                return "Birincisi büyük";
            }
            else
            {
                return "Bunların ikisi zaten eşit";
            }
        }

    }
}
