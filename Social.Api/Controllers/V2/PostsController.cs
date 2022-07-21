﻿using Microsoft.AspNetCore.Mvc;

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

            return Ok();
        }
    }
}
