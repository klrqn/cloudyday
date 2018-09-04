using System;
using System.Collections.Generic;

namespace cloudyday
{
    public class CityLine
    {
        public List<Cloud> Clouds;
        public List<Town> Towns;

        // get sum of all towns population.
        public long TotalTownPopulation()
        {
            long sum = 0;
            foreach (var town in Towns)
            {
                // System.Console.WriteLine("Sum: {0}", sum);
                sum += town.Population;
            }
            return sum;
        }
    }

}