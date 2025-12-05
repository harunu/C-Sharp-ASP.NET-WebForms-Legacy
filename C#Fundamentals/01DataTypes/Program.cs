using System;

namespace DataTypesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------
            // Object Type in C#
            // ----------------------
            // In C#, everything ultimately derives from the 'object' type.
            // It is the base type from which all other types (primitive or custom) inherit.
            // You can assign any data type (int, string, float, custom class, etc.) to an object.

            object firstValue = 1;
            object secondValue = 2;

            // Assigning object references
            secondValue = firstValue; // 'secondValue' now refers to the same value as 'firstValue'
            secondValue = 7;           // 'secondValue' now refers to a new value; 'firstValue' remains unchanged

            Console.WriteLine(firstValue); // Output: 1

            object variable = 1;
            Console.WriteLine(variable);              // Output: 1
            Console.WriteLine(variable.GetType());    // Output: System.Int32
            Console.WriteLine("--------");

            variable = "abc";
            Console.WriteLine(variable);              // Output: abc
            Console.WriteLine(variable.GetType());    // Output: System.String
            Console.WriteLine("--------");

            variable = 5.6F;
            Console.WriteLine(variable);              // Output: 5.6
            Console.WriteLine(variable.GetType());    // Output: System.Single
            Console.WriteLine("--------");

            variable = 'A';
            Console.WriteLine(variable);              // Output: A
            Console.WriteLine(variable.GetType());    // Output: System.Char
            Console.WriteLine("--------");

            Console.ReadLine();
            Console.Clear(); // Clears the console screen

            // ----------------------
            // Floating Point Operations
            // ----------------------
            float numerator = 5F;
            float denominator = 2F;

            Console.WriteLine(numerator / denominator); // Output: 2.5

            // ----------------------
            // Character and Casting
            // ----------------------
            char character = 'A';
            character = (char)45; // ASCII code 45 corresponds to '-'
            Console.WriteLine(character); // Output: -

            // ----------------------
            // String Formatting and Escape Sequences
            // ----------------------
            string quote = "\t Ataturk says:\n  \"The future is in the skies.\"";
            Console.WriteLine(quote);

            // ----------------------
            // File Paths - Escape Sequences vs Verbatim String Literals
            // ----------------------
            string pathWithEscapes = "D:\\08_DropBox\\Dropbox\\01_CoursePlans\\MCPDBT";
            string pathWithVerbatim = @"D:\08_DropBox\Dropbox\01_CoursePlans\""MCPDBT""";
            // Note: Double quotes must be escaped by doubling them inside verbatim strings

            Console.WriteLine(pathWithEscapes);
            Console.WriteLine(pathWithVerbatim);

            Console.Read();

            // ----------------------
            // TODO:
            // Future implementation: Add code to display a user's name here.
            // Console.WriteLine(userName);
            // ----------------------
        }
    }
}
