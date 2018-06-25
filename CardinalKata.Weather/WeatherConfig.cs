using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata
{
    class WeatherConfig : IReaderConfig
    {
        public int AStart => 6;
        public int BStart => 12;
        public int IdentityStart => 2;
        public int IdentityLen => 2;
        public string ObjectName => "Day";

        public bool IsMeaningfulLine(string line)
        {
            if (string.IsNullOrEmpty(line))
                return false;

            var possibleRankValue = line.Substring(2, 2);
            return int.TryParse(possibleRankValue.Trim(), out _);
        }
    }
}
