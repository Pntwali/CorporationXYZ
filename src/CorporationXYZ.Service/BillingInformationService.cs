using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Exceptions;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service
{
    public class BillingInformationService : IBillingInformationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BillingInformationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task UpdateUserBillingInformationAsync(Guid userId, decimal price)
        {
            var userBillingInfo = await _repository
                .BillingInformationRepository.GetUserBillingInformation(userId);
            if (userBillingInfo != null)
            {
                userBillingInfo.TotalPrice += price;
                ///throw new RelatedEntityNotFoundException<BillingInformation, Guid>("UserId", UserId);
            }
            else
            {
                userBillingInfo = new BillingInformation { 
                    UserId = userId,
                    TotalPrice = price
                    
                };
                
                _repository.BillingInformationRepository.CreateBillingInformation(userBillingInfo);

            }
            await _repository.SaveAsync();


        }

        // Implement the service interface members here
    }
}
