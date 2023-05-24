using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporationXYZ.Repository
{
    public class PricingPlanRepository : RepositoryBase<PricingPlan>, IPricingPlanRepository
    {
        public PricingPlanRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreatePricingPlan(PricingPlan pricingPlan)
        {
           Create(pricingPlan);
        }

        public async Task<PricingPlan> GetPricingPlanAsync(Guid companyId, bool trackChanges)
        {
            return await FindByCondition(x => x.Id.Equals(companyId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
