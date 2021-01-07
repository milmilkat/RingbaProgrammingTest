using System;
using System.Threading.Tasks;

namespace RingbaProgrammingTest
{
    public class HighlyOptimizedThreadSafeDuplicateCheckService : IDuplicateCheckService
    {
        public int[] Arr;

        private int NumberOfThreads = 1;
        private int[] Indices;

        public HighlyOptimizedThreadSafeDuplicateCheckService(int[] arr, int numOfThreads)
        {
            Arr = arr;
            NumberOfThreads = numOfThreads;
            Indices = new int[NumberOfThreads + 1];
            Indices[0] = 0;

            for (int i = 1; i < NumberOfThreads + 1; i++)
                Indices[i] = (Arr.Length / NumberOfThreads) * (i);

            if (Arr.Length % 2 != 0)
                Indices[NumberOfThreads] = Arr.Length;
        }

        public async Task<bool> IsThisTheFirstTimeWeHaveSeenUnordered(int id)
        {
            bool result = true;

            for (int i = 0; i < NumberOfThreads; i++)
                await Task.Run(() =>
                {
                    for (int j = Indices[i]; j < Indices[i+1]; j++)
                        if (id == Arr[j])
                            result = false;
                });

                if (!result)
                    return false;

            return true;
        }

        public async Task<bool> IsThisTheFirstTimeWeHaveSeenOrdered(int id)
        {
            int result = -1;

            for (int i = 0; i < NumberOfThreads; i++)
            {
                await Task.Run(()
                    => result = Array.BinarySearch(Arr[Indices[i]..Indices[i + 1]], id));

                if (result >= 0)
                    return false;
            }

            return true;
        }
    }
}
