using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63BirdenFazlaFonksiyonIcerenDelegate
{
    class Program
    {

        public delegate void YazMetoduDelegate();




        static void Main(string[] args)
        {
            YazMetoduDelegate degisken;

            degisken = new YazMetoduDelegate(Yaz1);
            degisken += Yaz2;

            degisken -= Yaz1;

            degisken();

            Console.ReadLine();
        }


        static void Yaz1()
        {
            Console.WriteLine("yaz1 metodu çağırıldı.");
        }

        static void Yaz2()
        {
            Console.WriteLine("Yaz2 metodu çağırıldı.");
        }
    }
}
