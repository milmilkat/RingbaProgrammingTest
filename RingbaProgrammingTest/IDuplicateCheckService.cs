using System.Threading.Tasks;

namespace RingbaProgrammingTest
{
    public interface IDuplicateCheckService
    {
        Task<bool> IsThisTheFirstTimeWeHaveSeenOrdered(int id);
        Task<bool> IsThisTheFirstTimeWeHaveSeenUnordered(int id);
    }
}
