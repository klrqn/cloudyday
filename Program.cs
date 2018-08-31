using System;

namespace cloudyday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p = new long[] {1, 2, 4, 6};
            var x = new long[] {1, 2, 4, 6};
            var y = new long[] {1, 2, 4, 6};
            var r = new long[] {1, 2, 4, 6};

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

            // practice - print all data
            System.Console.WriteLine("Number of Towns:\t{0}", towns);
            System.Console.WriteLine("Number of Clouds:\t{0}", clouds);

            // location of towns
            System.Console.Write("Location of towns:\t");
            for (var i = 0; i < towns; i++)
                System.Console.Write("{0} ", p[i]);
            System.Console.WriteLine();
            
            // location of clouds
            System.Console.Write("Location of clouds:\t");
            for (var i = 0; i < towns; i++)
                System.Console.Write("{0} ", p[i]);
            System.Console.WriteLine();

            System.Console.WriteLine(x);
            System.Console.WriteLine(r);

            return 1;


            // create a list of all cloudy locationscreate a list of all cloudy locations


            // iterate through list of town locations
            // if
        }
    }
}
