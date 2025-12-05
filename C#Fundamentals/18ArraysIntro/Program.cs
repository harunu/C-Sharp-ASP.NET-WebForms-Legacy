using System;

namespace _18ArraysIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = "";
            string[] students = new string[5];
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Enter the day number");
            int dayNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(days[dayNumber - 1]);

            string[] months = new string[12];

            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[11] = "December";

            Console.WriteLine("Enter the month number");
            int monthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(months[monthNumber - 1]);

            Console.ReadLine();
        }
    }
}
