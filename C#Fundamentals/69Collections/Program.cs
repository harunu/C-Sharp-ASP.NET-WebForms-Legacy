using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69Collections
{

    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Numarasi { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //HashTable();
            //List();
            //Dictionary();

            Stack st = new Stack();

            st.Push(1);
            st.Push(5);
            st.Push(6);

            var a = st.Pop();

            Queue ql = new Queue();

            ql.Enqueue(7);
            ql.Enqueue(4);
            ql.Enqueue(9);

            var b = ql.Dequeue();
        }

        private static void Dictionary()
        {
            Dictionary<int, Ogrenci> sozluk = new Dictionary<int, Ogrenci>();
            sozluk.Add(1, new Ogrenci { Adi = "", Soyadi = "" });

            var eleman = sozluk[1];
            var e = new Ogrenci();
        }

        private static void List()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler.Add(new Ogrenci { Adi = "Ahmet1", Soyadi = "Hatayli", Numarasi = 1 });
            ogrenciler.Add(new Ogrenci { Adi = "Ahmet2", Soyadi = "Hatayli2", Numarasi = 2 });
            ogrenciler.Add(new Ogrenci { Adi = "Ahmet1", Soyadi = "Hatayli3", Numarasi = 1 });
            ogrenciler.Add(new Ogrenci { Adi = "Ahmet3", Soyadi = "Hatayli3", Numarasi = 3 });

            var secim = from p in ogrenciler where p.Numarasi == 1 select p;
            //"select * from ogrenciler where ogrencinukasdda = 5";
            foreach (var item in secim)
            {
                Console.WriteLine(item.Adi);
            }

            Console.ReadLine();
        }

        private static void HashTable()
        {
            Hashtable ht = new Hashtable();

            ht.Add("apple", "Elma");
            ht.Add("rubber", "silgi");
            ht.Add("keyboard", "klavye");

            string kelime = Console.ReadLine();

            Console.WriteLine(ht[kelime]);
            Console.ReadLine();
        }

        private static void ArrayList()
        {
            ArrayList liste = new ArrayList();
            liste.Add(1);
            liste.Add(5);
            liste.Add("ahmet");
            liste.RemoveAt(2);

            int a = (int)liste[0];

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
