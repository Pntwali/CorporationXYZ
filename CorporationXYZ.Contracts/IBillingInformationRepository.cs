using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Contracts
{
    public interface IBillingInformationRepository
    {
        // Define the interface members here
        Task<BillingInformation> GetUserBillingInformation(Guid UserId);

        void CreateBillingInformation(BillingInformation billingInformation);

        
    }
}
