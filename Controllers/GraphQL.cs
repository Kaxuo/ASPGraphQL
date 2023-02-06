using API.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace API.Controllers
{
    [Route("api")]
    [ApiController]
    public class GraphQL : ControllerBase
    {
        [HttpGet("Graphql")]
        public ActionResult<string> GetData()
        {
            return Ok("hello");
        }
    }
}