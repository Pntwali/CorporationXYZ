using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service
{
    public class UsageStatisticsService : IUsageStatisticsService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UsageStatisticsService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task UpdateUserUsageStatisticsAsync(Guid userId, decimal price)
        {
            var userUsageStatistics = await _repository
                .UsageStatisticsRepository.GetUserUsageStatisticsAsync(userId);
            if (userUsageStatistics != null)
            {
                userUsageStatistics.RequestCount++;
                ///throw new RelatedEntityNotFoundException<BillingInformation, Guid>("UserId", UserId);
            }
            else
            {
                userUsageStatistics = new UsageStatistics
                {
                    UserId = userId,
                    Month = DateTime.Now.Month,
                    RequestCount = 1

                };

                 _repository.UsageStatisticsRepository.CreateUsageStatistics(userUsageStatistics);

            }
            await _repository.SaveAsync();
        }

        // Implement the service interface members here
    }
}
