using System;

namespace SquareRootWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to calculate their square root. Enter 0 to exit:");

            int number;
            do
            {
                number = int.Parse(Console.ReadLine());

                if (number != 0)
                {
                    Console.WriteLine($"Square root: {Math.Sqrt(number)}");
                }

            } while (number != 0);

            Console.ReadLine();
        }
    }
}