using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporationXYZ.Repository
{
    public class UsageStatisticsRepository : RepositoryBase<UsageStatistics>, IUsageStatisticsRepository
    {
        public UsageStatisticsRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateUsageStatistics(UsageStatistics billingInformation)
        {
            Create(billingInformation);
        }

        public async Task<int> GetUserCurrentRequestCounts(Guid userId)
        {
            return await FindByCondition(x => x.UserId == userId && x.Month == DateTime.Now.Month,false)
                .SumAsync(x => x.RequestCount);
        }

        public async Task<UsageStatistics> GetUserUsageStatisticsAsync(Guid UserId)
        {
            return await FindByCondition(x => x.UserId == UserId, false).SingleOrDefaultAsync();
        }

        
    }
}
