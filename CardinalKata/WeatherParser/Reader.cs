using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata.WeatherParser
{
    public class Reader
    {
        public IEnumerable<Entry> Read(string filePath)
        {
            var parser = new Parser();
            var lines = File.ReadLines(filePath);
            foreach (var line in lines.Skip(2).Take(30))
            {
                yield return parser.Parse(line);
            }
        }
    }
}
