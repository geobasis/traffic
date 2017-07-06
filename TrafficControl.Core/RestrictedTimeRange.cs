namespace TrafficControl.Core
{
    public struct RestrictedTimeRange
    {
        public int Start { get; private set; }
        public int End { get; private set; }

        public RestrictedTimeRange(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}