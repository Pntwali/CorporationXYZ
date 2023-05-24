using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Contracts
{
    public interface IQuotaRepository
    {
        Task<Quota> GetUserQuotaAsync(Guid UserId);
        void Create(Quota quota);

    }
}
