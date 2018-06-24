using WP = CardinalKata.WeatherParser;
using SP = CardinalKata.SoccerParser;
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
            Weather();
            Soccer();
            Console.ReadKey();
        }

        static void Weather()
        {
            var reader = new WP.Reader();
            var entries = reader.Read("WeatherParser\\data\\weather.dat").ToArray();
            var smallestSpread = entries.OrderBy(e => e.TemperatureSpread).First();
            Console.WriteLine($"Day {smallestSpread.DayNumber} has smallest spread with {smallestSpread.TemperatureSpread}");
        }

        static void Soccer()
        {
            // obviously I had to regionalize the name so the intended audience could understand
            var reader = new SP.Reader();
            var entries = reader.Read("SoccerParser\\data\\soccer.dat").ToArray();
            var smallestSpread = entries.OrderBy(e => e.GoalsDelta).First();
            Console.WriteLine($"Team {smallestSpread.Team} has smallest spread with {smallestSpread.GoalsDelta}");
        }
    }
}
