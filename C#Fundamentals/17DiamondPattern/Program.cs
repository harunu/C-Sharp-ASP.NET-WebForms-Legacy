using System;

namespace DiamondShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maximum width of the diamond:");
            int width = int.Parse(Console.ReadLine());

            // Ensure the width is an odd number
            if (width % 2 == 0)
            {
                width++;
            }

            for (int i = 1; i < (width * 2); i += 2)
            {
                int starsCount;

                if (i <= width)
                {
                    starsCount = i;
                }
                else
                {
                    starsCount = Math.Abs(width * 2 - i);
                }

                int spacesCount = (width - starsCount) / 2;

                // Print leading spaces
                for (int k = 0; k < spacesCount; k++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int m = 0; m < starsCount; m++)
                {
                    Console.Write("*");
                }

                // Print trailing spaces (optional, for symmetry)
                for (int l = 0; l < spacesCount; l++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}