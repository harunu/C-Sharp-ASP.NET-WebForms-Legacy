using System;

namespace WhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            // Using for loop
            for (; counter < 3;)
            {
                Console.WriteLine("Hello World " + counter);
                counter++;
            }

            counter = 0;

            // Using while loop
            while (counter < 3)
            {
                Console.WriteLine("Hello World " + counter);
                counter++;
            }

            Console.ReadLine();
        }
    }
}