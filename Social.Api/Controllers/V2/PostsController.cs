using Microsoft.AspNetCore.Mvc;
using Social.Domain.Models;

namespace Social.Api.Controllers.V2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(Guid id)
        {
            var post = new Post { Id = id, Text = "Are you expecting something to happen?" };

            return Ok(post);
        }
    }
}
