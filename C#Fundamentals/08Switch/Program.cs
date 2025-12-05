using System;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            Label_Start:

            // Traditional if-else version (commented out)
            /*
            if (a == 1)
            {
                Console.WriteLine("The value of 'a' is 1.");
            }
            else if (a == 2)
            {
                Console.WriteLine("The value of 'a' is 2.");
            }
            else if (a == 5)
            {
                Console.WriteLine("The value of 'a' is 5.");
            }
            else
            {
                Console.WriteLine("The value of 'a' is something else.");
            }
            */

            // Switch-case equivalent
            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine("The value of 'a' is 2.");
                    break;

                case 5:
                    Console.WriteLine("The value of 'a' is 5.");
                    goto case 1; // Redirect to case 1 after printing

                default:
                    Console.WriteLine("The value of 'a' is something else.");
                    break;
            }

            Console.ReadLine();
            goto Label_Start; // Infinite loop (returns to the label)
        }
    }
}