using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Reading8_Interfaces
{
    class JobComparer : IComparable<Job>
    {
        public int Compare(Job x, Job y)
        {
            return string.Compare(x.Name, y.Name);
        }

        public int CompareTo([AllowNull] Job other)
        {
            throw new NotImplementedException();
        }
    }
}
