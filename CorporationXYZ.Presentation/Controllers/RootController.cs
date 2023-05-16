using CorporationXYZ.Entities.LinkModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CorporationXYZ.Presentation.Controllers
{
    [Route("api")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize(Roles = "Manager")]
    public class RootController : ControllerBase
    {
        private readonly LinkGenerator _linkGenerator;

        public RootController(LinkGenerator linkGenerator) => _linkGenerator = linkGenerator;

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
    }
}