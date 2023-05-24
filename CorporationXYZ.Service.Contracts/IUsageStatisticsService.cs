using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service.Contracts
{
    public interface IUsageStatisticsService
    {
        public Task UpdateUserUsageStatisticsAsync(Guid clientId, decimal price);
    }
}
