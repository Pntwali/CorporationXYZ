using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Contracts
{
    public interface IPricingPlanRateRepository
    {
        // Define the interface members here
        Task<IEnumerable<decimal>> GetPlanPricingRates(Guid planId);
        void CreatePricingPlanRate(PricingPlanRate pricingPlanRate);
    }
}
