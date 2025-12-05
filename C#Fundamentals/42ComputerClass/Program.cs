using System;

namespace _42ComputerClass
{
    class Program
    {
        /*
        Create a class called Computer with the following properties:
        - ProcessorSpeed (Hz) int
        - Ram size (powers of 2) int // if not a power of 2, increase to be a power of 2
        - Disk size (powers of 2) long // if not a power of 2, increase to be a power of 2

        To create a computer, processor and ram must be defined. Computer object cannot be
        created without defining processor and ram. However, disk size can optionally be
        defined when creating an instance of the computer class.

        The computer should have a method called PerformOperation that takes an int parameter.
        - A processor with 1 Hz can perform 1 unit operation in 1 ms, so return how long the
          operation will take. Also check if enough ram is available and return 0 if ram is insufficient.
        - Have a WriteToDisk method that takes a string variable. If disk size is smaller than
          string length return false, otherwise return true.
        */


        static void Main(string[] args)
        {
            Computer b = new Computer(500, 64001);
            Console.WriteLine(b.PerformOperation(8000));
            Console.WriteLine(b.WriteToDisk("Hello world"));
            Console.Read();
        }
    }
}
