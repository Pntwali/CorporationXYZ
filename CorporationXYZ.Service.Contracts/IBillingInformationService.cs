using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service.Contracts
{
    public interface IBillingInformationService
    {
        public Task UpdateUserBillingInformationAsync(Guid clientId, decimal price);
        
        // Define the service interface members here
    }
}
