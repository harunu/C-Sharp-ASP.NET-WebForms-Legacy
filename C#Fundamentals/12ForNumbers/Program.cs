using System;

namespace ForNumbersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            // Find numbers divisible by 5 but not divisible by 7
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 5 == 0) && (i % 7 != 0))
                {
                    Console.WriteLine(i);
                    sum += i;
                    count++;
                }
            }

            // Display the result
            Console.WriteLine("{0,10} numbers found. Their arithmetic sum is: {1,20}", count, sum);
            Console.ReadLine();
        }
    }
}