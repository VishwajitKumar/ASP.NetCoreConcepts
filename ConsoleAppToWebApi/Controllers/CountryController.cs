using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        public string Name { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok(true);
        }
    }
}
