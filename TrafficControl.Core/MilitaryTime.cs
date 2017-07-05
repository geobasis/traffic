using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficControl.Core
{
    public class MilitaryTime
    {
        public static int Parse(string time)
        {
            string[] timeComponets = time.Split(':');
            string hourComponent = timeComponets[0];
            string minuteComponent = timeComponets[1];

            int hour = Convert.ToUInt16(hourComponent);
            int minute = Convert.ToUInt16(minuteComponent);

            return hour * 100 + minute;
        }
    }
}