using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7_Inheritance
{
    public abstract class AbstractEntity
    {
        private static uint nextId = 1;
        public readonly uint id;

        public AbstractEntity()
        {
            id = nextId;
            nextId++;
        }

    }
}
