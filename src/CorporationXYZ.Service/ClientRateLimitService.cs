
using AspNetCoreRateLimit;
using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;
using Microsoft.Extensions.Options;
using System.Collections.Concurrent;

namespace CorporationXYZ.Service
{
    public class ClientRateLimitService : IClientRateLimitService
    {
        //private readonly ClientRateLimitOptions _options;
        //private readonly IClientPolicyStore _clientPolicyStore;

        //public ClientRateLimitService(IOptions<ClientRateLimitOptions> optionsAccessor, IClientPolicyStore clientPolicyStore)
        //{
        //    _options = optionsAccessor.Value;
        //    _clientPolicyStore = clientPolicyStore;
        //}

        //public async Task SetUserRateLimitPolicy(Guid userId, PricingPlan userPlan)
        //{
        //    var userRateLimitPolicy = await _clientPolicyStore.GetAsync(userId.ToString());
        //    if (userRateLimitPolicy != null)
        //    {
        //        if (userRateLimitPolicy.Rules == null)
        //        {
        //            userRateLimitPolicy.Rules = new List<RateLimitRule>();
        //        }

        //        userRateLimitPolicy.Rules.Add(new RateLimitRule
        //        {
        //            Endpoint = "*",
        //            Period = "1m",
        //            Limit = userPlan.MaxRequestsPerMinute
        //        });

        //        await _clientPolicyStore.SetAsync(userId.ToString(), userRateLimitPolicy);
        //    }
        //    else
        //    {
        //        // Create a new rate limit policy for the user if it doesn't exist
        //        var newRateLimitPolicy = new AspNetCoreRateLimit.ClientRateLimitPolicy
        //        {
        //            ClientId = userId.ToString(),
        //            Rules = new List<RateLimitRule>
        //            {
        //                new RateLimitRule
        //                {
        //                    Endpoint = "*",
        //                    Period = "1m",
        //                    Limit = userPlan.MaxRequestsPerMinute
        //                }
        //            }
        //        };

        //        await _clientPolicyStore.SetAsync(userId.ToString(), newRateLimitPolicy);
        //    }
        //}


        //public async Task<(AspNetCoreRateLimit.ClientRateLimitPolicy clientRateLimitPolicy, string id)> GetClientRateLimitPolicy(Guid userId)
        //{

        //    return (clientRateLimitPolicy: await _clientPolicyStore.GetAsync(userId.ToString()), String.Empty);
        //}






        // Implement the service interface members here
    }
}
