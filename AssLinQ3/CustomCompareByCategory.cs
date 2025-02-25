using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssLinQ3
{
    internal class CustomCompareID : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            if(x==null)
            {

                if (y == null)
                    return true;

            }

            return x?.Category.Equals(y?.Category) ??false;

        }
        
        public int GetHashCode([DisallowNull] Product obj)
        {
           return HashCode.Combine(obj.Category);
        }
    }
}
