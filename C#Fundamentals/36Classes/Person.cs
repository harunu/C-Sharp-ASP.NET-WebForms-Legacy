using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36Classes
{
    public class Person
    {
        public string Name;
        public int Age;
        public string BloodType;

        private int Generosity;

        private int AffectionExpectation;

        private double CheckPocket()
        {
            Random sans = new Random();
            double inPocket = sans.Next(1, 100);
            return inPocket;
        }


        public double GiveMoney()
        {
            double owned = CheckPocket();
            double toGive = (Generosity * owned) / 100;
            return toGive;
        }


        public void HowAreYou()
        {
            if (AffectionExpectation > 50)
            {
                Console.WriteLine("Thanks for asking, it made me very happy!");
            }
            else
            {
                Console.WriteLine("What's it to you? Are you going to ask for a loan again?");
            }
        }

        /// <summary>
        /// This was created just as an example.
        /// </summary>
        public Person()
        {
            Generosity = (new Random()).Next(1, 100);
            Age = 0;
            BloodType = "0 rh /";
            Console.WriteLine("Parameterless constructor executed.");

            AffectionExpectation = (new Random()).Next(1, 100);
        }

        public void Speak()
        {
            Console.WriteLine("I am a person named {0}, {1} years old.", Name, Age);
        }

    }
}
