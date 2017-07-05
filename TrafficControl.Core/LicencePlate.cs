using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficControl.Core
{
    public class LicencePlate
    {
        private string _number;

        public LicencePlate(string number)
        {
            _number = number;
        }

        public int LastDigit()
        {
            var lastDigit = _number[_number.Length - 1].ToString();
            return Convert.ToUInt16(lastDigit);
        }
    }
}
