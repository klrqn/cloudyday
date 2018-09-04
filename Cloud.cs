using System;

namespace cloudyday
{
    public class Cloud
    {
        public long LowerLimit;
        public long UpperLimit;

        public Cloud(long lowerLimit, long upperLimit)
        {
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
        }
    }
}