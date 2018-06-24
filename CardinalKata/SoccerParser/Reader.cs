using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata.SoccerParser
{
    public class Reader
    {
        public IEnumerable<Entry> Read(string filePath)
        {
            var parser = new Parser();
            var lines = File.ReadLines(filePath).ToArray();
            foreach (var line in lines.Skip(1).Take(17))
            {
                yield return parser.Parse(line);
            }
            foreach (var line in lines.Skip(19).Take(3))
            {
                yield return parser.Parse(line);
            }
        }
    }
}
