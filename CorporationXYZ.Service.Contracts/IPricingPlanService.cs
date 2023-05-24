using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service.Contracts
{
    public interface IPricingPlanService
    {
        public Task<decimal> CalculateUserNotificationPrice(Guid userId);
        Task<PricingPlanDto> GetPricingPlanAsync(Guid pricingPlanId, bool trackChanges);
        Task<PricingPlanDto> CreatePricingPlanAsync(PricingPlanDto pricingPlanDto);
        
        // Define the service interface members here
    }
}
