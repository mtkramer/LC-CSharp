using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8_Interfaces
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        
        public void LoadDisc()
        {
            IsLoaded = true;
            Console.WriteLine($"{Name} DVD is loaded.");
        }

        public void PlayDisc()
        {
            SpinDisc();
            if (IsSpinning)
            {
                Console.WriteLine($"Playing {Name} DVD.  Enjoy!");
            }
            
        }

        public void SpinDisc()
        {
            if (IsLoaded) { IsSpinning = true;  Console.WriteLine($"{Name} DVD is spinning..."); }
            else { Console.WriteLine("Disc must be loaded into tray beforing spinning."); }
        }

        public void WriteData(string name, uint data)
        {
            SpinDisc();
            if(Capacity < DataSize + data) { 
                Console.WriteLine($"Cannot write {data} bytes onto {Name} DVD; {Capacity - DataSize} bytes remaining.");
            }
            else {
                Console.WriteLine($"Writing {data} bytes to {Name} DVD...");
                DataSize += data;
                Name = name;
                Console.WriteLine($"{Capacity - DataSize} bytes remain on {Name} DVD.");
                IsSpinning = false; 
            }
        }
    }
}
