using System;

namespace task3
{
    internal static class Program
    {
        private static void Main()
        {
            var house = new House(10, 10000);
            var house2 = house.Clone();
            var house3 = house.DeepClone();
            Console.WriteLine(house.ToString());
            Console.WriteLine(house2.ToString());
            Console.WriteLine(house3.ToString());
        }
    }
}