using System;
using System.Linq;

namespace Reading20_ORM_Relationships
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 50, 100 };
            // map function called .Select()
            var doubleNums = nums.Select(x => 2 * x);
            Console.WriteLine(string.Join(" ", doubleNums));
            // filter function called .Where()
            var evenNums = nums.Where(x => (x % 2 == 0));
            Console.WriteLine(string.Join(" ", evenNums));
            // var smiths = firstNames.Select(_______);
            string[] firstNames = { "John", "Jane", "Joe" };
            var smithNames = firstNames.Select(x => x + " Smith");
            Console.WriteLine(string.Join(" ", smithNames));
            // var bigNums = nums.Where(______);
            var bigNums = nums.Where(x=>(x > 42));
            Console.WriteLine(string.Join(" ", bigNums));
        }
    }
}
