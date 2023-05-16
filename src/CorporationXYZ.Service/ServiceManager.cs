using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.ConfigurationModels;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, 
            ILoggerManager logger, 
            IMapper mapper,
            UserManager<User> userManager,
            IOptions<JwtConfiguration> configuration)

        {
            _authenticationService = new Lazy<IAuthenticationService>(() =>
                                    new AuthenticationService(logger, mapper, userManager,
                                    configuration));

        }

        public IAuthenticationService AuthenticationService => _authenticationService.Value;


    }
}
