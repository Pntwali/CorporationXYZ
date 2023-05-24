using CorporationXYZ.Presentation.ActionFilters;
using CorporationXYZ.Service.Contracts;
using CorporationXYZ.Shared.DataTransferObjects;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Presentation.Controllers
{
    [Route("api/notify")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class NotificationController: ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly IBackgroundJobClient _backgroundJobClient;

        public NotificationController(IServiceManager service, IBackgroundJobClient backgroundJobClient)
        {
            _service = service;
            _backgroundJobClient = backgroundJobClient;
        }

        /// <summary>
        /// Sends a an SMS notification.
        /// </summary>
        [HttpPost("sms")]
        [ProducesResponseType(200)]
        public IActionResult SendFakeSmsNotification([FromBody] SmsNotificationDto sms)
        {
            
            _backgroundJobClient.Enqueue(() => _service.NotificationService.SendSmsNotification(sms));
            return Ok();
        }

        /// <summary>
        /// Sends a an email notification.
        /// </summary>
        [HttpPost("email")]
        [ProducesResponseType(200)]
        public IActionResult SendFakeEmailNotification([FromBody] EmailNotificationDto email)
        {

            _backgroundJobClient.Enqueue(() => _service.NotificationService.SendEmailNotification(email));
            return Ok();
        }
    }
}
