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

    public class Liste
    {
        private object[] dizi = new object[10];
        private int indis = 0;

        public int ekle(object EklenecekEleman)
        {
            if (indis >= dizi.Length)
            {
                BoyutAyarla(indis * 2);
            }

            dizi[indis] = EklenecekEleman;
            indis++;
            return indis;
        }

        private void BoyutAyarla(int boyut)
        {
            object[] yenidizi = new object[boyut];
            dizi.CopyTo(yenidizi, 0);
            dizi = yenidizi;
        }

        public object this[int i]
        {
            get
            {
                return dizi[i];
            }

        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Bu listede tutulacak elemanın cinsidir.</typeparam>
    public class Liste<T>
    {
        private T[] dizi = new T[10];
        private int indis = 0;

        public int ekle(T EklenecekEleman)
        {
            if (indis >= dizi.Length)
            {
                BoyutAyarla(indis * 2);
            }

            dizi[indis] = EklenecekEleman;
            indis++;

            return indis;
        }

        private void BoyutAyarla(int boyut)
        {
            T[] yenidizi = new T[boyut];
            dizi.CopyTo(yenidizi, 0);
            dizi = yenidizi;
        }

        public T this[int i]
        {
            get
            {
                return dizi[i];
            }

        }
    }


    public class Liste<T, G>
    {
        private T[] dizi = new T[10];
        private int indis = 0;

        public int ekle(T EklenecekEleman)
        {
            if (indis >= dizi.Length)
            {
                BoyutAyarla(indis * 2);
            }

            dizi[indis] = EklenecekEleman;
            indis++;

            return indis;
        }

        private void BoyutAyarla(int boyut)
        {
            T[] yenidizi = new T[boyut];
            dizi.CopyTo(yenidizi, 0);
            dizi = yenidizi;
        }

        public T this[int i]
        {
            get
            {
                return dizi[i];
            }

        }
    }
}
