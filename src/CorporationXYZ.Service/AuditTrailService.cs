using AutoMapper;
using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;

namespace CorporationXYZ.Service
{
    public class AuditTrailService : IAuditTrailService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AuditTrailService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        // Implement the service interface members here
    }
}
