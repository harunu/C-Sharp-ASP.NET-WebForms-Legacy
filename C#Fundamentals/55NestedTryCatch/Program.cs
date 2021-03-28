using System;

namespace _55NestedTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 0;

            try
            {
                try
                {
                    int l = a / b;
                }
                catch (Exception)
                {
                    try
                    {
                        Exception p = new Exception();
                        Console.WriteLine("1 numara çalıştı");
                        throw p;
                    }
                    catch (IndexOutOfRangeException ab)
                    {
                        Console.WriteLine("3 numara çalıştı.");
                    }
                }
                int mk = a / b;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("2 numara çalıştı");
            }
            Console.ReadLine();
        }
    }
}
