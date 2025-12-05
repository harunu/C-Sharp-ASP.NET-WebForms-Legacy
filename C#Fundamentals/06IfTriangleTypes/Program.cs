using System;

namespace TriangleTypeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side lengths of the triangle:");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            bool canFormTriangle = !(a <= Math.Abs(b - c) || a >= (b + c));

            // Triangle Inequality Theorem Checks

            if (b <= Math.Abs(a - c) || b >= (a + c))
            {
                canFormTriangle = false;
            }

            if (c <= Math.Abs(a - b) || c >= (a + b))
            {
                canFormTriangle = false;
            }

            if (canFormTriangle)
            {
                // Calculate expected hypotenuses to check for right triangle
                int hypotenuseA = (int)Math.Sqrt((b * b) + (c * c));
                int hypotenuseB = (int)Math.Sqrt((a * a) + (c * c));
                int hypotenuseC = (int)Math.Sqrt((a * a) + (b * b));

                // Determine Triangle Type by Sides
                if (a == b && b == c)
                {
                    Console.WriteLine("This is an equilateral triangle.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("This is an isosceles triangle.");
                }
                else
                {
                    Console.WriteLine("This is a scalene triangle.");
                }

                // Check for Right Triangle
                if (a == hypotenuseA || b == hypotenuseB || c == hypotenuseC)
                {
                    Console.WriteLine("This triangle is also a right-angled triangle.");
                }
            }
            else
            {
                Console.WriteLine("A triangle with these side lengths cannot be formed.");
            }

            Console.ReadLine();
        }
    }
}
