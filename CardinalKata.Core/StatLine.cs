using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata
{
    public class StatLine
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public string Identity { get; set; }
        public int Delta => Math.Abs(Min - Max);
    }
}
