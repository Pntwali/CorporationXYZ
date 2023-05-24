using CorporationXYZ.Entities.LinkModels;
using CorporationXYZ.Service.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Security.Claims;

namespace CorporationXYZ.Presentation.Controllers
{
    [Route("api")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class RootController : ControllerBase
    {
        private readonly LinkGenerator _linkGenerator;
        private readonly IServiceManager _service;

        public RootController(LinkGenerator linkGenerator, IServiceManager service)
        {
            _linkGenerator = linkGenerator;
            _service = service;
        }

        /// <summary>
        /// Gets the list of all links to resources
        /// </summary>
        /// <returns>The Resource access list</returns>

        [HttpGet(Name = "GetRoot")]
        public IActionResult GetRoot([FromHeader(Name = "Accept")] string mediaType)
        {
            if (mediaType.Contains("application/vnd.corporationxyz.apiroot"))
            {
                var list = new List<Link>
             {
                     new Link
                         {
                             Href = _linkGenerator.GetUriByName(HttpContext, nameof(GetRoot), new{}),
                             Rel = "self",
                             Method = "GET"
                         },
                         new Link
                         {
                             Href = _linkGenerator.GetUriByName(HttpContext, "GetCompanies", new{}),
                             Rel = "companies",
                             Method = "GET"
                         },
                     new Link
                      {
                         Href = _linkGenerator.GetUriByName(HttpContext, "CreateCompany", new
                        {}),
                                             Rel = "create_company",
                                             Method = "POST"
                        }
                 };
                return Ok(list);
            }
            return NoContent();
        }

        [HttpGet("clientRateLimitPolicy")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetClientRateLimitPolicyAsync()
        {
            var CurrentLoggedInUserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return Ok();
        }


    }
}