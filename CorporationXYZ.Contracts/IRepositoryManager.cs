using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Contracts
{
    public interface IRepositoryManager
    {
        public IAuditTrailRepository AuditTrailRepository { get; }
        public IBillingInformationRepository BillingInformationRepository { get; }
        public IClientRateLimitRepository ClientRateLimitRepository { get; }
        public IClientRateLimitPolicyRepository ClientRateLimitPolicyRepository { get; }
        public INotificationRepository NotificationRepository { get; }
        public IPricingPlanRepository PricingPlanRepository { get; }
        public IPricingPlanRateRepository PricingPlanRateRepository { get; }
        public IQuotaRepository QuotaRepository { get; }
 
        public IUsageStatisticsRepository UsageStatisticsRepository { get; }
        public IUserRepository UserRepository { get; }
        Task SaveAsync();

    }
}
