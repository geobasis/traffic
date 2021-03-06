﻿using System;
using System.Collections.Generic;

namespace TrafficControl.Core
{
    public class Schedule
    {
        private static Dictionary<DayOfWeek, List<int>> _restrictedDays = null;
        public static Dictionary<DayOfWeek, List<int>> RestrictedDays => (_restrictedDays == null)
            ? new Dictionary<DayOfWeek, List<int>>
                {
                    { DayOfWeek.Monday, new List<int> { 1, 2 } },
                    { DayOfWeek.Tuesday, new List<int> { 3, 4 } },
                    { DayOfWeek.Wednesday, new List<int> { 5, 6 } },
                    { DayOfWeek.Thursday, new List<int> { 7, 8 } },
                    { DayOfWeek.Friday, new List<int> { 9, 0 } },
                    { DayOfWeek.Saturday, new List<int> { } }, // Saturday and Sunday not exist restriction of circulation
                    { DayOfWeek.Sunday, new List<int> { } }
                }
            : _restrictedDays;

        private static IList<RestrictedTimeRange> _restrictedTimeRanges = null;
        public static IList<RestrictedTimeRange> RestrictedTimeRanges => (_restrictedTimeRanges == null)
            ? new List<RestrictedTimeRange>
                {
                    new RestrictedTimeRange(700, 930),
                    new RestrictedTimeRange(1600, 1930)
                }
            : _restrictedTimeRanges;
    }
}