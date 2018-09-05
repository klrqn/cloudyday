using System;

namespace cloudyday
{
    public struct Town
    {
        public long Population, Location;

        public Town(long population, long location)
        {
            Population = population;
            Location = location;
        }
    }
}

