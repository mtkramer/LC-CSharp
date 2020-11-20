using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8_Interfaces
{
    public abstract class BaseDisc
    {
        public string Name = "Blank";
        public const uint Capacity = 100;
        public uint DataSize = 0;
        public bool IsLoaded = false;
        public bool IsSpinning = false;

    }
}
