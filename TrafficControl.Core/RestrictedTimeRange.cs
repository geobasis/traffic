namespace TrafficControl.Core
{
    public struct RestrictedTimeRange
    {
        public int Start { get; set; }
        public int End { get; set; }

        public RestrictedTimeRange(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}