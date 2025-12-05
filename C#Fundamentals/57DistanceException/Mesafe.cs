using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57DistanceException
{
    class Distance
    {
        int _km;
        int _m;
        public int Kilometer
        {
            get
            {
                return _km;
            }
            set
            {
                if (value < 0)
                {
                    throw new DistanceException(value, this._m);
                }
                _km = value;
            }
        }
        public int Meter
        {
            get
            {
                return _m;
            }
            set
            {
                if (value < 0 || value > 999)
                {
                    throw new DistanceException(_km, value);
                }
                _m = value;
            }
        }
    }

    public class DistanceException : ApplicationException
    {

        string distanceIssue = "";
        public string DistanceIssue
        {
            get
            {
                return distanceIssue;
            }
            private set
            {
                distanceIssue = value;
            }
        }

        /// <summary>
        /// This exception is created when there is an assignment error in the Distance class.
        /// </summary>
        /// <param name="kilometer">Invalid km</param>
        /// <param name="meter">Invalid meter</param>
        public DistanceException(int kilometer, int meter)
        {
            if (kilometer < 0)
            {
                DistanceIssue += "Enter a value greater than 0 for the Kilometer property. ";
            }

            if (meter < 0 || meter > 999)
            {
                DistanceIssue += "Enter a value in the range [0-1000) for the Meter property.";
            }
        }

        public string Message
        {
            get
            {
                return "Distance value was entered incorrectly.";
            }
        }
    }
}
