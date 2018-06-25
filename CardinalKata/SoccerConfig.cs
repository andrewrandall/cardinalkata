using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata
{
    class SoccerConfig : IReaderConfig
    {
        public int AStart => 50;
        public int BStart => 43;
        public int IdentityStart => 7;
        public int IdentityLen => 13;
        public string ObjectName => "Team";

        public bool IsMeaningfulLine(string line)
        {
            if (string.IsNullOrEmpty(line))
                return false;

            var possibleRankValue = line.Substring(3, 2);
            return int.TryParse(possibleRankValue.Trim(), out _);
        }
    }
}
