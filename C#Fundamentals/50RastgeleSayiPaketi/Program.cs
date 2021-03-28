using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50RastgeleSayiPaketi
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal class RastgeleSayiUret
    {
        public delegate void metot();

        public class Deneme : ApplicationException
        {

        }

        public int Uret(metot a)
        {
            a();
            return (new Random()).Next(1, 1000);

        }

        protected string SametOzelligi { get; set; }
    }

    public class RastGeleSayiGetir
    {
        void deneme()
        {
            Console.WriteLine("deneme");
        }

        public int SayiGetir()
        {
            RastgeleSayiUret su = new RastgeleSayiUret();
            return su.Uret(deneme);
        }
    }
}
