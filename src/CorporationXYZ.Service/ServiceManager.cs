using AspNetCoreRateLimit;
using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.ConfigurationModels;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace CorporationXYZ.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthenticationService> _authenticationService;
        private readonly Lazy<IAuditTrailService> _auditTrailService;
        private readonly Lazy<IBillingInformationService> _billingInformationService;
        private readonly Lazy<IClientRateLimitPolicyService> _clientRateLimitPolicyService;
        private readonly Lazy<INotificationService> _notificationService;
        private readonly Lazy<IPricingPlanService> _pricingPlanService;
        private readonly Lazy<IPricingPlanRateService> _pricingPlanRateService;
        private readonly Lazy<IQuotaService> _quotaService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IUsageStatisticsService> _usageStatisticsService;

        public ServiceManager(
            IRepositoryManager repositoryManager, 
            ILoggerManager logger, 
            IMapper mapper,
            UserManager<User> userManager,
            IOptions<JwtConfiguration> configuration
            
            )

        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager,logger,mapper,userManager));
            _authenticationService = new Lazy<IAuthenticationService>(() => 
            new AuthenticationService(logger, mapper, userManager,configuration));
            _auditTrailService = new Lazy<IAuditTrailService>(() =>
                new AuditTrailService(repositoryManager, logger, mapper));
            _billingInformationService = new Lazy<IBillingInformationService>(() =>
                new BillingInformationService(repositoryManager, logger, mapper));
            _clientRateLimitPolicyService = new Lazy<IClientRateLimitPolicyService>(() =>
                new ClientRateLimitPolicyService(repositoryManager, logger, mapper));
            _notificationService = new Lazy<INotificationService>(() =>
                new NotificationService(repositoryManager, logger, mapper));
            _pricingPlanService = new Lazy<IPricingPlanService>(() =>
                new PricingPlanService(repositoryManager, logger, mapper));
            _pricingPlanRateService = new Lazy<IPricingPlanRateService>(() =>
                new PricingPlanRateService(repositoryManager, logger, mapper));
            _quotaService = new Lazy<IQuotaService>(() =>
                new QuotaService(repositoryManager, logger, mapper));
            _usageStatisticsService = new Lazy<IUsageStatisticsService>(() =>
                new UsageStatisticsService(repositoryManager, logger, mapper));
            

        }
        public IUserService UserService => _userService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public IAuditTrailService AuditTrailService => _auditTrailService.Value;
        public IBillingInformationService BillingInformationService => _billingInformationService.Value;
        public IClientRateLimitPolicyService ClientRateLimitPolicyService => _clientRateLimitPolicyService.Value;
        public INotificationService NotificationService => _notificationService.Value;
        public IPricingPlanService PricingPlanService => _pricingPlanService.Value;
        public IPricingPlanRateService PricingPlanRateService => _pricingPlanRateService.Value;
        public IQuotaService QuotaService => _quotaService.Value;
        public IUsageStatisticsService UsageStatisticsService => _usageStatisticsService.Value;


    }
}




