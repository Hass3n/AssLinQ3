using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssLinQ3
{
    internal class CustomComperer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            throw new NotImplementedException();
        }
    }
}
}
