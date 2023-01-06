using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DD.Interview.Application.Abstractions;
using DD.Interview.Application.DataModels.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DD.Interview.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationService authorizationService;

        public AuthorizationController(IAuthorizationService authorizationService)
        {
            this.authorizationService = authorizationService;
        }
        [HttpPost("login")]
        public IActionResult Authorization([FromBody] AuthorizationRequestModel request) {
            string result = authorizationService.Authorize(request.Username, request.Password);
            return Ok(new { token = result });
        }
    }
}
