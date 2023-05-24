using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Contracts
{
    public interface IUsageStatisticsRepository
    {
        Task<UsageStatistics> GetUserUsageStatisticsAsync(Guid UserId);
        void CreateUsageStatistics(UsageStatistics usageStatistics);

        Task<int> GetUserCurrentRequestCounts(Guid userId);
    }
}
