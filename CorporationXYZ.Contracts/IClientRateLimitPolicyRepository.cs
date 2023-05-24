using CorporationXYZ.Entities.Models;

namespace CorporationXYZ.Contracts
{
    public interface IClientRateLimitPolicyRepository
    {
        Task<ClientRateLimitPolicy> GetUserRateLimitPolicyAsync(Guid UserId);
    }
}
