using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66Generics
{
    public class Hayvan : IComparable
    {
        public string Adi { get; set; }
        public virtual string Konus()
        {
            return "Ben" + Adi;
        }

        public int Yas { get; set; }

        public int CompareTo(object obj)
        {
            if (this.Yas < ((Hayvan)obj).Yas)
            {
                return -1;
            }
            else if (this.Yas == ((Hayvan)obj).Yas)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    public class Kedi : Hayvan
    {

        public override string Konus()
        {
            return "Ben miyav. Adım da " + Adi;
        }
    }

    public class Kopek : Hayvan
    {

        public override string Konus()
        {
            return "Ben hav hav. Adım da " + Adi;
        }
    }


    public class Konusturucu<T> where T : Hayvan, new()
    {
        public string Konustur()
        {
            T hayvan1 = new T();
            return hayvan1.Konus();
        }
    }
}
