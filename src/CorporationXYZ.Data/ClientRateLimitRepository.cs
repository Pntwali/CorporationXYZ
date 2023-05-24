using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Repository
{
    public class ClientRateLimitRepository : RepositoryBase<ClientRateLimit>, IClientRateLimitRepository
    {
        public ClientRateLimitRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
