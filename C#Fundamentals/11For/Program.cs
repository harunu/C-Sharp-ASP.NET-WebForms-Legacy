using System;

namespace ForLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string log = string.Empty;

            // First loop: increments based on milliseconds modulo 10
            for (; number < 50; log += number.ToString() + " - ")
            {
                Console.WriteLine(number);
                number += DateTime.Now.Millisecond % 10; // Adds a pseudo-random step between 0–9
            }

            number = 0;

            // Wait for input before second loop
            Console.ReadLine();

            // Second loop: increments by 6
            for (; number < 50; number += 6)
            {
                Console.WriteLine(number);
            }

            // Output the accumulated log string from the first loop
            Console.WriteLine(log);
            Console.ReadLine();
        }
    }
}