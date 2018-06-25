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
            new Reporter().Run("weather.dat", new WeatherConfig());
        }
    }
}
