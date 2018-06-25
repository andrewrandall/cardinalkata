using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata
{
    public class Parser
    {
        public IEnumerable<StatLine> Parse(string filePath, IReaderConfig config)
        {
            var lines = File.ReadLines(filePath);
            foreach (var line in lines)
            {
                if (config.IsMeaningfulLine(line))
                {
                    yield return new StatLine
                    {
                        Identity = line.Substring(config.IdentityStart, config.IdentityLen).Trim(),
                        Min = int.Parse(line.Substring(config.AStart, 2)),
                        Max = int.Parse(line.Substring(config.BStart, 2))
                    };
                }
            }
        }
    }
}
