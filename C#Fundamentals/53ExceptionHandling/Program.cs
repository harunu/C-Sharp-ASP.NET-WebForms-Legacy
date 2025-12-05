using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            bool inputSuccessful = false;
            do
            {
                Console.WriteLine("Enter two numbers for division:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                result = 0;
                try
                {
                    result = a / b;
                    result++;
                    --result;
                    inputSuccessful = true;

                    //Close
                }
                catch (Exception)
                {
                    inputSuccessful = false;

                    Console.WriteLine("Entering 0 was a big mistake.");
                }
                finally
                {

                }

            } while (inputSuccessful == false);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
