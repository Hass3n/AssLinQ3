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
        
        private string GetSortedWord(string word)
        {
            return new string(word.Trim().OrderBy(c => c).ToArray());
        }

        public bool Equals(string x, string y)
        {
            return GetSortedWord(x) == GetSortedWord(y);
        }

        public int GetHashCode(string obj)
        {
            return GetSortedWord(obj).GetHashCode();
        }
    }
}

