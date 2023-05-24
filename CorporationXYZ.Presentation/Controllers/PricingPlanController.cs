using CorporationXYZ.Presentation.ActionFilters;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Presentation.Controllers
{
    [Route("api/Plans")]
    [ApiController]
    public class PricingPlanController : ControllerBase
    {
        private readonly IServiceManager _service;
        public PricingPlanController(IServiceManager service) => _service = service;

        

    }
}
