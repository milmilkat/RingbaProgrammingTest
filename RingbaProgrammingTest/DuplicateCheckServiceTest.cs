using Xunit;

namespace RingbaProgrammingTest
{
    public class DuplicateCheckServiceTest
    {
        HighlyOptimizedThreadSafeDuplicateCheckService Service;

        public DuplicateCheckServiceTest(HighlyOptimizedThreadSafeDuplicateCheckService service)
        {
            Service = service;
        }

        [Fact]
        public async void IsThisTheFirstTimeWeHaveSeenOrderedTest()
        {
            Service.Arr = new int[]{ 1, 2, 3, 5, 9, 11, 13, 17, 24 };
            bool result = await Service.IsThisTheFirstTimeWeHaveSeenOrdered(12);

            Assert.Equal(result, true);
        }

        [Fact]
        public async void IsThisTheFirstTimeWeHaveSeenUnorderedTest()
        {
            Service.Arr = new int[] { 1, 2, 3, 5, 9, 11, 13, 17, 24 };
            bool result = await Service.IsThisTheFirstTimeWeHaveSeenUnordered(11);

            Assert.Equal(result, false);
        }
    }
}
