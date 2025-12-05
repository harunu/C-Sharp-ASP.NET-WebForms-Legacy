using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------
            // Logical Operators Example
            // ----------------------
            bool firstCondition = true;
            bool secondCondition = false;
            bool thirdCondition = false;

            // 'firstCondition || secondCondition' evaluates to true,
            // but 'true && thirdCondition' becomes false
            bool logicalResult = (firstCondition || secondCondition) && thirdCondition;

            // ----------------------
            // Ternary Operator Example
            // ----------------------
            int a = 5;
            int b = 6;

            // If b equals 5, a = b * 2; otherwise a = b * 3
            a = (b == 5) ? (b * 2) : (b * 3); // b = 6, so a = 6 * 3 = 18

            // ----------------------
            // Arithmetic Operations
            // ----------------------
            int arithmeticResult = ((((a + 5) * 4) - b) + 3);
            arithmeticResult = arithmeticResult + -b; // Equivalent to arithmeticResult -= b

            // ----------------------
            // Post-Increment Example
            // ----------------------
            b = a++; // b gets the value of a first, then a is incremented by 1

            Console.WriteLine(a); // Output: 19
            Console.WriteLine(b); // Output: 18

            Console.ReadLine();
        }
    }
}