using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata
{
    public class Reporter
    {
        public void Run(string path, IReaderConfig config)
        {
            var parser = new Parser();
            var statLines = parser.Parse(path, config);
            var smallestSpread = statLines.OrderBy(e => e.Delta).First();
            Console.WriteLine($"{config.ObjectName} {smallestSpread.Identity} has the smallest spread with {smallestSpread.Delta}");
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
