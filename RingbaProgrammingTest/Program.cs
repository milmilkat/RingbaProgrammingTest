using System;

namespace RingbaProgrammingTest
{
    class Program
    {
        static int[] arr = { 1, 2, 3, 5, 9, 11, 13, 17, 24 };

        static HighlyOptimizedThreadSafeDuplicateCheckService Service =
            new HighlyOptimizedThreadSafeDuplicateCheckService(arr);

        static void Main(string[] args)
        {
            int id = 12;

            Console.WriteLine("Result with Unordered list:");
            var resultUnordered = Service.IsThisTheFirstTimeWeHaveSeenUnordered(id).Result;
            Console.WriteLine(resultUnordered);

            Console.WriteLine("Result with Ordered list:");
            var resultOrdered = Service.IsThisTheFirstTimeWeHaveSeenOrdered(id).Result;
            Console.WriteLine(resultOrdered);

            Console.ReadLine();
        }
    }
}
