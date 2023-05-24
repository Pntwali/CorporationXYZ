using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Contracts
{
    public interface IPricingPlanRepository
    {
        // Define the interface members here
        void CreatePricingPlan(PricingPlan pricingPlan);
        public Task<PricingPlan> GetPricingPlanAsync(Guid pricingPlanId, bool trackChanges);
    }
}
