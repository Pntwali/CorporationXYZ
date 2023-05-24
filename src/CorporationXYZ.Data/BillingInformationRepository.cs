using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporationXYZ.Repository
{
    public class BillingInformationRepository : RepositoryBase<BillingInformation>, IBillingInformationRepository
    {
        public BillingInformationRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateBillingInformation(BillingInformation billingInformation)
        {
            Create(billingInformation);
        }

        public async Task<BillingInformation> GetUserBillingInformation(Guid UserId)
        {
            return await FindByCondition(x => x.UserId == UserId, false).SingleOrDefaultAsync();
        }
    }
}
