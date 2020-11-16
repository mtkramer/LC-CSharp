using System;

namespace Studio5_Classes_Pt2_Obj
{
    class MenuItem
    {
        public int Category { get; set; }
        public bool Neo { get; set; }
        public string Description { get; set; }
        public float Price { get; }

        public MenuItem(string descript, float price, int category)
        {
            Category = category;
            Neo = true;
            Description = descript;
            Price = price;
        }
        public override bool Equals(object obj)
        {
            return obj is MenuItem menuItem &&
                Category == menuItem.Category &&
                Neo == menuItem.Neo &&
                Description == menuItem.Description &&
                Price == menuItem.Price;
        }
    }
}
