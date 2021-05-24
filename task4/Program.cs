using System;

namespace task4
{
    internal static class Program
    {
        private static void Main()
        {
            var customDate = new CustomDate(1, 1, 1);
            var customDate2 = new CustomDate(2, 2, 2);
            Console.WriteLine(customDate.ToString());
            Console.WriteLine(customDate2.ToString());
            Console.WriteLine(customDate + 1);
            Console.WriteLine(customDate2 - customDate);
        }
    }
}