using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthCoreApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/user-registration")]
    public class User_registration : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("User registration endpoint is working.");

        }
        
    }
}