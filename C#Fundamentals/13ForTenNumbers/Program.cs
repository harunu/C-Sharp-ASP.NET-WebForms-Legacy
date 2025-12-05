using System;

namespace ForTenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average = 0;
            int smallest = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
                average = (double)sum / (i + 1); // Cast to double for accurate decimal division

                if (i == 0)
                {
                    smallest = number; // Initialize smallest with the first entered number
                }
                else if (number < smallest)
                {
                    smallest = number; // Update smallest if a smaller number is found
                }

                Console.WriteLine("Current Sum: " + sum);
                Console.WriteLine("Current Average: " + average);
            }

            Console.WriteLine("The smallest number you entered is: " + smallest);
            Console.ReadLine();
        }
    }
}