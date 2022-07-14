using Microsoft.AspNetCore.Mvc;
using Social.Domain.Models;

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
            var post = new Post { Id = id, Text = "May the Force be with you" };

            return Ok(post);
        }
    }
}
