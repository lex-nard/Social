﻿using Microsoft.AspNetCore.Mvc;

namespace Social.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route(ApiRoutes.GeneralIdRoute)]
        public IActionResult GetById(Guid id)
        {

            return Ok();
        }
    }
}
