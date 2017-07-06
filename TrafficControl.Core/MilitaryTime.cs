using System;

namespace TrafficControl.Core
{
    public class MilitaryTime
    {
        private string _time;

        public MilitaryTime(string time)
        {
            _time = time;
        }

        public int Value
        { 
            get
            {
                string[] timeComponets = _time.Split(':');
                string hourComponent = timeComponets[0];
                string minuteComponent = timeComponets[1];

                int hour = Convert.ToUInt16(hourComponent);
                int minute = Convert.ToUInt16(minuteComponent);

                return (hour * 100) + minute;
            }
        }
    }
}