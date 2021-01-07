using Xunit;

namespace RingbaProgrammingTest
{
    public class DuplicateCheckServiceTest
    {
        IDuplicateCheckService Service;

        [Fact]
        public async void IsThisTheFirstTimeWeHaveSeenOrderedTest()
        {
            int[] arr = { 1, 2, 3, 5, 9, 11, 13, 17, 24 };
            int NumberOfThreads = 1;
            int id = 14;

            Service = new HighlyOptimizedThreadSafeDuplicateCheckService(arr, NumberOfThreads);
            
            bool result = await Service.IsThisTheFirstTimeWeHaveSeenOrdered(id);

            Assert.Equal(result, true);
        }

        [Fact]
        public async void IsThisTheFirstTimeWeHaveSeenUnorderedTest()
        {
            int[] arr = { 1, 2, 3, 5, 9, 11, 13, 17, 24 };
            int NumberOfThreads = 1;
            int id = 11;

            Service = new HighlyOptimizedThreadSafeDuplicateCheckService(arr, NumberOfThreads);
            
            bool result = await Service.IsThisTheFirstTimeWeHaveSeenUnordered(id);

            Assert.Equal(result, false);
        }
    }
}
