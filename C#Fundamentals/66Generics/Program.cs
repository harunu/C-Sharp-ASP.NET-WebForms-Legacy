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

            //GenOlmayanListe();
            //GenListe();

            //SinifFilitresi();

            //CompareValues();


            int k = 5;
            int l = 7;

            Swap<int>(ref k, ref l);

            double p = 9.7;
            double j = 10.8;

            Swap<double>(ref p, ref j);

            Console.WriteLine("k değişkeninin değeri : {0}", k);
            Console.WriteLine("l değişkeninin değeri : {0}", l);



            Console.ReadLine();
        }

        private static void CompareValues()
        {
            CompareValues<int> k = new CompareValues<int>();

            string s = k.Compare(10, 20);
            Console.WriteLine(s);

            CompareValues<DateTime> d = new CompareValues<DateTime>();
            s = d.Compare(DateTime.Parse("01.01.01"), DateTime.Parse("01.01.01"));

            Kedi kedi1 = new Kedi();
            kedi1.Yas = 3;

            Kopek kopek1 = new Kopek();
            kopek1.Yas = 4;

            CompareValues<Hayvan> h = new CompareValues<Hayvan>();
            s = h.Compare(kedi1, kopek1);

            Console.WriteLine(s);
        }


        public static void Swap<T>(ref T a, ref T b)
        {
            T Temp = a;
            a = b;
            b = Temp;
        }


        private static void SinifFilitresi()
        {
            Konusturucu<Kedi> k = new Konusturucu<Kedi>();

            Console.WriteLine(k.Konustur());



            Console.ReadLine();
        }

        private static void GenListe()
        {
            Liste<int> listem = new Liste<int>();



            listem.ekle(5);
            listem.ekle(6);



            Console.WriteLine(GenListTopla(listem));
        }

        private static void GenOlmayanListe()
        {
            Liste lst = new Liste();
            lst.ekle(10);
            lst.ekle("Ahmet");
            lst.ekle(new System.Data.SqlClient.SqlConnection());

            Console.WriteLine(ListeTopla(lst));
        }


        public static int GenListTopla(Liste<int> b)
        {
            return b[0] + b[1];
        }

        public static int ListeTopla(Liste a)
        {
            return (int)a[0] + (int)a[1];
        }
    }
}
