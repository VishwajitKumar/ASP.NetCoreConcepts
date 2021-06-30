using ConsoleAppToWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        public IActionResult GetAnimals()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(){Id=1, Name="Cow"},
                new Animal(){Id=2,Name="Dog"}
            };
            return Ok(animals);
        }
    }
}
