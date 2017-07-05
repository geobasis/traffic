using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficControl.Core
{
    public class Policy
    {
        private string _licencePlate;
        private DateTime _date;
        private string _time;

        public Policy(string licencePlate, DateTime date, string time)
        {
            _licencePlate = licencePlate;
            _date = date;
            _time = time;
        }

        private bool IsRestictedForDay()
        {
            return false;
        }
    }
}
