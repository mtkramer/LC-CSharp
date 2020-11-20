using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8_Interfaces
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone a, Cone b) {
            return string.Compare(a.Cost.ToString(), b.Cost.ToString());
        }
    }
}
