using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service
{
    public class QuotaService : IQuotaService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public QuotaService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<bool> CheckQuotaAsync(Guid userId)
        {
            var quota = await _repository.QuotaRepository.GetUserQuotaAsync(userId);
            if (quota == null)
            {
                return true;
            }
            int requestCount = await _repository.UsageStatisticsRepository.GetUserCurrentRequestCounts(userId);

            return requestCount < quota.MaxRequestsPerMonth;
        }

        // Implement the service interface members here
    }
}
