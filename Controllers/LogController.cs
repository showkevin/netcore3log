using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace logapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        [HttpGet("{message}")]
        public async Task<IActionResult> LogToConsole(string message)
        {
            try
            {
                Console.WriteLine(message);
                return Ok();
            }
            catch (System.Exception ex)
            {                
                return BadRequest(ex.Message);
            }
            
        }
    }
}