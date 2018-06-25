using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Run(WeatherPath, new WeatherConfig());
            Run(SoccerPath, new SoccerConfig());
            Console.ReadKey();
        }

        const string WeatherPath = "data\\weather.dat";
        const string SoccerPath = "data\\soccer.dat";

        static void Run(string path, IReaderConfig config)
        {
            var parser = new Parser();
            var statLines = parser.Parse(path, config);
            var smallestSpread = statLines.OrderBy(e => e.Delta).First();
            Console.WriteLine($"{config.ObjectName} {smallestSpread.Identity} has the smallest spread with {smallestSpread.Delta}");
        }
    }
}
