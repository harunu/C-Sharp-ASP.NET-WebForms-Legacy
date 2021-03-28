using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFUcgenCesitleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Türü belirlenecek üçgenin ayrıtlarını giriniz.");
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c:");
            int c = int.Parse(Console.ReadLine());

            bool ucgencizilebilir = true;

            if (a <= (Math.Abs(b - c)) || a >= (c + b))
            {
                ucgencizilebilir = false;
            }

            if (b <= (Math.Abs(a - c)) || b >= (c + a))
            {
                ucgencizilebilir = false;
            }

            if (c <= (Math.Abs(a - b)) || c >= (b + a))
            {
                ucgencizilebilir = false;
            }

            if (ucgencizilebilir)
            {

                int hipa = (int)Math.Sqrt((b * b) + (c * c));
                int hipb = (int)Math.Sqrt((a * a) + (c * c));
                int hipc = (int)Math.Sqrt((b * b) + (a * a));

                if ((a == b) && (b == c))
                {
                    Console.WriteLine("Bu bir eşit kenar üçgendir.");
                }
                else if ((a == b) || (b == c) || (a == c))
                {
                    Console.WriteLine("Bu bir ikiz kenar üçgendir.");
                }
                else
                {
                    Console.WriteLine("Bu bir çeşitkenar üçgendir.");
                }

                if ((a == hipa) || (b == hipb) || (c == hipc))
                {
                    Console.WriteLine("Bu üçgen aynı zamanda bir dik üçgendir.");
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz üçgenin çizilmesi mümkün değildir.");
            }

            Console.ReadLine();
        }
    }
}
