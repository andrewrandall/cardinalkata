using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata.SoccerParser
{
    public class Entry
    {
        public string Team { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsAllowed { get; set; }

        public int GoalsDelta => Math.Abs(GoalsScored - GoalsAllowed);
    }
}
