using System;

namespace SwitchCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers for calculation:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select an operation: +, -, *, /");
            string operation = Console.ReadLine();

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = (double)num1 / num2; // casting to avoid integer division
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please select one of +, -, *, /.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine("Result: " + result);
            }

            Console.ReadLine();
        }
    }
}