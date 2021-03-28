using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65EventOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Isim i = new Isim();

            i.PropertyChanged += new EventHandler(i_PropertyChanged);
            i.Property20 += new EventHandler(i_Property20);
            while (true)
            {
                i.Ad = Console.ReadLine();
            }
        }
        static void i_Property20(object sender, EventArgs e)
        {
            Console.WriteLine("20 karakterden fazla giriş yapıldı.");
        }

        static void i_PropertyChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Bir property değişti.");
        }
    }
}
