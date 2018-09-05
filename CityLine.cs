using System;
using System.Collections.Generic;

namespace cloudyday
{
    public class CityLine
    {
        public List<Cloud> Clouds;
        public List<Town> Towns;

        // get sum of all towns population.
        public long TotalPopulation(List<Town> Towns)
        {
            long sum = 0;
            foreach (var town in Towns)
            {
                System.Console.WriteLine("Sum: {0}", sum);
                sum += town.Population;
            }
            return sum;
        }

        public long SunnyPopulation()
        {
            var sunnyTowns = Towns;
            long sunnyTownsPopulation = TotalPopulation(Towns);
            for (var i = 0; i < Towns.Count; i++)
            {
                for (var j = 0; j < Clouds.Count; j++)
                {
                    if (sunnyTowns[i].Location >= Clouds[j].LowerLimit && sunnyTowns[i].Location <= Clouds[j].UpperLimit)
                    {
                        sunnyTownsPopulation -= sunnyTowns[i].Population;
                        sunnyTowns.Remove(sunnyTowns[i]);
                        continue;    
                    }
                }
            }
            return sunnyTownsPopulation;
        }
    }

}