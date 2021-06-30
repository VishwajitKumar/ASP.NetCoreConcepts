using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebApi.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController:ControllerBase
    {
        public string Wishing()
        {
            return "Hello";
        }
        public string Wishing1()
        {
            return "Hello1";
        }
    }
}
