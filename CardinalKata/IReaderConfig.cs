using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalKata
{
    public interface IReaderConfig
    {
        bool IsMeaningfulLine(string line);
        int AStart { get; }
        int BStart { get; }
        int IdentityStart { get; }
        int IdentityLen { get; }
        string ObjectName { get; }
    }
}
