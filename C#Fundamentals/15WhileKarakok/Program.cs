using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15WhileKarakok
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Karekökü alınacak sayıları girin, çıkmak için 0 girin :");
            int sayi;

            do
            {
                sayi = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(sayi).ToString());

            } while (sayi != 0);

            Console.ReadLine();
        }
    }
}
