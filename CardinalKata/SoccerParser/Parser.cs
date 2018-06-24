using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata.SoccerParser
{
    class Parser
    {
        public Entry Parse(string line)
        {
            var nameCol = line.Substring(7, 13);
            var forCol = line.Substring(43, 2);
            var againstCol = line.Substring(50, 2);
            return new Entry
            {
                Team = nameCol.Trim(),
                GoalsScored = int.Parse(forCol),
                GoalsAllowed = int.Parse(againstCol)
            };
        }
    }
}
