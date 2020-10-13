using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerDemoDotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        // GET: api/App
        [HttpGet("health")]
        public ActionResult Get()
        {
            return Ok("UP");
        }
    }
}
