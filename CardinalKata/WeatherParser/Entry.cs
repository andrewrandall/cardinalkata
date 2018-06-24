using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata.WeatherParser
{
    public class Entry
    {
        public int DayNumber { get; set; }
        public int MaximumTemperature { get; set; }
        public int MinimumTemperature { get; set; }

        public int TemperatureSpread => Math.Abs(MaximumTemperature - MinimumTemperature);
    }
}
