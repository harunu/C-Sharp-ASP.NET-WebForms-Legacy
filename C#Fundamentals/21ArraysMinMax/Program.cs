using System;

namespace _21ArraysMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            int largest = array[0];
            int smallest = array[0];
            int sum = 0;

            foreach (var element in array)
            {
                if (element < smallest)
                {
                    smallest = element;
                }
                if (element > largest)
                {
                    largest = element;
                }
                sum += element;
            }

            Console.WriteLine(smallest);
            Console.WriteLine(largest);
            Console.WriteLine(sum / 20.0);
            Console.ReadLine();
        }
    }
}
