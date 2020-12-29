using System;
using System.Linq;

namespace Reading20_ORM_Relationships
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            // map function called .Select()
            var doubleNums = nums.Select(x => 2 * x);
            Console.WriteLine(string.Join(" ", doubleNums));
            // filter function called .Where()
            var evenNums = nums.Where(x => (x % 2 == 0));
            Console.WriteLine(string.Join(" ", evenNums));
        }
    }
}
