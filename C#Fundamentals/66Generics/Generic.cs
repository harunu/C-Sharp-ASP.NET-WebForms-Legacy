using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66Generics
{
    class Generic
    {
    }

    public class CustomList
    {
        private object[] array = new object[10];
        private int index = 0;

        public int Add(object ElementToAdd)
        {
            if (index >= array.Length)
            {
                AdjustSize(index * 2);
            }

            array[index] = ElementToAdd;
            index++;
            return index;
        }

        private void AdjustSize(int size)
        {
            object[] newArray = new object[size];
            array.CopyTo(newArray, 0);
            array = newArray;
        }

        public object this[int i]
        {
            get
            {
                return array[i];
            }
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T">This is the type of element to be stored in this list.</typeparam>
    public class CustomList<T>
    {
        private T[] array = new T[10];
        private int index = 0;

        public int Add(T ElementToAdd)
        {
            if (index >= array.Length)
            {
                AdjustSize(index * 2);
            }

            array[index] = ElementToAdd;
            index++;

            return index;
        }

        private void AdjustSize(int size)
        {
            T[] newArray = new T[size];
            array.CopyTo(newArray, 0);
            array = newArray;
        }

        public T this[int i]
        {
            get
            {
                return array[i];
            }
        }
    }


    public class CustomList<T, G>
    {
        private T[] array = new T[10];
        private int index = 0;

        public int Add(T ElementToAdd)
        {
            if (index >= array.Length)
            {
                AdjustSize(index * 2);
            }

            array[index] = ElementToAdd;
            index++;

            return index;
        }

        private void AdjustSize(int size)
        {
            T[] newArray = new T[size];
            array.CopyTo(newArray, 0);
            array = newArray;
        }

        public T this[int i]
        {
            get
            {
                return array[i];
            }
        }
    }
}
