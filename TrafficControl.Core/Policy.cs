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

        public bool IsRestricted => IsRestictedForDay && IsRestrictedForTime();

        private bool IsRestictedForDay => Schedule.RestrictedDays[_date.DayOfWeek].Contains(_licencePlate.LastDigit);

        private bool IsRestrictedForTime()
        {
            int timeValue = _time.Value;
            return Schedule.RestrictedTimeRanges.Any(
                range => timeValue >= range.Start && timeValue <= range.End);
        }
    }
}