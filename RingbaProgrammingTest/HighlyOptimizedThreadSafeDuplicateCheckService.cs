using System;
using System.Threading.Tasks;

namespace RingbaProgrammingTest
{
    public class HighlyOptimizedThreadSafeDuplicateCheckService : IDuplicateCheckService
    {
        public int[] Arr;
        public int Max;
        public int Min;

        public HighlyOptimizedThreadSafeDuplicateCheckService(int[] arr)
        {
            Arr = arr;
            Max = arr.Length - 1;
            Min = 0;
        }

        public async Task<bool> IsThisTheFirstTimeWeHaveSeenOrdered(int id)
        {
            int result = -1;

            await Task.Run(() => result = Array.BinarySearch(Arr, id));

            if (result < 0)
                return true;
            else
                return false;
        }

        public async Task<bool> IsThisTheFirstTimeWeHaveSeenUnordered(int id)
        {
            bool result = true;

            await Task.Run(() =>
            {
                for (int i = 0; i < Arr.Length; i++)
                    if (id == Arr[i])
                        result = false;
            });

            return result;
        }
    }
}
