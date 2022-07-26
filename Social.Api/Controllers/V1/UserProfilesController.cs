using MediatR;
using Microsoft.AspNetCore.Mvc;
using Social.Api.Contracts.UserProfile.Requests;

namespace Social.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfilesController : Controller
    {
        private readonly IMediator _mediator;
        public UserProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAllProfiles()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateUserProfiles([FromBody] UserProfileCreate profile)
        {
            return Ok();
        }
    }
}
