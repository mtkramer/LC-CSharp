using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8_Interfaces
{
    public interface IOpticalDisc
    {
        void LoadDisc();
        void SpinDisc();
        void WriteData(string name, uint data);
        void PlayDisc();
    }
}
