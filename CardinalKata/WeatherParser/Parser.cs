using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata.WeatherParser
{
    class Parser
    {
        public Entry Parse(string line)
        {
            var dayCol = line.Substring(2, 2);
            var minCol = line.Substring(6, 2);
            var maxCol = line.Substring(12, 2);
            return new Entry
            {
                DayNumber = int.Parse(dayCol),
                MinimumTemperature = int.Parse(minCol),
                MaximumTemperature = int.Parse(maxCol)
            };
        }
    }
}
