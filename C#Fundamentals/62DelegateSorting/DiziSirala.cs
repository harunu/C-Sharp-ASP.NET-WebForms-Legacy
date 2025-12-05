using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62DelegateSorting
{
    public class ArraySort
    {
        public delegate bool ArraySortingFunction(string a, string b);

        public string[] SortArray(string[] array, ArraySortingFunction SortFunc)
        {

            for (int i = 1; i < array.Length; i++)
            {
                if (SortFunc(array[i], array[i - 1]) == true)
                {
                    string temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    i = 1;
                }
            }
            return array;
        }
    }
}
