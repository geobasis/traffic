using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficControl.Core
{
    public class Policy
    {
        private LicencePlate _licencePlate;
        private DateTime _date;
        private MilitaryTime _time;

        public Policy(LicencePlate licencePlate, DateTime date, MilitaryTime time)
        {
            _licencePlate = licencePlate;
            _date = date;
            _time = time;
        }

        public bool IsRestricted { 
            get
            {
                return IsRestictedForDay() && IsRestrictedForTime();
            }
        }
        private bool IsRestictedForDay()
        {
            var dayOfWeek = _date.DayOfWeek;
            Dictionary<DayOfWeek, List<int>> restrictionForDay = Schedule.DayRestricteds;
            if (restrictionForDay.ContainsKey(dayOfWeek))
            {
                var lastDigit = _licencePlate.LastDigit;
                return restrictionForDay[dayOfWeek].Contains(lastDigit);
            }
            else
            {
                return false;
            }
        }

        private bool IsRestrictedForTime()
        {
            int timeValue = _time.Value;
            return Schedule.RangeTimeRestricteds.Any(
                range => timeValue >= range.Start && timeValue <= range.End);
        }
    }
}
