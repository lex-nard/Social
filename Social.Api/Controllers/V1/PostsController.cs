using Microsoft.AspNetCore.Mvc;

namespace Social.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(Guid id)
        {

            return Ok();
        }
    }
}
