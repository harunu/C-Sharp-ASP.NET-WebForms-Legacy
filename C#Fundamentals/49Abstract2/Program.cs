using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49Abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi tekir = new Kedi();
            Konustur(tekir);

            Kopek k9 = new Kopek();

            Konustur(k9);

            Console.ReadLine();
        }

        public static void Konustur(Canli x)
        {
            Console.WriteLine(x.Konus());
        }
    }
}
