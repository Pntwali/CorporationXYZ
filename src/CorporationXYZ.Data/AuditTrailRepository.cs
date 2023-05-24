using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Repository
{
    public class AuditTrailRepository : RepositoryBase<AuditTrail>, IAuditTrailRepository
    {
        public AuditTrailRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
