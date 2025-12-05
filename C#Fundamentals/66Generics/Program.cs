using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            //NonGenericList();
            //GenericList();

            //ClassFilter();

            //CompareValues();


            int k = 5;
            int l = 7;

            Swap<int>(ref k, ref l);

            double p = 9.7;
            double j = 10.8;

            Swap<double>(ref p, ref j);

            Console.WriteLine("Value of k variable: {0}", k);
            Console.WriteLine("Value of l variable: {0}", l);



            Console.ReadLine();
        }

        private static void CompareValuesMethod()
        {
            CompareValues<int> k = new CompareValues<int>();

            string s = k.Compare(10, 20);
            Console.WriteLine(s);

            CompareValues<DateTime> d = new CompareValues<DateTime>();
            s = d.Compare(DateTime.Parse("01.01.01"), DateTime.Parse("01.01.01"));

            Cat cat1 = new Cat();
            cat1.Age = 3;

            Dog dog1 = new Dog();
            dog1.Age = 4;

            CompareValues<Animal> h = new CompareValues<Animal>();
            s = h.Compare(cat1, dog1);

            Console.WriteLine(s);
        }


        public static void Swap<T>(ref T a, ref T b)
        {
            T Temp = a;
            a = b;
            b = Temp;
        }


        private static void ClassFilter()
        {
            Speaker<Cat> k = new Speaker<Cat>();

            Console.WriteLine(k.MakeSpeak());



            Console.ReadLine();
        }

        private static void GenericList()
        {
            CustomList<int> myList = new CustomList<int>();



            myList.Add(5);
            myList.Add(6);



            Console.WriteLine(GenListSum(myList));
        }

        private static void NonGenericList()
        {
            CustomList lst = new CustomList();
            lst.Add(10);
            lst.Add("Ahmet");
            lst.Add(new System.Data.SqlClient.SqlConnection());

            Console.WriteLine(ListSum(lst));
        }


        public static int GenListSum(CustomList<int> b)
        {
            return b[0] + b[1];
        }

        public static int ListSum(CustomList a)
        {
            return (int)a[0] + (int)a[1];
        }
    }
}
