using System;

namespace _43Enumerations
{
    class Customer
    {
        public enum CustomerType
        {
            Buyer, Seller, Both
        }

        public enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }


        public string CustomerName { get; set; }

        /// <summary>
        /// Enter 1 for Buyer, 2 for Seller, 3 for Both
        /// </summary>
        public CustomerType CType { get; set; }

        public string GetAccountReport(Days day)
        {
            Console.WriteLine(day.ToString() + " report");
            return "";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Customer a = new Customer();
            a.CustomerName = "Kelimator";
            a.CType = Customer.CustomerType.Buyer;

            //a.GetAccountReport(Customer.Days.Tuesday);
            string[] daysStr = Enum.GetNames(typeof(Customer.Days));
            Customer.Days k = (Customer.Days)4;

            int i = 1;
            foreach (string day in daysStr)
            {
                Console.WriteLine(i.ToString() + " - " + day);
                i++;
            }

            Console.WriteLine("Which day's report do you want?");
            int dayValue = int.Parse(Console.ReadLine());

            a.GetAccountReport((Customer.Days)(dayValue - 1));
            Console.Read();
        }
    }
}
