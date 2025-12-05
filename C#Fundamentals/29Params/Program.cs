using System;

namespace _29Params
{
    class Program
    {

        static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int t = Add(1, 2, 3, 4, 5, 6);
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
