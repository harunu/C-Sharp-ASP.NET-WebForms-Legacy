using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ExceptionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Apple", "Pear", "Orange", "Plum", "Cherry" };
            entry:
            Console.WriteLine("Which element of the array do you want to see?");

            try
            {
                int element = int.Parse(Console.ReadLine());

                int s = 19 / element;
                Console.WriteLine(array[element]);

            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine("You entered a number that is not in the array.");
                goto entry;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Didn't we say enter a number, why did you enter that :( ?");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.GetType());
            }
            finally
            {

                Console.WriteLine("It was nice working with you.");
            }

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
