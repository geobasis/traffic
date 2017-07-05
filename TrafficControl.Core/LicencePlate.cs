using System;

namespace TrafficControl.Core
{
    public class LicencePlate
    {
        private string _number;

        public LicencePlate(string number)
        {
            _number = number;
        }

        public int LastDigit { 
            get {
                var lastDigit = _number[_number.Length - 1].ToString();
                return Convert.ToUInt16(lastDigit);
                }
        }
    }
}
