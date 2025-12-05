using System;

namespace ElectricityBilling
{
    class Program
    {
        static void Main(string[] args)
        {
            int consumption;

            Console.Write("Enter the amount of electricity consumption (kWh): ");
            consumption = int.Parse(Console.ReadLine());

            decimal totalAmount = 0;
            decimal unitPrice = 40; // Default unit price (will be overridden based on consumption)

            if (consumption <= 150)
            {
                unitPrice = 10;
            }
            else if (consumption < 300)
            {
                unitPrice = 20;
            }

            totalAmount = unitPrice * consumption;

            Console.WriteLine($"Total amount to be paid: {totalAmount}"); // Output example: 2000
            Console.ReadLine();
        }
    }
}