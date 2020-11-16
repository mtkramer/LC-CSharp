using System;


namespace Reading5_Classes_Pt2_Obj
{
    public class Pet
    {
        public string Name { get; set; }
        public Pet(string n) { Name = n; }

        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == this) { return true; }
            if (toBeCompared == null) { return false; }
            if (toBeCompared.GetType() != GetType()) { return false; }
            Pet p = toBeCompared as Pet;
            return p.Name == Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
