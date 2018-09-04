using System;
using System.Collections.Generic;

namespace cloudyday
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var p = new long[] {10, 50, 40, 60};// town populations
            var x = new long[] {6, 8, 12, 20};  // town location
            var y = new long[] {4, 10, 13, 18}; // cloud location (center)
            var r = new long[] {2, 4, 3, 2};    // cloud range

            System.Console.WriteLine(maximumPeople(p, x, y, r));
        }

        // Return the maximum number of people that will be in a sunny town after removing exactly one cloud.
        static long maximumPeople(long[] p, long[] x, long[] y, long[] r) 
        {
            // get # of towns and clouds
            var towns           = p.Length;
            var clouds          = y.Length;
            var townsLocation   = p;
            var townsPopulation = x;
            var cloudsLocation  = y;
            var cloudsSize      = r;

            // var data = new CityLine();

            // practice - print all data
            System.Console.WriteLine("Number of Towns:\t{0}", towns);
            System.Console.WriteLine("Number of Clouds:\t{0}", clouds);

            var allClouds = new List<Cloud>();
            var allTowns = new List<Town>();

            // location of towns
            System.Console.Write("Location of towns:\t");
            for (var i = 0; i < towns; i++)
            {
                System.Console.Write("{0} ", p[i]);
                var town = new Town(x[i],p[i]);
                allTowns.Add(town);
            }

            System.Console.WriteLine();
            
            // location of clouds
            System.Console.Write("Location of clouds:\t");
            for (var i = 0; i < towns; i++)
            {
                System.Console.Write("{0} ", y[i]);
                var cloud = new Cloud(y[i]-r[i], y[i]+r[i]);
                allClouds.Add(cloud);
            }


            System.Console.WriteLine();

            foreach (var item in allTowns)
            {
            System.Console.Write(" " + item);
            System.Console.Write(" " + item.Location + " " + item.Population);
            }

            foreach (var item in allClouds)
            {
            System.Console.Write(" " + item);
            System.Console.Write(" " + item.LowerLimit + " " + item.UpperLimit);
            }
            // System.Console.WriteLine(r);

            return 1;


            // create a list of all cloudy locationscreate a list of all cloudy locations


            // iterate through list of town locations
            // if
        }
    }
}
