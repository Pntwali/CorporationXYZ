using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporationXYZ.Repository
{
    public class ClientRateLimitPolicyRepository : RepositoryBase<ClientRateLimitPolicy>, IClientRateLimitPolicyRepository
    {
        public ClientRateLimitPolicyRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<ClientRateLimitPolicy> GetUserRateLimitPolicyAsync(Guid UserId)
        {
            return await FindByCondition(x => x.UserId == UserId, false).SingleOrDefaultAsync();
        }
    }
}
