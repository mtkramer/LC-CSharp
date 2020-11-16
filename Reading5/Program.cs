using System;

namespace Reading5_Classes_Pt2_Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPet = "Fluffy";
            Pet secondPet = new Pet("Fluffy");
            Pet thirdPet = new Pet("Fluffy");
            Console.WriteLine($"secondPet == thirdPet: {secondPet == thirdPet}");  // false
            Console.WriteLine($"thirdPet.Equals(secondPet): {thirdPet.Equals(secondPet)}");  //  true
            Console.WriteLine($"thirdPet.Name == firstPet: {thirdPet.Name == firstPet}");  //  true
            Console.WriteLine($"thirdPet.Equals(firstPet): {thirdPet.Equals(firstPet)}");  //  false
        }
    }
}
