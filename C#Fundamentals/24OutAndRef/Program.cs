using System;

namespace _24OutAndRef
{
    class Program
    {

        #region OurFirstMethods
        static double Square(double a)
        {
            return a * a;
        }


        /// <summary>
        /// This method calculates and returns the square and square root of a given number.
        /// </summary>
        /// <param name="a">The number whose square and root will be calculated.</param>
        /// <param name="sq">Square of the input number</param>
        /// <param name="rt">Square root of the input number</param>
        /// <returns>Returns true if the number is even, false otherwise</returns>
        public static bool SquareAndRoot(double a, out double sq, out double rt)
        {
            sq = a * a;
            rt = Math.Sqrt(a);

            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddAndMultiply(double a, double b, out double sum, out double product)
        {
            sum = a + b;
            product = a * b;
        }
        #endregion



        static void Main(string[] args)
        {
            double sumResult, productResult;

            AddAndMultiply(10, 30, out sumResult, out productResult);
            double rootResult, squareResult;
            bool value = SquareAndRoot(25, out squareResult, out rootResult);
            SquareAndRoot(10, out squareResult, out rootResult);

            //double a = double.Parse(Console.ReadLine());

            double a;

            bool conversionResult = double.TryParse(Console.ReadLine(), out a);
            if (conversionResult == true)
            {
                Console.WriteLine("Thank you, you made a correct entry. Number: {0}", a);
            }
            else
            {
                Console.WriteLine("Such a user should not exist. Wrong.");
            }

            Console.WriteLine(squareResult);
            double result = sumResult + productResult;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
