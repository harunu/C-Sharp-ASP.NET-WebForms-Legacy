using System;

namespace _38ClassesReview
{
    class Student
    {
        /* Access modifiers:
         * public : Everyone can access
         * private : Only accessible within the class itself
         */

        public Student(string name)
        {
            AgeProperty = 16;
            this.Name = name;
        }

        private int _Number;

        public int Number
        {
            get
            {
                return _Number;
            }
            set
            {
                _Number = value;
            }
        }


        public string Name;
        public string LastName;
        private int _age;

        public void SetAge(int value)
        {
            if (value > 0 && value < 120)
            {
                if ((value > 50 && (Name != "BetulCan")) || value < 50)
                {
                    _age = value;
                    return;
                }
            }

            throw new Exception("Cannot assign such a value to the Age property");
        }

        public int GetAge()
        {
            return _age;
        }

        public int AgeProperty
        {
            get
            {
                return _age;
            }

            private set
            {
                if (value > 0 && value < 120)
                {
                    if ((value > 50 && (Name != "BetulCan")) || value < 50)
                    {
                        _age = value;
                        return;
                    }
                }
            }
        }
        public void Speak()
        {
            Console.WriteLine("I am a student, my name is {0}", Name);
        }
    }
}
