using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficControl.Core
{
    public class Schedule
    {
        public static Dictionary<int, List<int>> RestrictionForDay()
        {
            return new Dictionary<int, List<int>>
            {
                { 1, new List<int> { 1, 2 } }, // Monday
                { 2, new List<int> { 3, 4 } }, // Tuesday
                { 3, new List<int> { 5, 6 } }  // Wednesday
            };
        }

        public static IList<RestrictedTimeRange> RestrictionForHours()
        {
            return new List<RestrictedTimeRange>
            {
                new RestrictedTimeRange(700, 930),
                new RestrictedTimeRange(1600, 1930)
            };
        }
    }
}
