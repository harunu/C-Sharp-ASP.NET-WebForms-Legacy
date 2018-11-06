using _50RastgeleSayiPaketi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48OgrenciTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper lh = new LogHelper();
            lh.Logla("Bu bizim ilk loglamamız.");

            lh.Logla("basdfasdfasd");

            lh.Logla(".......");

            _50RastgeleSayiPaketi.RastGeleSayiGetir sg = new RastGeleSayiGetir();
            Console.WriteLine(sg.SayiGetir());

            Console.Read();
        }
    }
}
