using System;
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

        public bool IsRestricted()
        {
            return IsRestictedForDay() && IsRestrictedForTime();
        }

        private bool IsRestictedForDay()
        {
            var dayOfWeek = _date.DayOfWeek;
            var lastDigit = _licencePlate.LastDigit();
            // FIXME: I should be a property
            return Schedule.RestrictionForDay[dayOfWeek].Contains(lastDigit);
        }

        private bool IsRestrictedForTime()
        {
            return Schedule.RestrictionForHours.Any(
                range => _time.Value() >= range.Start && _time.Value() <= range.End);
        }
    }
}
