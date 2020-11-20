using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8_Interfaces
{
    class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor a, Flavor b)
        {
            return string.Compare(a.Name, b.Name);
        }
    }
}
