using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37ClassesRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //RectangleOperations();
            //CircleOperations();

            Customer cust = new Customer();
            cust.Name = "Ahmet";
            cust.CreditScore = 5;
            int credit = cust.GrantCredit();
            Console.WriteLine(credit);
            Console.ReadLine();
        }

        private static void CircleOperations()
        {
            Circle circle = new Circle();
            circle.Radius = 5;
            int a = circle.Radius;
        }

        private static void RectangleOperations()
        {
            Rectangle shape1 = new Rectangle();
            //shape1.Width = -10;
            //shape1.Height = 20;
            shape1.SetWidthHeight(10, 20);
            shape1.HeightProperty = 6;

            Console.WriteLine(shape1.HeightProperty);
            Console.WriteLine(shape1.Diagonal());
            Console.WriteLine(shape1.RectangleName);
        }
    }
}
