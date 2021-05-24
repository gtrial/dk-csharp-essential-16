using System;

namespace task2
{
    internal static class Program
    {
        private static void Main()
        {
            var block1 = new Block(1, 2, 3, 4);
            var block2 = new Block(1, 2, 3, 4);
            Console.WriteLine(block1.GetHashCode());
            Console.WriteLine(block2.GetHashCode());
            Console.WriteLine(block1.Equals(block2));
            Console.WriteLine(block1.ToString());
        }
    }
}