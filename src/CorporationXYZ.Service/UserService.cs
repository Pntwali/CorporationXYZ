using AspNetCoreRateLimit;
using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Exceptions;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserService(
            IRepositoryManager repository,
            ILoggerManager logger,
            IMapper mapper,
            UserManager<User> userManager)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;

        }

        public async Task SetUSerPlan(Guid userId, Guid planId)
        {
            var userToUpdate = await _userManager.FindByIdAsync(userId.ToString());
            if (userToUpdate == null)
            {
                throw new EntityNotFoundException<User>(userId);
            }
            var userPlan = await _repository.PricingPlanRepository.GetPricingPlanAsync(planId, false);
            if (userPlan == null)
            {
                throw new EntityNotFoundException<PricingPlan>(planId);
            }
            userToUpdate.PricingPlanId = planId;
            SetUserQuota(userId,userPlan);
            //await _clientRateLimitService.SetUserRateLimitPolicy(userId,userPlan);
            await _repository.SaveAsync();
        }

       

        private void SetUserQuota(Guid userId, PricingPlan userPlan)
        {
            var userQuota = new Quota();
            userQuota.UserId = userId;
            userQuota.MaxRequestsPerMonth = userPlan.MaxRequestsPerMonth;
            _repository.QuotaRepository.Create(userQuota);
        }

        
    }


}
