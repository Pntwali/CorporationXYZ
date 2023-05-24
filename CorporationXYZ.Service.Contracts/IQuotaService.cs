using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service.Contracts
{
    public interface IQuotaService
    {
        public Task<bool> CheckQuotaAsync(Guid userId);
    }
}
