using CorporationXYZ.Service.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Presentation.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly IClientRateLimitService _clientRateLimitService;
        public UserController(IServiceManager service, IClientRateLimitService clientRateLimitService)
        {
            _service = service;
            _clientRateLimitService = clientRateLimitService;
        }
   

        /// <summary>
        /// Sets the pricing plan for a user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="planId">The ID of the pricing plan.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpPost("subscription")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> SetUserPlan([FromQuery] Guid userId, [FromQuery] Guid planId)
        {
            await _service.UserService.SetUSerPlan(userId, planId);
            return Ok();
        }

        

    }
}
