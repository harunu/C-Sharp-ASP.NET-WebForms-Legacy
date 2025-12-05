using System;

namespace RowColumnPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows and columns:");
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    for (int m = 0; m < 3; m++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}