using System;

namespace _07RastgeleSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgele = rnd.Next(1, 20);


            Console.WriteLine("Aklımdan bir sayı tuttum, bil bakalım kaç tuttum?");
            int tahmin = int.Parse(Console.ReadLine());
            bool bildi = false;

            if (tahmin == rastgele)
            {
                Console.WriteLine("Hakkaten hisli bir insamışsın hemen bildin. Ya da gördün mü ne yaptın debuggerdan");
                bildi = true;
            }


            if (tahmin != rastgele && bildi == false)
            {
                Console.WriteLine("Bildin. Ya da gördün mü ne yaptın debuggerdan");
                bildi = true;
            }
            else
            {
                if (tahmin < rastgele)
                {
                    Console.WriteLine("Bilemedin ama biraz daha büyük atabilirsin.");

                }
                else
                {
                    Console.WriteLine("Bilemedin ama hayallerini küçük tut.");
                }

                tahmin = int.Parse(Console.ReadLine());
            }

            if (tahmin == rastgele && bildi == false)
            {
                Console.WriteLine("Bildin. Ya da gördün mü ne yaptın debuggerdan");
                bildi = true;
            }
            else
            {
                if (tahmin < rastgele)
                {
                    Console.WriteLine("Bilemedin ama biraz daha büyük atabilirsin.");

                }
                else
                {
                    Console.WriteLine("Bilemedin ama hayallerini küçük tut.");
                }

                tahmin = int.Parse(Console.ReadLine());
            }

            if (tahmin != rastgele)
            {
                bildi = false;
            }

            if (bildi == false)
            {
                Console.WriteLine("Bilemediniz. Tuttuğum sayı : " + rastgele.ToString());
            }
            Console.ReadLine();
        }
    }
}
