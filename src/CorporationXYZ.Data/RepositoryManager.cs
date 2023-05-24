using CorporationXYZ.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;

        private readonly Lazy<IAuditTrailRepository> _auditTrailRepository;
        private readonly Lazy<IBillingInformationRepository> _billingInformationRepository;
        private readonly Lazy<IClientRateLimitRepository> _clientRateLimitRepository;
        private readonly Lazy<IClientRateLimitPolicyRepository> _clientRateLimitPolicyRepository;
        private readonly Lazy<INotificationRepository> _notificationRepository;
        private readonly Lazy<IPricingPlanRepository> _pricingPlanRepository;
        private readonly Lazy<IPricingPlanRateRepository> _pricingPlanRateRepository;
        private readonly Lazy<IQuotaRepository> _quotaRepository;
        private readonly Lazy<IUsageStatisticsRepository> _usageStatisticsRepository;
        private readonly Lazy<IUserRepository> _userRepository;


        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
             _auditTrailRepository = new Lazy<IAuditTrailRepository>(() => new AuditTrailRepository(repositoryContext));
             _billingInformationRepository = new Lazy<IBillingInformationRepository>(() => new BillingInformationRepository(repositoryContext));
             _clientRateLimitRepository = new Lazy<IClientRateLimitRepository>(() => new ClientRateLimitRepository(repositoryContext));
             _clientRateLimitPolicyRepository = new Lazy<IClientRateLimitPolicyRepository>(()=> new ClientRateLimitPolicyRepository(repositoryContext));
             _notificationRepository = new Lazy<INotificationRepository>(() => new NotificationRepository(repositoryContext));
             _pricingPlanRepository = new Lazy<IPricingPlanRepository>(() => new PricingPlanRepository(repositoryContext));
             _pricingPlanRateRepository = new Lazy<IPricingPlanRateRepository>(() => new PricingPlanRateRepository(repositoryContext));
             _quotaRepository = new Lazy<IQuotaRepository>(() => new QuotaRepository(repositoryContext));
            
             _usageStatisticsRepository = new Lazy<IUsageStatisticsRepository>(() => new UsageStatisticsRepository(repositoryContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));

        }

        public IAuditTrailRepository AuditTrailRepository => _auditTrailRepository.Value;
        public IBillingInformationRepository BillingInformationRepository => _billingInformationRepository.Value;
        public IClientRateLimitRepository ClientRateLimitRepository => _clientRateLimitRepository.Value;
        public IClientRateLimitPolicyRepository ClientRateLimitPolicyRepository => _clientRateLimitPolicyRepository.Value;
        public INotificationRepository NotificationRepository => _notificationRepository.Value;
        public IPricingPlanRepository PricingPlanRepository => _pricingPlanRepository.Value;
        public IPricingPlanRateRepository PricingPlanRateRepository => _pricingPlanRateRepository.Value;
        public IQuotaRepository QuotaRepository => _quotaRepository.Value;
        
        public IUsageStatisticsRepository UsageStatisticsRepository => _usageStatisticsRepository.Value;
        public IUserRepository UserRepository => _userRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }

}

