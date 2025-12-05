using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment to explore more examples
            // NumericConversionExamples();

            Console.Clear();

            // ----------------------
            // String to Integer Conversion
            // ----------------------
            string stringNumber = "25";
            int integerNumber = int.Parse(stringNumber);

            // Integer to String Conversion
            int number = 456;
            string text = number.ToString();
            text = text + "abc";

            Console.WriteLine(text); // Output: 456abc
            Console.ReadLine();
        }

        private static void NumericConversionExamples()
        {
            // ----------------------
            // Implicit Conversion (Widening Conversion)
            // ----------------------
            // byte smallValue = 20;
            // int largeValue = smallValue; // Automatically allowed

            byte convertedValue;
            byte convertedValueUnchecked;

            // ----------------------
            // Explicit Conversion (Narrowing Conversion)
            // ----------------------
            float floatingNumber = 5.6F;
            int integerFromFloat = (int)floatingNumber; // Data loss (decimal part truncated)

            integerFromFloat = (int)'5'; // ASCII value of character '5' is 53

            // ----------------------
            // Checked and Unchecked Context
            // ----------------------
            // 'checked' ensures that overflow raises an exception
            checked
            {
                int valueInChecked = 1000;
                convertedValue = (byte)valueInChecked; // Overflow occurs -> exception in checked context

                // Nested 'unchecked' block ignores overflow
                unchecked
                {
                    int valueInUnchecked = 300;
                    convertedValueUnchecked = (byte)valueInUnchecked; // Overflow ignored, wraps around
                }
            }

            Console.WriteLine(convertedValue);
            Console.ReadLine();
        }
    }
}
