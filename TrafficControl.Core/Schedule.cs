using System;
using System.Collections.Generic;

namespace TrafficControl.Core
{
    public class Schedule
    {
        public static Dictionary<DayOfWeek, List<int>> RestrictionForDay =>
            new Dictionary<DayOfWeek, List<int>>
            {
                { DayOfWeek.Monday, new List<int> { 1, 2 } },
                { DayOfWeek.Tuesday, new List<int> { 3, 4 } },
                { DayOfWeek.Wednesday, new List<int> { 5, 6 } },
                { DayOfWeek.Saturday, new List<int> { } }
            };

        public static IList<RestrictedTimeRange> RestrictionForHours =>
            new List<RestrictedTimeRange>
            {
                new RestrictedTimeRange(700, 930),
                new RestrictedTimeRange(1600, 1930)
            };
    }
}
