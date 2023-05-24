using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporationXYZ.Repository
{
    public class QuotaRepository : RepositoryBase<Quota>, IQuotaRepository
    {
        public QuotaRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateQuota(Quota quota) => Create(quota);

        public async Task<Quota> GetUserQuotaAsync(Guid UserId)
        {
            return await FindByCondition(x => x.UserId == UserId,false).SingleOrDefaultAsync();
        }
    }
}
