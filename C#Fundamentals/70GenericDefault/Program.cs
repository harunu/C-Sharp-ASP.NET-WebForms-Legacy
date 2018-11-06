using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70GenericDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            DegerGetir<bool> dg = new DegerGetir<bool>();
            Console.WriteLine(dg.Getir(true, -6));
            Console.ReadLine();
        }
    }
    public class Sinif
    {

    }

    public class DegerGetir<T>
    {

        public T Getir(T a, int b)
        {
            if (b > 0)
            {
                return a;
            }
            else
            {
                return default(T);
            }
        }
    }
}
