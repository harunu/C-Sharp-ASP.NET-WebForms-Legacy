using System;

namespace CoffeeShopSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base price of the coffee: ");
            decimal basePrice = decimal.Parse(Console.ReadLine());

            Console.Write("Select size - (L)arge, (M)edium, (S)mall: ");
            string sizeChoice = Console.ReadLine().ToUpper();

            decimal finalPrice = 0;
            bool validSelection = true;

            switch (sizeChoice)
            {
                case "L":
                    finalPrice = basePrice * 1.5M;
                    break;
                case "M":
                    finalPrice = basePrice * 1.25M;
                    break;
                case "S":
                    finalPrice = basePrice;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose L, M, or S.");
                    validSelection = false;
                    break;
            }

            if (validSelection)
            {
                Console.WriteLine($"The total price is: {finalPrice:C}");
            }

            Console.ReadLine();
        }
    }
}