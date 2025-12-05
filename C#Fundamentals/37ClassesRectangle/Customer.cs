using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37ClassesRectangle
{
    class Customer
    {
        string _name, _accountNumber;
        int _creditScore;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }

        /// <summary>
        /// A number between 1-5
        /// </summary>
        public int CreditScore
        {
            get
            {
                return _creditScore;
            }
            set
            {
                if (value <= 5 && value > 0)
                {
                    _creditScore = value;
                }

            }
        }

        /// <summary>
        /// Returns CreditScore * 10
        /// </summary>
        public int GrantCredit()
        {
            return _creditScore * 10;
        }
    }
}
