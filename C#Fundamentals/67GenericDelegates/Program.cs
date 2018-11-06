using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67GenericDelegates
{
    class Program
    {
        public delegate void FonksiyonDel(string s);

        public delegate void DelFonk<T>(T k);

        static void Main(string[] args)
        {
            //FonksiyonDel a = new FonksiyonDel(EkranaYazdir);
            //a += EkranaCiftYazdir;
            //a("merhaba");

            DelFonk<string> k = new DelFonk<string>(EkranaYazdir);
            k("kkkkkk");

            DelFonk<int> e = new DelFonk<int>(EkranaIntYazdir);
            e(5);



        }


        public static void EkranaIntYazdir(int i)
        {
            Console.WriteLine(i);
            Console.ReadLine();
        }

        public static void EkranaYazdir(string s)
        {
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static void EkranaCiftYazdir(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
