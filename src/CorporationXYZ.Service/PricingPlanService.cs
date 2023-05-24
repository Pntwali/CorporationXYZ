using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Exceptions;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service
{
    public class PricingPlanService : IPricingPlanService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PricingPlanService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<decimal> CalculateUserNotificationPrice(Guid userId)
        {
            var pricingPlan = _repository.UserRepository.GetUserPlan(userId);
            if (pricingPlan == null)
            {
                throw new UserPricingPlanNotFoundException(userId);
            }

            var rates = await _repository.PricingPlanRateRepository.GetPlanPricingRates(pricingPlan.Id);
            decimal totalPrice = rates.Sum();
            return totalPrice;
        }

        public async Task<PricingPlanDto> CreatePricingPlanAsync(PricingPlanDto pricingPlanDto)
        {
            var pricingPlanEntity = _mapper.Map<PricingPlan>(pricingPlanDto);
            _repository.PricingPlanRepository.CreatePricingPlan(pricingPlanEntity);
            await _repository.SaveAsync();
            var pricingPlanToReturn = _mapper.Map<PricingPlanDto>(pricingPlanEntity);
            return pricingPlanToReturn;
        }

        public async Task<PricingPlanDto> GetPricingPlanAsync(Guid pricingPlanId, bool trackChanges)
        {
            var pricingPlan = await _repository.PricingPlanRepository.GetPricingPlanAsync(pricingPlanId, trackChanges);
            if (pricingPlan == null)
                throw new EntityNotFoundException<PricingPlanDto>(pricingPlanId);
            var pricingPlanDto = _mapper.Map<PricingPlanDto>(pricingPlan);
            return pricingPlanDto;
        }

        // Implement the service interface members here
    }
}
