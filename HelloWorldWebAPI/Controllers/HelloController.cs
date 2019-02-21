using System;

using Microsoft.AspNetCore.Mvc;

using HelloWorldWebAPI.Models;

namespace HelloWorldWebAPI.Controllers
{
    [Route("api/Hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {

        // GET /api/hello/Gary
        [HttpGet("{name:alpha}")]
        public ActionResult<Greeting> Get(String name)
        {
            return Ok(new Greeting() { Message = "Hello Word", To = name });      // 200 OK
        }
        
    }
}
