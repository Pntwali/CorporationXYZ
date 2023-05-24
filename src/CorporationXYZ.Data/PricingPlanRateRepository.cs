using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporationXYZ.Repository
{
    public class PricingPlanRateRepository : RepositoryBase<PricingPlanRate>, IPricingPlanRateRepository
    {
        public PricingPlanRateRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreatePricingPlanRate(PricingPlanRate pricingPlanRate)
        {
            Create(pricingPlanRate);
        }

        public async Task<IEnumerable<decimal>> GetPlanPricingRates(Guid planId)
        {
            return await FindByCondition(x => x.PricingPlanId == planId,false)
                .Select(rate => rate.Rate)
                .ToListAsync();
        }
    }
}
