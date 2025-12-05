using System;

namespace _39PhoneNumberClass
{
    class PhoneNumber
    {
        private string _type;

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                switch (value)
                {
                    case "Home":
                    case "Mobile":
                    case "Work":
                        _type = value;
                        break;
                    default:
                        _type = "Unknown";
                        break;
                }
            }
        }

        public void MakeCall()
        {
            Console.WriteLine(Name + " " + LastName + " " + Number + " is being called. Please wait.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneNumber phoneNo = new PhoneNumber()
            {
                Name = "Ahmet",
                LastName = "Hunkar",
                Number = "111111",
                Type = "Other"
            };
            phoneNo.MakeCall();
            Console.WriteLine(phoneNo.Type);
            Console.Read();
        }
    }
}
