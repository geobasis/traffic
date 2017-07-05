using System;
using System.Collections.Generic;

namespace TrafficControl.Core
{
    public class Schedule
    {
        private static Dictionary<DayOfWeek, List<int>> _restrictionForDay = null;
        public static Dictionary<DayOfWeek, List<int>> DayRestricteds => (_restrictionForDay == null)
            ? new Dictionary<DayOfWeek, List<int>>
                {
                    { DayOfWeek.Monday, new List<int> { 1, 2 } },
                    { DayOfWeek.Tuesday, new List<int> { 3, 4 } },
                    { DayOfWeek.Wednesday, new List<int> { 5, 6 } },
                    { DayOfWeek.Thursday, new List<int> { 7, 8 } },
                    { DayOfWeek.Friday, new List<int> { 9, 0 } }
                }
            : _restrictionForDay;

        private static IList<RestrictedTimeRange> _restrictionForHours = null;
        public static IList<RestrictedTimeRange> RangeTimeRestricteds => (_restrictionForHours == null)
            ? new List<RestrictedTimeRange>
                {
                    new RestrictedTimeRange(700, 930),
                    new RestrictedTimeRange(1600, 1930)
                }
            : _restrictionForHours;
    }
}
