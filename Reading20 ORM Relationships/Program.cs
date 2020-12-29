using System;
using System.Linq;

namespace Reading20_ORM_Relationships
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            var doubleNums = nums.Select(x => 2 * x);
            Console.WriteLine(string.Join(" ", doubleNums));
        }
    }
}
