using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57MesafeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mesafe m = new Mesafe();

                m.Kilometre = 19900;
            }
            catch (MesafeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.MesafeSorun);

            }

            Console.ReadLine();


        }
    }
}
