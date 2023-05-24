using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Service.Contracts
{
    public interface IServiceManager
    {
        IAuthenticationService AuthenticationService { get; }
        IAuditTrailService AuditTrailService { get; }
        IBillingInformationService BillingInformationService { get; }
        IClientRateLimitPolicyService ClientRateLimitPolicyService { get; }
        INotificationService NotificationService { get; }
        IPricingPlanService PricingPlanService { get; }
        IPricingPlanRateService PricingPlanRateService { get; }
        IQuotaService QuotaService { get; }
        IUserService UserService { get; }
        IUsageStatisticsService UsageStatisticsService { get; }

    }
}
