using System;

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
