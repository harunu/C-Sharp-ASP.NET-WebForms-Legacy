using System;

namespace ConditionalStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;

            if (a < 10)
                Console.WriteLine("The value of 'a' is less than 10."); // Case 1
            else if (a < 20)
            {
                Console.WriteLine("The value of 'a' is between 10 and 20."); // Case 2
            }
            else if (a < 30)
            {
                Console.WriteLine("The value of 'a' is between 20 and 30."); // Case 3
            }
            else
            {
                Console.WriteLine("The value of 'a' is equal to or greater than 30."); // Case 4
            }

            Console.ReadLine();
        }
    }
}