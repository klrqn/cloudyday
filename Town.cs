using System;

namespace cloudyday
{
    public class Town
    {
        public long Population;
        public long Location;

        public Town(long population, long location)
        {
            this.Population = population;
            this.Location = location;
        }
    }
}